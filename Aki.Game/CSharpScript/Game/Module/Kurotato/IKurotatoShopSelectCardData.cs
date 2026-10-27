using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056EF RID: 22255
	public interface IKurotatoShopSelectCardData
	{
		// Token: 0x170087E2 RID: 34786
		// (get) Token: 0x060389A6 RID: 231846
		// (set) Token: 0x060389A7 RID: 231847
		int Id { get; set; }

		// Token: 0x170087E3 RID: 34787
		// (get) Token: 0x060389A8 RID: 231848
		// (set) Token: 0x060389A9 RID: 231849
		int SelectionId { get; set; }

		// Token: 0x170087E4 RID: 34788
		// (get) Token: 0x060389AA RID: 231850
		// (set) Token: 0x060389AB RID: 231851
		EKurotatoCardType CardType { get; set; }

		// Token: 0x170087E5 RID: 34789
		// (get) Token: 0x060389AC RID: 231852
		// (set) Token: 0x060389AD RID: 231853
		int OriginalCost { get; set; }

		// Token: 0x170087E6 RID: 34790
		// (get) Token: 0x060389AE RID: 231854
		// (set) Token: 0x060389AF RID: 231855
		int Cost { get; set; }

		// Token: 0x170087E7 RID: 34791
		// (get) Token: 0x060389B0 RID: 231856
		// (set) Token: 0x060389B1 RID: 231857
		bool IsLock { get; set; }

		// Token: 0x170087E8 RID: 34792
		// (get) Token: 0x060389B2 RID: 231858
		// (set) Token: 0x060389B3 RID: 231859
		bool HasBuy { get; set; }

		// Token: 0x170087E9 RID: 34793
		// (get) Token: 0x060389B4 RID: 231860
		// (set) Token: 0x060389B5 RID: 231861
		bool IsRecommend { get; set; }
	}
}
