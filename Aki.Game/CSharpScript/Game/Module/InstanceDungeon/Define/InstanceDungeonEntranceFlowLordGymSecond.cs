using System;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058DB RID: 22747
	public class InstanceDungeonEntranceFlowLordGymSecond : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x06039CBC RID: 236732 RVA: 0x00DBADF4 File Offset: 0x00DB8FF4
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				if (LordGymController.Instance.IsInLordGymDungeon())
				{
					TowerController.Instance.ClearAllHatredInTower();
					LordGymDifficultySelectViewParam param = new LordGymDifficultySelectViewParam
					{
						LordEntranceSetId = 200102,
						LordEntranceId = LordGymModel.Instance.EntranceEntityId,
						IsPlaySpecialSequence = false
					};
					UiManager.Instance.OpenView(EUiViewName.LordGymSecondDifficultySelectView, param, null);
					return;
				}
				if (LordGymModel.Instance.SkipBossSelectInFlow)
				{
					LordGymModel.Instance.SkipBossSelectInFlow = false;
					LordGymDifficultySelectViewParam param2 = new LordGymDifficultySelectViewParam
					{
						LordEntranceSetId = 200102,
						LordEntranceId = LordGymModel.Instance.EntranceEntityId,
						IsPlaySpecialSequence = false
					};
					UiManager.Instance.OpenView(EUiViewName.LordGymSecondDifficultySelectView, param2, null);
					return;
				}
				LordGymLordEntranceSelectViewParam param3 = new LordGymLordEntranceSelectViewParam
				{
					EntranceSetId = 200102,
					IsPlaySpecialSequence = new bool?(false),
					NeedBlackScreenAnim = false
				};
				UiManager.Instance.OpenView(EUiViewName.LordGymSecondBossSelectView, param3, null);
			});
			base.AddStep(delegate
			{
				FormationController.Instance.OpenBattleTeamView(InstanceDungeonEntranceModel.Instance.InstanceId, false, true, true, null);
			});
			base.AddStep(delegate
			{
				if (!UiManager.Instance.IsViewOpen(EUiViewName.BattleTeam2DView))
				{
					base.RevertStep();
					return;
				}
				InstanceDungeonEntranceController.Instance.EnterInstanceDungeon().ContinueWith(delegate(bool result)
				{
					FormationController.Instance.CloseBattleTeamView();
					if (result)
					{
						base.Reset();
						return;
					}
					base.RevertStep();
				});
			});
		}
	}
}
