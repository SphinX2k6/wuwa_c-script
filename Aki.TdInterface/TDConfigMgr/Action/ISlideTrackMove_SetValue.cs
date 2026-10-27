using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E8E RID: 7822
	public class ISlideTrackMove_SetValue
	{
		// Token: 0x040063D3 RID: 25555
		public ESplineMovePattern Type;

		// Token: 0x040063D4 RID: 25556
		public float? MaxOffsetDistance;

		// Token: 0x040063D5 RID: 25557
		public bool? IsOneWay;

		// Token: 0x040063D6 RID: 25558
		public float? LayerVerticalLimit;

		// Token: 0x040063D7 RID: 25559
		public bool? DynamicGravity;

		// Token: 0x040063D8 RID: 25560
		public float? GravitySwitchAngularVelocity;

		// Token: 0x040063D9 RID: 25561
		public int? AutoExitDistance;

		// Token: 0x040063DA RID: 25562
		public float DirectionAngleLimit;

		// Token: 0x040063DB RID: 25563
		public float EdgeLimitCurveFactor;
	}
}
