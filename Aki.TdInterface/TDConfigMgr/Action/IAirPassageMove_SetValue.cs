using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001954 RID: 6484
	public class IAirPassageMove_SetValue
	{
		// Token: 0x04005766 RID: 22374
		public ESplineMovePattern Type;

		// Token: 0x04005767 RID: 22375
		public float? MaxOffsetDistance;

		// Token: 0x04005768 RID: 22376
		public bool? IsOneWay;

		// Token: 0x04005769 RID: 22377
		public float? LayerVerticalLimit;

		// Token: 0x0400576A RID: 22378
		public bool? DynamicGravity;

		// Token: 0x0400576B RID: 22379
		public float? GravitySwitchAngularVelocity;

		// Token: 0x0400576C RID: 22380
		public int? AutoExitDistance;

		// Token: 0x0400576D RID: 22381
		[Nullable(2)]
		public IAirPassageMoveLimit Limit;
	}
}
