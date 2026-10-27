using System;

// Token: 0x02001539 RID: 5433
public interface ITurntableQuestInfo
{
	// Token: 0x17000D50 RID: 3408
	// (get) Token: 0x06009B63 RID: 39779
	// (set) Token: 0x06009B64 RID: 39780
	int QuestState { get; set; }

	// Token: 0x17000D51 RID: 3409
	// (get) Token: 0x06009B65 RID: 39781
	// (set) Token: 0x06009B66 RID: 39782
	long QuestUnlockStamp { get; set; }
}
