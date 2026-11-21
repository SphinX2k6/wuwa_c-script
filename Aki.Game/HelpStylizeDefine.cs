using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200131B RID: 4891
public class HelpStylizeDefine : IStaticVariableResetter
{
	// Token: 0x0600C03E RID: 49214 RVA: 0x0038CA94 File Offset: 0x0038AC94
	static HelpStylizeDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HelpStylizeDefine.CreateStaticDefaultValue), new Action(HelpStylizeDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600C03F RID: 49215 RVA: 0x0038CAB4 File Offset: 0x0038ACB4
	public static void CreateStaticDefaultValue()
	{
		HelpStylizeDefine.helpPopUpViewStylizeMap = new Dictionary<EHelpStylizeType, EUiViewName>
		{
			{
				EHelpStylizeType.None,
				EUiViewName.HelpView
			},
			{
				EHelpStylizeType.FloroRanch,
				EUiViewName.FloroRanchHelpView
			},
			{
				EHelpStylizeType.Pinball,
				EUiViewName.PinballMainHelpView
			}
		};
		HelpStylizeDefine.helpStylizeType2PopFrameType = new Dictionary<EHelpStylizeType, EUiBehaviourPopType?>
		{
			{
				EHelpStylizeType.None,
				null
			},
			{
				EHelpStylizeType.FloroRanch,
				null
			},
			{
				EHelpStylizeType.Pinball,
				new EUiBehaviourPopType?(EUiBehaviourPopType.PinballMiddle)
			}
		};
	}

	// Token: 0x0600C040 RID: 49216 RVA: 0x0038CB27 File Offset: 0x0038AD27
	public static void ResetStaticDefaultValue()
	{
		HelpStylizeDefine.helpPopUpViewStylizeMap = null;
		HelpStylizeDefine.helpStylizeType2PopFrameType = null;
	}

	// Token: 0x04006E5D RID: 28253
	[Nullable(1)]
	public static Dictionary<EHelpStylizeType, EUiViewName> helpPopUpViewStylizeMap;

	// Token: 0x04006E5E RID: 28254
	[Nullable(1)]
	public static Dictionary<EHelpStylizeType, EUiBehaviourPopType?> helpStylizeType2PopFrameType;
}
