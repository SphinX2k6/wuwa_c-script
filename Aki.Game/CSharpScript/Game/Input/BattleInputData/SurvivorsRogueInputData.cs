using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input.BattleInputData
{
	// Token: 0x02006FE2 RID: 28642
	[NullableContext(1)]
	[Nullable(0)]
	public class SurvivorsRogueInputData : BattleInputData
	{
		// Token: 0x06045A47 RID: 285255 RVA: 0x0114B57C File Offset: 0x0114977C
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

		// Token: 0x06045A48 RID: 285256 RVA: 0x0114B63F File Offset: 0x0114983F
		protected override Dictionary<string, EInputAction> OnGetActionMap()
		{
			return this.ActionMap;
		}

		// Token: 0x06045A49 RID: 285257 RVA: 0x0114B647 File Offset: 0x01149847
		protected override Dictionary<string, EInputAxis> OnGetAxisMap()
		{
			return this.AxisMap;
		}

		// Token: 0x06045A4A RID: 285258 RVA: 0x0114B650 File Offset: 0x01149850
		protected override bool OnCheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			if (this.ActionMap.ContainsKey(actionName))
			{
				return true;
			}
			string inputDistributeTag = inputActionHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true) || Array.IndexOf<string>(this.AllowActionNameList, actionName) >= 0;
		}

		// Token: 0x06045A4B RID: 285259 RVA: 0x0114B6A4 File Offset: 0x011498A4
		protected override bool OnCheckAxisInAllowFightAxisNameList(string axisName, InputAxisHandle inputAxisHandle)
		{
			if (this.AxisMap.ContainsKey(axisName))
			{
				return true;
			}
			string inputDistributeTag = inputAxisHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true);
		}

		// Token: 0x0402458D RID: 148877
		private readonly Dictionary<string, EInputAction> ActionMap;

		// Token: 0x0402458E RID: 148878
		private readonly Dictionary<string, EInputAxis> AxisMap;

		// Token: 0x0402458F RID: 148879
		private readonly string[] AllowActionNameList;

		// Token: 0x04024590 RID: 148880
		private readonly string[] MatchInputDistributeTag;
	}
}
