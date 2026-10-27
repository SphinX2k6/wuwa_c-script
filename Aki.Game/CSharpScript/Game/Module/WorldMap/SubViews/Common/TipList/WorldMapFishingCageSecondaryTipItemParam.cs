using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList
{
	// Token: 0x02004838 RID: 18488
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapFishingCageSecondaryTipItemParam : IWorldMapFishingCageSecondaryTipItemParam, IWorldMapSecondaryTipItemParam
	{
		// Token: 0x170078F4 RID: 30964
		// (get) Token: 0x06030622 RID: 198178 RVA: 0x00B3B594 File Offset: 0x00B39794
		// (set) Token: 0x06030623 RID: 198179 RVA: 0x00B3B59C File Offset: 0x00B3979C
		public string Name { get; set; }

		// Token: 0x170078F5 RID: 30965
		// (get) Token: 0x06030624 RID: 198180 RVA: 0x00B3B5A5 File Offset: 0x00B397A5
		// (set) Token: 0x06030625 RID: 198181 RVA: 0x00B3B5AD File Offset: 0x00B397AD
		public string Desc { get; set; }

		// Token: 0x170078F6 RID: 30966
		// (get) Token: 0x06030626 RID: 198182 RVA: 0x00B3B5B6 File Offset: 0x00B397B6
		// (set) Token: 0x06030627 RID: 198183 RVA: 0x00B3B5BE File Offset: 0x00B397BE
		public int RelativeId { get; set; }

		// Token: 0x170078F7 RID: 30967
		// (get) Token: 0x06030628 RID: 198184 RVA: 0x00B3B5C7 File Offset: 0x00B397C7
		// (set) Token: 0x06030629 RID: 198185 RVA: 0x00B3B5CF File Offset: 0x00B397CF
		public EFishingCageSecondaryTipItemType TipItemType { get; set; }
	}
}
