using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000527 RID: 1319
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorHookConfig_SetValue
	{
		// Token: 0x0400135C RID: 4956
		public IFaceToTargetMotorInteractConstraint InteractConstraint;

		// Token: 0x0400135D RID: 4957
		public float? Radius;

		// Token: 0x0400135E RID: 4958
		public float? NonInteractiveInnerRadius;

		// Token: 0x0400135F RID: 4959
		public IMotorHookEndDir HookEndDir;

		// Token: 0x04001360 RID: 4960
		public IMotorHookAcceleration MotorHookAcceleration;

		// Token: 0x04001361 RID: 4961
		public IHookLockScreenDetectTypeBase ScreenDetectType;

		// Token: 0x04001362 RID: 4962
		public bool? AutoExit;

		// Token: 0x04001363 RID: 4963
		public IMotorHookPerformanceConfig MotorHookPerformanceConfig;
	}
}
