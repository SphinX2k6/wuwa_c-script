using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000063 RID: 99
	public class DynamicSpawnMonsterComponent_SetValue
	{
		// Token: 0x04000207 RID: 519
		public bool? Disabled;

		// Token: 0x04000208 RID: 520
		public bool? EdIsLocked;

		// Token: 0x04000209 RID: 521
		[Nullable(1)]
		public List<IConditionSpawnMonster> Group;
	}
}
