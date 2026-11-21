using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046C5 RID: 18117
	public class KurotatoAttrSelectCardData : IKurotatoAttrSelectCardData
	{
		// Token: 0x17005BA6 RID: 23462
		// (get) Token: 0x0602D8AD RID: 186541 RVA: 0x00CBEB02 File Offset: 0x00CBCD02
		// (set) Token: 0x0602D8AE RID: 186542 RVA: 0x00CBEB0A File Offset: 0x00CBCD0A
		public int ItemId { get; set; }

		// Token: 0x17005BA7 RID: 23463
		// (get) Token: 0x0602D8AF RID: 186543 RVA: 0x00CBEB13 File Offset: 0x00CBCD13
		// (set) Token: 0x0602D8B0 RID: 186544 RVA: 0x00CBEB1B File Offset: 0x00CBCD1B
		public int SelectionId { get; set; }

		// Token: 0x17005BA8 RID: 23464
		// (get) Token: 0x0602D8B1 RID: 186545 RVA: 0x00CBEB24 File Offset: 0x00CBCD24
		// (set) Token: 0x0602D8B2 RID: 186546 RVA: 0x00CBEB2C File Offset: 0x00CBCD2C
		public bool IsRecommend { get; set; }

		// Token: 0x17005BA9 RID: 23465
		// (get) Token: 0x0602D8B3 RID: 186547 RVA: 0x00CBEB35 File Offset: 0x00CBCD35
		// (set) Token: 0x0602D8B4 RID: 186548 RVA: 0x00CBEB3D File Offset: 0x00CBCD3D
		public EKurotatoAttrSelectType SelectType { get; set; }
	}
}
