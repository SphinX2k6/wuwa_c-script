using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E42 RID: 7746
	[NullableContext(2)]
	[Nullable(0)]
	public class IMp4GamepadShake_SetValue
	{
		// Token: 0x0400639B RID: 25499
		public EGamepadShakeType Type;

		// Token: 0x0400639C RID: 25500
		public IMp4GamepadShakeFadeInConfig FadeInConfig;

		// Token: 0x0400639D RID: 25501
		public IMp4GamepadShakeFadeOutConfig FadeOutConfig;

		// Token: 0x0400639E RID: 25502
		public float? ShakeScale;
	}
}
