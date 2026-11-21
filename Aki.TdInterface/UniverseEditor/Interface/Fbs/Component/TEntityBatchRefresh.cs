using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200622B RID: 25131
	public enum TEntityBatchRefresh : byte
	{
		// Token: 0x040100D8 RID: 65752
		NONE,
		// Token: 0x040100D9 RID: 65753
		IRandomBatchPoolRefresh,
		// Token: 0x040100DA RID: 65754
		IRandomBatchRefresh,
		// Token: 0x040100DB RID: 65755
		ISequenceBatchRefresh
	}
}
