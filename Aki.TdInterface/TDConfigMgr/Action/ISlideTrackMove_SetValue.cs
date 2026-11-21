using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020C3 RID: 8387
	public class ISlideTrackMove_SetValue
	{
		// Token: 0x040069B7 RID: 27063
		public ESplineMovePattern Type;

		// Token: 0x040069B8 RID: 27064
		public float? MaxOffsetDistance;

		// Token: 0x040069B9 RID: 27065
		public bool? IsOneWay;

		// Token: 0x040069BA RID: 27066
		public float? LayerVerticalLimit;

		// Token: 0x040069BB RID: 27067
		public bool? DynamicGravity;

		// Token: 0x040069BC RID: 27068
		public float? GravitySwitchAngularVelocity;

		// Token: 0x040069BD RID: 27069
		public int? AutoExitDistance;

		// Token: 0x040069BE RID: 27070
		public float DirectionAngleLimit;

		// Token: 0x040069BF RID: 27071
		public float EdgeLimitCurveFactor;
	}
}
