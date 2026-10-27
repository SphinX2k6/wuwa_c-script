using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF9 RID: 7673
	public class ISendBattleEventsForMonsterSummon_SetValue
	{
		// Token: 0x04006256 RID: 25174
		public EExecBattleActionType Type;

		// Token: 0x04006257 RID: 25175
		[Nullable(1)]
		public List<ISendBattleEventsForMonsterSummonConfig> Configs;
	}
}
