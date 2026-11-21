using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CAC RID: 23724
	public class IPasserbyNpcRandomStandGenerateT
	{
		// Token: 0x1700AE48 RID: 44616
		// (get) Token: 0x060275D5 RID: 161237 RVA: 0x0056382A File Offset: 0x00561A2A
		// (set) Token: 0x060275D6 RID: 161238 RVA: 0x00563832 File Offset: 0x00561A32
		public EPasserbyNpcGenerateType Type { get; set; }

		// Token: 0x1700AE49 RID: 44617
		// (get) Token: 0x060275D7 RID: 161239 RVA: 0x0056383B File Offset: 0x00561A3B
		// (set) Token: 0x060275D8 RID: 161240 RVA: 0x00563843 File Offset: 0x00561A43
		public IPasserbyNpcSelfSpawnCenterPosT SpawnCenterPos { get; set; }

		// Token: 0x1700AE4A RID: 44618
		// (get) Token: 0x060275D9 RID: 161241 RVA: 0x0056384C File Offset: 0x00561A4C
		// (set) Token: 0x060275DA RID: 161242 RVA: 0x00563854 File Offset: 0x00561A54
		public List<IPasserbyNpcRandomGroupT> Groups { get; set; }

		// Token: 0x060275DB RID: 161243 RVA: 0x0056385D File Offset: 0x00561A5D
		public IPasserbyNpcRandomStandGenerateT()
		{
			this.Type = EPasserbyNpcGenerateType.RandomStand;
			this.SpawnCenterPos = null;
			this.Groups = null;
		}
	}
}
