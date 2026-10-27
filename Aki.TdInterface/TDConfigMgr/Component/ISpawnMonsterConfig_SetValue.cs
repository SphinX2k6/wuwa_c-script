using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E7 RID: 1767
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnMonsterConfig_SetValue
	{
		// Token: 0x040019E6 RID: 6630
		public int Id;

		// Token: 0x040019E7 RID: 6631
		public float DelayTime;

		// Token: 0x040019E8 RID: 6632
		[Nullable(2)]
		public List<int> TargetsToAwake;

		// Token: 0x040019E9 RID: 6633
		public ISpawnMonsterCompleteCondition CompleteCondition;

		// Token: 0x040019EA RID: 6634
		public ISpawnMonsterPreDependOnPreceding PreCondition;
	}
}
