using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048D6 RID: 18646
	public class WheelTowerExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC6B RID: 191595 RVA: 0x00D0B5DC File Offset: 0x00D097DC
		public override bool Checker()
		{
			return WheelTowerModel.Instance.CheckInInstanceDungeon();
		}

		// Token: 0x0602EC6C RID: 191596 RVA: 0x00D0B5E8 File Offset: 0x00D097E8
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			bool flag = UiManager.Instance.IsViewOpen(EUiViewName.WheelTowerModeSelectView);
			bool flag2 = UiManager.Instance.IsViewOpen(EUiViewName.WheelTowerMainView);
			if (flag || flag2)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.WheelTowerReturnWorldConfirm);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.WheelTowerInstanceExitConfirm);
			confirmBoxDataNew2.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew2.FunctionMap[1] = delegate()
			{
				WheelTowerController.Instance.SetBanTimeStop(false);
				WheelTowerController.Instance.RequestEndChallenge(delegate
				{
					int selectedRound = WheelTowerModel.Instance.SelectedRound;
					UiManager.Instance.OpenView(EUiViewName.WheelTowerPrepareView, selectedRound, null);
				});
			};
			confirmBoxDataNew2.FunctionMap[2] = delegate()
			{
				WheelTowerController.Instance.RequestSelectedRoundChallenge();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
		}
	}
}
