using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045EE RID: 17902
	public class TCsvFindSunSpiritLevelDataT
	{
		// Token: 0x17007F4A RID: 32586
		// (get) Token: 0x0601B1D9 RID: 111065 RVA: 0x003DD493 File Offset: 0x003DB693
		// (set) Token: 0x0601B1DA RID: 111066 RVA: 0x003DD49B File Offset: 0x003DB69B
		public int Id { get; set; }

		// Token: 0x17007F4B RID: 32587
		// (get) Token: 0x0601B1DB RID: 111067 RVA: 0x003DD4A4 File Offset: 0x003DB6A4
		// (set) Token: 0x0601B1DC RID: 111068 RVA: 0x003DD4AC File Offset: 0x003DB6AC
		public IFindSunSpiritLevelConfigT Data { get; set; }

		// Token: 0x0601B1DD RID: 111069 RVA: 0x003DD4B5 File Offset: 0x003DB6B5
		public TCsvFindSunSpiritLevelDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
