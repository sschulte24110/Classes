// See https://aka.ms/new-console-template for more information
using Classes;

var account = new BankAccount("Scott", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
