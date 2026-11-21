using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056B7 RID: 22199
	[NullableContext(1)]
	[Nullable(0)]
	public static class DangoBrawlConst
	{
		// Token: 0x0401CF33 RID: 118579
		public const int DefaultGridWeight = 6;

		// Token: 0x0401CF34 RID: 118580
		public const int DefaultGridHeight = 8;

		// Token: 0x0401CF35 RID: 118581
		public const int GridSize = 136;

		// Token: 0x0401CF36 RID: 118582
		public const int BenchRotateRowThreshold = 3;

		// Token: 0x0401CF37 RID: 118583
		public const int UnvalidId = -1;

		// Token: 0x0401CF38 RID: 118584
		public const int ReflectLogConfigId = -1001;

		// Token: 0x0401CF39 RID: 118585
		public const int LifestealLogConfigId = -1002;

		// Token: 0x0401CF3A RID: 118586
		[StaticVariableRuleIgnore]
		public static readonly int[] DangoBrawlRotateAngle = new int[]
		{
			0,
			-90,
			-180,
			-270
		};

		// Token: 0x0401CF3B RID: 118587
		public const float ShopTalkBubbleDurationMs = 5000f;

		// Token: 0x0401CF3C RID: 118588
		public const float TipsHoverHideDelayMs = 50f;

		// Token: 0x0401CF3D RID: 118589
		public const float HpAddTipsValTweenDuring = 0.35f;

		// Token: 0x0401CF3E RID: 118590
		public const float CoinTweenDuring = 0.3f;

		// Token: 0x0401CF3F RID: 118591
		public const float SellFlyDurationDrag = 0.5f;

		// Token: 0x0401CF40 RID: 118592
		public const float SellFlyDurationButton = 1.3f;

		// Token: 0x0401CF41 RID: 118593
		public const float ShopStateGiveCoinDuration = 1.3f;

		// Token: 0x0401CF42 RID: 118594
		public const float CombineSubFlyDuration = 0.5f;

		// Token: 0x0401CF43 RID: 118595
		public const float EventChooseFlyDuration = 0.5f;

		// Token: 0x0401CF44 RID: 118596
		public const float ShopRefreshCd = 0.5f;

		// Token: 0x0401CF45 RID: 118597
		public const float FxScalePerCell = 0.5f;

		// Token: 0x0401CF46 RID: 118598
		public const float CombineGuideLineMinLength = 60f;

		// Token: 0x0401CF47 RID: 118599
		public const float CombineGuideLineMaxLength = 136f;

		// Token: 0x0401CF48 RID: 118600
		public const int ArchiveHelpId = 678;

		// Token: 0x0401CF49 RID: 118601
		public const int GeneralHelpId = 652;

		// Token: 0x0401CF4A RID: 118602
		public const int HandBookHelpId = 682;

		// Token: 0x0401CF4B RID: 118603
		public const int DangoBrawlRoundMaxTime = 60;

		// Token: 0x0401CF4C RID: 118604
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyList<float> DangoBrawlPlayRateList = new float[]
		{
			1f,
			1.5f,
			2f
		};

		// Token: 0x0401CF4D RID: 118605
		public const string BuffDetailFloorColor = "AAFF93";

		// Token: 0x0401CF4E RID: 118606
		public const string DeBuffDetailFloorColor = "FF8888";

		// Token: 0x0401CF4F RID: 118607
		public const string BuffDetailFloorOutlineColor = "1F313B";

		// Token: 0x0401CF50 RID: 118608
		public const string DeBuffDetailFloorOutlineColor = "391A1A";

		// Token: 0x0401CF51 RID: 118609
		public const float StepTime = 2f;

		// Token: 0x0401CF52 RID: 118610
		public const int MinEventCount = 1;
	}
}
