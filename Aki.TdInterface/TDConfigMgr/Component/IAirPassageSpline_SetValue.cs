using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001CF RID: 463
	public class IAirPassageSpline_SetValue
	{
		// Token: 0x040008B1 RID: 2225
		public ESplineType Type;

		// Token: 0x040008B2 RID: 2226
		public string MiddleLineEffect;

		// Token: 0x040008B3 RID: 2227
		public string TailCircleEffect;

		// Token: 0x040008B4 RID: 2228
		public string MiddleCircleEffect;

		// Token: 0x040008B5 RID: 2229
		public string MiddleCircleOverlyingEffect;

		// Token: 0x040008B6 RID: 2230
		public float MiddleCircleSpace;

		// Token: 0x040008B7 RID: 2231
		public float MiddleCircleRadius;

		// Token: 0x040008B8 RID: 2232
		public float MovableRadius;

		// Token: 0x040008B9 RID: 2233
		public float Resistance;

		// Token: 0x040008BA RID: 2234
		public float SpeedLimit;

		// Token: 0x040008BB RID: 2235
		public float SprintSpeedLimit;

		// Token: 0x040008BC RID: 2236
		public List<ICommonSplinePoint> Points;
	}
}
