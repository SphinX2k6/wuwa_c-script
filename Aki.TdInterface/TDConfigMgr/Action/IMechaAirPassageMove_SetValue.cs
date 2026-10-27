using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BC5 RID: 7109
	public class IMechaAirPassageMove_SetValue
	{
		// Token: 0x04005CDD RID: 23773
		public ESplineMovePattern Type;

		// Token: 0x04005CDE RID: 23774
		public float? MaxOffsetDistance;

		// Token: 0x04005CDF RID: 23775
		public bool? IsOneWay;

		// Token: 0x04005CE0 RID: 23776
		public float? LayerVerticalLimit;

		// Token: 0x04005CE1 RID: 23777
		public bool? DynamicGravity;

		// Token: 0x04005CE2 RID: 23778
		public float? GravitySwitchAngularVelocity;

		// Token: 0x04005CE3 RID: 23779
		public int? AutoExitDistance;

		// Token: 0x04005CE4 RID: 23780
		public float ForwardAngleLimit;

		// Token: 0x04005CE5 RID: 23781
		[Nullable(2)]
		public string ForwardAngleLimitCurve;

		// Token: 0x04005CE6 RID: 23782
		[Nullable(1)]
		public string InputCorrectionCurve;

		// Token: 0x04005CE7 RID: 23783
		public float? InputCorrectionBaseAngle;

		// Token: 0x04005CE8 RID: 23784
		public float? CorrectionPredictionDistance;
	}
}
