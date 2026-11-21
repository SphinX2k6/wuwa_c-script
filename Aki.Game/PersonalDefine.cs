using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001898 RID: 6296
public class PersonalDefine : IStaticVariableResetter
{
	// Token: 0x0600F94F RID: 63823 RVA: 0x0048E772 File Offset: 0x0048C972
	static PersonalDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PersonalDefine.CreateStaticDefaultValue), new Action(PersonalDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600F950 RID: 63824 RVA: 0x0048E791 File Offset: 0x0048C991
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

	// Token: 0x0600F951 RID: 63825 RVA: 0x0048E7C1 File Offset: 0x0048C9C1
	public static void ResetStaticDefaultValue()
	{
		PersonalDefine.playerTitleQualityToColor = null;
	}

	// Token: 0x04008B3E RID: 35646
	public const int MAX_SIGN_LENGTH = 40;

	// Token: 0x04008B3F RID: 35647
	public const int MAX_NAME_LENGTH = 12;

	// Token: 0x04008B40 RID: 35648
	[Nullable(1)]
	public const string STOP_AUDIO_EVENT_NAME = "stop_gacha_role_audio";

	// Token: 0x04008B41 RID: 35649
	[Nullable(1)]
	public static Dictionary<int, string> playerTitleQualityToColor;
}
