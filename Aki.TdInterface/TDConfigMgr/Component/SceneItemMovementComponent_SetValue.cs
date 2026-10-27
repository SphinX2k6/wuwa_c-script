using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000894 RID: 2196
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemMovementComponent_SetValue
	{
		// Token: 0x04002039 RID: 8249
		public bool? Disabled;

		// Token: 0x0400203A RID: 8250
		public bool? EdIsLocked;

		// Token: 0x0400203B RID: 8251
		public ISplineMove Patrol;

		// Token: 0x0400203C RID: 8252
		public IMovementPlatformConfig PlatformConfig;
	}
}
