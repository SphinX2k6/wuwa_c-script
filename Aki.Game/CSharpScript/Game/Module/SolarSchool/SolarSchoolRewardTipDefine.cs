using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059F9 RID: 23033
	[NullableContext(1)]
	[Nullable(0)]
	public static class SolarSchoolRewardTipDefine
	{
		// Token: 0x0401DDD8 RID: 122328
		public const float RewardTipAddIntervalMs = 100f;

		// Token: 0x0401DDD9 RID: 122329
		public const float RewardTipSlideDurationMs = 100f;

		// Token: 0x0401DDDA RID: 122330
		public const float BatchCloseDelayMs = 1000f;

		// Token: 0x0401DDDB RID: 122331
		public const float RewardTipLoadTimeoutMs = 2000f;

		// Token: 0x0401DDDC RID: 122332
		public const int MaxVisibleItemCount = 5;

		// Token: 0x0401DDDD RID: 122333
		public const string AttrUpBackgroundResourceId = "T_SolarSchoolAcquireBg";

		// Token: 0x0401DDDE RID: 122334
		public const string AttrDownBackgroundResourceId = "T_SolarSchoolAcquireDownBg";

		// Token: 0x0401DDDF RID: 122335
		public const string AttrUpSpriteResourceId = "SP_SolarSchoolAcquireUp";

		// Token: 0x0401DDE0 RID: 122336
		public const string AttrDownSpriteResourceId = "SP_SolarSchoolAcquireDown";

		// Token: 0x0401DDE1 RID: 122337
		public const string AttrFatigueUpSpriteResourceId = "SP_SolarSchoolAcquireUpB";

		// Token: 0x0401DDE2 RID: 122338
		public const string AttrFatigueDownSpriteResourceId = "SP_SolarSchoolAcquireDownB";

		// Token: 0x0401DDE3 RID: 122339
		public const string QuestDoneIconResourceId = "T_SolarSchoolIconDone";

		// Token: 0x0401DDE4 RID: 122340
		public const string QuestDoneDescTextId = "SolarSchool_QuestPanel_Left";

		// Token: 0x0401DDE5 RID: 122341
		public const string QuestRewardDoneTitleId = "SolarSchool_QuestPanel_Left1";

		// Token: 0x0401DDE6 RID: 122342
		public const string QuestRewardDoneTextId = "SolarSchool_QuestPanel_Left2";
	}
}
