using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001317 RID: 4887
	public class ITrapDefenseSystemConfig_SetValue
	{
		// Token: 0x040041B2 RID: 16818
		public EEnableSystemType Type;

		// Token: 0x040041B3 RID: 16819
		public int TrapDefenseId;

		// Token: 0x040041B4 RID: 16820
		public List<ITrapDefenseSystemVar> Vars;
	}
}
