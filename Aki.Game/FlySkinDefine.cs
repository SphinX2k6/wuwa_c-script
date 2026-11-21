using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001FC9 RID: 8137
public class FlySkinDefine : IStaticVariableResetter
{
	// Token: 0x0601430E RID: 82702 RVA: 0x005E39BF File Offset: 0x005E1BBF
	static FlySkinDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FlySkinDefine.CreateStaticDefaultValue), new Action(FlySkinDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0601430F RID: 82703 RVA: 0x005E39E0 File Offset: 0x005E1BE0
	public static void CreateStaticDefaultValue()
	{
		FlySkinDefine.FLY_SKIN_APPLY_TO_ALL_HELP_ID = new int?(243);
		FlySkinDefine.flySkinTabToType = new Dictionary<EFlySkinTab, EFlySkinType>
		{
			{
				EFlySkinTab.ParaglidingTab,
				EFlySkinType.Paragliding
			},
			{
				EFlySkinTab.SoarWingTab,
				EFlySkinType.SoarWing
			}
		};
		FlySkinDefine.DEFAULT_FLY_SKIN_CASE = "GliderSkinCase";
		FlySkinDefine.flySkinTypeToCase = new Dictionary<EFlySkinType, string>
		{
			{
				EFlySkinType.Paragliding,
				"GliderSkinCase"
			},
			{
				EFlySkinType.SoarWing,
				"SoarSkinCase"
			}
		};
	}

	// Token: 0x06014310 RID: 82704 RVA: 0x005E3A42 File Offset: 0x005E1C42
	public static void ResetStaticDefaultValue()
	{
		FlySkinDefine.FLY_SKIN_APPLY_TO_ALL_HELP_ID = null;
		FlySkinDefine.flySkinTabToType = null;
		FlySkinDefine.DEFAULT_FLY_SKIN_CASE = null;
		FlySkinDefine.flySkinTypeToCase = null;
	}

	// Token: 0x0400AB78 RID: 43896
	public static int? FLY_SKIN_APPLY_TO_ALL_HELP_ID;

	// Token: 0x0400AB79 RID: 43897
	[Nullable(2)]
	public static Dictionary<EFlySkinTab, EFlySkinType> flySkinTabToType;

	// Token: 0x0400AB7A RID: 43898
	[Nullable(2)]
	public static string DEFAULT_FLY_SKIN_CASE;

	// Token: 0x0400AB7B RID: 43899
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<EFlySkinType, string> flySkinTypeToCase;
}
