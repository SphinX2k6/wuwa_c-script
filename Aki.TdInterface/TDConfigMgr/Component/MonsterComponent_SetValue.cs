using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000838 RID: 2104
	[NullableContext(2)]
	[Nullable(0)]
	public class MonsterComponent_SetValue
	{
		// Token: 0x04001E6D RID: 7789
		public bool? Disabled;

		// Token: 0x04001E6E RID: 7790
		public bool? EdIsLocked;

		// Token: 0x04001E6F RID: 7791
		public int FightConfigId;

		// Token: 0x04001E70 RID: 7792
		public IBossStateViewConfig BossViewConfig;

		// Token: 0x04001E71 RID: 7793
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> InitGasTag;

		// Token: 0x04001E72 RID: 7794
		public int? SpecialHateAndSenseConfig;

		// Token: 0x04001E73 RID: 7795
		public IMonsterPerformConfig PerformConfig;

		// Token: 0x04001E74 RID: 7796
		public List<int> ShareLifeSubMonsterIds;

		// Token: 0x04001E75 RID: 7797
		public int? LifeMaxCustomizationId;

		// Token: 0x04001E76 RID: 7798
		public IMonsterNpcInteractionEnableConfig EnableMonsterNpcInteraction;

		// Token: 0x04001E77 RID: 7799
		public IMonsterCommunicationGroupConfig MonsterCommunicationGroup;
	}
}
