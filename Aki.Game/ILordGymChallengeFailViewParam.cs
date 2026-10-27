using System;

// Token: 0x02002198 RID: 8600
public interface ILordGymChallengeFailViewParam
{
	// Token: 0x17001537 RID: 5431
	// (get) Token: 0x06010B80 RID: 68480
	// (set) Token: 0x06010B81 RID: 68481
	int LordId { get; set; }

	// Token: 0x17001538 RID: 5432
	// (get) Token: 0x06010B82 RID: 68482
	// (set) Token: 0x06010B83 RID: 68483
	ELordGymVersion Version { get; set; }

	// Token: 0x17001539 RID: 5433
	// (get) Token: 0x06010B84 RID: 68484
	// (set) Token: 0x06010B85 RID: 68485
	bool IsFromGuide { get; set; }
}
