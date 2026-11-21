using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input.BattleInputData
{
	// Token: 0x02006163 RID: 24931
	[NullableContext(1)]
	[Nullable(0)]
	public class SurvivorsRogueInputData : BattleInputData
	{
		// Token: 0x0603BBF8 RID: 244728 RVA: 0x010F5370 File Offset: 0x010F3570
		public SurvivorsRogueInputData()
		{
			Dictionary<string, EInputAction> dictionary = new Dictionary<string, EInputAction>();
			dictionary["技能1"] = EInputAction.技能1;
			dictionary["闪避"] = EInputAction.闪避;
			dictionary["走跑切换"] = EInputAction.走跑切换;
			this.ActionMap = dictionary;
			Dictionary<string, EInputAxis> dictionary2 = new Dictionary<string, EInputAxis>();
			dictionary2["MoveForward"] = EInputAxis.MoveForward;
			dictionary2["MoveRight"] = EInputAxis.MoveRight;
			this.AxisMap = dictionary2;
			this.AllowActionNameList = new string[]
			{
				"轮盘2",
				"幻象探索选择界面",
				"角色选择界面"
			};
			this.MatchInputDistributeTag = new string[]
			{
				"FightInputRoot.FightInput.ActionInput",
				"FightInputRoot.FightInput.AxisInput",
				"UiInputRoot.ShortcutKeyTag"
			};
			base..ctor(EInputDataType.SurvivorsRogue, EInputBindingType.Original);
		}

		// Token: 0x0603BBF9 RID: 244729 RVA: 0x010F5433 File Offset: 0x010F3633
		protected override Dictionary<string, EInputAction> OnGetActionMap()
		{
			return this.ActionMap;
		}

		// Token: 0x0603BBFA RID: 244730 RVA: 0x010F543B File Offset: 0x010F363B
		protected override Dictionary<string, EInputAxis> OnGetAxisMap()
		{
			return this.AxisMap;
		}

		// Token: 0x0603BBFB RID: 244731 RVA: 0x010F5444 File Offset: 0x010F3644
		protected override bool OnCheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			if (this.ActionMap.ContainsKey(actionName))
			{
				return true;
			}
			string inputDistributeTag = inputActionHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true) || Array.IndexOf<string>(this.AllowActionNameList, actionName) >= 0;
		}

		// Token: 0x0603BBFC RID: 244732 RVA: 0x010F5498 File Offset: 0x010F3698
		protected override bool OnCheckAxisInAllowFightAxisNameList(string axisName, InputAxisHandle inputAxisHandle)
		{
			if (this.AxisMap.ContainsKey(axisName))
			{
				return true;
			}
			string inputDistributeTag = inputAxisHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true);
		}

		// Token: 0x0401F842 RID: 129090
		private readonly Dictionary<string, EInputAction> ActionMap;

		// Token: 0x0401F843 RID: 129091
		private readonly Dictionary<string, EInputAxis> AxisMap;

		// Token: 0x0401F844 RID: 129092
		private readonly string[] AllowActionNameList;

		// Token: 0x0401F845 RID: 129093
		private readonly string[] MatchInputDistributeTag;
	}
}
