using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200076F RID: 1903
	[NullableContext(2)]
	[Nullable(0)]
	public class IThrowMotionLevitate_SetValue
	{
		// Token: 0x04001BA2 RID: 7074
		public EThrowMotion Type;

		// Token: 0x04001BA3 RID: 7075
		public float Velocity;

		// Token: 0x04001BA4 RID: 7076
		public string VelocityCurve;

		// Token: 0x04001BA5 RID: 7077
		public float MoveTime;

		// Token: 0x04001BA6 RID: 7078
		public float? RayRadius;

		// Token: 0x04001BA7 RID: 7079
		public IRenderTrajectoryConfig RenderTrajectoryConfig;
	}
}
