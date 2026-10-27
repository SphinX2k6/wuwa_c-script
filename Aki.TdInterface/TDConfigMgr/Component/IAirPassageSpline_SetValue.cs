using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001B8 RID: 440
	[NullableContext(1)]
	[Nullable(0)]
	public class IAirPassageSpline_SetValue
	{
		// Token: 0x04000858 RID: 2136
		public ESplineType Type;

		// Token: 0x04000859 RID: 2137
		public string MiddleLineEffect;

		// Token: 0x0400085A RID: 2138
		public string TailCircleEffect;

		// Token: 0x0400085B RID: 2139
		public string MiddleCircleEffect;

		// Token: 0x0400085C RID: 2140
		public string MiddleCircleOverlyingEffect;

		// Token: 0x0400085D RID: 2141
		public float MiddleCircleSpace;

		// Token: 0x0400085E RID: 2142
		public float MiddleCircleRadius;

		// Token: 0x0400085F RID: 2143
		public float MovableRadius;

		// Token: 0x04000860 RID: 2144
		public float Resistance;

		// Token: 0x04000861 RID: 2145
		public float SpeedLimit;

		// Token: 0x04000862 RID: 2146
		public float SprintSpeedLimit;

		// Token: 0x04000863 RID: 2147
		public List<ICommonSplinePoint> Points;
	}
}
