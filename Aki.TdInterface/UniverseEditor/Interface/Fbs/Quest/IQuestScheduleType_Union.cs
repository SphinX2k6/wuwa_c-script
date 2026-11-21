using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004487 RID: 17543
	public enum IQuestScheduleType_Union : byte
	{
		// Token: 0x0400C564 RID: 50532
		NONE,
		// Token: 0x0400C565 RID: 50533
		IQuestScheduleType,
		// Token: 0x0400C566 RID: 50534
		IQuestScheduleNone,
		// Token: 0x0400C567 RID: 50535
		IQuestScheduleEntityHP,
		// Token: 0x0400C568 RID: 50536
		IQuestScheduleScore,
		// Token: 0x0400C569 RID: 50537
		IQuestScheduleChildQuestCompleted,
		// Token: 0x0400C56A RID: 50538
		IQuestScheduleChildQuestCompletedCount,
		// Token: 0x0400C56B RID: 50539
		IQuestScheduleTowerChallengeTitle,
		// Token: 0x0400C56C RID: 50540
		IQuestScheduleRoleTowerChallengeTitle,
		// Token: 0x0400C56D RID: 50541
		IQuestScheduleBtTreeVar,
		// Token: 0x0400C56E RID: 50542
		IQuestScheduleMultiBtTreeVar,
		// Token: 0x0400C56F RID: 50543
		IQuestScheduleTimeLeft,
		// Token: 0x0400C570 RID: 50544
		IQuestScheduleMeetCondition,
		// Token: 0x0400C571 RID: 50545
		IQuestScheduleProgressValue,
		// Token: 0x0400C572 RID: 50546
		IQuestScheduleDistanceValue
	}
}
