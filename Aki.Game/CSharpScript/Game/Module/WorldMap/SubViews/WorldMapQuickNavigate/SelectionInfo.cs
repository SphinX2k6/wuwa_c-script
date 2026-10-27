using System;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020047DA RID: 18394
	public class SelectionInfo : ISelectionInfo
	{
		// Token: 0x170078BB RID: 30907
		// (get) Token: 0x060302F8 RID: 197368 RVA: 0x00B2A64D File Offset: 0x00B2884D
		// (set) Token: 0x060302F9 RID: 197369 RVA: 0x00B2A655 File Offset: 0x00B28855
		public int FirstIndex { get; set; }

		// Token: 0x170078BC RID: 30908
		// (get) Token: 0x060302FA RID: 197370 RVA: 0x00B2A65E File Offset: 0x00B2885E
		// (set) Token: 0x060302FB RID: 197371 RVA: 0x00B2A666 File Offset: 0x00B28866
		public int SecondIndex { get; set; }

		// Token: 0x170078BD RID: 30909
		// (get) Token: 0x060302FC RID: 197372 RVA: 0x00B2A66F File Offset: 0x00B2886F
		// (set) Token: 0x060302FD RID: 197373 RVA: 0x00B2A677 File Offset: 0x00B28877
		public int CountryId { get; set; }

		// Token: 0x170078BE RID: 30910
		// (get) Token: 0x060302FE RID: 197374 RVA: 0x00B2A680 File Offset: 0x00B28880
		// (set) Token: 0x060302FF RID: 197375 RVA: 0x00B2A688 File Offset: 0x00B28888
		public bool ExpandCountry { get; set; }

		// Token: 0x170078BF RID: 30911
		// (get) Token: 0x06030300 RID: 197376 RVA: 0x00B2A691 File Offset: 0x00B28891
		// (set) Token: 0x06030301 RID: 197377 RVA: 0x00B2A699 File Offset: 0x00B28899
		public int StateId { get; set; }

		// Token: 0x170078C0 RID: 30912
		// (get) Token: 0x06030302 RID: 197378 RVA: 0x00B2A6A2 File Offset: 0x00B288A2
		// (set) Token: 0x06030303 RID: 197379 RVA: 0x00B2A6AA File Offset: 0x00B288AA
		public int AreaId { get; set; }
	}
}
