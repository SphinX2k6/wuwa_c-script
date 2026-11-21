using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A5C RID: 19036
	public class TCsvTrapDefenseMonsterGroupDataT
	{
		// Token: 0x17008595 RID: 34197
		// (get) Token: 0x0601C9E6 RID: 117222 RVA: 0x00409E87 File Offset: 0x00408087
		// (set) Token: 0x0601C9E7 RID: 117223 RVA: 0x00409E8F File Offset: 0x0040808F
		public int Id { get; set; }

		// Token: 0x17008596 RID: 34198
		// (get) Token: 0x0601C9E8 RID: 117224 RVA: 0x00409E98 File Offset: 0x00408098
		// (set) Token: 0x0601C9E9 RID: 117225 RVA: 0x00409EA0 File Offset: 0x004080A0
		public List<ITrapDefenseMonsterGroupT> Monsters { get; set; }

		// Token: 0x0601C9EA RID: 117226 RVA: 0x00409EA9 File Offset: 0x004080A9
		public TCsvTrapDefenseMonsterGroupDataT()
		{
			this.Id = 0;
			this.Monsters = null;
		}
	}
}
