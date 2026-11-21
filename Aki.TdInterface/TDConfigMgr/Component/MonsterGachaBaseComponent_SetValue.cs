using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008DD RID: 2269
	public class MonsterGachaBaseComponent_SetValue
	{
		// Token: 0x0400208D RID: 8333
		public bool? Disabled;

		// Token: 0x0400208E RID: 8334
		public bool? EdIsLocked;

		// Token: 0x0400208F RID: 8335
		public List<int> MonsterEntityIds;

		// Token: 0x04002090 RID: 8336
		public List<IMonsterGachaSlot> Config;

		// Token: 0x04002091 RID: 8337
		public List<IMonsterFormation> Formation;
	}
}
