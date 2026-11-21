using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008DB RID: 2267
	[NullableContext(2)]
	[Nullable(0)]
	public class MonsterComponent_SetValue
	{
		// Token: 0x0400207A RID: 8314
		public bool? Disabled;

		// Token: 0x0400207B RID: 8315
		public bool? EdIsLocked;

		// Token: 0x0400207C RID: 8316
		public int FightConfigId;

		// Token: 0x0400207D RID: 8317
		public IBossStateViewConfig BossViewConfig;

		// Token: 0x0400207E RID: 8318
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> InitGasTag;

		// Token: 0x0400207F RID: 8319
		public int? SpecialHateAndSenseConfig;

		// Token: 0x04002080 RID: 8320
		public IMonsterPerformConfig PerformConfig;

		// Token: 0x04002081 RID: 8321
		public List<int> ShareLifeSubMonsterIds;

		// Token: 0x04002082 RID: 8322
		public int? LifeMaxCustomizationId;

		// Token: 0x04002083 RID: 8323
		public IMonsterNpcInteractionEnableConfig EnableMonsterNpcInteraction;

		// Token: 0x04002084 RID: 8324
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMonsterCombatInteractionConfig> EnableMonsterCombatInteraction;

		// Token: 0x04002085 RID: 8325
		public IMonsterCommunicationGroupConfig MonsterCommunicationGroup;

		// Token: 0x04002086 RID: 8326
		public List<EExtraMovementAbility> ExtraMovementAbilities;
	}
}
