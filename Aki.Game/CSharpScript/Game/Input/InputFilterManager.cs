using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input
{
	// Token: 0x02006FCC RID: 28620
	[NullableContext(1)]
	[Nullable(0)]
	public class InputFilterManager : IStaticVariableResetter
	{
		// Token: 0x060459B9 RID: 285113 RVA: 0x01149C3C File Offset: 0x01147E3C
		static InputFilterManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputFilterManager.CreateStaticDefaultValue), new Action(InputFilterManager.ResetStaticDefaultValue));
		}

		// Token: 0x060459BA RID: 285114 RVA: 0x01149D82 File Offset: 0x01147F82
		public static void UpdateCharacterSystemActions(EInputAction inputAction, EUiViewName uiViewName)
		{
			InputFilterManager.CharacterSystemActions[inputAction] = uiViewName;
		}

		// Token: 0x060459BB RID: 285115 RVA: 0x01149D90 File Offset: 0x01147F90
		public static void CreateStaticDefaultValue()
		{
			InputFilterManager.CharacterSystemActions = new Dictionary<EInputAction, EUiViewName>();
			Dictionary<EUiViewName, HashSet<EInputAction>> dictionary = new Dictionary<EUiViewName, HashSet<EInputAction>>();
			EUiViewName plotSubtitleView = EUiViewName.PlotSubtitleView;
			dictionary[plotSubtitleView] = new HashSet<EInputAction>();
			InputFilterManager.CharacterSystemViewActions = dictionary;
		}

		// Token: 0x060459BC RID: 285116 RVA: 0x01149DC3 File Offset: 0x01147FC3
		public static void ResetStaticDefaultValue()
		{
			InputFilterManager.CharacterSystemActions = null;
			InputFilterManager.CharacterSystemViewActions = null;
		}

		// Token: 0x04024550 RID: 148816
		[StaticVariableRuleIgnore]
		public static readonly HashSet<EInputAction> CharacterActions = new HashSet<EInputAction>
		{
			EInputAction.跳跃,
			EInputAction.攀爬,
			EInputAction.走跑切换,
			EInputAction.攻击,
			EInputAction.闪避,
			EInputAction.技能1,
			EInputAction.幻象1,
			EInputAction.大招,
			EInputAction.幻象2,
			EInputAction.切换角色1,
			EInputAction.切换角色2,
			EInputAction.切换角色3,
			EInputAction.锁定目标,
			EInputAction.瞄准,
			EInputAction.通用交互,
			EInputAction.下降,
			EInputAction.移动输入按键事件
		};

		// Token: 0x04024551 RID: 148817
		public static Dictionary<EInputAction, EUiViewName> CharacterSystemActions;

		// Token: 0x04024552 RID: 148818
		public static Dictionary<EUiViewName, HashSet<EInputAction>> CharacterSystemViewActions;

		// Token: 0x04024553 RID: 148819
		[StaticVariableRuleIgnore]
		public static readonly HashSet<EInputAxis> CharacterAxes = new HashSet<EInputAxis>
		{
			EInputAxis.MoveForward,
			EInputAxis.MoveRight,
			EInputAxis.LookUp,
			EInputAxis.Turn,
			EInputAxis.Zoom
		};
	}
}
