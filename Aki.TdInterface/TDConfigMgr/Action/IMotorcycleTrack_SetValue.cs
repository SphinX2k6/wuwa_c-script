using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C19 RID: 7193
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorcycleTrack_SetValue
	{
		// Token: 0x04005DDA RID: 24026
		public ESplineMovePattern Type;

		// Token: 0x04005DDB RID: 24027
		public float? MaxOffsetDistance;

		// Token: 0x04005DDC RID: 24028
		public bool? IsOneWay;

		// Token: 0x04005DDD RID: 24029
		public float? LayerVerticalLimit;

		// Token: 0x04005DDE RID: 24030
		public bool? DynamicGravity;

		// Token: 0x04005DDF RID: 24031
		public float? GravitySwitchAngularVelocity;

		// Token: 0x04005DE0 RID: 24032
		public int? AutoExitDistance;

		// Token: 0x04005DE1 RID: 24033
		public bool? DisableAutoForward;

		// Token: 0x04005DE2 RID: 24034
		public float? LongitudinalAngleLimit;

		// Token: 0x04005DE3 RID: 24035
		public float ForwardAngleLimit;

		// Token: 0x04005DE4 RID: 24036
		[Nullable(2)]
		public string ForwardAngleLimitCurve;

		// Token: 0x04005DE5 RID: 24037
		public string InputCorrectionCurve;

		// Token: 0x04005DE6 RID: 24038
		public float? InputCorrectionBaseAngle;

		// Token: 0x04005DE7 RID: 24039
		public float? CorrectionPredictionDistance;

		// Token: 0x04005DE8 RID: 24040
		public string AccelerationCorrectionCurve;

		// Token: 0x04005DE9 RID: 24041
		[Nullable(2)]
		public IAutomaticDrive AutomaticDrive;
	}
}
