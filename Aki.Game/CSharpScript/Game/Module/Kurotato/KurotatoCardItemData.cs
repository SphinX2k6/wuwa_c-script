using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056EA RID: 22250
	public class KurotatoCardItemData : IKurotatoCardItemData
	{
		// Token: 0x170087D0 RID: 34768
		// (get) Token: 0x0603897F RID: 231807 RVA: 0x00D70471 File Offset: 0x00D6E671
		// (set) Token: 0x06038980 RID: 231808 RVA: 0x00D70479 File Offset: 0x00D6E679
		public int Id { get; set; }

		// Token: 0x170087D1 RID: 34769
		// (get) Token: 0x06038981 RID: 231809 RVA: 0x00D70482 File Offset: 0x00D6E682
		// (set) Token: 0x06038982 RID: 231810 RVA: 0x00D7048A File Offset: 0x00D6E68A
		public int SelectionId { get; set; }

		// Token: 0x170087D2 RID: 34770
		// (get) Token: 0x06038983 RID: 231811 RVA: 0x00D70493 File Offset: 0x00D6E693
		// (set) Token: 0x06038984 RID: 231812 RVA: 0x00D7049B File Offset: 0x00D6E69B
		public int Cost { get; set; }

		// Token: 0x170087D3 RID: 34771
		// (get) Token: 0x06038985 RID: 231813 RVA: 0x00D704A4 File Offset: 0x00D6E6A4
		// (set) Token: 0x06038986 RID: 231814 RVA: 0x00D704AC File Offset: 0x00D6E6AC
		public EKurotatoCardType CardType { get; set; }

		// Token: 0x170087D4 RID: 34772
		// (get) Token: 0x06038987 RID: 231815 RVA: 0x00D704B5 File Offset: 0x00D6E6B5
		// (set) Token: 0x06038988 RID: 231816 RVA: 0x00D704BD File Offset: 0x00D6E6BD
		public bool HasBuy { get; set; }

		// Token: 0x170087D5 RID: 34773
		// (get) Token: 0x06038989 RID: 231817 RVA: 0x00D704C6 File Offset: 0x00D6E6C6
		// (set) Token: 0x0603898A RID: 231818 RVA: 0x00D704CE File Offset: 0x00D6E6CE
		public bool IsRecommend { get; set; }

		// Token: 0x170087D6 RID: 34774
		// (get) Token: 0x0603898B RID: 231819 RVA: 0x00D704D7 File Offset: 0x00D6E6D7
		// (set) Token: 0x0603898C RID: 231820 RVA: 0x00D704DF File Offset: 0x00D6E6DF
		public bool HasLock { get; set; }

		// Token: 0x170087D7 RID: 34775
		// (get) Token: 0x0603898D RID: 231821 RVA: 0x00D704E8 File Offset: 0x00D6E6E8
		// (set) Token: 0x0603898E RID: 231822 RVA: 0x00D704F0 File Offset: 0x00D6E6F0
		public bool ShowLock { get; set; }
	}
}
