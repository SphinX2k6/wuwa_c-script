using System;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058DC RID: 22748
	public class InstanceDungeonEntranceFlowLordGymThird5 : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x06039CC0 RID: 236736 RVA: 0x00DBAEB8 File Offset: 0x00DB90B8
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				if (LordGymController.Instance.IsInLordGymDungeon())
				{
					LordGymDifficultySelectViewParam param = new LordGymDifficultySelectViewParam
					{
						LordEntranceSetId = 200104,
						LordEntranceId = LordGymModel.Instance.EntranceEntityId,
						IsPlaySpecialSequence = true
					};
					TowerController.Instance.ClearAllHatredInTower();
					UiManager.Instance.OpenView(EUiViewName.LordGymThird5DifficultySelectView, param, null);
					return;
				}
				if (LordGymModel.Instance.SkipBossSelectInFlow)
				{
					LordGymModel.Instance.SkipBossSelectInFlow = false;
					LordGymDifficultySelectViewParam param2 = new LordGymDifficultySelectViewParam
					{
						LordEntranceSetId = 200104,
						LordEntranceId = LordGymModel.Instance.EntranceEntityId,
						IsPlaySpecialSequence = true
					};
					UiManager.Instance.OpenView(EUiViewName.LordGymThird5DifficultySelectView, param2, null);
					return;
				}
				LordGymLordEntranceSelectViewParam param3 = new LordGymLordEntranceSelectViewParam
				{
					EntranceSetId = 200104,
					IsPlaySpecialSequence = new bool?(true),
					NeedBlackScreenAnim = false
				};
				UiManager.Instance.OpenView(EUiViewName.LordGymThird5LittleLoadingView, param3, null);
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
				InstanceDungeonEntranceController.Instance.EnterInstanceDungeon().ContinueWith(delegate(bool bSuccess)
				{
					FormationController.Instance.CloseBattleTeamView();
					if (bSuccess)
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
