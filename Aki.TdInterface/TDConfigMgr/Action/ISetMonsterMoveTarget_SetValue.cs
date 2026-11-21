using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200205C RID: 8284
	public class ISetMonsterMoveTarget_SetValue
	{
		// Token: 0x0400689D RID: 26781
		public EExecBattleActionType Type;

		// Token: 0x0400689E RID: 26782
		public int TargetEntityId;

		// Token: 0x0400689F RID: 26783
		public EMoveEvent? MoveEvent;

		// Token: 0x040068A0 RID: 26784
		public List<int> MonsterEntityIds;
	}
}
