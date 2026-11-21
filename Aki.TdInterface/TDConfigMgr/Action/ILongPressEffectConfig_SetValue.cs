using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D86 RID: 7558
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressEffectConfig_SetValue
	{
		// Token: 0x04006179 RID: 24953
		public string CameraShakeBpPath;

		// Token: 0x0400617A RID: 24954
		public string LongPressSound;

		// Token: 0x0400617B RID: 24955
		public IGamePadInteractVibration GamePadVibration;

		// Token: 0x0400617C RID: 24956
		public string LongPressScreenEffect;

		// Token: 0x0400617D RID: 24957
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> PlayEffects;
	}
}
