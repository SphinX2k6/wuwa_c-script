using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000670 RID: 1648
	public class IPathDrivenActorSplineMove_SetValue
	{
		// Token: 0x0400183A RID: 6202
		public EPathDrivenActorMoveType Type;

		// Token: 0x0400183B RID: 6203
		public List<int> SplineEntityIds;

		// Token: 0x0400183C RID: 6204
		public bool? IsRandomSpline;

		// Token: 0x0400183D RID: 6205
		public bool? IsChainedSpline;

		// Token: 0x0400183E RID: 6206
		public bool? IsLoop;

		// Token: 0x0400183F RID: 6207
		public bool? IsFollowSplineDir;
	}
}
