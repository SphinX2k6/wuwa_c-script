using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020028D8 RID: 10456
public class RoleUiDefine : IStaticVariableResetter
{
	// Token: 0x06015960 RID: 88416 RVA: 0x00572904 File Offset: 0x00570B04
	static RoleUiDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleUiDefine.CreateStaticDefaultValue), new Action(RoleUiDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06015961 RID: 88417 RVA: 0x00572924 File Offset: 0x00570B24
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

	// Token: 0x06015962 RID: 88418 RVA: 0x00572AB2 File Offset: 0x00570CB2
	public static void ResetStaticDefaultValue()
	{
		RoleUiDefine.roleSystemModeUiParam = null;
	}

	// Token: 0x0400A0AE RID: 41134
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<ERoleSystemMode, IRoleSystemUiParams> roleSystemModeUiParam;
}
