using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200062F RID: 1583
	[NullableContext(2)]
	[Nullable(0)]
	public class IProjectileMotion_SetValue
	{
		// Token: 0x0400178F RID: 6031
		public EThrowMotion Type;

		// Token: 0x04001790 RID: 6032
		public float Velocity;

		// Token: 0x04001791 RID: 6033
		public float AngularVelocity;

		// Token: 0x04001792 RID: 6034
		public string CameraShake;

		// Token: 0x04001793 RID: 6035
		public ISpeedCurveMotion MatchSpeedCurve;
	}
}
