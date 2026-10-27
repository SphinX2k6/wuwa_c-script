using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000216 RID: 534
	public class ICaptureStrategicPoint2_SetValue
	{
		// Token: 0x04000983 RID: 2435
		public EProgressBarControlType Type;

		// Token: 0x04000984 RID: 2436
		public int MaxValue;

		// Token: 0x04000985 RID: 2437
		public int InitValue;

		// Token: 0x04000986 RID: 2438
		public int? ProgressPerformanceAttribute;

		// Token: 0x04000987 RID: 2439
		[Nullable(1)]
		public IStaticEntitiyMatch EnemyEntitiyMatch;

		// Token: 0x04000988 RID: 2440
		public float PlayerInMonsterOutCaptureSpeed;

		// Token: 0x04000989 RID: 2441
		public float PlayerInMonsterInCaptureSpeed;

		// Token: 0x0400098A RID: 2442
		public float PlayerOutMonsterOutCaptureSpeed;

		// Token: 0x0400098B RID: 2443
		public float PlayerOutMonsterInCaptureSpeed;
	}
}
