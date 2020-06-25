﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Team_Golf;

namespace Team_Golf.Migrations
{
    [DbContext(typeof(GolfCourseContext))]
    partial class GolfCourseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Team_Golf.Models.GolfCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GolfCourses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseType = "18Hole",
                            Description = "Good snack shack and poor caddying",
                            Image = "Bushwood.jpg",
                            Name = "Bushwood CC"
                        },
                        new
                        {
                            Id = 2,
                            CourseType = "PuttPutt",
                            Description = "Price is wrong B&$#%",
                            Image = "FurryCreek.jpg",
                            Name = "Fury Creek Golf CC"
                        },
                        new
                        {
                            Id = 3,
                            CourseType = "9Hole",
                            Description = "Waggle and let the big dog eat",
                            Image = "Cottonwood.jpg",
                            Name = "Cotton Wood"
                        });
                });

            modelBuilder.Entity("Team_Golf.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GolfCourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReviewRating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GolfCourseId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GolfCourseId = 1,
                            ReviewDate = new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewRating = 1,
                            ReviewText = "I played bad. This course sucks.",
                            ReviewerName = "Ron"
                        },
                        new
                        {
                            Id = 2,
                            GolfCourseId = 1,
                            ReviewDate = new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewRating = 2,
                            ReviewText = "I played good. This course is awesome.",
                            ReviewerName = "Dan"
                        },
                        new
                        {
                            Id = 3,
                            GolfCourseId = 2,
                            ReviewDate = new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewRating = 3,
                            ReviewText = "I'm a pro, and wouldn't play a crappy course like this.",
                            ReviewerName = "Chuck"
                        },
                        new
                        {
                            Id = 4,
                            GolfCourseId = 1,
                            ReviewDate = new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewRating = 4,
                            ReviewText = "I forgot my clubs and didn't actually play.",
                            ReviewerName = "Tom"
                        });
                });

            modelBuilder.Entity("Team_Golf.Models.Review", b =>
                {
                    b.HasOne("Team_Golf.Models.GolfCourse", "GolfCourse")
                        .WithMany("Reviews")
                        .HasForeignKey("GolfCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
