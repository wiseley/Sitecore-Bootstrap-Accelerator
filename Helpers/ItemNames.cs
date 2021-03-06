﻿namespace ModernBusiness.Helpers
{
    /// <summary>
    /// Hard-coded Sitecore item names go here and only here.
    /// </summary>
    public static class ItemNames
    {

        public const string ContentFolder = "Content";

        public static class Templates
        {
            public const string CalloutContainer = "Callout Container";
            public const string SliderContainer = "Slider Container";
            public const string Callout = "Callout";
            public const string ContentSection = "Content Section";
        }

        public static class Options
        {
            public static class CalloutStyles
            {
                public const string Inherit = "Inherit from Container";
                public const string IconBox = "Icon Heading with Call to Action";
                public const string Image = "Image Only";
                public const string ImageHeading = "Image with Heading";
                public const string ImageHeadingIntro = "Image with Heading and Intro";
            }
        }

        public static class ContentFolderItems
        {
            public const string Slider = "Slider";
            public const string Callouts = "Callouts";
            public const string Portfolio = "Portfolio";
            public const string ContentSection = "Content Section";
        }

    }
}