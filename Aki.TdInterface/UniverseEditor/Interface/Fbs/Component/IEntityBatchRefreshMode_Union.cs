using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C4 RID: 22212
	public enum IEntityBatchRefreshMode_Union : byte
	{
		// Token: 0x0400EE00 RID: 60928
		NONE,
		// Token: 0x0400EE01 RID: 60929
		IEntityBatchRefreshMode,
		// Token: 0x0400EE02 RID: 60930
		ISequenceBatchRefresh,
		// Token: 0x0400EE03 RID: 60931
		IRandomBatchRefresh,
		// Token: 0x0400EE04 RID: 60932
		IRandomBatchPoolRefresh
	}
}
