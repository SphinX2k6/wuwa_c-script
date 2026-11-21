using System;
using System.Runtime.CompilerServices;

// Token: 0x0200089F RID: 2207
public class PinballDefine : IStaticVariableResetter
{
	// Token: 0x060063BF RID: 25535 RVA: 0x001FB4A7 File Offset: 0x001F96A7
	static PinballDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballDefine.CreateStaticDefaultValue), new Action(PinballDefine.ResetStaticDefaultValue));
	}

	// Token: 0x060063C0 RID: 25536 RVA: 0x001FB4C6 File Offset: 0x001F96C6
	public static void CreateStaticDefaultValue()
	{
		PinballDefine.pinballRankTopIconResourceKeys = new string[]
		{
			"",
			"T_RankListNo1",
			"T_RankListNo2",
			"T_RankListNo3"
		};
	}

	// Token: 0x060063C1 RID: 25537 RVA: 0x001FB4F3 File Offset: 0x001F96F3
	public static void ResetStaticDefaultValue()
	{
		PinballDefine.pinballRankTopIconResourceKeys = null;
	}

	// Token: 0x04004042 RID: 16450
	[Nullable(1)]
	public const string WEAPON_CANNOT_EQUIP_ICON_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/CatapultStory/OutSide/SP_IconTitle02.SP_IconTitle02";

	// Token: 0x04004043 RID: 16451
	public const int PINBALL_ACTIVITY_CACHE_KEY3_ROLE = 0;

	// Token: 0x04004044 RID: 16452
	public const int PINBALL_ACTIVITY_CACHE_KEY2_ROLE_RED_DOT = 0;

	// Token: 0x04004045 RID: 16453
	public const int PINBALL_ROLE_MULTIPLE_LEVEL_UP_TIMES = 10;

	// Token: 0x04004046 RID: 16454
	public const int PINBALL_DEFAULT_TIPS_DURATION = 2000;

	// Token: 0x04004047 RID: 16455
	public const int PINBALL_CURRENCY_ITEM_ID = 89500002;

	// Token: 0x04004048 RID: 16456
	public const int PINBALL_FORMATION_MAX_SIZE = 3;

	// Token: 0x04004049 RID: 16457
	[Nullable(1)]
	public const string PINBALL_ITEMBASE_NUMBER_RESID = "SP_ComItemNum0";

	// Token: 0x0400404A RID: 16458
	public const int PINBALL_MAIN_LEVEL_HELP = 555;

	// Token: 0x0400404B RID: 16459
	public const int PINBALL_DAILY_LEVEL_HELP = 556;

	// Token: 0x0400404C RID: 16460
	public const int PINBALL_TOWER_LEVEL_HELP = 557;

	// Token: 0x0400404D RID: 16461
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static string[] pinballRankTopIconResourceKeys;
}
