using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data
{
	// Token: 0x0200378C RID: 14220
	public class RegionalTerminalFunctionData : RegionalTerminalGameplayData
	{
		// Token: 0x06024F76 RID: 151414 RVA: 0x00A720DE File Offset: 0x00A702DE
		[NullableContext(2)]
		public override void TerminalFunction(Action<bool> callback = null)
		{
			FunctionController.Instance.OpenFunctionRelateView((EFunctionType)this.GameplayId);
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x06024F77 RID: 151415 RVA: 0x00A720FA File Offset: 0x00A702FA
		public override void BarFunction()
		{
			if (this.GetLockState())
			{
				RegionalTerminalController.Instance.OpenTerminalOverviewView(this.Id);
				return;
			}
			this.TerminalFunction(null);
		}

		// Token: 0x06024F78 RID: 151416 RVA: 0x00A7211C File Offset: 0x00A7031C
		public override bool GetShowState()
		{
			return FunctionModel.Instance.IsShow(this.GameplayId);
		}

		// Token: 0x06024F79 RID: 151417 RVA: 0x00A72130 File Offset: 0x00A70330
		public override ERedDotName? GetRedDotName()
		{
			if (this.GetLockState())
			{
				return null;
			}
			return FunctionModel.Instance.GetFunctionItemRedDotName(this.GameplayId);
		}

		// Token: 0x06024F7A RID: 151418 RVA: 0x00A7215F File Offset: 0x00A7035F
		public override int GetRedDotId()
		{
			return 0;
		}

		// Token: 0x06024F7B RID: 151419 RVA: 0x00A72164 File Offset: 0x00A70364
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

		// Token: 0x06024F7C RID: 151420 RVA: 0x00A721AF File Offset: 0x00A703AF
		public override bool GetLockState()
		{
			return !FunctionModel.Instance.IsOpen(this.GameplayId);
		}

		// Token: 0x06024F7D RID: 151421 RVA: 0x00A721C4 File Offset: 0x00A703C4
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

		// Token: 0x06024F7E RID: 151422 RVA: 0x00A72264 File Offset: 0x00A70464
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
