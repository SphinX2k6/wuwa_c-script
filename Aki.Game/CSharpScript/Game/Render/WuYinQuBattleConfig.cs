using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034C2 RID: 13506
	[NullableContext(1)]
	[Nullable(0)]
	public class WuYinQuBattleConfig
	{
		// Token: 0x04012E9F RID: 77471
		[StaticVariableRuleIgnore]
		public static readonly FVector TriggerThreshold = new FVector(80f, 80f, 80f);

		// Token: 0x04012EA0 RID: 77472
		public const float TriggerTransitionTime = 3.5f;

		// Token: 0x04012EA1 RID: 77473
		public const float LandscapeHardness = 0.0001f;

		// Token: 0x04012EA2 RID: 77474
		public const string MarkFightingStart1 = "FightingStart1";

		// Token: 0x04012EA3 RID: 77475
		public const string MarkFightingCycle1 = "FightingCycle1";

		// Token: 0x04012EA4 RID: 77476
		public const string MarkFightingEnd1 = "FightingEnd1";

		// Token: 0x04012EA5 RID: 77477
		public const string MarkFightingStart2 = "FightingStart2";

		// Token: 0x04012EA6 RID: 77478
		public const string MarkFightingCycle2 = "FightingCycle2";

		// Token: 0x04012EA7 RID: 77479
		public const string MarkFightingEnd2 = "FightingEnd2";

		// Token: 0x04012EA8 RID: 77480
		public const string MarkFightingStart3 = "FightingStart3";

		// Token: 0x04012EA9 RID: 77481
		public const string MarkFightingCycle3 = "FightingCycle3";

		// Token: 0x04012EAA RID: 77482
		public const string MarkFightingEnd3 = "FightingEnd3";

		// Token: 0x04012EAB RID: 77483
		public const string MarkFightingOverStart = "FightingOverStart";

		// Token: 0x04012EAC RID: 77484
		public const string MarkFightingOverEnd = "FightingOverEnd";
	}
}
