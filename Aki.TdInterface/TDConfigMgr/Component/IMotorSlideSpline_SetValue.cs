using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000531 RID: 1329
	public class IMotorSlideSpline_SetValue
	{
		// Token: 0x04001388 RID: 5000
		public ESplineType Type;

		// Token: 0x04001389 RID: 5001
		public float RangeRadius;

		// Token: 0x0400138A RID: 5002
		[Nullable(1)]
		public List<IMotorSlideSplinePoint> Points;
	}
}
