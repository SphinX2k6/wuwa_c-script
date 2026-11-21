using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020004B4 RID: 1204
public class GolemHackingDefineStaticData : IStaticVariableResetter
{
	// Token: 0x06003C8D RID: 15501 RVA: 0x00156697 File Offset: 0x00154897
	static GolemHackingDefineStaticData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GolemHackingDefineStaticData.CreateStaticDefaultValue), new Action(GolemHackingDefineStaticData.ResetStaticDefaultValue));
	}

	// Token: 0x06003C8E RID: 15502 RVA: 0x001566B8 File Offset: 0x001548B8
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

	// Token: 0x06003C8F RID: 15503 RVA: 0x00156765 File Offset: 0x00154965
	public static void ResetStaticDefaultValue()
	{
		GolemHackingDefineStaticData.GolemHackingTexResourceMap = null;
	}

	// Token: 0x040030D0 RID: 12496
	[Nullable(1)]
	public static Dictionary<EGolemHackingGroupState, string[]> GolemHackingTexResourceMap;
}
