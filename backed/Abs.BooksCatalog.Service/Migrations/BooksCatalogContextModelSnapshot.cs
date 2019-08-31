﻿// <auto-generated />
using System;
using Abs.BooksCatalog.Service.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Abs.BooksCatalog.Service.Migrations
{
    [DbContext(typeof(BooksCatalogContext))]
    partial class BooksCatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Abs.BooksCatalog.Service.Data.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BookId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Abs.BooksCatalog.Service.Data.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<DateTime?>("PublishedOn");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Abs.BooksCatalog.Service.Data.Cover", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BookId");

                    b.HasKey("Code");

                    b.HasIndex("BookId");

                    b.ToTable("Cover");
                });

            modelBuilder.Entity("Abs.BooksCatalog.Service.Data.Author", b =>
                {
                    b.HasOne("Abs.BooksCatalog.Service.Data.Book")
                        .WithMany("Authors")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("Abs.BooksCatalog.Service.Data.Cover", b =>
                {
                    b.HasOne("Abs.BooksCatalog.Service.Data.Book")
                        .WithMany("Covers")
                        .HasForeignKey("BookId");
                });
#pragma warning restore 612, 618
        }
    }
}
