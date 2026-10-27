using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005EB RID: 1515
	[NullableContext(2)]
	[Nullable(0)]
	public class IPatrolSpline_SetValue
	{
		// Token: 0x0400168C RID: 5772
		public ESplineType Type;

		// Token: 0x0400168D RID: 5773
		public ICycleModeType CycleOption;

		// Token: 0x0400168E RID: 5774
		public bool? IsNavigation;

		// Token: 0x0400168F RID: 5775
		public float? TurnSpeed;

		// Token: 0x04001690 RID: 5776
		public bool? IsFloating;

		// Token: 0x04001691 RID: 5777
		[Nullable(1)]
		public List<IPatrolSplinePoint> Points;

		// Token: 0x04001692 RID: 5778
		public IPatrolRange PatrolRange;
	}
}
