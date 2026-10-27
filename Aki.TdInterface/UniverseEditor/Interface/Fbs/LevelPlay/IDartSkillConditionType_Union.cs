using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004488 RID: 17544
	public enum IDartSkillConditionType_Union : byte
	{
		// Token: 0x0400C47E RID: 50302
		NONE,
		// Token: 0x0400C47F RID: 50303
		IDartSkillConditionType,
		// Token: 0x0400C480 RID: 50304
		IRemainScoreGeCondition,
		// Token: 0x0400C481 RID: 50305
		IRemainScoreLeCondition,
		// Token: 0x0400C482 RID: 50306
		IBehindScoreGeCondition,
		// Token: 0x0400C483 RID: 50307
		IBehindScoreLeCondition,
		// Token: 0x0400C484 RID: 50308
		IRemainScoreCanWinCondition,
		// Token: 0x0400C485 RID: 50309
		IRoundIndexCondition,
		// Token: 0x0400C486 RID: 50310
		IFirstRoundsCondition
	}
}
