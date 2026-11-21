using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C2 RID: 22210
	public class IEntityBatchRefreshModeT
	{
		// Token: 0x17009FE3 RID: 40931
		// (get) Token: 0x0602397A RID: 145786 RVA: 0x004E509B File Offset: 0x004E329B
		// (set) Token: 0x0602397B RID: 145787 RVA: 0x004E50A3 File Offset: 0x004E32A3
		public EEntityBatchRefreshMode Type { get; set; }

		// Token: 0x17009FE4 RID: 40932
		// (get) Token: 0x0602397C RID: 145788 RVA: 0x004E50AC File Offset: 0x004E32AC
		// (set) Token: 0x0602397D RID: 145789 RVA: 0x004E50B4 File Offset: 0x004E32B4
		public List<IEntityListBatchT> EntityBatches { get; set; }

		// Token: 0x0602397E RID: 145790 RVA: 0x004E50BD File Offset: 0x004E32BD
		public IEntityBatchRefreshModeT()
		{
			this.Type = EEntityBatchRefreshMode.SequenceBatch;
			this.EntityBatches = null;
		}
	}
}
