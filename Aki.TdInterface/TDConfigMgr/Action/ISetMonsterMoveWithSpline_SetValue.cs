using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E2B RID: 7723
	public class ISetMonsterMoveWithSpline_SetValue
	{
		// Token: 0x040062CE RID: 25294
		public EExecBattleActionType Type;

		// Token: 0x040062CF RID: 25295
		[Nullable(1)]
		public List<IMonsterMoveSplineConfig> MoveSplineConfigs;
	}
}
