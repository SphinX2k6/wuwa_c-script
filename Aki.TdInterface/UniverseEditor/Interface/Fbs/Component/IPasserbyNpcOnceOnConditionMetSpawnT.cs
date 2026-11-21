using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA0 RID: 23712
	public class IPasserbyNpcOnceOnConditionMetSpawnT
	{
		// Token: 0x1700AE2C RID: 44588
		// (get) Token: 0x0602755F RID: 161119 RVA: 0x00562991 File Offset: 0x00560B91
		// (set) Token: 0x06027560 RID: 161120 RVA: 0x00562999 File Offset: 0x00560B99
		public EPasserbyNpcSpawnType Type { get; set; }

		// Token: 0x1700AE2D RID: 44589
		// (get) Token: 0x06027561 RID: 161121 RVA: 0x005629A2 File Offset: 0x00560BA2
		// (set) Token: 0x06027562 RID: 161122 RVA: 0x005629AA File Offset: 0x00560BAA
		public int MaxSpawnCount { get; set; }

		// Token: 0x1700AE2E RID: 44590
		// (get) Token: 0x06027563 RID: 161123 RVA: 0x005629B3 File Offset: 0x00560BB3
		// (set) Token: 0x06027564 RID: 161124 RVA: 0x005629BB File Offset: 0x00560BBB
		public int MinDistance { get; set; }

		// Token: 0x1700AE2F RID: 44591
		// (get) Token: 0x06027565 RID: 161125 RVA: 0x005629C4 File Offset: 0x00560BC4
		// (set) Token: 0x06027566 RID: 161126 RVA: 0x005629CC File Offset: 0x00560BCC
		public IPasserbyNpcRandomStandGenerateT SpawnPos { get; set; }

		// Token: 0x1700AE30 RID: 44592
		// (get) Token: 0x06027567 RID: 161127 RVA: 0x005629D5 File Offset: 0x00560BD5
		// (set) Token: 0x06027568 RID: 161128 RVA: 0x005629DD File Offset: 0x00560BDD
		public byte NullMask { get; set; }

		// Token: 0x06027569 RID: 161129 RVA: 0x005629E6 File Offset: 0x00560BE6
		public IPasserbyNpcOnceOnConditionMetSpawnT()
		{
			this.Type = EPasserbyNpcSpawnType.FixInterval;
			this.MaxSpawnCount = 0;
			this.MinDistance = 0;
			this.SpawnPos = null;
			this.NullMask = 0;
		}
	}
}
