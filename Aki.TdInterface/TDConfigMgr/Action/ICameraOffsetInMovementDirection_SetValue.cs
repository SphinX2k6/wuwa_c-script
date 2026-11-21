using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019D4 RID: 6612
	public class ICameraOffsetInMovementDirection_SetValue
	{
		// Token: 0x040058A0 RID: 22688
		public float MinInterpolationSpeed;

		// Token: 0x040058A1 RID: 22689
		public float MaxInterpolationSpeed;

		// Token: 0x040058A2 RID: 22690
		public float OffsetDistance1;

		// Token: 0x040058A3 RID: 22691
		public float OffsetDistance2;

		// Token: 0x040058A4 RID: 22692
		[Nullable(2)]
		public IBaseCurve OffsetCurve;

		// Token: 0x040058A5 RID: 22693
		public int? CenteringWaitTime;

		// Token: 0x040058A6 RID: 22694
		public int? StartupWaitTime;
	}
}
