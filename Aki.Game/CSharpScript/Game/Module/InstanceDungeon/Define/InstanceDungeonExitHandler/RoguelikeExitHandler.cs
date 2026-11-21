using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048D0 RID: 18640
	public class RoguelikeExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC55 RID: 191573 RVA: 0x00D0B140 File Offset: 0x00D09340
		public override bool Checker()
		{
			return RoguelikeModel.Instance.CheckInRoguelike() || WeeklyRogueModel.Instance.CheckIsInWeeklyRogue();
		}

		// Token: 0x0602EC56 RID: 191574 RVA: 0x00D0B15C File Offset: 0x00D0935C
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			if (RoguelikeModel.Instance.CheckInRoguelike())
			{
				RogueChallengeModeType? rogueModeType = RoguelikeModel.Instance.RogueModeType;
				if (rogueModeType.GetValueOrDefault() == RogueChallengeModeType.NormalInst)
				{
					this.RoguelikeNormalExit();
					return;
				}
				if (rogueModeType.GetValueOrDefault() == RogueChallengeModeType.TowerTrial)
				{
					this.RoguelikeTowerTrialExit();
				}
				return;
			}
			else
			{
				if (WeeklyRogueModel.Instance.CheckIsInWeeklyRogue())
				{
					this.WeeklyRogueExit();
					return;
				}
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
				return;
			}
		}

		// Token: 0x0602EC57 RID: 191575 RVA: 0x00D0B1C1 File Offset: 0x00D093C1
		private void RoguelikeNormalExit()
		{
			UiManager.Instance.OpenView(EUiViewName.RoguelikeExitTips, null, null);
		}

		// Token: 0x0602EC58 RID: 191576 RVA: 0x00D0B1D4 File Offset: 0x00D093D4
		private void RoguelikeTowerTrialExit()
		{
			int instId = InstanceDungeonEntranceModel.Instance.InstanceId;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoguelikeBossChallengeExitConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				RoguelikeController.Instance.RoguelikeBossChallengeResultRequest(instId, null);
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				RoguelikeController.Instance.RoguelikeQuitRequest();
			};
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602EC59 RID: 191577 RVA: 0x00D0B25F File Offset: 0x00D0945F
		private void WeeklyRogueExit()
		{
			UiManager.Instance.OpenView(EUiViewName.WeeklyRogueExitTips, null, null);
		}
	}
}
