using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002163 RID: 8547
	public class ResetPlayerCameraFocus_SetValue
	{
		// Token: 0x04007057 RID: 28759
		[Nullable(1)]
		public IResetPlayerFocusType ResetType;

		// Token: 0x04007058 RID: 28760
		public float FadeInTime;

		// Token: 0x04007059 RID: 28761
		public bool? CannotInterrupt;

		// Token: 0x0400705A RID: 28762
		public float? Duration;
	}
}
