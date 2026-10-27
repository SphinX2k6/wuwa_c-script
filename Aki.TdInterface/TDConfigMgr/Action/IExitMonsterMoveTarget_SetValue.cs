using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A24 RID: 6692
	public class IExitMonsterMoveTarget_SetValue
	{
		// Token: 0x040058B3 RID: 22707
		public EExecBattleActionType Type;

		// Token: 0x040058B4 RID: 22708
		[Nullable(1)]
		public List<int> TargetEntities;
	}
}
