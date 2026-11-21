using System;

// Token: 0x02001B3C RID: 6972
public enum EQuestSpecialState
{
	// Token: 0x040098B1 RID: 39089
	None,
	// Token: 0x040098B2 RID: 39090
	PreShow,
	// Token: 0x040098B3 RID: 39091
	LockByLackResource,
	// Token: 0x040098B4 RID: 39092
	ResourceReadyButLock,
	// Token: 0x040098B5 RID: 39093
	Suspend,
	// Token: 0x040098B6 RID: 39094
	LockQuestSuspendByOnline,
	// Token: 0x040098B7 RID: 39095
	HasRecommendQuest,
	// Token: 0x040098B8 RID: 39096
	RefOccupiedEntity,
	// Token: 0x040098B9 RID: 39097
	LockByFocusMode,
	// Token: 0x040098BA RID: 39098
	NotInFocusModeButLock,
	// Token: 0x040098BB RID: 39099
	FocusOtherQuest,
	// Token: 0x040098BC RID: 39100
	ActivityGuideQuest,
	// Token: 0x040098BD RID: 39101
	ActivityQuest
}
