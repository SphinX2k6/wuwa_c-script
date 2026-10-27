using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A4E RID: 10830
public class FlySkinDefine : IStaticVariableResetter
{
	// Token: 0x060168ED RID: 92397 RVA: 0x005B787B File Offset: 0x005B5A7B
	static FlySkinDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FlySkinDefine.CreateStaticDefaultValue), new Action(FlySkinDefine.ResetStaticDefaultValue));
	}

	// Token: 0x060168EE RID: 92398 RVA: 0x005B789C File Offset: 0x005B5A9C
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

	// Token: 0x060168EF RID: 92399 RVA: 0x005B78FE File Offset: 0x005B5AFE
	public static void ResetStaticDefaultValue()
	{
		FlySkinDefine.FLY_SKIN_APPLY_TO_ALL_HELP_ID = null;
		FlySkinDefine.flySkinTabToType = null;
		FlySkinDefine.DEFAULT_FLY_SKIN_CASE = null;
		FlySkinDefine.flySkinTypeToCase = null;
	}

	// Token: 0x0400A774 RID: 42868
	public static int? FLY_SKIN_APPLY_TO_ALL_HELP_ID;

	// Token: 0x0400A775 RID: 42869
	[Nullable(2)]
	public static Dictionary<EFlySkinTab, EFlySkinType> flySkinTabToType;

	// Token: 0x0400A776 RID: 42870
	[Nullable(2)]
	public static string DEFAULT_FLY_SKIN_CASE;

	// Token: 0x0400A777 RID: 42871
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<EFlySkinType, string> flySkinTypeToCase;
}
