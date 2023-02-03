using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new String[8, 4];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int u = 0; u < i; u++)
                {
                    Console.Write("*\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("请输入第一个名字：");
            String name1 = Console.ReadLine();
            Console.WriteLine("请输入第二个名字：");
            String name2 = Console.ReadLine();
            Console.WriteLine("请输入第三个名字：");
            String name3 = Console.ReadLine();
            Dictionary<int, String> dictionary = new Dictionary<int, string>();
            List<String> list = new List<string>();
            double number = 0.01;
            for (int i = 0; i<30; i++)
            {
                number *= 2;
                Console.WriteLine(number/1000);
            }
            String name = String.Format("三次输入依次是{0}、{1}、{2}", name1,name2, number);
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
