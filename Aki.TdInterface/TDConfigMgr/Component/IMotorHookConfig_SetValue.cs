using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200058E RID: 1422
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorHookConfig_SetValue
	{
		// Token: 0x040014C6 RID: 5318
		public IFaceToTargetMotorInteractConstraint InteractConstraint;

		// Token: 0x040014C7 RID: 5319
		public float? Radius;

		// Token: 0x040014C8 RID: 5320
		public float? NonInteractiveInnerRadius;

		// Token: 0x040014C9 RID: 5321
		public IMotorHookEndDir HookEndDir;

		// Token: 0x040014CA RID: 5322
		public IMotorHookAcceleration MotorHookAcceleration;

		// Token: 0x040014CB RID: 5323
		public IHookLockScreenDetectTypeBase ScreenDetectType;

		// Token: 0x040014CC RID: 5324
		public bool? AutoExit;

		// Token: 0x040014CD RID: 5325
		public IMotorHookPerformanceConfig MotorHookPerformanceConfig;
	}
}
