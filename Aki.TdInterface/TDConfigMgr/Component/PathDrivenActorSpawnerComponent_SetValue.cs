using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200084E RID: 2126
	public class PathDrivenActorSpawnerComponent_SetValue
	{
		// Token: 0x04001EFB RID: 7931
		public bool? Disabled;

		// Token: 0x04001EFC RID: 7932
		public bool? EdIsLocked;

		// Token: 0x04001EFD RID: 7933
		[Nullable(1)]
		public IIntervalSplineSpawn SpawnRule;

		// Token: 0x04001EFE RID: 7934
		[Nullable(2)]
		public ITargetEntityType Target;
	}
}
