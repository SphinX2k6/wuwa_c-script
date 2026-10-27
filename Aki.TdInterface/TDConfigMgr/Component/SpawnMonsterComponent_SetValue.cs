using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008A0 RID: 2208
	[NullableContext(1)]
	[Nullable(0)]
	public class SpawnMonsterComponent_SetValue
	{
		// Token: 0x04002074 RID: 8308
		public bool? Disabled;

		// Token: 0x04002075 RID: 8309
		public bool? EdIsLocked;

		// Token: 0x04002076 RID: 8310
		public ISpawnMonsterStartCondition ActiveType;

		// Token: 0x04002077 RID: 8311
		public List<ISpawnMonsterConfig> SpawnMonsterConfigs;

		// Token: 0x04002078 RID: 8312
		public bool? IssharedHatred;

		// Token: 0x04002079 RID: 8313
		[Nullable(2)]
		public ISpawnMonsterConstraintAnnularSector SpawnMonsterConstraintType;
	}
}
