using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044A7 RID: 17575
	public class IDynamicSpawnMonsterRandomPoolConfigsT
	{
		// Token: 0x17007C06 RID: 31750
		// (get) Token: 0x0601A3E8 RID: 107496 RVA: 0x003BFD61 File Offset: 0x003BDF61
		// (set) Token: 0x0601A3E9 RID: 107497 RVA: 0x003BFD69 File Offset: 0x003BDF69
		public List<IDynamicSpawnMonsterRandomPoolConfigT> Pools { get; set; }

		// Token: 0x0601A3EA RID: 107498 RVA: 0x003BFD72 File Offset: 0x003BDF72
		public IDynamicSpawnMonsterRandomPoolConfigsT()
		{
			this.Pools = null;
		}
	}
}
