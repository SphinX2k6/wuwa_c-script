using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE6 RID: 7910
	public class IPetalGrabMove_SetValue
	{
		// Token: 0x04006539 RID: 25913
		public ESplineMovePattern Type;

		// Token: 0x0400653A RID: 25914
		public float? MaxOffsetDistance;

		// Token: 0x0400653B RID: 25915
		public bool? IsOneWay;

		// Token: 0x0400653C RID: 25916
		public float? LayerVerticalLimit;

		// Token: 0x0400653D RID: 25917
		public bool? DynamicGravity;

		// Token: 0x0400653E RID: 25918
		public float? GravitySwitchAngularVelocity;

		// Token: 0x0400653F RID: 25919
		public int? AutoExitDistance;

		// Token: 0x04006540 RID: 25920
		public IPetalGrabMoveLinear ControlType;
	}
}
