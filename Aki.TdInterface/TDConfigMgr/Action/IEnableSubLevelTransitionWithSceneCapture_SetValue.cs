using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019F5 RID: 6645
	[NullableContext(2)]
	[Nullable(0)]
	public class IEnableSubLevelTransitionWithSceneCapture_SetValue
	{
		// Token: 0x04005843 RID: 22595
		public EEnableSubLevelTransitionType Type;

		// Token: 0x04005844 RID: 22596
		public string SceneCaptureEffect;

		// Token: 0x04005845 RID: 22597
		public string ScreenEffect;

		// Token: 0x04005846 RID: 22598
		public string ScreenEffectLoop;

		// Token: 0x04005847 RID: 22599
		public float? DelayTime;

		// Token: 0x04005848 RID: 22600
		public bool? IsAllowInput;
	}
}
