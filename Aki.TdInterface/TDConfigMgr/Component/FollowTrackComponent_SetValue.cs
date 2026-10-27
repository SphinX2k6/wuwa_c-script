using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200017C RID: 380
	public class FollowTrackComponent_SetValue
	{
		// Token: 0x04000741 RID: 1857
		public bool? Disabled;

		// Token: 0x04000742 RID: 1858
		public bool? EdIsLocked;

		// Token: 0x04000743 RID: 1859
		public float Range;

		// Token: 0x04000744 RID: 1860
		public int SplineEntityId;

		// Token: 0x04000745 RID: 1861
		[Nullable(1)]
		public IFollowTrackEndType EndType;
	}
}
