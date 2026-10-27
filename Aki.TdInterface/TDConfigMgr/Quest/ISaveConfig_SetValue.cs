using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001121 RID: 4385
	public class ISaveConfig_SetValue
	{
		// Token: 0x04003B5A RID: 15194
		public bool? IsTemp;

		// Token: 0x04003B5B RID: 15195
		public bool? EnableRollbackWhileSwitchOnlineMode;

		// Token: 0x04003B5C RID: 15196
		public bool? DisableRollbackWhileReconnect;

		// Token: 0x04003B5D RID: 15197
		[Nullable(2)]
		public IPosRollbackConfig PosRollbackCfg;

		// Token: 0x04003B5E RID: 15198
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> EnterActions;

		// Token: 0x04003B5F RID: 15199
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IInitConditionActions> InitConditionActions;
	}
}
