using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000626 RID: 1574
	public class IParkourSpline_SetValue
	{
		// Token: 0x04001768 RID: 5992
		public ESplineType Type;

		// Token: 0x04001769 RID: 5993
		public bool IsRequireToEnd;

		// Token: 0x0400176A RID: 5994
		public int CheckPointsRequire;

		// Token: 0x0400176B RID: 5995
		public string CheckPointResource;

		// Token: 0x0400176C RID: 5996
		[Nullable(2)]
		public string CheckPointsDestroyRes;

		// Token: 0x0400176D RID: 5997
		[Nullable(2)]
		public string StartResource;

		// Token: 0x0400176E RID: 5998
		[Nullable(2)]
		public string EndResource;

		// Token: 0x0400176F RID: 5999
		public List<IParkourSplinePoint> Points;
	}
}
