using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017CD RID: 6093
	public class IAirPassageMove_SetValue
	{
		// Token: 0x04005322 RID: 21282
		public ESplineMovePattern Type;

		// Token: 0x04005323 RID: 21283
		public float? MaxOffsetDistance;

		// Token: 0x04005324 RID: 21284
		public bool? IsOneWay;

		// Token: 0x04005325 RID: 21285
		public float? LayerVerticalLimit;

		// Token: 0x04005326 RID: 21286
		public bool? DynamicGravity;

		// Token: 0x04005327 RID: 21287
		public float? GravitySwitchAngularVelocity;

		// Token: 0x04005328 RID: 21288
		public int? AutoExitDistance;

		// Token: 0x04005329 RID: 21289
		[Nullable(2)]
		public IAirPassageMoveLimit Limit;
	}
}
