using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E90 RID: 7824
	public class IOnetimeGamepadShake_SetValue
	{
		// Token: 0x04006452 RID: 25682
		public EGamepadShakeType Type;

		// Token: 0x04006453 RID: 25683
		public bool? IsIgnoreTimeDilation;

		// Token: 0x04006454 RID: 25684
		[Nullable(2)]
		public string GamepadShakeTag;
	}
}
