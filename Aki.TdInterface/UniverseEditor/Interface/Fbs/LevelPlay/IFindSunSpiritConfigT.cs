using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044AD RID: 17581
	public class IFindSunSpiritConfigT
	{
		// Token: 0x17007C18 RID: 31768
		// (get) Token: 0x0601A42E RID: 107566 RVA: 0x003C05B9 File Offset: 0x003BE7B9
		// (set) Token: 0x0601A42F RID: 107567 RVA: 0x003C05C1 File Offset: 0x003BE7C1
		public int Id { get; set; }

		// Token: 0x17007C19 RID: 31769
		// (get) Token: 0x0601A430 RID: 107568 RVA: 0x003C05CA File Offset: 0x003BE7CA
		// (set) Token: 0x0601A431 RID: 107569 RVA: 0x003C05D2 File Offset: 0x003BE7D2
		public string Name { get; set; }

		// Token: 0x17007C1A RID: 31770
		// (get) Token: 0x0601A432 RID: 107570 RVA: 0x003C05DB File Offset: 0x003BE7DB
		// (set) Token: 0x0601A433 RID: 107571 RVA: 0x003C05E3 File Offset: 0x003BE7E3
		public IFindSunSpiritLevelConfigT Level { get; set; }

		// Token: 0x0601A434 RID: 107572 RVA: 0x003C05EC File Offset: 0x003BE7EC
		public IFindSunSpiritConfigT()
		{
			this.Id = 0;
			this.Name = null;
			this.Level = null;
		}
	}
}
