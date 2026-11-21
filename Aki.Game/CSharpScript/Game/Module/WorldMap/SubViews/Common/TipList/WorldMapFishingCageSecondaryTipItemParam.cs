using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList
{
	// Token: 0x02003769 RID: 14185
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapFishingCageSecondaryTipItemParam : IWorldMapFishingCageSecondaryTipItemParam, IWorldMapSecondaryTipItemParam
	{
		// Token: 0x17004BB1 RID: 19377
		// (get) Token: 0x06024DF2 RID: 151026 RVA: 0x00A6B660 File Offset: 0x00A69860
		// (set) Token: 0x06024DF3 RID: 151027 RVA: 0x00A6B668 File Offset: 0x00A69868
		public string Name { get; set; }

		// Token: 0x17004BB2 RID: 19378
		// (get) Token: 0x06024DF4 RID: 151028 RVA: 0x00A6B671 File Offset: 0x00A69871
		// (set) Token: 0x06024DF5 RID: 151029 RVA: 0x00A6B679 File Offset: 0x00A69879
		public string Desc { get; set; }

		// Token: 0x17004BB3 RID: 19379
		// (get) Token: 0x06024DF6 RID: 151030 RVA: 0x00A6B682 File Offset: 0x00A69882
		// (set) Token: 0x06024DF7 RID: 151031 RVA: 0x00A6B68A File Offset: 0x00A6988A
		public int RelativeId { get; set; }

		// Token: 0x17004BB4 RID: 19380
		// (get) Token: 0x06024DF8 RID: 151032 RVA: 0x00A6B693 File Offset: 0x00A69893
		// (set) Token: 0x06024DF9 RID: 151033 RVA: 0x00A6B69B File Offset: 0x00A6989B
		public EFishingCageSecondaryTipItemType TipItemType { get; set; }
	}
}
