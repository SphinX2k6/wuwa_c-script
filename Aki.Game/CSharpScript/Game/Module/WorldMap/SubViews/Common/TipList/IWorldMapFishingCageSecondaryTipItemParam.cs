using System;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList
{
	// Token: 0x02004837 RID: 18487
	public interface IWorldMapFishingCageSecondaryTipItemParam : IWorldMapSecondaryTipItemParam
	{
		// Token: 0x170078F2 RID: 30962
		// (get) Token: 0x0603061E RID: 198174
		// (set) Token: 0x0603061F RID: 198175
		int RelativeId { get; set; }

		// Token: 0x170078F3 RID: 30963
		// (get) Token: 0x06030620 RID: 198176
		// (set) Token: 0x06030621 RID: 198177
		EFishingCageSecondaryTipItemType TipItemType { get; set; }
	}
}
