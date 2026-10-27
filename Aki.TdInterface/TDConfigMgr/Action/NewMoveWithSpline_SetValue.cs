using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020E5 RID: 8421
	public class NewMoveWithSpline_SetValue
	{
		// Token: 0x04006ED9 RID: 28377
		[Nullable(1)]
		public INewSplineMoveTarget MoveTarget;

		// Token: 0x04006EDA RID: 28378
		public int SplineEntityId;

		// Token: 0x04006EDB RID: 28379
		public int? StartPointIndex;

		// Token: 0x04006EDC RID: 28380
		public int? EndPointIndex;

		// Token: 0x04006EDD RID: 28381
		public bool? IsStartFromCurrentPos;

		// Token: 0x04006EDE RID: 28382
		public bool? IsFollowStrictly;
	}
}
