using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046C7 RID: 18119
	public class KurotatoShopSelectCardData : IKurotatoShopSelectCardData
	{
		// Token: 0x17005BB2 RID: 23474
		// (get) Token: 0x0602D8C6 RID: 186566 RVA: 0x00CBEB4E File Offset: 0x00CBCD4E
		// (set) Token: 0x0602D8C7 RID: 186567 RVA: 0x00CBEB56 File Offset: 0x00CBCD56
		public int Id { get; set; }

		// Token: 0x17005BB3 RID: 23475
		// (get) Token: 0x0602D8C8 RID: 186568 RVA: 0x00CBEB5F File Offset: 0x00CBCD5F
		// (set) Token: 0x0602D8C9 RID: 186569 RVA: 0x00CBEB67 File Offset: 0x00CBCD67
		public int SelectionId { get; set; }

		// Token: 0x17005BB4 RID: 23476
		// (get) Token: 0x0602D8CA RID: 186570 RVA: 0x00CBEB70 File Offset: 0x00CBCD70
		// (set) Token: 0x0602D8CB RID: 186571 RVA: 0x00CBEB78 File Offset: 0x00CBCD78
		public EKurotatoCardType CardType { get; set; }

		// Token: 0x17005BB5 RID: 23477
		// (get) Token: 0x0602D8CC RID: 186572 RVA: 0x00CBEB81 File Offset: 0x00CBCD81
		// (set) Token: 0x0602D8CD RID: 186573 RVA: 0x00CBEB89 File Offset: 0x00CBCD89
		public int OriginalCost { get; set; }

		// Token: 0x17005BB6 RID: 23478
		// (get) Token: 0x0602D8CE RID: 186574 RVA: 0x00CBEB92 File Offset: 0x00CBCD92
		// (set) Token: 0x0602D8CF RID: 186575 RVA: 0x00CBEB9A File Offset: 0x00CBCD9A
		public int Cost { get; set; }

		// Token: 0x17005BB7 RID: 23479
		// (get) Token: 0x0602D8D0 RID: 186576 RVA: 0x00CBEBA3 File Offset: 0x00CBCDA3
		// (set) Token: 0x0602D8D1 RID: 186577 RVA: 0x00CBEBAB File Offset: 0x00CBCDAB
		public bool IsLock { get; set; }

		// Token: 0x17005BB8 RID: 23480
		// (get) Token: 0x0602D8D2 RID: 186578 RVA: 0x00CBEBB4 File Offset: 0x00CBCDB4
		// (set) Token: 0x0602D8D3 RID: 186579 RVA: 0x00CBEBBC File Offset: 0x00CBCDBC
		public bool HasBuy { get; set; }

		// Token: 0x17005BB9 RID: 23481
		// (get) Token: 0x0602D8D4 RID: 186580 RVA: 0x00CBEBC5 File Offset: 0x00CBCDC5
		// (set) Token: 0x0602D8D5 RID: 186581 RVA: 0x00CBEBCD File Offset: 0x00CBCDCD
		public bool IsRecommend { get; set; }
	}
}
