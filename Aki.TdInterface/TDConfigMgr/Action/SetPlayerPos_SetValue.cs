using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021CF RID: 8655
	[NullableContext(2)]
	[Nullable(0)]
	public class SetPlayerPos_SetValue
	{
		// Token: 0x04007168 RID: 29032
		[Nullable(1)]
		public ITeleportConfig TelePortConfig;

		// Token: 0x04007169 RID: 29033
		public ITelePortAfterTimeOut TeammateTeleportConfig;

		// Token: 0x0400716A RID: 29034
		public ITeleportTransitionType TransitionOption;

		// Token: 0x0400716B RID: 29035
		public bool? DisableAutoFadeInScreen;

		// Token: 0x0400716C RID: 29036
		public bool? OnlinePreciseTransport;
	}
}
