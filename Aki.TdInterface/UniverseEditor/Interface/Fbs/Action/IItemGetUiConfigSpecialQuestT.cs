using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007074 RID: 28788
	public class IItemGetUiConfigSpecialQuestT
	{
		// Token: 0x1700D2D1 RID: 53969
		// (get) Token: 0x06031EB7 RID: 204471 RVA: 0x006C18D7 File Offset: 0x006BFAD7
		// (set) Token: 0x06031EB8 RID: 204472 RVA: 0x006C18DF File Offset: 0x006BFADF
		public EItemGetUiType Type { get; set; }

		// Token: 0x1700D2D2 RID: 53970
		// (get) Token: 0x06031EB9 RID: 204473 RVA: 0x006C18E8 File Offset: 0x006BFAE8
		// (set) Token: 0x06031EBA RID: 204474 RVA: 0x006C18F0 File Offset: 0x006BFAF0
		public string Title { get; set; }

		// Token: 0x1700D2D3 RID: 53971
		// (get) Token: 0x06031EBB RID: 204475 RVA: 0x006C18F9 File Offset: 0x006BFAF9
		// (set) Token: 0x06031EBC RID: 204476 RVA: 0x006C1901 File Offset: 0x006BFB01
		public bool ShowDetail { get; set; }

		// Token: 0x1700D2D4 RID: 53972
		// (get) Token: 0x06031EBD RID: 204477 RVA: 0x006C190A File Offset: 0x006BFB0A
		// (set) Token: 0x06031EBE RID: 204478 RVA: 0x006C1912 File Offset: 0x006BFB12
		public byte NullMask { get; set; }

		// Token: 0x06031EBF RID: 204479 RVA: 0x006C191B File Offset: 0x006BFB1B
		public IItemGetUiConfigSpecialQuestT()
		{
			this.Type = EItemGetUiType.None;
			this.Title = null;
			this.ShowDetail = false;
			this.NullMask = 0;
		}
	}
}
