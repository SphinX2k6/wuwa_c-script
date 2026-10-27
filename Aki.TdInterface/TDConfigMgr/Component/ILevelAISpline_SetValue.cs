using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004BB RID: 1211
	public class ILevelAISpline_SetValue
	{
		// Token: 0x0400121D RID: 4637
		public ESplineType Type;

		// Token: 0x0400121E RID: 4638
		public int EntityId;

		// Token: 0x0400121F RID: 4639
		[Nullable(2)]
		public ILevelAiCycleLooply CycleOption;

		// Token: 0x04001220 RID: 4640
		public bool? UsePathFinding;

		// Token: 0x04001221 RID: 4641
		public bool? IsPassEveryKeyPoint;

		// Token: 0x04001222 RID: 4642
		[Nullable(1)]
		public List<ILevelAISplinePoint> Points;
	}
}
