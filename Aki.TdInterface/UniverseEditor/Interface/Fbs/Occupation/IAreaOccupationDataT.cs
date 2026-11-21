using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047F2 RID: 18418
	public class IAreaOccupationDataT
	{
		// Token: 0x17008078 RID: 32888
		// (get) Token: 0x0601B351 RID: 111441 RVA: 0x003DB11A File Offset: 0x003D931A
		// (set) Token: 0x0601B352 RID: 111442 RVA: 0x003DB122 File Offset: 0x003D9322
		public EOccupationType Type { get; set; }

		// Token: 0x17008079 RID: 32889
		// (get) Token: 0x0601B353 RID: 111443 RVA: 0x003DB12B File Offset: 0x003D932B
		// (set) Token: 0x0601B354 RID: 111444 RVA: 0x003DB133 File Offset: 0x003D9333
		public int LevelId { get; set; }

		// Token: 0x1700807A RID: 32890
		// (get) Token: 0x0601B355 RID: 111445 RVA: 0x003DB13C File Offset: 0x003D933C
		// (set) Token: 0x0601B356 RID: 111446 RVA: 0x003DB144 File Offset: 0x003D9344
		public int IdentifyEntityId { get; set; }

		// Token: 0x0601B357 RID: 111447 RVA: 0x003DB14D File Offset: 0x003D934D
		public IAreaOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
			this.LevelId = 0;
			this.IdentifyEntityId = 0;
		}
	}
}
