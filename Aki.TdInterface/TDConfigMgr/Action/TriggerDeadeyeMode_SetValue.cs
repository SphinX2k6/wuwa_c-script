using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002259 RID: 8793
	[NullableContext(2)]
	[Nullable(0)]
	public class TriggerDeadeyeMode_SetValue
	{
		// Token: 0x040072FC RID: 29436
		[Nullable(1)]
		public IDeadeyeFollowShooterConfig FollowShooterConfig;

		// Token: 0x040072FD RID: 29437
		[Nullable(1)]
		public List<int> FocusOnTags;

		// Token: 0x040072FE RID: 29438
		public float FocusRadius;

		// Token: 0x040072FF RID: 29439
		public float? TimeScale;

		// Token: 0x04007300 RID: 29440
		public float? TimeScaleTransitionTime;

		// Token: 0x04007301 RID: 29441
		public IDeadeyeFadeOutConfig FadeOutConfig;

		// Token: 0x04007302 RID: 29442
		[Nullable(1)]
		public IDeadeyeEnergyConfig EnergyConfig;

		// Token: 0x04007303 RID: 29443
		public IDeadeyeCameraConfig DefaultLookAt;

		// Token: 0x04007304 RID: 29444
		public IDeadEyeEffectConfig EffectConfig;

		// Token: 0x04007305 RID: 29445
		public string FinishSendSelfEvent;
	}
}
