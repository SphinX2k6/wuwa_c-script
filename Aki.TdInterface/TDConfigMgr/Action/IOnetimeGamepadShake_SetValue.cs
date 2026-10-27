using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C8B RID: 7307
	public class IOnetimeGamepadShake_SetValue
	{
		// Token: 0x04005EFF RID: 24319
		public EGamepadShakeType Type;

		// Token: 0x04005F00 RID: 24320
		public bool? IsIgnoreTimeDilation;

		// Token: 0x04005F01 RID: 24321
		[Nullable(2)]
		public string GamepadShakeTag;
	}
}
