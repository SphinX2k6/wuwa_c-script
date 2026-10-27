using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001000 RID: 4096
public class GolemHackingDefineStaticData : IStaticVariableResetter
{
	// Token: 0x060068FA RID: 26874 RVA: 0x0014DDFD File Offset: 0x0014BFFD
	static GolemHackingDefineStaticData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GolemHackingDefineStaticData.CreateStaticDefaultValue), new Action(GolemHackingDefineStaticData.ResetStaticDefaultValue));
	}

	// Token: 0x060068FB RID: 26875 RVA: 0x0014DE1C File Offset: 0x0014C01C
	public static void CreateStaticDefaultValue()
	{
		GolemHackingDefineStaticData.GolemHackingTexResourceMap = new Dictionary<EGolemHackingGroupState, string[]>
		{
			{
				EGolemHackingGroupState.Locked,
				new string[]
				{
					"T_LevelCardBlackNor",
					"T_LevelCardBlackHold",
					"T_LevelCardBlackPress"
				}
			},
			{
				EGolemHackingGroupState.Normal,
				new string[]
				{
					"T_LevelCardBlueNor",
					"T_LevelCardBlueHold",
					"T_LevelCardBluePress"
				}
			},
			{
				EGolemHackingGroupState.Clear,
				new string[]
				{
					"T_LevelCardGreenNor",
					"T_LevelCardGreenHold",
					"T_LevelCardGreenPress"
				}
			},
			{
				EGolemHackingGroupState.Bonus,
				new string[]
				{
					"T_LevelCardPurpleNor",
					"T_LevelCardPurpleHold",
					"T_LevelCardPurplePress"
				}
			}
		};
	}

	// Token: 0x060068FC RID: 26876 RVA: 0x0014DEC9 File Offset: 0x0014C0C9
	public static void ResetStaticDefaultValue()
	{
		GolemHackingDefineStaticData.GolemHackingTexResourceMap = null;
	}

	// Token: 0x04003039 RID: 12345
	[Nullable(1)]
	public static Dictionary<EGolemHackingGroupState, string[]> GolemHackingTexResourceMap;
}
