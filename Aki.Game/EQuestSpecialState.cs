using System;

// Token: 0x02002651 RID: 9809
public enum EQuestSpecialState
{
	// Token: 0x04009759 RID: 38745
	None,
	// Token: 0x0400975A RID: 38746
	PreShow,
	// Token: 0x0400975B RID: 38747
	LockByLackResource,
	// Token: 0x0400975C RID: 38748
	ResourceReadyButLock,
	// Token: 0x0400975D RID: 38749
	Suspend,
	// Token: 0x0400975E RID: 38750
	LockQuestSuspendByOnline,
	// Token: 0x0400975F RID: 38751
	HasRecommendQuest,
	// Token: 0x04009760 RID: 38752
	RefOccupiedEntity,
	// Token: 0x04009761 RID: 38753
	LockByFocusMode,
	// Token: 0x04009762 RID: 38754
	NotInFocusModeButLock,
	// Token: 0x04009763 RID: 38755
	FocusOtherQuest,
	// Token: 0x04009764 RID: 38756
	ActivityGuideQuest,
	// Token: 0x04009765 RID: 38757
	ActivityQuest
}
