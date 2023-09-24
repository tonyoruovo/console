using System;
namespace Projects
{
    class Program
    {
        /// <summary>
        /// Helper that returns a <c>1</c> or <c>0</c> showing that the argument is equal to <c>8</c> or otherwise respectively.
        /// </summary>
        private static int Get8(int n)
        {
            return (
                (~0x8 >>> 0)//Apply bitwise not to switch oon all except the 4th bit and ensure it does not negate the operand
                 & n)//
                  == 0 ? 1 : 0;//return 0 if the result is non zero or 1 if otherwise
        }
        /// <summary>
        /// traverse array and returns an acummulated result such as:
        /// </summary>
        /// <list type="bullet">
        /// <item>
        /// <description> Add 1 for each even number element</description>
        /// </item>
        /// <item>
        /// <description> Add 3 for each odd number element</description>
        /// </item>
        /// <item>
        /// <description> Add 5 for each 8 (including the 1 already added for even)</description>
        /// </item>
        /// <item>
        /// <description> return the accumulated result</description>
        /// </item>
        /// </list>
        /// <param name="input">array of numbers</param>
        /// <returns>The accumulated result</returns>
        private static int Accumulate(int[] input)
        {
            var r = 0;//return value
            foreach (var x in input)
            {
                r += ((x & 0x1) ^ 0x1) + ((x & 0x1) * 0x3) + (Get8(x) * 5);
            }
            return r;
        }
        public static void Main(string[] args)
        {
            int[][] values = new int[][]{new int[]{1, 2, 3, 4, 5}, new int[]{15, 25, 35}, new int[]{8, 8}};
            foreach (var x in values){
                Console.WriteLine(Accumulate(x));
            }
        }
        static string ToBin(int y)
        {
            return Convert.ToString((uint)y, 2);
        }
        static void Wl(string y)
        {
            Console.Write($"{y}, ");
        }
    }
}
