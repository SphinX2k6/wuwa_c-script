using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DAC RID: 7596
	public class IMechaAirPassageMove_SetValue
	{
		// Token: 0x040061F2 RID: 25074
		public ESplineMovePattern Type;

		// Token: 0x040061F3 RID: 25075
		public float? MaxOffsetDistance;

		// Token: 0x040061F4 RID: 25076
		public bool? IsOneWay;

		// Token: 0x040061F5 RID: 25077
		public float? LayerVerticalLimit;

		// Token: 0x040061F6 RID: 25078
		public bool? DynamicGravity;

		// Token: 0x040061F7 RID: 25079
		public float? GravitySwitchAngularVelocity;

		// Token: 0x040061F8 RID: 25080
		public int? AutoExitDistance;

		// Token: 0x040061F9 RID: 25081
		public float ForwardAngleLimit;

		// Token: 0x040061FA RID: 25082
		[Nullable(2)]
		public string ForwardAngleLimitCurve;

		// Token: 0x040061FB RID: 25083
		public string InputCorrectionCurve;

		// Token: 0x040061FC RID: 25084
		public float? InputCorrectionBaseAngle;

		// Token: 0x040061FD RID: 25085
		public float? CorrectionPredictionDistance;
	}
}
