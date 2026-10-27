using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000014 RID: 20
	public class AdsorbComponent_SetValue
	{
		// Token: 0x04000037 RID: 55
		public bool? Disabled;

		// Token: 0x04000038 RID: 56
		public bool? EdIsLocked;

		// Token: 0x04000039 RID: 57
		public float Range;

		// Token: 0x0400003A RID: 58
		public float StartVelocity;

		// Token: 0x0400003B RID: 59
		public float Acceleration;

		// Token: 0x0400003C RID: 60
		[Nullable(2)]
		public IEntityState ActiveStateCondition;

		// Token: 0x0400003D RID: 61
		public int AdsorbLimitedTime;
	}
}
