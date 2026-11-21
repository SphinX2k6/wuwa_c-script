using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A5F RID: 19039
	public class TCsvTrapDefenseWaveDataT
	{
		// Token: 0x1700859A RID: 34202
		// (get) Token: 0x0601CA02 RID: 117250 RVA: 0x0040A233 File Offset: 0x00408433
		// (set) Token: 0x0601CA03 RID: 117251 RVA: 0x0040A23B File Offset: 0x0040843B
		public int Id { get; set; }

		// Token: 0x1700859B RID: 34203
		// (get) Token: 0x0601CA04 RID: 117252 RVA: 0x0040A244 File Offset: 0x00408444
		// (set) Token: 0x0601CA05 RID: 117253 RVA: 0x0040A24C File Offset: 0x0040844C
		public List<ITrapDefenseSpawnMonsterT> SpawnMonsters { get; set; }

		// Token: 0x0601CA06 RID: 117254 RVA: 0x0040A255 File Offset: 0x00408455
		public TCsvTrapDefenseWaveDataT()
		{
			this.Id = 0;
			this.SpawnMonsters = null;
		}
	}
}
