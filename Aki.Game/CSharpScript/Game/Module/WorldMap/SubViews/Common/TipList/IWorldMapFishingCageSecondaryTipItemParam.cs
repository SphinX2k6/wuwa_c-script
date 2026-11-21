using System;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList
{
	// Token: 0x02003768 RID: 14184
	public interface IWorldMapFishingCageSecondaryTipItemParam : IWorldMapSecondaryTipItemParam
	{
		// Token: 0x17004BAF RID: 19375
		// (get) Token: 0x06024DEE RID: 151022
		// (set) Token: 0x06024DEF RID: 151023
		int RelativeId { get; set; }

		// Token: 0x17004BB0 RID: 19376
		// (get) Token: 0x06024DF0 RID: 151024
		// (set) Token: 0x06024DF1 RID: 151025
		EFishingCageSecondaryTipItemType TipItemType { get; set; }
	}
}
