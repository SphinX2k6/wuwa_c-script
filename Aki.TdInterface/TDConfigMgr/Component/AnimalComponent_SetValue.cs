using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000022 RID: 34
	public class AnimalComponent_SetValue
	{
		// Token: 0x0400007B RID: 123
		public bool? Disabled;

		// Token: 0x0400007C RID: 124
		public bool? EdIsLocked;

		// Token: 0x0400007D RID: 125
		public bool IsStare;

		// Token: 0x0400007E RID: 126
		public int? AnimalAttackRange;

		// Token: 0x0400007F RID: 127
		public int? MoveRange;

		// Token: 0x04000080 RID: 128
		public bool? UseRangeComponentAsMoveRange;

		// Token: 0x04000081 RID: 129
		public bool? CanKillSelf;

		// Token: 0x04000082 RID: 130
		public bool? PlayDeathAnimOnDestroy;

		// Token: 0x04000083 RID: 131
		[Nullable(2)]
		public ICollectAnimalConfig SpecialAnimalConfig;

		// Token: 0x04000084 RID: 132
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IAnimalEmotionBubbleEntry> EmotionBubbleMap;
	}
}
