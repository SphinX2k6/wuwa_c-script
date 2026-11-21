using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020009C3 RID: 2499
[NullableContext(1)]
[Nullable(0)]
public class Spring25Define : IStaticVariableResetter
{
	// Token: 0x06006DDA RID: 28122 RVA: 0x0021F108 File Offset: 0x0021D308
	static Spring25Define()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Spring25Define.CreateStaticDefaultValue), new Action(Spring25Define.ResetStaticDefaultValue));
	}

	// Token: 0x06006DDB RID: 28123 RVA: 0x0021F128 File Offset: 0x0021D328
	public static void CreateStaticDefaultValue()
	{
		Spring25Define.Spring25DialogIndex = new Dictionary<string, int>
		{
			{
				"Bubble01",
				0
			},
			{
				"Bubble02",
				1
			},
			{
				"Bubble03",
				2
			},
			{
				"Bubble04",
				3
			},
			{
				"Bubble05",
				4
			},
			{
				"Bubble06",
				5
			},
			{
				"Bubble07",
				6
			},
			{
				"Bubble08",
				7
			}
		};
	}

	// Token: 0x06006DDC RID: 28124 RVA: 0x0021F19F File Offset: 0x0021D39F
	public static void ResetStaticDefaultValue()
	{
		Spring25Define.Spring25DialogIndex = null;
	}

	// Token: 0x04004426 RID: 17446
	public const int SANHUA_SKIN_ITEM_ID = 81011102;

	// Token: 0x04004427 RID: 17447
	public const int PROGRESS_BLINK_WAITING_TIME = 1000;

	// Token: 0x04004428 RID: 17448
	public const string PROGRESS_TEXT_ID_IN_SUBVIEW = "Springsystem_1";

	// Token: 0x04004429 RID: 17449
	public const string REWARD_TITLE_TEXT_ID_IN_SUBVIEW = "Springsystem_2";

	// Token: 0x0400442A RID: 17450
	public const string BUTTON_TEXT_ID_IN_SUBVIEW = "Springsystem_3";

	// Token: 0x0400442B RID: 17451
	public const string NO_LETTER_TIPS_TEXT_ID = "SpringMessage_1";

	// Token: 0x0400442C RID: 17452
	public const string REMAIN_CHANCE_NOT_ENOUGH = "SpringMessage_2";

	// Token: 0x0400442D RID: 17453
	public const string BUTTON_TEXT_ID_IN_DIALOG = "Springsystem_4";

	// Token: 0x0400442E RID: 17454
	public const string FUNCTION_AND_NUMBER_TEXT_ID = "Springsystem_5";

	// Token: 0x0400442F RID: 17455
	public const string ALL_CHARACTER_INVITED = "Springsystem_6";

	// Token: 0x04004430 RID: 17456
	public const int START_MALE_CHAT_CONFIG_ID = 99;

	// Token: 0x04004431 RID: 17457
	public const int START_FEMALE_CHAT_CONFIG_ID = 100;

	// Token: 0x04004432 RID: 17458
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<string, int> Spring25DialogIndex;
}
