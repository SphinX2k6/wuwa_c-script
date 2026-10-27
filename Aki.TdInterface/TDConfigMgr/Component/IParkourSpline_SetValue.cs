using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005BB RID: 1467
	[NullableContext(2)]
	[Nullable(0)]
	public class IParkourSpline_SetValue
	{
		// Token: 0x040015F4 RID: 5620
		public ESplineType Type;

		// Token: 0x040015F5 RID: 5621
		public bool IsRequireToEnd;

		// Token: 0x040015F6 RID: 5622
		public int CheckPointsRequire;

		// Token: 0x040015F7 RID: 5623
		[Nullable(1)]
		public string CheckPointResource;

		// Token: 0x040015F8 RID: 5624
		public string CheckPointsDestroyRes;

		// Token: 0x040015F9 RID: 5625
		public string StartResource;

		// Token: 0x040015FA RID: 5626
		public string EndResource;

		// Token: 0x040015FB RID: 5627
		[Nullable(1)]
		public List<IParkourSplinePoint> Points;
	}
}
