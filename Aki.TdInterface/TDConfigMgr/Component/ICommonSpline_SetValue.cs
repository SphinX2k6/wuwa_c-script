using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000254 RID: 596
	public class ICommonSpline_SetValue
	{
		// Token: 0x04000A96 RID: 2710
		public ESplineType Type;

		// Token: 0x04000A97 RID: 2711
		[Nullable(1)]
		public List<ICommonSplinePoint> Points;
	}
}
