using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015D9 RID: 5593
	[EnumExtensions]
	public enum EExecBattleActionType
	{
		// Token: 0x04004A86 RID: 19078
		SetBattleTags,
		// Token: 0x04004A87 RID: 19079
		SendBattleEvents,
		// Token: 0x04004A88 RID: 19080
		SendBattleEventsForMonsterSummon,
		// Token: 0x04004A89 RID: 19081
		SetMonsterMoveTarget,
		// Token: 0x04004A8A RID: 19082
		ExitMonsterMoveTarget,
		// Token: 0x04004A8B RID: 19083
		SetMonsterMoveWithSpline,
		// Token: 0x04004A8C RID: 19084
		ExitMonsterMoveWithSpline
	}
}
