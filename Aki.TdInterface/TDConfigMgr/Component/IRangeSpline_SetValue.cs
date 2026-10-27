using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000663 RID: 1635
	public class IRangeSpline_SetValue
	{
		// Token: 0x04001843 RID: 6211
		public ESplineType Type;

		// Token: 0x04001844 RID: 6212
		public float Height;

		// Token: 0x04001845 RID: 6213
		[Nullable(1)]
		public List<ICommonSplinePoint> Points;
	}
}
