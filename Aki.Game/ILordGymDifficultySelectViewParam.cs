using System;

// Token: 0x0200168E RID: 5774
public interface ILordGymDifficultySelectViewParam
{
	// Token: 0x1700157F RID: 5503
	// (get) Token: 0x0600E0CA RID: 57546
	// (set) Token: 0x0600E0CB RID: 57547
	int LordEntranceSetId { get; set; }

	// Token: 0x17001580 RID: 5504
	// (get) Token: 0x0600E0CC RID: 57548
	// (set) Token: 0x0600E0CD RID: 57549
	int LordEntranceId { get; set; }

	// Token: 0x17001581 RID: 5505
	// (get) Token: 0x0600E0CE RID: 57550
	// (set) Token: 0x0600E0CF RID: 57551
	bool IsPlaySpecialSequence { get; set; }

	// Token: 0x17001582 RID: 5506
	// (get) Token: 0x0600E0D0 RID: 57552
	// (set) Token: 0x0600E0D1 RID: 57553
	int DefaultLordId { get; set; }
}
