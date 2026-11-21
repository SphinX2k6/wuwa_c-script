using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E08 RID: 7688
	public class IMotorcycleTrack_SetValue
	{
		// Token: 0x04006301 RID: 25345
		public ESplineMovePattern Type;

		// Token: 0x04006302 RID: 25346
		public float? MaxOffsetDistance;

		// Token: 0x04006303 RID: 25347
		public bool? IsOneWay;

		// Token: 0x04006304 RID: 25348
		public float? LayerVerticalLimit;

		// Token: 0x04006305 RID: 25349
		public bool? DynamicGravity;

		// Token: 0x04006306 RID: 25350
		public float? GravitySwitchAngularVelocity;

		// Token: 0x04006307 RID: 25351
		public int? AutoExitDistance;

		// Token: 0x04006308 RID: 25352
		public bool? DisableAutoForward;

		// Token: 0x04006309 RID: 25353
		public float? LongitudinalAngleLimit;

		// Token: 0x0400630A RID: 25354
		public float ForwardAngleLimit;

		// Token: 0x0400630B RID: 25355
		[Nullable(2)]
		public string ForwardAngleLimitCurve;

		// Token: 0x0400630C RID: 25356
		public string InputCorrectionCurve;

		// Token: 0x0400630D RID: 25357
		public float? InputCorrectionBaseAngle;

		// Token: 0x0400630E RID: 25358
		public float? CorrectionPredictionDistance;

		// Token: 0x0400630F RID: 25359
		public string AccelerationCorrectionCurve;

		// Token: 0x04006310 RID: 25360
		[Nullable(2)]
		public IAutomaticDrive AutomaticDrive;
	}
}
