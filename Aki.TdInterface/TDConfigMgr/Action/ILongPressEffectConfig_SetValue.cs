using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B9F RID: 7071
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressEffectConfig_SetValue
	{
		// Token: 0x04005C64 RID: 23652
		public string CameraShakeBpPath;

		// Token: 0x04005C65 RID: 23653
		public string LongPressSound;

		// Token: 0x04005C66 RID: 23654
		public IGamePadInteractVibration GamePadVibration;

		// Token: 0x04005C67 RID: 23655
		public string LongPressScreenEffect;

		// Token: 0x04005C68 RID: 23656
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> PlayEffects;
	}
}
