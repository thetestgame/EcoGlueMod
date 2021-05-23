namespace Eco
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.EcopediaRoot;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Mods.TechTree;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    [Serialized]
    [LocDisplayName("Glue")]
    [Weight(5)]
    public partial class GlueItem : FoodItem
    {
        public override LocString DisplayDescription => Localizer.DoStr("Seems to attract small pandas for some reason.");
        public override float Calories => 1;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 8, Fat = 4, Protein = 6, Vitamins = 0 };
    }
}
