using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000514 RID: 1300
	public class ILevelAISpline_SetValue
	{
		// Token: 0x0400133F RID: 4927
		public ESplineType Type;

		// Token: 0x04001340 RID: 4928
		public int EntityId;

		// Token: 0x04001341 RID: 4929
		[Nullable(2)]
		public ILevelAiCycleLooply CycleOption;

		// Token: 0x04001342 RID: 4930
		public bool? UsePathFinding;

		// Token: 0x04001343 RID: 4931
		public bool? IsPassEveryKeyPoint;

		// Token: 0x04001344 RID: 4932
		public List<ILevelAISplinePoint> Points;
	}
}
