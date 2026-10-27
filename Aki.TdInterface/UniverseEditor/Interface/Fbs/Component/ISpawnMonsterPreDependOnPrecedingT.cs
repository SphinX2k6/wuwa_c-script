using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005960 RID: 22880
	public class ISpawnMonsterPreDependOnPrecedingT
	{
		// Token: 0x1700ABBD RID: 43965
		// (get) Token: 0x06026BB1 RID: 158641 RVA: 0x005553BF File Offset: 0x005535BF
		// (set) Token: 0x06026BB2 RID: 158642 RVA: 0x005553C7 File Offset: 0x005535C7
		public ESpawnMonsterPreCondition Type { get; set; }

		// Token: 0x1700ABBE RID: 43966
		// (get) Token: 0x06026BB3 RID: 158643 RVA: 0x005553D0 File Offset: 0x005535D0
		// (set) Token: 0x06026BB4 RID: 158644 RVA: 0x005553D8 File Offset: 0x005535D8
		public List<int> Ids { get; set; }

		// Token: 0x06026BB5 RID: 158645 RVA: 0x005553E1 File Offset: 0x005535E1
		public ISpawnMonsterPreDependOnPrecedingT()
		{
			this.Type = ESpawnMonsterPreCondition.DependOnPreceding;
			this.Ids = null;
		}
	}
}
