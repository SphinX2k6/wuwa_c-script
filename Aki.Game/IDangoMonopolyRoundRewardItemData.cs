using System;

// Token: 0x02001249 RID: 4681
public interface IDangoMonopolyRoundRewardItemData
{
	// Token: 0x17000AC0 RID: 2752
	// (get) Token: 0x06007F13 RID: 32531
	bool IsReceived { get; }

	// Token: 0x17000AC1 RID: 2753
	// (get) Token: 0x06007F14 RID: 32532
	bool IsCanReceived { get; }

	// Token: 0x17000AC2 RID: 2754
	// (get) Token: 0x06007F15 RID: 32533
	int ItemId { get; }

	// Token: 0x17000AC3 RID: 2755
	// (get) Token: 0x06007F16 RID: 32534
	int Count { get; }

	// Token: 0x17000AC4 RID: 2756
	// (get) Token: 0x06007F17 RID: 32535
	int BoardId { get; }

	// Token: 0x17000AC5 RID: 2757
	// (get) Token: 0x06007F18 RID: 32536
	bool IsCurrent { get; }

	// Token: 0x17000AC6 RID: 2758
	// (get) Token: 0x06007F19 RID: 32537
	int Position { get; }
}
