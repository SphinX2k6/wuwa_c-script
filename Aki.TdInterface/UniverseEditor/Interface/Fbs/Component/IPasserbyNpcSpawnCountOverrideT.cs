using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CCA RID: 23754
	public class IPasserbyNpcSpawnCountOverrideT
	{
		// Token: 0x1700AE85 RID: 44677
		// (get) Token: 0x060276CD RID: 161485 RVA: 0x00565752 File Offset: 0x00563952
		// (set) Token: 0x060276CE RID: 161486 RVA: 0x0056575A File Offset: 0x0056395A
		public int PcSpawnCount { get; set; }

		// Token: 0x1700AE86 RID: 44678
		// (get) Token: 0x060276CF RID: 161487 RVA: 0x00565763 File Offset: 0x00563963
		// (set) Token: 0x060276D0 RID: 161488 RVA: 0x0056576B File Offset: 0x0056396B
		public int MobileSpawnCount { get; set; }

		// Token: 0x1700AE87 RID: 44679
		// (get) Token: 0x060276D1 RID: 161489 RVA: 0x00565774 File Offset: 0x00563974
		// (set) Token: 0x060276D2 RID: 161490 RVA: 0x0056577C File Offset: 0x0056397C
		public byte NullMask { get; set; }

		// Token: 0x060276D3 RID: 161491 RVA: 0x00565785 File Offset: 0x00563985
		public IPasserbyNpcSpawnCountOverrideT()
		{
			this.PcSpawnCount = 0;
			this.MobileSpawnCount = 0;
			this.NullMask = 0;
		}
	}
}
