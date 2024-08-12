﻿using Microsoft.EntityFrameworkCore;
using UKParliament.CodeTest.Data.Entities;

namespace UKParliament.CodeTest.Data
{
    public class TodoListContext : DbContext
    {
        public TodoListContext(DbContextOptions<TodoListContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Use this method to seed the DB with Todo items, if desired, like so:
            //modelBuilder.Entity<TodoItem>(new TodoItem {Id = 1, Title = "Do shopping"}).HasData();
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}