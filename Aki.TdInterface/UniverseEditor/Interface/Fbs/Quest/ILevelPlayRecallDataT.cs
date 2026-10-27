using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F03 RID: 16131
	public class ILevelPlayRecallDataT
	{
		// Token: 0x17006FE6 RID: 28646
		// (get) Token: 0x06016D64 RID: 93540 RVA: 0x0034B205 File Offset: 0x00349405
		// (set) Token: 0x06016D65 RID: 93541 RVA: 0x0034B20D File Offset: 0x0034940D
		public ERecallDataType Type { get; set; }

		// Token: 0x17006FE7 RID: 28647
		// (get) Token: 0x06016D66 RID: 93542 RVA: 0x0034B216 File Offset: 0x00349416
		// (set) Token: 0x06016D67 RID: 93543 RVA: 0x0034B21E File Offset: 0x0034941E
		public int Id { get; set; }

		// Token: 0x17006FE8 RID: 28648
		// (get) Token: 0x06016D68 RID: 93544 RVA: 0x0034B227 File Offset: 0x00349427
		// (set) Token: 0x06016D69 RID: 93545 RVA: 0x0034B22F File Offset: 0x0034942F
		public ILevelPlayRecallConfigT RecallConfig { get; set; }

		// Token: 0x06016D6A RID: 93546 RVA: 0x0034B238 File Offset: 0x00349438
		public ILevelPlayRecallDataT()
		{
			this.Type = ERecallDataType.LevelPlay;
			this.Id = 0;
			this.RecallConfig = null;
		}
	}
}
