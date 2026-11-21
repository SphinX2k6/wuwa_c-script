using System;

// Token: 0x020006FD RID: 1789
public interface IDangoMonopolyRoundRewardItemData
{
	// Token: 0x17000AE0 RID: 2784
	// (get) Token: 0x060052AA RID: 21162
	bool IsReceived { get; }

	// Token: 0x17000AE1 RID: 2785
	// (get) Token: 0x060052AB RID: 21163
	bool IsCanReceived { get; }

	// Token: 0x17000AE2 RID: 2786
	// (get) Token: 0x060052AC RID: 21164
	int ItemId { get; }

	// Token: 0x17000AE3 RID: 2787
	// (get) Token: 0x060052AD RID: 21165
	int Count { get; }

	// Token: 0x17000AE4 RID: 2788
	// (get) Token: 0x060052AE RID: 21166
	int BoardId { get; }

	// Token: 0x17000AE5 RID: 2789
	// (get) Token: 0x060052AF RID: 21167
	bool IsCurrent { get; }

	// Token: 0x17000AE6 RID: 2790
	// (get) Token: 0x060052B0 RID: 21168
	int Position { get; }
}
