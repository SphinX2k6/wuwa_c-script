using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input.BattleInputData
{
	// Token: 0x02006FE3 RID: 28643
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseInputData : BattleInputData
	{
		// Token: 0x06045A4C RID: 285260 RVA: 0x0114B6E8 File Offset: 0x011498E8
		public TrapDefenseInputData()
		{
			Dictionary<string, EInputAction> dictionary = new Dictionary<string, EInputAction>();
			dictionary["塔防跳跃"] = EInputAction.跳跃;
			dictionary["塔防走跑切换"] = EInputAction.走跑切换;
			dictionary["塔防射击"] = EInputAction.攻击;
			dictionary["塔防冲刺"] = EInputAction.闪避;
			dictionary["塔防道具"] = EInputAction.幻象1;
			this.ActionMap = dictionary;
			Dictionary<string, EInputAxis> dictionary2 = new Dictionary<string, EInputAxis>();
			dictionary2["LookUp"] = EInputAxis.LookUp;
			dictionary2["Turn"] = EInputAxis.Turn;
			dictionary2["TrapDefenseMoveForward"] = EInputAxis.MoveForward;
			dictionary2["TrapDefenseMoveRight"] = EInputAxis.MoveRight;
			dictionary2["TrapDefenseZoom"] = EInputAxis.Zoom;
			dictionary2["WheelAxis"] = EInputAxis.WheelAxis;
			this.AxisMap = dictionary2;
			this.AllowActionNameList = new string[]
			{
				"塔防轮盘",
				"塔防道具",
				"塔防旋转",
				"塔防回收机关"
			};
			this.MatchInputDistributeTag = new string[]
			{
				"FightInputRoot.FightInput.ActionInput",
				"FightInputRoot.FightInput.AxisInput",
				"UiInputRoot.ShortcutKeyTag"
			};
			base..ctor(EInputDataType.TrapDefense, EInputBindingType.Original);
		}

		// Token: 0x06045A4D RID: 285261 RVA: 0x0114B813 File Offset: 0x01149A13
		protected override Dictionary<string, EInputAction> OnGetActionMap()
		{
			return this.ActionMap;
		}

		// Token: 0x06045A4E RID: 285262 RVA: 0x0114B81B File Offset: 0x01149A1B
		protected override Dictionary<string, EInputAxis> OnGetAxisMap()
		{
			return this.AxisMap;
		}

		// Token: 0x06045A4F RID: 285263 RVA: 0x0114B824 File Offset: 0x01149A24
		protected override bool OnCheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			if (this.ActionMap.ContainsKey(actionName))
			{
				return true;
			}
			string inputDistributeTag = inputActionHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true) || Array.IndexOf<string>(this.AllowActionNameList, actionName) >= 0;
		}

		// Token: 0x06045A50 RID: 285264 RVA: 0x0114B878 File Offset: 0x01149A78
		protected override bool OnCheckAxisInAllowFightAxisNameList(string axisName, InputAxisHandle inputAxisHandle)
		{
			if (this.AxisMap.ContainsKey(axisName))
			{
				return true;
			}
			string inputDistributeTag = inputAxisHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true);
		}

		// Token: 0x04024591 RID: 148881
		private readonly Dictionary<string, EInputAction> ActionMap;

		// Token: 0x04024592 RID: 148882
		private readonly Dictionary<string, EInputAxis> AxisMap;

		// Token: 0x04024593 RID: 148883
		private readonly string[] AllowActionNameList;

		// Token: 0x04024594 RID: 148884
		private readonly string[] MatchInputDistributeTag;
	}
}
