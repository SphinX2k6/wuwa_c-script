using System;

// Token: 0x020021AA RID: 8618
public interface ILordGymDifficultySelectViewParam
{
	// Token: 0x17001548 RID: 5448
	// (get) Token: 0x06010C39 RID: 68665
	// (set) Token: 0x06010C3A RID: 68666
	int LordEntranceSetId { get; set; }

	// Token: 0x17001549 RID: 5449
	// (get) Token: 0x06010C3B RID: 68667
	// (set) Token: 0x06010C3C RID: 68668
	int LordEntranceId { get; set; }

	// Token: 0x1700154A RID: 5450
	// (get) Token: 0x06010C3D RID: 68669
	// (set) Token: 0x06010C3E RID: 68670
	bool IsPlaySpecialSequence { get; set; }

	// Token: 0x1700154B RID: 5451
	// (get) Token: 0x06010C3F RID: 68671
	// (set) Token: 0x06010C40 RID: 68672
	int DefaultLordId { get; set; }
}
