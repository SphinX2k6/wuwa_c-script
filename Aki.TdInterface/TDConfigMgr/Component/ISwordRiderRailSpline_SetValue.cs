using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000745 RID: 1861
	public class ISwordRiderRailSpline_SetValue
	{
		// Token: 0x04001B09 RID: 6921
		public ESplineType Type;

		// Token: 0x04001B0A RID: 6922
		public ESwordRiderRailWall WallType;

		// Token: 0x04001B0B RID: 6923
		[Nullable(2)]
		public string PathEffect;

		// Token: 0x04001B0C RID: 6924
		[Nullable(1)]
		public List<ISwordRiderRailSplinePoint> Points;
	}
}
