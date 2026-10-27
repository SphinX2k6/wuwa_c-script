using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058FB RID: 22779
	public class ISequenceBatchRefreshT
	{
		// Token: 0x1700AABC RID: 43708
		// (get) Token: 0x060267DE RID: 157662 RVA: 0x0054DC97 File Offset: 0x0054BE97
		// (set) Token: 0x060267DF RID: 157663 RVA: 0x0054DC9F File Offset: 0x0054BE9F
		public EEntityBatchRefreshMode Type { get; set; }

		// Token: 0x1700AABD RID: 43709
		// (get) Token: 0x060267E0 RID: 157664 RVA: 0x0054DCA8 File Offset: 0x0054BEA8
		// (set) Token: 0x060267E1 RID: 157665 RVA: 0x0054DCB0 File Offset: 0x0054BEB0
		public List<IEntityListBatchT> EntityBatches { get; set; }

		// Token: 0x1700AABE RID: 43710
		// (get) Token: 0x060267E2 RID: 157666 RVA: 0x0054DCB9 File Offset: 0x0054BEB9
		// (set) Token: 0x060267E3 RID: 157667 RVA: 0x0054DCC1 File Offset: 0x0054BEC1
		public bool IsRestartAfterAllBatchesFinished { get; set; }

		// Token: 0x1700AABF RID: 43711
		// (get) Token: 0x060267E4 RID: 157668 RVA: 0x0054DCCA File Offset: 0x0054BECA
		// (set) Token: 0x060267E5 RID: 157669 RVA: 0x0054DCD2 File Offset: 0x0054BED2
		public byte NullMask { get; set; }

		// Token: 0x060267E6 RID: 157670 RVA: 0x0054DCDB File Offset: 0x0054BEDB
		public ISequenceBatchRefreshT()
		{
			this.Type = EEntityBatchRefreshMode.SequenceBatch;
			this.EntityBatches = null;
			this.IsRestartAfterAllBatchesFinished = false;
			this.NullMask = 0;
		}
	}
}
