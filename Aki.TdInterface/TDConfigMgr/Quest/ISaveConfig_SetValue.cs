using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200124F RID: 4687
	public class ISaveConfig_SetValue
	{
		// Token: 0x04003EA8 RID: 16040
		public bool? IsTemp;

		// Token: 0x04003EA9 RID: 16041
		public bool? EnableRollbackWhileSwitchOnlineMode;

		// Token: 0x04003EAA RID: 16042
		public bool? DisableRollbackWhileReconnect;

		// Token: 0x04003EAB RID: 16043
		[Nullable(2)]
		public IPosRollbackConfig PosRollbackCfg;

		// Token: 0x04003EAC RID: 16044
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> EnterActions;

		// Token: 0x04003EAD RID: 16045
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IInitConditionActions> InitConditionActions;
	}
}
