using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044A1 RID: 17569
	public class IDynamicSpawnMonsterGroupT
	{
		// Token: 0x17007BFB RID: 31739
		// (get) Token: 0x0601A3AE RID: 107438 RVA: 0x003BF5FC File Offset: 0x003BD7FC
		// (set) Token: 0x0601A3AF RID: 107439 RVA: 0x003BF604 File Offset: 0x003BD804
		public int Id { get; set; }

		// Token: 0x17007BFC RID: 31740
		// (get) Token: 0x0601A3B0 RID: 107440 RVA: 0x003BF60D File Offset: 0x003BD80D
		// (set) Token: 0x0601A3B1 RID: 107441 RVA: 0x003BF615 File Offset: 0x003BD815
		public int Weight { get; set; }

		// Token: 0x0601A3B2 RID: 107442 RVA: 0x003BF61E File Offset: 0x003BD81E
		public IDynamicSpawnMonsterGroupT()
		{
			this.Id = 0;
			this.Weight = 0;
		}
	}
}
