using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input
{
	// Token: 0x0200614D RID: 24909
	[NullableContext(1)]
	[Nullable(0)]
	public class InputFilterManager : IStaticVariableResetter
	{
		// Token: 0x0603BB69 RID: 244585 RVA: 0x010F3A34 File Offset: 0x010F1C34
		static InputFilterManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputFilterManager.CreateStaticDefaultValue), new Action(InputFilterManager.ResetStaticDefaultValue));
		}

		// Token: 0x0603BB6A RID: 244586 RVA: 0x010F3B7A File Offset: 0x010F1D7A
		public static void UpdateCharacterSystemActions(EInputAction inputAction, EUiViewName uiViewName)
		{
			InputFilterManager.CharacterSystemActions[inputAction] = uiViewName;
		}

		// Token: 0x0603BB6B RID: 244587 RVA: 0x010F3B88 File Offset: 0x010F1D88
		public static void CreateStaticDefaultValue()
		{
			InputFilterManager.CharacterSystemActions = new Dictionary<EInputAction, EUiViewName>();
			Dictionary<EUiViewName, HashSet<EInputAction>> dictionary = new Dictionary<EUiViewName, HashSet<EInputAction>>();
			EUiViewName plotSubtitleView = EUiViewName.PlotSubtitleView;
			dictionary[plotSubtitleView] = new HashSet<EInputAction>();
			InputFilterManager.CharacterSystemViewActions = dictionary;
		}

		// Token: 0x0603BB6C RID: 244588 RVA: 0x010F3BBB File Offset: 0x010F1DBB
		public static void ResetStaticDefaultValue()
		{
			InputFilterManager.CharacterSystemActions = null;
			InputFilterManager.CharacterSystemViewActions = null;
		}

		// Token: 0x0401F805 RID: 129029
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

		// Token: 0x0401F806 RID: 129030
		public static Dictionary<EInputAction, EUiViewName> CharacterSystemActions;

		// Token: 0x0401F807 RID: 129031
		public static Dictionary<EUiViewName, HashSet<EInputAction>> CharacterSystemViewActions;

		// Token: 0x0401F808 RID: 129032
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
