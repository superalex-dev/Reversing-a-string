using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversed = new string(input.Reverse().ToArray());
            Console.WriteLine(reversed);
        }
    }
}
