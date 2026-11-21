using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000283 RID: 643
	[NullableContext(2)]
	[Nullable(0)]
	public class ICircumnutation_SetValue
	{
		// Token: 0x04000B32 RID: 2866
		public EThrowMotion Type;

		// Token: 0x04000B33 RID: 2867
		public float Velocity;

		// Token: 0x04000B34 RID: 2868
		public string VelocityCurve;

		// Token: 0x04000B35 RID: 2869
		public EDirection Direction;

		// Token: 0x04000B36 RID: 2870
		public float AngularVelocity;

		// Token: 0x04000B37 RID: 2871
		public float RotationSpeed;

		// Token: 0x04000B38 RID: 2872
		public string AngularVelocityCurve;

		// Token: 0x04000B39 RID: 2873
		public IRenderTrajectoryConfig RenderTrajectoryConfig;
	}
}
