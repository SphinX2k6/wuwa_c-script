using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E53 RID: 7763
public class RoleUiDefine : IStaticVariableResetter
{
	// Token: 0x06013364 RID: 78692 RVA: 0x0059D7CD File Offset: 0x0059B9CD
	static RoleUiDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleUiDefine.CreateStaticDefaultValue), new Action(RoleUiDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06013365 RID: 78693 RVA: 0x0059D7EC File Offset: 0x0059B9EC
	public static void CreateStaticDefaultValue()
	{
		RoleUiDefine.roleSystemModeUiParam = new Dictionary<ERoleSystemMode, IRoleSystemUiParams>
		{
			{
				ERoleSystemMode.Trial,
				new RoleSystemUiParams
				{
					RoleListButton = true,
					RoleListButtonRedDot = false,
					RoleList = true,
					RoleListNeedTrial = true,
					RoleListRedDot = false,
					TabRedDot = false,
					TeachBtn = true,
					SwitchSkin = false,
					BackgroundMusicSwitch = false
				}
			},
			{
				ERoleSystemMode.Normal,
				new RoleSystemUiParams
				{
					RoleListButton = true,
					RoleListButtonRedDot = true,
					RoleList = true,
					RoleListNeedTrial = true,
					RoleListRedDot = true,
					TabRedDot = true,
					TeachBtn = true,
					SwitchSkin = true,
					BackgroundMusicSwitch = true
				}
			},
			{
				ERoleSystemMode.Preview,
				new RoleSystemUiParams
				{
					RoleListButton = true,
					RoleListButtonRedDot = false,
					RoleList = true,
					RoleListNeedTrial = false,
					RoleListRedDot = false,
					TabRedDot = false,
					TeachBtn = false,
					SwitchSkin = false,
					BackgroundMusicSwitch = false
				}
			},
			{
				ERoleSystemMode.RoleNewJoin,
				new RoleSystemUiParams
				{
					RoleListButton = false,
					RoleListButtonRedDot = false,
					RoleList = true,
					RoleListNeedTrial = false,
					RoleListRedDot = false,
					TabRedDot = false,
					TeachBtn = false,
					SwitchSkin = false,
					BackgroundMusicSwitch = false
				}
			},
			{
				ERoleSystemMode.SpecialTrial,
				new RoleSystemUiParams
				{
					RoleListButton = true,
					RoleListButtonRedDot = false,
					RoleList = true,
					RoleListNeedTrial = true,
					RoleListRedDot = false,
					TabRedDot = false,
					TeachBtn = true,
					SwitchSkin = false,
					BackgroundMusicSwitch = false
				}
			}
		};
	}

	// Token: 0x06013366 RID: 78694 RVA: 0x0059D97A File Offset: 0x0059BB7A
	public static void ResetStaticDefaultValue()
	{
		RoleUiDefine.roleSystemModeUiParam = null;
	}

	// Token: 0x0400A498 RID: 42136
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<ERoleSystemMode, IRoleSystemUiParams> roleSystemModeUiParam;
}
