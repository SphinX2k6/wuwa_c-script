using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DE6 RID: 24038
	public class IRandomBatchPoolRefreshT
	{
		// Token: 0x1700B12A RID: 45354
		// (get) Token: 0x060281DA RID: 164314 RVA: 0x0057CA67 File Offset: 0x0057AC67
		// (set) Token: 0x060281DB RID: 164315 RVA: 0x0057CA6F File Offset: 0x0057AC6F
		public EEntityBatchRefreshMode Type { get; set; }

		// Token: 0x1700B12B RID: 45355
		// (get) Token: 0x060281DC RID: 164316 RVA: 0x0057CA78 File Offset: 0x0057AC78
		// (set) Token: 0x060281DD RID: 164317 RVA: 0x0057CA80 File Offset: 0x0057AC80
		public List<IEntityListBatchT> EntityBatches { get; set; }

		// Token: 0x1700B12C RID: 45356
		// (get) Token: 0x060281DE RID: 164318 RVA: 0x0057CA89 File Offset: 0x0057AC89
		// (set) Token: 0x060281DF RID: 164319 RVA: 0x0057CA91 File Offset: 0x0057AC91
		public bool IsRestartAfterAllBatchesFinished { get; set; }

		// Token: 0x1700B12D RID: 45357
		// (get) Token: 0x060281E0 RID: 164320 RVA: 0x0057CA9A File Offset: 0x0057AC9A
		// (set) Token: 0x060281E1 RID: 164321 RVA: 0x0057CAA2 File Offset: 0x0057ACA2
		public byte NullMask { get; set; }

		// Token: 0x060281E2 RID: 164322 RVA: 0x0057CAAB File Offset: 0x0057ACAB
		public IRandomBatchPoolRefreshT()
		{
			this.Type = EEntityBatchRefreshMode.SequenceBatch;
			this.EntityBatches = null;
			this.IsRestartAfterAllBatchesFinished = false;
			this.NullMask = 0;
		}
	}
}
