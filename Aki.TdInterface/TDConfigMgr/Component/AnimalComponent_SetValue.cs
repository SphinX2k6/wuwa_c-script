using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000022 RID: 34
	[NullableContext(2)]
	[Nullable(0)]
	public class AnimalComponent_SetValue
	{
		// Token: 0x0400007F RID: 127
		public bool? Disabled;

		// Token: 0x04000080 RID: 128
		public bool? EdIsLocked;

		// Token: 0x04000081 RID: 129
		public bool IsStare;

		// Token: 0x04000082 RID: 130
		public int? AnimalAttackRange;

		// Token: 0x04000083 RID: 131
		public int? MoveRange;

		// Token: 0x04000084 RID: 132
		public bool? UseRangeComponentAsMoveRange;

		// Token: 0x04000085 RID: 133
		public bool? CanKillSelf;

		// Token: 0x04000086 RID: 134
		public bool? PlayDeathAnimOnDestroy;

		// Token: 0x04000087 RID: 135
		public ICollectAnimalConfig SpecialAnimalConfig;

		// Token: 0x04000088 RID: 136
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IAnimalEmotionBubbleEntry> EmotionBubbleMap;

		// Token: 0x04000089 RID: 137
		public List<EExtraMovementAbility> ExtraMovementAbilities;
	}
}
