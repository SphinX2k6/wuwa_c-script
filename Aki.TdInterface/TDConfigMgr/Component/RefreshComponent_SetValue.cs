using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200086A RID: 2154
	public class RefreshComponent_SetValue
	{
		// Token: 0x04001F73 RID: 8051
		public bool? Disabled;

		// Token: 0x04001F74 RID: 8052
		public bool? EdIsLocked;

		// Token: 0x04001F75 RID: 8053
		[Nullable(1)]
		public IRefreshRule RefreshRule;

		// Token: 0x04001F76 RID: 8054
		public bool? IsDisableRefreshAfterDroppingReward;

		// Token: 0x04001F77 RID: 8055
		public bool? IsResetOnDungeonRestart;
	}
}
