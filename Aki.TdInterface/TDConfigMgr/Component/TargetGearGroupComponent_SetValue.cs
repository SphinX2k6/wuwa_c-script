using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B8 RID: 2232
	[NullableContext(1)]
	[Nullable(0)]
	public class TargetGearGroupComponent_SetValue
	{
		// Token: 0x040020E1 RID: 8417
		public bool? Disabled;

		// Token: 0x040020E2 RID: 8418
		public bool? EdIsLocked;

		// Token: 0x040020E3 RID: 8419
		public string Type;

		// Token: 0x040020E4 RID: 8420
		public List<ITargetGearGroupConfig> GroupConfigs;
	}
}
