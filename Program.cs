using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace order1
{
    class Program
    {
        static void Main(string[] args)
        {
            int price= Convert.ToInt32(Console.ReadLine());
            if (price> 900)
            {
                Console.WriteLine("Discount is 40%");
            }
            else if (price>700)
            {
                Console.WriteLine("Discount is 30%");
            }
            else if (price > 400)
            {
                Console.WriteLine("Discount is 20%");
            }
            else if (price > 100)
            {
                Console.WriteLine("Discount is 5%");
            }
            else
            {
                Console.WriteLine("No discount");
            }
            Console.ReadKey();
        }
    }
}
