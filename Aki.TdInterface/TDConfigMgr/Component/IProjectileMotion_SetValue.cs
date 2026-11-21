using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006CC RID: 1740
	[NullableContext(2)]
	[Nullable(0)]
	public class IProjectileMotion_SetValue
	{
		// Token: 0x04001981 RID: 6529
		public EThrowMotion Type;

		// Token: 0x04001982 RID: 6530
		public float Velocity;

		// Token: 0x04001983 RID: 6531
		public float AngularVelocity;

		// Token: 0x04001984 RID: 6532
		public string CameraShake;

		// Token: 0x04001985 RID: 6533
		public ISpeedCurveMotion MatchSpeedCurve;
	}
}
