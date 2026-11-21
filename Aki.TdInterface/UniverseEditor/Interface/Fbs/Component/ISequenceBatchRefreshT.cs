using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F08 RID: 24328
	public class ISequenceBatchRefreshT
	{
		// Token: 0x1700B3F0 RID: 46064
		// (get) Token: 0x06028D48 RID: 167240 RVA: 0x00594903 File Offset: 0x00592B03
		// (set) Token: 0x06028D49 RID: 167241 RVA: 0x0059490B File Offset: 0x00592B0B
		public EEntityBatchRefreshMode Type { get; set; }

		// Token: 0x1700B3F1 RID: 46065
		// (get) Token: 0x06028D4A RID: 167242 RVA: 0x00594914 File Offset: 0x00592B14
		// (set) Token: 0x06028D4B RID: 167243 RVA: 0x0059491C File Offset: 0x00592B1C
		public List<IEntityListBatchT> EntityBatches { get; set; }

		// Token: 0x1700B3F2 RID: 46066
		// (get) Token: 0x06028D4C RID: 167244 RVA: 0x00594925 File Offset: 0x00592B25
		// (set) Token: 0x06028D4D RID: 167245 RVA: 0x0059492D File Offset: 0x00592B2D
		public bool IsRestartAfterAllBatchesFinished { get; set; }

		// Token: 0x1700B3F3 RID: 46067
		// (get) Token: 0x06028D4E RID: 167246 RVA: 0x00594936 File Offset: 0x00592B36
		// (set) Token: 0x06028D4F RID: 167247 RVA: 0x0059493E File Offset: 0x00592B3E
		public byte NullMask { get; set; }

		// Token: 0x06028D50 RID: 167248 RVA: 0x00594947 File Offset: 0x00592B47
		public ISequenceBatchRefreshT()
		{
			this.Type = EEntityBatchRefreshMode.SequenceBatch;
			this.EntityBatches = null;
			this.IsRestartAfterAllBatchesFinished = false;
			this.NullMask = 0;
		}
	}
}
