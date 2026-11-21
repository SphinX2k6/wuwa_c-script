using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024C6 RID: 9414
	public class TriggerDeadeyeMode_SetValue
	{
		// Token: 0x04007949 RID: 31049
		public IDeadeyeFollowShooterConfig FollowShooterConfig;

		// Token: 0x0400794A RID: 31050
		public List<int> FocusOnTags;

		// Token: 0x0400794B RID: 31051
		public float FocusRadius;

		// Token: 0x0400794C RID: 31052
		public float? TimeScale;

		// Token: 0x0400794D RID: 31053
		public float? TimeScaleTransitionTime;

		// Token: 0x0400794E RID: 31054
		[Nullable(2)]
		public IDeadeyeFadeOutConfig FadeOutConfig;

		// Token: 0x0400794F RID: 31055
		public IDeadeyeEnergyConfig EnergyConfig;

		// Token: 0x04007950 RID: 31056
		[Nullable(2)]
		public IDeadeyeCameraConfig DefaultLookAt;

		// Token: 0x04007951 RID: 31057
		[Nullable(2)]
		public IDeadEyeEffectConfig EffectConfig;

		// Token: 0x04007952 RID: 31058
		[Nullable(2)]
		public string FinishSendSelfEvent;
	}
}
