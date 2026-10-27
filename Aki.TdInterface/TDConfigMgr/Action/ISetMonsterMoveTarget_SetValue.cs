using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E29 RID: 7721
	public class ISetMonsterMoveTarget_SetValue
	{
		// Token: 0x040062C6 RID: 25286
		public EExecBattleActionType Type;

		// Token: 0x040062C7 RID: 25287
		public int TargetEntityId;

		// Token: 0x040062C8 RID: 25288
		public EMoveEvent? MoveEvent;

		// Token: 0x040062C9 RID: 25289
		[Nullable(1)]
		public List<int> MonsterEntityIds;
	}
}
