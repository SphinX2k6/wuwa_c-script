using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004046 RID: 16454
	public enum IQuestScheduleType_Union : byte
	{
		// Token: 0x0400BB7D RID: 47997
		NONE,
		// Token: 0x0400BB7E RID: 47998
		IQuestScheduleType,
		// Token: 0x0400BB7F RID: 47999
		IQuestScheduleNone,
		// Token: 0x0400BB80 RID: 48000
		IQuestScheduleEntityHP,
		// Token: 0x0400BB81 RID: 48001
		IQuestScheduleScore,
		// Token: 0x0400BB82 RID: 48002
		IQuestScheduleChildQuestCompleted,
		// Token: 0x0400BB83 RID: 48003
		IQuestScheduleChildQuestCompletedCount,
		// Token: 0x0400BB84 RID: 48004
		IQuestScheduleTowerChallengeTitle,
		// Token: 0x0400BB85 RID: 48005
		IQuestScheduleRoleTowerChallengeTitle,
		// Token: 0x0400BB86 RID: 48006
		IQuestScheduleBtTreeVar,
		// Token: 0x0400BB87 RID: 48007
		IQuestScheduleMultiBtTreeVar,
		// Token: 0x0400BB88 RID: 48008
		IQuestScheduleTimeLeft,
		// Token: 0x0400BB89 RID: 48009
		IQuestScheduleMeetCondition,
		// Token: 0x0400BB8A RID: 48010
		IQuestScheduleProgressValue,
		// Token: 0x0400BB8B RID: 48011
		IQuestScheduleDistanceValue
	}
}
