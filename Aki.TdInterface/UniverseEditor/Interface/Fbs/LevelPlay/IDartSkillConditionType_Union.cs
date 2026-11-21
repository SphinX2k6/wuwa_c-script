using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048F0 RID: 18672
	public enum IDartSkillConditionType_Union : byte
	{
		// Token: 0x0400CEAC RID: 52908
		NONE,
		// Token: 0x0400CEAD RID: 52909
		IDartSkillConditionType,
		// Token: 0x0400CEAE RID: 52910
		IRemainScoreGeCondition,
		// Token: 0x0400CEAF RID: 52911
		IRemainScoreLeCondition,
		// Token: 0x0400CEB0 RID: 52912
		IBehindScoreGeCondition,
		// Token: 0x0400CEB1 RID: 52913
		IBehindScoreLeCondition,
		// Token: 0x0400CEB2 RID: 52914
		IRemainScoreCanWinCondition,
		// Token: 0x0400CEB3 RID: 52915
		IRoundIndexCondition,
		// Token: 0x0400CEB4 RID: 52916
		IFirstRoundsCondition
	}
}
