using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006767 RID: 26471
	[NullableContext(1)]
	[Nullable(0)]
	public static class DangoBrawlConst
	{
		// Token: 0x040226D6 RID: 141014
		public const int DefaultGridWeight = 6;

		// Token: 0x040226D7 RID: 141015
		public const int DefaultGridHeight = 8;

		// Token: 0x040226D8 RID: 141016
		public const int GridSize = 136;

		// Token: 0x040226D9 RID: 141017
		public const int BenchRotateRowThreshold = 3;

		// Token: 0x040226DA RID: 141018
		public const int UnvalidId = -1;

		// Token: 0x040226DB RID: 141019
		public const int ReflectLogConfigId = -1001;

		// Token: 0x040226DC RID: 141020
		public const int LifestealLogConfigId = -1002;

		// Token: 0x040226DD RID: 141021
		[StaticVariableRuleIgnore]
		public static readonly int[] DangoBrawlRotateAngle = new int[]
		{
			0,
			-90,
			-180,
			-270
		};

		// Token: 0x040226DE RID: 141022
		public const float ShopTalkBubbleDurationMs = 5000f;

		// Token: 0x040226DF RID: 141023
		public const float TipsHoverHideDelayMs = 50f;

		// Token: 0x040226E0 RID: 141024
		public const float HpAddTipsValTweenDuring = 0.35f;

		// Token: 0x040226E1 RID: 141025
		public const float CoinTweenDuring = 0.3f;

		// Token: 0x040226E2 RID: 141026
		public const float SellFlyDurationDrag = 0.5f;

		// Token: 0x040226E3 RID: 141027
		public const float SellFlyDurationButton = 1.3f;

		// Token: 0x040226E4 RID: 141028
		public const float ShopStateGiveCoinDuration = 1.3f;

		// Token: 0x040226E5 RID: 141029
		public const float CombineSubFlyDuration = 0.5f;

		// Token: 0x040226E6 RID: 141030
		public const float EventChooseFlyDuration = 0.5f;

		// Token: 0x040226E7 RID: 141031
		public const float ShopRefreshCd = 0.5f;

		// Token: 0x040226E8 RID: 141032
		public const float FxScalePerCell = 0.5f;

		// Token: 0x040226E9 RID: 141033
		public const float CombineGuideLineMinLength = 60f;

		// Token: 0x040226EA RID: 141034
		public const float CombineGuideLineMaxLength = 136f;

		// Token: 0x040226EB RID: 141035
		public const int ArchiveHelpId = 678;

		// Token: 0x040226EC RID: 141036
		public const int GeneralHelpId = 652;

		// Token: 0x040226ED RID: 141037
		public const int HandBookHelpId = 682;

		// Token: 0x040226EE RID: 141038
		public const int DangoBrawlRoundMaxTime = 60;

		// Token: 0x040226EF RID: 141039
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyList<float> DangoBrawlPlayRateList = new float[]
		{
			1f,
			1.5f,
			2f
		};

		// Token: 0x040226F0 RID: 141040
		public const string BuffDetailFloorColor = "AAFF93";

		// Token: 0x040226F1 RID: 141041
		public const string DeBuffDetailFloorColor = "FF8888";

		// Token: 0x040226F2 RID: 141042
		public const string BuffDetailFloorOutlineColor = "1F313B";

		// Token: 0x040226F3 RID: 141043
		public const string DeBuffDetailFloorOutlineColor = "391A1A";

		// Token: 0x040226F4 RID: 141044
		public const float StepTime = 2f;

		// Token: 0x040226F5 RID: 141045
		public const int MinEventCount = 1;
	}
}
