using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x0200459A RID: 17818
	[NullableContext(1)]
	[Nullable(0)]
	public class WuYinQuBattleConfig
	{
		// Token: 0x04018864 RID: 100452
		[StaticVariableRuleIgnore]
		public static readonly FVector TriggerThreshold = new FVector(80f, 80f, 80f);

		// Token: 0x04018865 RID: 100453
		public const float TriggerTransitionTime = 3.5f;

		// Token: 0x04018866 RID: 100454
		public const float LandscapeHardness = 0.0001f;

		// Token: 0x04018867 RID: 100455
		public const string MarkFightingStart1 = "FightingStart1";

		// Token: 0x04018868 RID: 100456
		public const string MarkFightingCycle1 = "FightingCycle1";

		// Token: 0x04018869 RID: 100457
		public const string MarkFightingEnd1 = "FightingEnd1";

		// Token: 0x0401886A RID: 100458
		public const string MarkFightingStart2 = "FightingStart2";

		// Token: 0x0401886B RID: 100459
		public const string MarkFightingCycle2 = "FightingCycle2";

		// Token: 0x0401886C RID: 100460
		public const string MarkFightingEnd2 = "FightingEnd2";

		// Token: 0x0401886D RID: 100461
		public const string MarkFightingStart3 = "FightingStart3";

		// Token: 0x0401886E RID: 100462
		public const string MarkFightingCycle3 = "FightingCycle3";

		// Token: 0x0401886F RID: 100463
		public const string MarkFightingEnd3 = "FightingEnd3";

		// Token: 0x04018870 RID: 100464
		public const string MarkFightingOverStart = "FightingOverStart";

		// Token: 0x04018871 RID: 100465
		public const string MarkFightingOverEnd = "FightingOverEnd";
	}
}
