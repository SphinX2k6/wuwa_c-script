using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B88 RID: 7048
	[NullableContext(2)]
	[Nullable(0)]
	public class IEnableSubLevelTransitionWithSceneCapture_SetValue
	{
		// Token: 0x04005CA5 RID: 23717
		public EEnableSubLevelTransitionType Type;

		// Token: 0x04005CA6 RID: 23718
		public string SceneCaptureEffect;

		// Token: 0x04005CA7 RID: 23719
		public string ScreenEffect;

		// Token: 0x04005CA8 RID: 23720
		public string ScreenEffectLoop;

		// Token: 0x04005CA9 RID: 23721
		public float? DelayTime;

		// Token: 0x04005CAA RID: 23722
		public bool? IsAllowInput;
	}
}
