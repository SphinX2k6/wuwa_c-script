using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200243A RID: 9274
	public class SetPlayerPos_SetValue
	{
		// Token: 0x040077B0 RID: 30640
		public ITeleportConfig TelePortConfig;

		// Token: 0x040077B1 RID: 30641
		[Nullable(2)]
		public ITelePortAfterTimeOut TeammateTeleportConfig;

		// Token: 0x040077B2 RID: 30642
		[Nullable(2)]
		public ITeleportTransitionType TransitionOption;

		// Token: 0x040077B3 RID: 30643
		public bool? DisableAutoFadeInScreen;

		// Token: 0x040077B4 RID: 30644
		public bool? OnlinePreciseTransport;

		// Token: 0x040077B5 RID: 30645
		public bool? IsBanMapSound;
	}
}
