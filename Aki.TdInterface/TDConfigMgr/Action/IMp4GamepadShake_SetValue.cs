using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C4B RID: 7243
	[NullableContext(2)]
	[Nullable(0)]
	public class IMp4GamepadShake_SetValue
	{
		// Token: 0x04005E64 RID: 24164
		public EGamepadShakeType Type;

		// Token: 0x04005E65 RID: 24165
		public IMp4GamepadShakeFadeInConfig FadeInConfig;

		// Token: 0x04005E66 RID: 24166
		public IMp4GamepadShakeFadeOutConfig FadeOutConfig;

		// Token: 0x04005E67 RID: 24167
		public float? ShakeScale;
	}
}
