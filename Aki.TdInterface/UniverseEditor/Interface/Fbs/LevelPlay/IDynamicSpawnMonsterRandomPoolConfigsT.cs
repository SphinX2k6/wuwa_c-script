using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200490F RID: 18703
	public class IDynamicSpawnMonsterRandomPoolConfigsT
	{
		// Token: 0x17008245 RID: 33349
		// (get) Token: 0x0601BBB9 RID: 113593 RVA: 0x003EBF6D File Offset: 0x003EA16D
		// (set) Token: 0x0601BBBA RID: 113594 RVA: 0x003EBF75 File Offset: 0x003EA175
		public List<IDynamicSpawnMonsterRandomPoolConfigT> Pools { get; set; }

		// Token: 0x0601BBBB RID: 113595 RVA: 0x003EBF7E File Offset: 0x003EA17E
		public IDynamicSpawnMonsterRandomPoolConfigsT()
		{
			this.Pools = null;
		}
	}
}
