using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F96 RID: 3990
	[EnumExtensions]
	public enum EQuestScheduleType
	{
		// Token: 0x04003429 RID: 13353
		None,
		// Token: 0x0400342A RID: 13354
		ChildQuestCompleted,
		// Token: 0x0400342B RID: 13355
		EntityHP,
		// Token: 0x0400342C RID: 13356
		Score,
		// Token: 0x0400342D RID: 13357
		ChildQuestCompletedCount,
		// Token: 0x0400342E RID: 13358
		TowerChallengeTitle,
		// Token: 0x0400342F RID: 13359
		RoleTowerChallengeTitle,
		// Token: 0x04003430 RID: 13360
		Var,
		// Token: 0x04003431 RID: 13361
		MultiVar,
		// Token: 0x04003432 RID: 13362
		TimeLeft,
		// Token: 0x04003433 RID: 13363
		Condition,
		// Token: 0x04003434 RID: 13364
		ProgressValue,
		// Token: 0x04003435 RID: 13365
		DistanceValue
	}
}
