using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058F8 RID: 22776
	public class RoguelikeExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D32 RID: 236850 RVA: 0x00DBC1DC File Offset: 0x00DBA3DC
		public override bool Checker()
		{
			return RoguelikeModel.Instance.CheckInRoguelike() || WeeklyRogueModel.Instance.CheckIsInWeeklyRogue();
		}

		// Token: 0x06039D33 RID: 236851 RVA: 0x00DBC1F8 File Offset: 0x00DBA3F8
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

		// Token: 0x06039D34 RID: 236852 RVA: 0x00DBC25D File Offset: 0x00DBA45D
		private void RoguelikeNormalExit()
		{
			UiManager.Instance.OpenView(EUiViewName.RoguelikeExitTips, null, null);
		}

		// Token: 0x06039D35 RID: 236853 RVA: 0x00DBC270 File Offset: 0x00DBA470
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

		// Token: 0x06039D36 RID: 236854 RVA: 0x00DBC2FB File Offset: 0x00DBA4FB
		private void WeeklyRogueExit()
		{
			UiManager.Instance.OpenView(EUiViewName.WeeklyRogueExitTips, null, null);
		}
	}
}
