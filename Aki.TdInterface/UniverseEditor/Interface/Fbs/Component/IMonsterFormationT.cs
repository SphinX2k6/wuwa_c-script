using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B14 RID: 23316
	public class IMonsterFormationT
	{
		// Token: 0x1700AA34 RID: 43572
		// (get) Token: 0x0602655A RID: 157018 RVA: 0x00540781 File Offset: 0x0053E981
		// (set) Token: 0x0602655B RID: 157019 RVA: 0x00540789 File Offset: 0x0053E989
		public List<EMonsterMatchType> FormationPosConfig { get; set; }

		// Token: 0x0602655C RID: 157020 RVA: 0x00540792 File Offset: 0x0053E992
		public IMonsterFormationT()
		{
			this.FormationPosConfig = null;
		}
	}
}
