using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ABC RID: 6844
	public class IContinualGamepadShake_SetValue
	{
		// Token: 0x04005ACD RID: 23245
		public EGamepadShakeType Type;

		// Token: 0x04005ACE RID: 23246
		public bool? IsIgnoreTimeDilation;

		// Token: 0x04005ACF RID: 23247
		public float Duration;

		// Token: 0x04005AD0 RID: 23248
		public bool IsLoop;

		// Token: 0x04005AD1 RID: 23249
		[Nullable(2)]
		public string GamepadShakeTag;
	}
}
