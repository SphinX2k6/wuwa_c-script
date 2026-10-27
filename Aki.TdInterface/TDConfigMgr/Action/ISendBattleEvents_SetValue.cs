using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF7 RID: 7671
	public class ISendBattleEvents_SetValue
	{
		// Token: 0x04006250 RID: 25168
		public EExecBattleActionType Type;

		// Token: 0x04006251 RID: 25169
		[Nullable(1)]
		public List<ISetBattleTagConfig> Configs;
	}
}
