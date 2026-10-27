using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EEF RID: 3823
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckMonsterBattleAttribute_SetValue
	{
		// Token: 0x0400331C RID: 13084
		public ETargetBattleAttribute Type;

		// Token: 0x0400331D RID: 13085
		public IHealthAttributeToTarget Option;

		// Token: 0x0400331E RID: 13086
		public List<int> EntityIds;
	}
}
