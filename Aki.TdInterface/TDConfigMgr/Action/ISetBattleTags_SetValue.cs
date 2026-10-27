using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E17 RID: 7703
	public class ISetBattleTags_SetValue
	{
		// Token: 0x040062A3 RID: 25251
		public EExecBattleActionType Type;

		// Token: 0x040062A4 RID: 25252
		[Nullable(1)]
		public List<ISetBattleTagConfig> Configs;
	}
}
