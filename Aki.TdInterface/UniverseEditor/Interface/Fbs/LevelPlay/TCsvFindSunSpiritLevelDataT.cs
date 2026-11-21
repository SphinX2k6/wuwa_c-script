using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A56 RID: 19030
	public class TCsvFindSunSpiritLevelDataT
	{
		// Token: 0x1700858B RID: 34187
		// (get) Token: 0x0601C9AE RID: 117166 RVA: 0x0040972F File Offset: 0x0040792F
		// (set) Token: 0x0601C9AF RID: 117167 RVA: 0x00409737 File Offset: 0x00407937
		public int Id { get; set; }

		// Token: 0x1700858C RID: 34188
		// (get) Token: 0x0601C9B0 RID: 117168 RVA: 0x00409740 File Offset: 0x00407940
		// (set) Token: 0x0601C9B1 RID: 117169 RVA: 0x00409748 File Offset: 0x00407948
		public IFindSunSpiritLevelConfigT Data { get; set; }

		// Token: 0x0601C9B2 RID: 117170 RVA: 0x00409751 File Offset: 0x00407951
		public TCsvFindSunSpiritLevelDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
