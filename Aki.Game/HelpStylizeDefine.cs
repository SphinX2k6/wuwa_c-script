using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001E59 RID: 7769
public class HelpStylizeDefine : IStaticVariableResetter
{
	// Token: 0x0600EC1F RID: 60447 RVA: 0x00380DE8 File Offset: 0x0037EFE8
	static HelpStylizeDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HelpStylizeDefine.CreateStaticDefaultValue), new Action(HelpStylizeDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600EC20 RID: 60448 RVA: 0x00380E08 File Offset: 0x0037F008
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
				null
			}
		};
	}

	// Token: 0x0600EC21 RID: 60449 RVA: 0x00380E7D File Offset: 0x0037F07D
	public static void ResetStaticDefaultValue()
	{
		HelpStylizeDefine.helpPopUpViewStylizeMap = null;
		HelpStylizeDefine.helpStylizeType2PopFrameType = null;
	}

	// Token: 0x04006D7C RID: 28028
	[Nullable(1)]
	public static Dictionary<EHelpStylizeType, EUiViewName> helpPopUpViewStylizeMap;

	// Token: 0x04006D7D RID: 28029
	[Nullable(1)]
	public static Dictionary<EHelpStylizeType, EUiBehaviourPopType?> helpStylizeType2PopFrameType;
}
