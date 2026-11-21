using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001739 RID: 5945
	[EnumExtensions]
	public enum EExecBattleActionType
	{
		// Token: 0x04004E43 RID: 20035
		SetBattleTags,
		// Token: 0x04004E44 RID: 20036
		SendBattleEvents,
		// Token: 0x04004E45 RID: 20037
		SendBattleEventsForMonsterSummon,
		// Token: 0x04004E46 RID: 20038
		SetMonsterMoveTarget,
		// Token: 0x04004E47 RID: 20039
		ExitMonsterMoveTarget,
		// Token: 0x04004E48 RID: 20040
		SetMonsterMoveWithSpline,
		// Token: 0x04004E49 RID: 20041
		ExitMonsterMoveWithSpline,
		// Token: 0x04004E4A RID: 20042
		AssistCharacterMoveToPoint,
		// Token: 0x04004E4B RID: 20043
		AssistCharacterStopMoveToPoint
	}
}
