using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F1 RID: 2289
	public class PathDrivenActorSpawnerComponent_SetValue
	{
		// Token: 0x0400210D RID: 8461
		public bool? Disabled;

		// Token: 0x0400210E RID: 8462
		public bool? EdIsLocked;

		// Token: 0x0400210F RID: 8463
		public IIntervalSplineSpawn SpawnRule;

		// Token: 0x04002110 RID: 8464
		[Nullable(2)]
		public ITargetEntityType Target;
	}
}
