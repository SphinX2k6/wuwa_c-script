using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046C1 RID: 18113
	public class KurotatoCardItemData : IKurotatoCardItemData
	{
		// Token: 0x17005B98 RID: 23448
		// (get) Token: 0x0602D88F RID: 186511 RVA: 0x00CBEA59 File Offset: 0x00CBCC59
		// (set) Token: 0x0602D890 RID: 186512 RVA: 0x00CBEA61 File Offset: 0x00CBCC61
		public int Id { get; set; }

		// Token: 0x17005B99 RID: 23449
		// (get) Token: 0x0602D891 RID: 186513 RVA: 0x00CBEA6A File Offset: 0x00CBCC6A
		// (set) Token: 0x0602D892 RID: 186514 RVA: 0x00CBEA72 File Offset: 0x00CBCC72
		public int SelectionId { get; set; }

		// Token: 0x17005B9A RID: 23450
		// (get) Token: 0x0602D893 RID: 186515 RVA: 0x00CBEA7B File Offset: 0x00CBCC7B
		// (set) Token: 0x0602D894 RID: 186516 RVA: 0x00CBEA83 File Offset: 0x00CBCC83
		public int Cost { get; set; }

		// Token: 0x17005B9B RID: 23451
		// (get) Token: 0x0602D895 RID: 186517 RVA: 0x00CBEA8C File Offset: 0x00CBCC8C
		// (set) Token: 0x0602D896 RID: 186518 RVA: 0x00CBEA94 File Offset: 0x00CBCC94
		public EKurotatoCardType CardType { get; set; }

		// Token: 0x17005B9C RID: 23452
		// (get) Token: 0x0602D897 RID: 186519 RVA: 0x00CBEA9D File Offset: 0x00CBCC9D
		// (set) Token: 0x0602D898 RID: 186520 RVA: 0x00CBEAA5 File Offset: 0x00CBCCA5
		public bool HasBuy { get; set; }

		// Token: 0x17005B9D RID: 23453
		// (get) Token: 0x0602D899 RID: 186521 RVA: 0x00CBEAAE File Offset: 0x00CBCCAE
		// (set) Token: 0x0602D89A RID: 186522 RVA: 0x00CBEAB6 File Offset: 0x00CBCCB6
		public bool IsRecommend { get; set; }

		// Token: 0x17005B9E RID: 23454
		// (get) Token: 0x0602D89B RID: 186523 RVA: 0x00CBEABF File Offset: 0x00CBCCBF
		// (set) Token: 0x0602D89C RID: 186524 RVA: 0x00CBEAC7 File Offset: 0x00CBCCC7
		public bool HasLock { get; set; }

		// Token: 0x17005B9F RID: 23455
		// (get) Token: 0x0602D89D RID: 186525 RVA: 0x00CBEAD0 File Offset: 0x00CBCCD0
		// (set) Token: 0x0602D89E RID: 186526 RVA: 0x00CBEAD8 File Offset: 0x00CBCCD8
		public bool ShowLock { get; set; }
	}
}
