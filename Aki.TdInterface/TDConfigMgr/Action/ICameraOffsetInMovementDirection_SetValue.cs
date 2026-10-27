using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001849 RID: 6217
	public class ICameraOffsetInMovementDirection_SetValue
	{
		// Token: 0x04005454 RID: 21588
		public float MinInterpolationSpeed;

		// Token: 0x04005455 RID: 21589
		public float MaxInterpolationSpeed;

		// Token: 0x04005456 RID: 21590
		public float OffsetDistance1;

		// Token: 0x04005457 RID: 21591
		public float OffsetDistance2;

		// Token: 0x04005458 RID: 21592
		[Nullable(2)]
		public IBaseCurve OffsetCurve;

		// Token: 0x04005459 RID: 21593
		public int? CenteringWaitTime;

		// Token: 0x0400545A RID: 21594
		public int? StartupWaitTime;
	}
}
