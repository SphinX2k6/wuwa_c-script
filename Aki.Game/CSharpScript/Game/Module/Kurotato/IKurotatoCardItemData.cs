using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056E9 RID: 22249
	public interface IKurotatoCardItemData
	{
		// Token: 0x170087C8 RID: 34760
		// (get) Token: 0x0603896F RID: 231791
		// (set) Token: 0x06038970 RID: 231792
		int Id { get; set; }

		// Token: 0x170087C9 RID: 34761
		// (get) Token: 0x06038971 RID: 231793
		// (set) Token: 0x06038972 RID: 231794
		int SelectionId { get; set; }

		// Token: 0x170087CA RID: 34762
		// (get) Token: 0x06038973 RID: 231795
		// (set) Token: 0x06038974 RID: 231796
		int Cost { get; set; }

		// Token: 0x170087CB RID: 34763
		// (get) Token: 0x06038975 RID: 231797
		// (set) Token: 0x06038976 RID: 231798
		EKurotatoCardType CardType { get; set; }

		// Token: 0x170087CC RID: 34764
		// (get) Token: 0x06038977 RID: 231799
		// (set) Token: 0x06038978 RID: 231800
		bool HasBuy { get; set; }

		// Token: 0x170087CD RID: 34765
		// (get) Token: 0x06038979 RID: 231801
		// (set) Token: 0x0603897A RID: 231802
		bool IsRecommend { get; set; }

		// Token: 0x170087CE RID: 34766
		// (get) Token: 0x0603897B RID: 231803
		// (set) Token: 0x0603897C RID: 231804
		bool HasLock { get; set; }

		// Token: 0x170087CF RID: 34767
		// (get) Token: 0x0603897D RID: 231805
		// (set) Token: 0x0603897E RID: 231806
		bool ShowLock { get; set; }
	}
}
