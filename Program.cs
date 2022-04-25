using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0, i;
            Console.WriteLine(" Enter a 2 or more digit number");
            number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                i = number % 10;
                sum = sum + i;
                number /= 10;
            }
            Console.WriteLine("Sum = " + sum);
            Console.ReadLine();
        }
    }
}
