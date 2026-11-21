using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200023B RID: 571
	public class ICaptureStrategicPoint_SetValue
	{
		// Token: 0x04000A00 RID: 2560
		public EProgressBarControlType Type;

		// Token: 0x04000A01 RID: 2561
		public int MaxValue;

		// Token: 0x04000A02 RID: 2562
		public int InitValue;

		// Token: 0x04000A03 RID: 2563
		public int? ProgressPerformanceAttribute;

		// Token: 0x04000A04 RID: 2564
		public int IncreaseSpeed;

		// Token: 0x04000A05 RID: 2565
		public int DecreaseSpeed;

		// Token: 0x04000A06 RID: 2566
		public int? UnoccupiedDecreaseSpeed;

		// Token: 0x04000A07 RID: 2567
		public IStaticEntitiyMatch EnemyEntitiyMatch;

		// Token: 0x04000A08 RID: 2568
		public ECaptureStateType? CaptureType;
	}
}
