using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002346 RID: 9030
	public class NewMoveWithSpline_SetValue
	{
		// Token: 0x0400750C RID: 29964
		public INewSplineMoveTarget MoveTarget;

		// Token: 0x0400750D RID: 29965
		[Nullable(2)]
		public IFrontAxleTrackingSplineMove Move;

		// Token: 0x0400750E RID: 29966
		public int SplineEntityId;

		// Token: 0x0400750F RID: 29967
		public int? StartPointIndex;

		// Token: 0x04007510 RID: 29968
		public int? EndPointIndex;

		// Token: 0x04007511 RID: 29969
		public bool? IsStartFromCurrentPos;

		// Token: 0x04007512 RID: 29970
		public bool? IsFollowStrictly;
	}
}
