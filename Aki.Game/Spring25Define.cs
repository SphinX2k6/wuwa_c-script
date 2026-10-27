using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200150B RID: 5387
[NullableContext(1)]
[Nullable(0)]
public class Spring25Define : IStaticVariableResetter
{
	// Token: 0x060099FC RID: 39420 RVA: 0x0021536C File Offset: 0x0021356C
	static Spring25Define()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Spring25Define.CreateStaticDefaultValue), new Action(Spring25Define.ResetStaticDefaultValue));
	}

	// Token: 0x060099FD RID: 39421 RVA: 0x0021538C File Offset: 0x0021358C
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

	// Token: 0x060099FE RID: 39422 RVA: 0x00215403 File Offset: 0x00213603
	public static void ResetStaticDefaultValue()
	{
		Spring25Define.Spring25DialogIndex = null;
	}

	// Token: 0x04004380 RID: 17280
	public const int SANHUA_SKIN_ITEM_ID = 81011102;

	// Token: 0x04004381 RID: 17281
	public const int PROGRESS_BLINK_WAITING_TIME = 1000;

	// Token: 0x04004382 RID: 17282
	public const string PROGRESS_TEXT_ID_IN_SUBVIEW = "Springsystem_1";

	// Token: 0x04004383 RID: 17283
	public const string REWARD_TITLE_TEXT_ID_IN_SUBVIEW = "Springsystem_2";

	// Token: 0x04004384 RID: 17284
	public const string BUTTON_TEXT_ID_IN_SUBVIEW = "Springsystem_3";

	// Token: 0x04004385 RID: 17285
	public const string NO_LETTER_TIPS_TEXT_ID = "SpringMessage_1";

	// Token: 0x04004386 RID: 17286
	public const string REMAIN_CHANCE_NOT_ENOUGH = "SpringMessage_2";

	// Token: 0x04004387 RID: 17287
	public const string BUTTON_TEXT_ID_IN_DIALOG = "Springsystem_4";

	// Token: 0x04004388 RID: 17288
	public const string FUNCTION_AND_NUMBER_TEXT_ID = "Springsystem_5";

	// Token: 0x04004389 RID: 17289
	public const string ALL_CHARACTER_INVITED = "Springsystem_6";

	// Token: 0x0400438A RID: 17290
	public const int START_MALE_CHAT_CONFIG_ID = 99;

	// Token: 0x0400438B RID: 17291
	public const int START_FEMALE_CHAT_CONFIG_ID = 100;

	// Token: 0x0400438C RID: 17292
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<string, int> Spring25DialogIndex;
}
