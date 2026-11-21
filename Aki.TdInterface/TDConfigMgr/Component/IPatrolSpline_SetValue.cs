using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000688 RID: 1672
	public class IPatrolSpline_SetValue
	{
		// Token: 0x0400187A RID: 6266
		public ESplineType Type;

		// Token: 0x0400187B RID: 6267
		[Nullable(2)]
		public ICycleModeType CycleOption;

		// Token: 0x0400187C RID: 6268
		public bool? IsNavigation;

		// Token: 0x0400187D RID: 6269
		public float? TurnSpeed;

		// Token: 0x0400187E RID: 6270
		public bool? IsFloating;

		// Token: 0x0400187F RID: 6271
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IPatrolPositionRefreshConfig> PositionRefreshConfigs;

		// Token: 0x04001880 RID: 6272
		public List<IPatrolSplinePoint> Points;

		// Token: 0x04001881 RID: 6273
		[Nullable(2)]
		public IPatrolRange PatrolRange;
	}
}
