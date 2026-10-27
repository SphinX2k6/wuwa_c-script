using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200108E RID: 4238
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestPlayerHitCount_SetValue
	{
		// Token: 0x040039A7 RID: 14759
		public EPlayerHitStatisticsType Type;

		// Token: 0x040039A8 RID: 14760
		public float? Cd;

		// Token: 0x040039A9 RID: 14761
		public List<int> EntityIds;

		// Token: 0x040039AA RID: 14762
		public List<int> SkillIds;
	}
}
