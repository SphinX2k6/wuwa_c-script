using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005DF RID: 1503
	public class IPathDrivenActorSplineMove_SetValue
	{
		// Token: 0x04001663 RID: 5731
		public EPathDrivenActorMoveType Type;

		// Token: 0x04001664 RID: 5732
		[Nullable(1)]
		public List<int> SplineEntityIds;

		// Token: 0x04001665 RID: 5733
		public bool? IsRandomSpline;

		// Token: 0x04001666 RID: 5734
		public bool? IsChainedSpline;

		// Token: 0x04001667 RID: 5735
		public bool? IsLoop;

		// Token: 0x04001668 RID: 5736
		public bool? IsFollowSplineDir;
	}
}
