using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000788 RID: 1928
	public class ISpawnMonsterConfig_SetValue
	{
		// Token: 0x04001BE5 RID: 7141
		public int Id;

		// Token: 0x04001BE6 RID: 7142
		public float DelayTime;

		// Token: 0x04001BE7 RID: 7143
		[Nullable(2)]
		public List<int> TargetsToAwake;

		// Token: 0x04001BE8 RID: 7144
		public ISpawnMonsterCompleteCondition CompleteCondition;

		// Token: 0x04001BE9 RID: 7145
		public ISpawnMonsterPreDependOnPreceding PreCondition;
	}
}
