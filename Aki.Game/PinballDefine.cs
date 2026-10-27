using System;
using System.Runtime.CompilerServices;

// Token: 0x020013EB RID: 5099
public class PinballDefine : IStaticVariableResetter
{
	// Token: 0x0600902A RID: 36906 RVA: 0x001F296B File Offset: 0x001F0B6B
	static PinballDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballDefine.CreateStaticDefaultValue), new Action(PinballDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600902B RID: 36907 RVA: 0x001F298A File Offset: 0x001F0B8A
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

	// Token: 0x0600902C RID: 36908 RVA: 0x001F29B7 File Offset: 0x001F0BB7
	public static void ResetStaticDefaultValue()
	{
		PinballDefine.pinballRankTopIconResourceKeys = null;
	}

	// Token: 0x04003FAA RID: 16298
	[Nullable(1)]
	public const string WEAPON_CANNOT_EQUIP_ICON_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/CatapultStory/OutSide/SP_IconTitle02.SP_IconTitle02";

	// Token: 0x04003FAB RID: 16299
	public const int PINBALL_ACTIVITY_CACHE_KEY3_ROLE = 0;

	// Token: 0x04003FAC RID: 16300
	public const int PINBALL_ACTIVITY_CACHE_KEY2_ROLE_RED_DOT = 0;

	// Token: 0x04003FAD RID: 16301
	public const int PINBALL_ROLE_MULTIPLE_LEVEL_UP_TIMES = 10;

	// Token: 0x04003FAE RID: 16302
	public const int PINBALL_DEFAULT_TIPS_DURATION = 2000;

	// Token: 0x04003FAF RID: 16303
	public const int PINBALL_CURRENCY_ITEM_ID = 89500002;

	// Token: 0x04003FB0 RID: 16304
	public const int PINBALL_FORMATION_MAX_SIZE = 3;

	// Token: 0x04003FB1 RID: 16305
	[Nullable(1)]
	public const string PINBALL_ITEMBASE_NUMBER_RESID = "SP_ComItemNum0";

	// Token: 0x04003FB2 RID: 16306
	public const int PINBALL_MAIN_LEVEL_HELP = 555;

	// Token: 0x04003FB3 RID: 16307
	public const int PINBALL_DAILY_LEVEL_HELP = 556;

	// Token: 0x04003FB4 RID: 16308
	public const int PINBALL_TOWER_LEVEL_HELP = 557;

	// Token: 0x04003FB5 RID: 16309
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static string[] pinballRankTopIconResourceKeys;
}
