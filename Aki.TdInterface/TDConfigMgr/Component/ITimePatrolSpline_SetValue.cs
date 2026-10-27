using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200077C RID: 1916
	public class ITimePatrolSpline_SetValue
	{
		// Token: 0x04001BD7 RID: 7127
		public ESplineType Type;

		// Token: 0x04001BD8 RID: 7128
		[Nullable(1)]
		public List<ITimePatrolSplinePoint> Points;
	}
}
