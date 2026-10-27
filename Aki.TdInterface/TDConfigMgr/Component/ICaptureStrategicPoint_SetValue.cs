using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000214 RID: 532
	public class ICaptureStrategicPoint_SetValue
	{
		// Token: 0x04000976 RID: 2422
		public EProgressBarControlType Type;

		// Token: 0x04000977 RID: 2423
		public int MaxValue;

		// Token: 0x04000978 RID: 2424
		public int InitValue;

		// Token: 0x04000979 RID: 2425
		public int? ProgressPerformanceAttribute;

		// Token: 0x0400097A RID: 2426
		public int IncreaseSpeed;

		// Token: 0x0400097B RID: 2427
		public int DecreaseSpeed;

		// Token: 0x0400097C RID: 2428
		public int? UnoccupiedDecreaseSpeed;

		// Token: 0x0400097D RID: 2429
		[Nullable(1)]
		public IStaticEntitiyMatch EnemyEntitiyMatch;

		// Token: 0x0400097E RID: 2430
		public ECaptureStateType? CaptureType;
	}
}
