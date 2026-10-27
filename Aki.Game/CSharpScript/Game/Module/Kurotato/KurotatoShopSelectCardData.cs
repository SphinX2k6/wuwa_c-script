using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056F0 RID: 22256
	public class KurotatoShopSelectCardData : IKurotatoShopSelectCardData
	{
		// Token: 0x170087EA RID: 34794
		// (get) Token: 0x060389B6 RID: 231862 RVA: 0x00D70566 File Offset: 0x00D6E766
		// (set) Token: 0x060389B7 RID: 231863 RVA: 0x00D7056E File Offset: 0x00D6E76E
		public int Id { get; set; }

		// Token: 0x170087EB RID: 34795
		// (get) Token: 0x060389B8 RID: 231864 RVA: 0x00D70577 File Offset: 0x00D6E777
		// (set) Token: 0x060389B9 RID: 231865 RVA: 0x00D7057F File Offset: 0x00D6E77F
		public int SelectionId { get; set; }

		// Token: 0x170087EC RID: 34796
		// (get) Token: 0x060389BA RID: 231866 RVA: 0x00D70588 File Offset: 0x00D6E788
		// (set) Token: 0x060389BB RID: 231867 RVA: 0x00D70590 File Offset: 0x00D6E790
		public EKurotatoCardType CardType { get; set; }

		// Token: 0x170087ED RID: 34797
		// (get) Token: 0x060389BC RID: 231868 RVA: 0x00D70599 File Offset: 0x00D6E799
		// (set) Token: 0x060389BD RID: 231869 RVA: 0x00D705A1 File Offset: 0x00D6E7A1
		public int OriginalCost { get; set; }

		// Token: 0x170087EE RID: 34798
		// (get) Token: 0x060389BE RID: 231870 RVA: 0x00D705AA File Offset: 0x00D6E7AA
		// (set) Token: 0x060389BF RID: 231871 RVA: 0x00D705B2 File Offset: 0x00D6E7B2
		public int Cost { get; set; }

		// Token: 0x170087EF RID: 34799
		// (get) Token: 0x060389C0 RID: 231872 RVA: 0x00D705BB File Offset: 0x00D6E7BB
		// (set) Token: 0x060389C1 RID: 231873 RVA: 0x00D705C3 File Offset: 0x00D6E7C3
		public bool IsLock { get; set; }

		// Token: 0x170087F0 RID: 34800
		// (get) Token: 0x060389C2 RID: 231874 RVA: 0x00D705CC File Offset: 0x00D6E7CC
		// (set) Token: 0x060389C3 RID: 231875 RVA: 0x00D705D4 File Offset: 0x00D6E7D4
		public bool HasBuy { get; set; }

		// Token: 0x170087F1 RID: 34801
		// (get) Token: 0x060389C4 RID: 231876 RVA: 0x00D705DD File Offset: 0x00D6E7DD
		// (set) Token: 0x060389C5 RID: 231877 RVA: 0x00D705E5 File Offset: 0x00D6E7E5
		public bool IsRecommend { get; set; }
	}
}
