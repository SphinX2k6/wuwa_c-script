using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DF8 RID: 24056
	public class IRandomPoolChooseT
	{
		// Token: 0x1700B14C RID: 45388
		// (get) Token: 0x06028286 RID: 164486 RVA: 0x0057E02F File Offset: 0x0057C22F
		// (set) Token: 0x06028287 RID: 164487 RVA: 0x0057E037 File Offset: 0x0057C237
		public EMonsterChooseType Type { get; set; }

		// Token: 0x1700B14D RID: 45389
		// (get) Token: 0x06028288 RID: 164488 RVA: 0x0057E040 File Offset: 0x0057C240
		// (set) Token: 0x06028289 RID: 164489 RVA: 0x0057E048 File Offset: 0x0057C248
		public List<IRandomPoolConfigT> RandomPoolConfigs { get; set; }

		// Token: 0x0602828A RID: 164490 RVA: 0x0057E051 File Offset: 0x0057C251
		public IRandomPoolChooseT()
		{
			this.Type = EMonsterChooseType.RandomPoolChoose;
			this.RandomPoolConfigs = null;
		}
	}
}
