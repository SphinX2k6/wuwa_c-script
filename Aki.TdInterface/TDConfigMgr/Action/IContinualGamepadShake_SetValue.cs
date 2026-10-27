using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001933 RID: 6451
	public class IContinualGamepadShake_SetValue
	{
		// Token: 0x0400567D RID: 22141
		public EGamepadShakeType Type;

		// Token: 0x0400567E RID: 22142
		public bool? IsIgnoreTimeDilation;

		// Token: 0x0400567F RID: 22143
		public float Duration;

		// Token: 0x04005680 RID: 22144
		public bool IsLoop;

		// Token: 0x04005681 RID: 22145
		[Nullable(2)]
		public string GamepadShakeTag;
	}
}
