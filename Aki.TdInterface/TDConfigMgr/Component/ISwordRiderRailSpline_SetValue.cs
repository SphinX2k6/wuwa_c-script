using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007E6 RID: 2022
	public class ISwordRiderRailSpline_SetValue
	{
		// Token: 0x04001D0E RID: 7438
		public ESplineType Type;

		// Token: 0x04001D0F RID: 7439
		public ESwordRiderRailWall WallType;

		// Token: 0x04001D10 RID: 7440
		[Nullable(2)]
		public string PathEffect;

		// Token: 0x04001D11 RID: 7441
		public List<ISwordRiderRailSplinePoint> Points;
	}
}
