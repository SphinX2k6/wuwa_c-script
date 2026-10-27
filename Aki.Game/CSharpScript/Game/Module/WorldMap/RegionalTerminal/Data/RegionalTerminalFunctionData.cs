using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data
{
	// Token: 0x0200485B RID: 18523
	public class RegionalTerminalFunctionData : RegionalTerminalGameplayData
	{
		// Token: 0x060307A7 RID: 198567 RVA: 0x00B41E9A File Offset: 0x00B4009A
		[NullableContext(2)]
		public override void TerminalFunction(Action<bool> callback = null)
		{
			FunctionController.Instance.OpenFunctionRelateView((EFunctionType)this.GameplayId);
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x060307A8 RID: 198568 RVA: 0x00B41EB6 File Offset: 0x00B400B6
		public override void BarFunction()
		{
			if (this.GetLockState())
			{
				RegionalTerminalController.Instance.OpenTerminalOverviewView(this.Id);
				return;
			}
			this.TerminalFunction(null);
		}

		// Token: 0x060307A9 RID: 198569 RVA: 0x00B41ED8 File Offset: 0x00B400D8
		public override bool GetShowState()
		{
			return FunctionModel.Instance.IsShow(this.GameplayId);
		}

		// Token: 0x060307AA RID: 198570 RVA: 0x00B41EEC File Offset: 0x00B400EC
		public override ERedDotName? GetRedDotName()
		{
			if (this.GetLockState())
			{
				return null;
			}
			return FunctionModel.Instance.GetFunctionItemRedDotName(this.GameplayId);
		}

		// Token: 0x060307AB RID: 198571 RVA: 0x00B41F1B File Offset: 0x00B4011B
		public override int GetRedDotId()
		{
			return 0;
		}

		// Token: 0x060307AC RID: 198572 RVA: 0x00B41F20 File Offset: 0x00B40120
		public override bool GetRedDotState()
		{
			if (this.GetLockState())
			{
				return false;
			}
			ERedDotName? redDotName = this.GetRedDotName();
			if (redDotName == null)
			{
				return false;
			}
			RedDotBase redDot = RedDotModel.Instance.GetRedDot(redDotName.Value);
			return redDot != null && redDot.IsRedDotActive();
		}

		// Token: 0x060307AD RID: 198573 RVA: 0x00B41F6B File Offset: 0x00B4016B
		public override bool GetLockState()
		{
			return !FunctionModel.Instance.IsOpen(this.GameplayId);
		}

		// Token: 0x060307AE RID: 198574 RVA: 0x00B41F80 File Offset: 0x00B40180
		[NullableContext(1)]
		public override IRegionalTerminalViewParams GetViewParams()
		{
			FunctionCondition? functionCondition = FunctionConfig.Instance.GetFunctionCondition(this.GameplayId);
			bool lockState = this.GetLockState();
			return new RegionalTerminalViewParams
			{
				ShowLockPanel = lockState,
				ShowButton = !lockState,
				LockClickFunc = new Action(this.OpenFunctionConditionView),
				LockTxtId = ((functionCondition.Value.OpenConditionId > 0) ? (LevelGeneralCommons.GetConditionGroupHintText(functionCondition.Value.OpenConditionId) ?? "") : ""),
				ButtonTxtId = base.GetGameplayConfig().UnlockButtonText
			};
		}

		// Token: 0x060307AF RID: 198575 RVA: 0x00B42020 File Offset: 0x00B40220
		private void OpenFunctionConditionView()
		{
			List<IActivityConditionData> list = new List<IActivityConditionData>();
			int openConditionId = FunctionConfig.Instance.GetFunctionCondition(this.GameplayId).Value.OpenConditionId;
			foreach (int conditionId in ConditionConfig.Instance.GetGroupConditionIds(openConditionId))
			{
				Condition? conditionConfig = ConditionConfig.Instance.GetConditionConfig(conditionId);
				if (conditionConfig != null)
				{
					int accessType = -1;
					if (!string.IsNullOrEmpty(conditionConfig.Value.Description))
					{
						if (conditionConfig.Value.AccessId > 0)
						{
							AccessPath? configById = GetWayConfig.Instance.GetConfigById(conditionConfig.Value.AccessId);
							accessType = ((configById != null) ? configById.GetValueOrDefault().SkipName : -1);
						}
						ActivityConditionData item = new ActivityConditionData
						{
							ConditionId = conditionId,
							ConditionTextId = conditionConfig.Value.Description,
							IsFinished = RegionalTerminalModel.Instance.GetFuncIdConditionFinishedState(this.GameplayId, conditionId),
							AccessId = conditionConfig.Value.AccessId,
							AccessType = accessType
						};
						list.Add(item);
					}
				}
			}
			ConditionGroupData param = new ConditionGroupData(openConditionId, list, "", false);
			UiManager.Instance.OpenView(EUiViewName.CommonConditionView, param, null);
		}
	}
}
