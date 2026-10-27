using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006907 RID: 26887
	public class IHideSpecifyLevelPlayGroupT
	{
		// Token: 0x1700C777 RID: 51063
		// (get) Token: 0x0602EEA9 RID: 192169 RVA: 0x00666157 File Offset: 0x00664357
		// (set) Token: 0x0602EEAA RID: 192170 RVA: 0x0066615F File Offset: 0x0066435F
		public EHideType Type { get; set; }

		// Token: 0x1700C778 RID: 51064
		// (get) Token: 0x0602EEAB RID: 192171 RVA: 0x00666168 File Offset: 0x00664368
		// (set) Token: 0x0602EEAC RID: 192172 RVA: 0x00666170 File Offset: 0x00664370
		public List<int> LevelPlays { get; set; }

		// Token: 0x0602EEAD RID: 192173 RVA: 0x00666179 File Offset: 0x00664379
		public IHideSpecifyLevelPlayGroupT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.LevelPlays = null;
		}
	}
}
