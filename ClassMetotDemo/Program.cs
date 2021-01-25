using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiz");

            Customer customer1 = new Customer();
            customer1.Id = 01;
            customer1.FirstName = "Ali";
            customer1.LastName = "Demirog";

            Customer customer2 = new Customer();
            customer2.Id = 02;
            customer2.FirstName = "Ayşe";
            customer2.LastName = "Çelik";

           
            

            Customer[] customers = new Customer[] { customer1,customer2};
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + "---" + customer.FirstName + "---" + customer.LastName + "---");
                Console.WriteLine("********************");
            }


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Delete();
            customerManager.Update();


        }
    }
}
