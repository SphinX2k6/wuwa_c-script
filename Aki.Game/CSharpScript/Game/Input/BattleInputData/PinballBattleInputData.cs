using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input.BattleInputData
{
	// Token: 0x02006161 RID: 24929
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleInputData : BattleInputData
	{
		// Token: 0x0603BBEE RID: 244718 RVA: 0x010F5079 File Offset: 0x010F3279
		public PinballBattleInputData() : base(EInputDataType.PinballBattle, EInputBindingType.Original)
		{
		}

		// Token: 0x0603BBEF RID: 244719 RVA: 0x010F50B5 File Offset: 0x010F32B5
		protected override Dictionary<string, EInputAction> OnGetActionMap()
		{
			return this.ActionMap;
		}

		// Token: 0x0603BBF0 RID: 244720 RVA: 0x010F50BD File Offset: 0x010F32BD
		protected override Dictionary<string, EInputAxis> OnGetAxisMap()
		{
			return this.AxisMap;
		}

		// Token: 0x0603BBF1 RID: 244721 RVA: 0x010F50C8 File Offset: 0x010F32C8
		protected override bool OnCheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			if (this.ActionMap.ContainsKey(actionName))
			{
				return true;
			}
			string inputDistributeTag = inputActionHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true);
		}

		// Token: 0x0603BBF2 RID: 244722 RVA: 0x010F510C File Offset: 0x010F330C
		protected override bool OnCheckAxisInAllowFightAxisNameList(string axisName, InputAxisHandle inputAxisHandle)
		{
			if (this.AxisMap.ContainsKey(axisName))
			{
				return true;
			}
			string inputDistributeTag = inputAxisHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || !InputDistributeModel.Instance.IsTagMatchInputDistributeTags(inputDistributeTag, this.MatchInputDistributeTag, true);
		}

		// Token: 0x0401F83B RID: 129083
		private readonly Dictionary<string, EInputAction> ActionMap = new Dictionary<string, EInputAction>();

		// Token: 0x0401F83C RID: 129084
		private readonly Dictionary<string, EInputAxis> AxisMap = new Dictionary<string, EInputAxis>();

		// Token: 0x0401F83D RID: 129085
		private readonly string[] MatchInputDistributeTag = new string[]
		{
			"FightInputRoot.FightInput.ActionInput",
			"FightInputRoot.FightInput.AxisInput"
		};
	}
}
