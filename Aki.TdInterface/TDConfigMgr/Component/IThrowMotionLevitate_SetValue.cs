using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000810 RID: 2064
	[NullableContext(2)]
	[Nullable(0)]
	public class IThrowMotionLevitate_SetValue
	{
		// Token: 0x04001DA7 RID: 7591
		public EThrowMotion Type;

		// Token: 0x04001DA8 RID: 7592
		public float Velocity;

		// Token: 0x04001DA9 RID: 7593
		public string VelocityCurve;

		// Token: 0x04001DAA RID: 7594
		public float MoveTime;

		// Token: 0x04001DAB RID: 7595
		public float? RayRadius;

		// Token: 0x04001DAC RID: 7596
		public IRenderTrajectoryConfig RenderTrajectoryConfig;
	}
}
