using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000242 RID: 578
	[NullableContext(2)]
	[Nullable(0)]
	public class ICircumnutation_SetValue
	{
		// Token: 0x04000A56 RID: 2646
		public EThrowMotion Type;

		// Token: 0x04000A57 RID: 2647
		public float Velocity;

		// Token: 0x04000A58 RID: 2648
		public string VelocityCurve;

		// Token: 0x04000A59 RID: 2649
		public EDirection Direction;

		// Token: 0x04000A5A RID: 2650
		public float AngularVelocity;

		// Token: 0x04000A5B RID: 2651
		public float RotationSpeed;

		// Token: 0x04000A5C RID: 2652
		public string AngularVelocityCurve;

		// Token: 0x04000A5D RID: 2653
		public IRenderTrajectoryConfig RenderTrajectoryConfig;
	}
}
