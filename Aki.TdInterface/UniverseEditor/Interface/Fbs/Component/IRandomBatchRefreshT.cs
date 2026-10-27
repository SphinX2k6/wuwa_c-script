using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E2 RID: 22498
	public class IRandomBatchRefreshT
	{
		// Token: 0x1700A80D RID: 43021
		// (get) Token: 0x06025CDA RID: 154842 RVA: 0x00536CD7 File Offset: 0x00534ED7
		// (set) Token: 0x06025CDB RID: 154843 RVA: 0x00536CDF File Offset: 0x00534EDF
		public EEntityBatchRefreshMode Type { get; set; }

		// Token: 0x1700A80E RID: 43022
		// (get) Token: 0x06025CDC RID: 154844 RVA: 0x00536CE8 File Offset: 0x00534EE8
		// (set) Token: 0x06025CDD RID: 154845 RVA: 0x00536CF0 File Offset: 0x00534EF0
		public List<IEntityListBatchT> EntityBatches { get; set; }

		// Token: 0x06025CDE RID: 154846 RVA: 0x00536CF9 File Offset: 0x00534EF9
		public IRandomBatchRefreshT()
		{
			this.Type = EEntityBatchRefreshMode.SequenceBatch;
			this.EntityBatches = null;
		}
	}
}
