using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020023B3 RID: 9139
public class PersonalDefine : IStaticVariableResetter
{
	// Token: 0x0601249D RID: 74909 RVA: 0x0048128A File Offset: 0x0047F48A
	static PersonalDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PersonalDefine.CreateStaticDefaultValue), new Action(PersonalDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0601249E RID: 74910 RVA: 0x004812A9 File Offset: 0x0047F4A9
	public static void CreateStaticDefaultValue()
	{
		PersonalDefine.playerTitleQualityToColor = new Dictionary<int, string>
		{
			{
				0,
				"FFF7A0FF"
			},
			{
				1,
				"D3DEFFFF"
			},
			{
				2,
				"B19370FF"
			}
		};
	}

	// Token: 0x0601249F RID: 74911 RVA: 0x004812D9 File Offset: 0x0047F4D9
	public static void ResetStaticDefaultValue()
	{
		PersonalDefine.playerTitleQualityToColor = null;
	}

	// Token: 0x040089F7 RID: 35319
	public const int MAX_SIGN_LENGTH = 40;

	// Token: 0x040089F8 RID: 35320
	public const int MAX_NAME_LENGTH = 12;

	// Token: 0x040089F9 RID: 35321
	[Nullable(1)]
	public const string STOP_AUDIO_EVENT_NAME = "stop_gacha_role_audio";

	// Token: 0x040089FA RID: 35322
	[Nullable(1)]
	public static Dictionary<int, string> playerTitleQualityToColor;
}
