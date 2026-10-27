using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000842 RID: 2114
	public class NavMeshComponent_SetValue
	{
		// Token: 0x04001E9C RID: 7836
		public bool? Disabled;

		// Token: 0x04001E9D RID: 7837
		public bool? EdIsLocked;

		// Token: 0x04001E9E RID: 7838
		[Nullable(1)]
		public INavMeshAkiEntitySource Source;
	}
}
