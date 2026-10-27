using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057DF RID: 22495
	public class IRandomBatchPoolRefreshT
	{
		// Token: 0x1700A806 RID: 43014
		// (get) Token: 0x06025CBA RID: 154810 RVA: 0x005368DB File Offset: 0x00534ADB
		// (set) Token: 0x06025CBB RID: 154811 RVA: 0x005368E3 File Offset: 0x00534AE3
		public EEntityBatchRefreshMode Type { get; set; }

		// Token: 0x1700A807 RID: 43015
		// (get) Token: 0x06025CBC RID: 154812 RVA: 0x005368EC File Offset: 0x00534AEC
		// (set) Token: 0x06025CBD RID: 154813 RVA: 0x005368F4 File Offset: 0x00534AF4
		public List<IEntityListBatchT> EntityBatches { get; set; }

		// Token: 0x1700A808 RID: 43016
		// (get) Token: 0x06025CBE RID: 154814 RVA: 0x005368FD File Offset: 0x00534AFD
		// (set) Token: 0x06025CBF RID: 154815 RVA: 0x00536905 File Offset: 0x00534B05
		public bool IsRestartAfterAllBatchesFinished { get; set; }

		// Token: 0x1700A809 RID: 43017
		// (get) Token: 0x06025CC0 RID: 154816 RVA: 0x0053690E File Offset: 0x00534B0E
		// (set) Token: 0x06025CC1 RID: 154817 RVA: 0x00536916 File Offset: 0x00534B16
		public byte NullMask { get; set; }

		// Token: 0x06025CC2 RID: 154818 RVA: 0x0053691F File Offset: 0x00534B1F
		public IRandomBatchPoolRefreshT()
		{
			this.Type = EEntityBatchRefreshMode.SequenceBatch;
			this.EntityBatches = null;
			this.IsRestartAfterAllBatchesFinished = false;
			this.NullMask = 0;
		}
	}
}
