using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000943 RID: 2371
	public class SpawnMonsterComponent_SetValue
	{
		// Token: 0x04002286 RID: 8838
		public bool? Disabled;

		// Token: 0x04002287 RID: 8839
		public bool? EdIsLocked;

		// Token: 0x04002288 RID: 8840
		public ISpawnMonsterStartCondition ActiveType;

		// Token: 0x04002289 RID: 8841
		public List<ISpawnMonsterConfig> SpawnMonsterConfigs;

		// Token: 0x0400228A RID: 8842
		public bool? IssharedHatred;

		// Token: 0x0400228B RID: 8843
		[Nullable(2)]
		public ISpawnMonsterConstraintAnnularSector SpawnMonsterConstraintType;
	}
}
