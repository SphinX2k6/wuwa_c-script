using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000937 RID: 2359
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemMovementComponent_SetValue
	{
		// Token: 0x0400224B RID: 8779
		public bool? Disabled;

		// Token: 0x0400224C RID: 8780
		public bool? EdIsLocked;

		// Token: 0x0400224D RID: 8781
		public ISplineMove Patrol;

		// Token: 0x0400224E RID: 8782
		public IMovementPlatformConfig PlatformConfig;
	}
}
