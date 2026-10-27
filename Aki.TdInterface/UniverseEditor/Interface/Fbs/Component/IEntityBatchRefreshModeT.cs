using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200515D RID: 20829
	public class IEntityBatchRefreshModeT
	{
		// Token: 0x170097F6 RID: 38902
		// (get) Token: 0x06021A26 RID: 137766 RVA: 0x004AB10F File Offset: 0x004A930F
		// (set) Token: 0x06021A27 RID: 137767 RVA: 0x004AB117 File Offset: 0x004A9317
		public EEntityBatchRefreshMode Type { get; set; }

		// Token: 0x170097F7 RID: 38903
		// (get) Token: 0x06021A28 RID: 137768 RVA: 0x004AB120 File Offset: 0x004A9320
		// (set) Token: 0x06021A29 RID: 137769 RVA: 0x004AB128 File Offset: 0x004A9328
		public List<IEntityListBatchT> EntityBatches { get; set; }

		// Token: 0x06021A2A RID: 137770 RVA: 0x004AB131 File Offset: 0x004A9331
		public IEntityBatchRefreshModeT()
		{
			this.Type = EEntityBatchRefreshMode.SequenceBatch;
			this.EntityBatches = null;
		}
	}
}
