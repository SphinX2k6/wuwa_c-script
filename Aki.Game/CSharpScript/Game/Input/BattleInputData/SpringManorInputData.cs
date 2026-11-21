using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input.BattleInputData
{
	// Token: 0x02006162 RID: 24930
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorInputData : BattleInputData
	{
		// Token: 0x0603BBF3 RID: 244723 RVA: 0x010F5150 File Offset: 0x010F3350
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

		// Token: 0x0603BBF4 RID: 244724 RVA: 0x010F52C6 File Offset: 0x010F34C6
		protected override Dictionary<string, EInputAction> OnGetActionMap()
		{
			return this.ActionMap;
		}

		// Token: 0x0603BBF5 RID: 244725 RVA: 0x010F52CE File Offset: 0x010F34CE
		protected override Dictionary<string, EInputAxis> OnGetAxisMap()
		{
			return this.AxisMap;
		}

		// Token: 0x0603BBF6 RID: 244726 RVA: 0x010F52D8 File Offset: 0x010F34D8
		protected override bool OnCheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			if (this.ActionMap.ContainsKey(actionName))
			{
				return true;
			}
			string inputDistributeTag = inputActionHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true) || this.AllowActionNameSet.Contains(actionName);
		}

		// Token: 0x0603BBF7 RID: 244727 RVA: 0x010F532C File Offset: 0x010F352C
		protected override bool OnCheckAxisInAllowFightAxisNameList(string axisName, InputAxisHandle inputAxisHandle)
		{
			if (this.AxisMap.ContainsKey(axisName))
			{
				return true;
			}
			string inputDistributeTag = inputAxisHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true);
		}

		// Token: 0x0401F83E RID: 129086
		private readonly Dictionary<string, EInputAction> ActionMap;

		// Token: 0x0401F83F RID: 129087
		private readonly Dictionary<string, EInputAxis> AxisMap;

		// Token: 0x0401F840 RID: 129088
		private readonly HashSet<string> AllowActionNameSet;

		// Token: 0x0401F841 RID: 129089
		private readonly string[] MatchInputDistributeTag;
	}
}
