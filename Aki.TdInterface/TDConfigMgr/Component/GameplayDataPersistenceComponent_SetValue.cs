using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000180 RID: 384
	public class GameplayDataPersistenceComponent_SetValue
	{
		// Token: 0x04000754 RID: 1876
		public bool? Disabled;

		// Token: 0x04000755 RID: 1877
		public bool? EdIsLocked;

		// Token: 0x04000756 RID: 1878
		[Nullable(1)]
		public IGameplayDataPersistenceTetrisBoardGame DataPersistenceGameplay;
	}
}
