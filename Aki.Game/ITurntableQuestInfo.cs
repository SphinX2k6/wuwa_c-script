using System;

// Token: 0x020009F1 RID: 2545
public interface ITurntableQuestInfo
{
	// Token: 0x17000D71 RID: 3441
	// (get) Token: 0x06006F41 RID: 28481
	// (set) Token: 0x06006F42 RID: 28482
	int QuestState { get; set; }

	// Token: 0x17000D72 RID: 3442
	// (get) Token: 0x06006F43 RID: 28483
	// (set) Token: 0x06006F44 RID: 28484
	long QuestUnlockStamp { get; set; }
}
