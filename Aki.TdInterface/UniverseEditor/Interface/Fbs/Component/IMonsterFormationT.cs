using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005576 RID: 21878
	public class IMonsterFormationT
	{
		// Token: 0x1700A1AC RID: 41388
		// (get) Token: 0x0602434D RID: 148301 RVA: 0x00500209 File Offset: 0x004FE409
		// (set) Token: 0x0602434E RID: 148302 RVA: 0x00500211 File Offset: 0x004FE411
		public List<EMonsterMatchType> FormationPosConfig { get; set; }

		// Token: 0x0602434F RID: 148303 RVA: 0x0050021A File Offset: 0x004FE41A
		public IMonsterFormationT()
		{
			this.FormationPosConfig = null;
		}
	}
}
