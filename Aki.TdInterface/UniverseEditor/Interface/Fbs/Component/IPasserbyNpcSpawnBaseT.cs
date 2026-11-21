using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CBB RID: 23739
	public class IPasserbyNpcSpawnBaseT
	{
		// Token: 0x1700AE61 RID: 44641
		// (get) Token: 0x06027645 RID: 161349 RVA: 0x00564484 File Offset: 0x00562684
		// (set) Token: 0x06027646 RID: 161350 RVA: 0x0056448C File Offset: 0x0056268C
		public EPasserbyNpcSpawnType Type { get; set; }

		// Token: 0x1700AE62 RID: 44642
		// (get) Token: 0x06027647 RID: 161351 RVA: 0x00564495 File Offset: 0x00562695
		// (set) Token: 0x06027648 RID: 161352 RVA: 0x0056449D File Offset: 0x0056269D
		public int MaxSpawnCount { get; set; }

		// Token: 0x1700AE63 RID: 44643
		// (get) Token: 0x06027649 RID: 161353 RVA: 0x005644A6 File Offset: 0x005626A6
		// (set) Token: 0x0602764A RID: 161354 RVA: 0x005644AE File Offset: 0x005626AE
		public int MinDistance { get; set; }

		// Token: 0x1700AE64 RID: 44644
		// (get) Token: 0x0602764B RID: 161355 RVA: 0x005644B7 File Offset: 0x005626B7
		// (set) Token: 0x0602764C RID: 161356 RVA: 0x005644BF File Offset: 0x005626BF
		public byte NullMask { get; set; }

		// Token: 0x0602764D RID: 161357 RVA: 0x005644C8 File Offset: 0x005626C8
		public IPasserbyNpcSpawnBaseT()
		{
			this.Type = EPasserbyNpcSpawnType.FixInterval;
			this.MaxSpawnCount = 0;
			this.MinDistance = 0;
			this.NullMask = 0;
		}
	}
}
