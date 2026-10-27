using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C0C RID: 23564
	public enum TEntityBatchRefresh : byte
	{
		// Token: 0x0400F3BD RID: 62397
		NONE,
		// Token: 0x0400F3BE RID: 62398
		IRandomBatchPoolRefresh,
		// Token: 0x0400F3BF RID: 62399
		IRandomBatchRefresh,
		// Token: 0x0400F3C0 RID: 62400
		ISequenceBatchRefresh
	}
}
