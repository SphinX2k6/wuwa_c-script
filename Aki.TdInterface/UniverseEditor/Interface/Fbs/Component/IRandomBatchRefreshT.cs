using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DE9 RID: 24041
	public class IRandomBatchRefreshT
	{
		// Token: 0x1700B131 RID: 45361
		// (get) Token: 0x060281FA RID: 164346 RVA: 0x0057CE63 File Offset: 0x0057B063
		// (set) Token: 0x060281FB RID: 164347 RVA: 0x0057CE6B File Offset: 0x0057B06B
		public EEntityBatchRefreshMode Type { get; set; }

		// Token: 0x1700B132 RID: 45362
		// (get) Token: 0x060281FC RID: 164348 RVA: 0x0057CE74 File Offset: 0x0057B074
		// (set) Token: 0x060281FD RID: 164349 RVA: 0x0057CE7C File Offset: 0x0057B07C
		public List<IEntityListBatchT> EntityBatches { get; set; }

		// Token: 0x060281FE RID: 164350 RVA: 0x0057CE85 File Offset: 0x0057B085
		public IRandomBatchRefreshT()
		{
			this.Type = EEntityBatchRefreshMode.SequenceBatch;
			this.EntityBatches = null;
		}
	}
}
