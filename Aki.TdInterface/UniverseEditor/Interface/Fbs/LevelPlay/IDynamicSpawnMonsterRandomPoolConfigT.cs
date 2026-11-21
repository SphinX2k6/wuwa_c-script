using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200490C RID: 18700
	public class IDynamicSpawnMonsterRandomPoolConfigT
	{
		// Token: 0x17008240 RID: 33344
		// (get) Token: 0x0601BB9D RID: 113565 RVA: 0x003EBBF5 File Offset: 0x003E9DF5
		// (set) Token: 0x0601BB9E RID: 113566 RVA: 0x003EBBFD File Offset: 0x003E9DFD
		public int Id { get; set; }

		// Token: 0x17008241 RID: 33345
		// (get) Token: 0x0601BB9F RID: 113567 RVA: 0x003EBC06 File Offset: 0x003E9E06
		// (set) Token: 0x0601BBA0 RID: 113568 RVA: 0x003EBC0E File Offset: 0x003E9E0E
		public EMonsterSourceType MonsterSource { get; set; }

		// Token: 0x17008242 RID: 33346
		// (get) Token: 0x0601BBA1 RID: 113569 RVA: 0x003EBC17 File Offset: 0x003E9E17
		// (set) Token: 0x0601BBA2 RID: 113570 RVA: 0x003EBC1F File Offset: 0x003E9E1F
		public List<IDynamicSpawnMonsterGroupT> MonsterGroup { get; set; }

		// Token: 0x0601BBA3 RID: 113571 RVA: 0x003EBC28 File Offset: 0x003E9E28
		public IDynamicSpawnMonsterRandomPoolConfigT()
		{
			this.Id = 0;
			this.MonsterSource = EMonsterSourceType.EntityTemplate;
			this.MonsterGroup = null;
		}
	}
}
