using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input.BattleInputData
{
	// Token: 0x02006FE0 RID: 28640
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleInputData : BattleInputData
	{
		// Token: 0x06045A3D RID: 285245 RVA: 0x0114B285 File Offset: 0x01149485
		public PinballBattleInputData() : base(EInputDataType.PinballBattle, EInputBindingType.Original)
		{
		}

		// Token: 0x06045A3E RID: 285246 RVA: 0x0114B2C1 File Offset: 0x011494C1
		protected override Dictionary<string, EInputAction> OnGetActionMap()
		{
			return this.ActionMap;
		}

		// Token: 0x06045A3F RID: 285247 RVA: 0x0114B2C9 File Offset: 0x011494C9
		protected override Dictionary<string, EInputAxis> OnGetAxisMap()
		{
			return this.AxisMap;
		}

		// Token: 0x06045A40 RID: 285248 RVA: 0x0114B2D4 File Offset: 0x011494D4
		protected override bool OnCheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			if (this.ActionMap.ContainsKey(actionName))
			{
				return true;
			}
			string inputDistributeTag = inputActionHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true);
		}

		// Token: 0x06045A41 RID: 285249 RVA: 0x0114B318 File Offset: 0x01149518
		protected override bool OnCheckAxisInAllowFightAxisNameList(string axisName, InputAxisHandle inputAxisHandle)
		{
			if (this.AxisMap.ContainsKey(axisName))
			{
				return true;
			}
			string inputDistributeTag = inputAxisHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true);
		}

		// Token: 0x04024586 RID: 148870
		private readonly Dictionary<string, EInputAction> ActionMap = new Dictionary<string, EInputAction>();

		// Token: 0x04024587 RID: 148871
		private readonly Dictionary<string, EInputAxis> AxisMap = new Dictionary<string, EInputAxis>();

		// Token: 0x04024588 RID: 148872
		private readonly string[] MatchInputDistributeTag = new string[]
		{
			"FightInputRoot.FightInput.ActionInput",
			"FightInputRoot.FightInput.AxisInput"
		};
	}
}
