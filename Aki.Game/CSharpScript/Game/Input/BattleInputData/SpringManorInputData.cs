using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input.BattleInputData
{
	// Token: 0x02006FE1 RID: 28641
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorInputData : BattleInputData
	{
		// Token: 0x06045A42 RID: 285250 RVA: 0x0114B35C File Offset: 0x0114955C
		public SpringManorInputData()
		{
			Dictionary<string, EInputAction> dictionary = new Dictionary<string, EInputAction>();
			dictionary["跳跃"] = EInputAction.跳跃;
			dictionary["走跑切换"] = EInputAction.走跑切换;
			dictionary["闪避"] = EInputAction.闪避;
			dictionary["通用交互"] = EInputAction.通用交互;
			dictionary["下降"] = EInputAction.下降;
			this.ActionMap = dictionary;
			Dictionary<string, EInputAxis> dictionary2 = new Dictionary<string, EInputAxis>();
			dictionary2["LookUp"] = EInputAxis.LookUp;
			dictionary2["Turn"] = EInputAxis.Turn;
			dictionary2["MoveForward"] = EInputAxis.MoveForward;
			dictionary2["MoveRight"] = EInputAxis.MoveRight;
			dictionary2["Zoom"] = EInputAxis.Zoom;
			dictionary2["WheelAxis"] = EInputAxis.WheelAxis;
			this.AxisMap = dictionary2;
			this.AllowActionNameSet = new HashSet<string>
			{
				"任务追踪",
				"切换交互",
				"任务",
				"玩法放弃",
				"幻象探索选择界面",
				"轮盘2",
				"切换角色1",
				"切换角色2",
				"切换角色3"
			};
			this.MatchInputDistributeTag = new string[]
			{
				"FightInputRoot.FightInput.ActionInput",
				"FightInputRoot.FightInput.AxisInput",
				"UiInputRoot.ShortcutKeyTag"
			};
			base..ctor(EInputDataType.SpringManor, EInputBindingType.Original);
		}

		// Token: 0x06045A43 RID: 285251 RVA: 0x0114B4D2 File Offset: 0x011496D2
		protected override Dictionary<string, EInputAction> OnGetActionMap()
		{
			return this.ActionMap;
		}

		// Token: 0x06045A44 RID: 285252 RVA: 0x0114B4DA File Offset: 0x011496DA
		protected override Dictionary<string, EInputAxis> OnGetAxisMap()
		{
			return this.AxisMap;
		}

		// Token: 0x06045A45 RID: 285253 RVA: 0x0114B4E4 File Offset: 0x011496E4
		protected override bool OnCheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			if (this.ActionMap.ContainsKey(actionName))
			{
				return true;
			}
			string inputDistributeTag = inputActionHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true) || this.AllowActionNameSet.Contains(actionName);
		}

		// Token: 0x06045A46 RID: 285254 RVA: 0x0114B538 File Offset: 0x01149738
		protected override bool OnCheckAxisInAllowFightAxisNameList(string axisName, InputAxisHandle inputAxisHandle)
		{
			if (this.AxisMap.ContainsKey(axisName))
			{
				return true;
			}
			string inputDistributeTag = inputAxisHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true);
		}

		// Token: 0x04024589 RID: 148873
		private readonly Dictionary<string, EInputAction> ActionMap;

		// Token: 0x0402458A RID: 148874
		private readonly Dictionary<string, EInputAxis> AxisMap;

		// Token: 0x0402458B RID: 148875
		private readonly HashSet<string> AllowActionNameSet;

		// Token: 0x0402458C RID: 148876
		private readonly string[] MatchInputDistributeTag;
	}
}
