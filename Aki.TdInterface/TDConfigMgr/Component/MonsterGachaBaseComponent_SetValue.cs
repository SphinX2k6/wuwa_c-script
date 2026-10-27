using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200083A RID: 2106
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterGachaBaseComponent_SetValue
	{
		// Token: 0x04001E7E RID: 7806
		public bool? Disabled;

		// Token: 0x04001E7F RID: 7807
		public bool? EdIsLocked;

		// Token: 0x04001E80 RID: 7808
		public List<int> MonsterEntityIds;

		// Token: 0x04001E81 RID: 7809
		public List<IMonsterGachaSlot> Config;

		// Token: 0x04001E82 RID: 7810
		public List<IMonsterFormation> Formation;
	}
}
