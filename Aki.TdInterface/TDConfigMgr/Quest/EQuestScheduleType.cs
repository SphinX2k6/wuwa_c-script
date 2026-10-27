using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000E83 RID: 3715
	[EnumExtensions]
	public enum EQuestScheduleType
	{
		// Token: 0x04003127 RID: 12583
		None,
		// Token: 0x04003128 RID: 12584
		ChildQuestCompleted,
		// Token: 0x04003129 RID: 12585
		EntityHP,
		// Token: 0x0400312A RID: 12586
		Score,
		// Token: 0x0400312B RID: 12587
		ChildQuestCompletedCount,
		// Token: 0x0400312C RID: 12588
		TowerChallengeTitle,
		// Token: 0x0400312D RID: 12589
		RoleTowerChallengeTitle,
		// Token: 0x0400312E RID: 12590
		Var,
		// Token: 0x0400312F RID: 12591
		MultiVar,
		// Token: 0x04003130 RID: 12592
		TimeLeft,
		// Token: 0x04003131 RID: 12593
		Condition,
		// Token: 0x04003132 RID: 12594
		ProgressValue,
		// Token: 0x04003133 RID: 12595
		DistanceValue
	}
}
