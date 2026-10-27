using System;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058D9 RID: 22745
	public class InstanceDungeonEntranceFlowLordGym : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x06039CB4 RID: 236724 RVA: 0x00DBAC6C File Offset: 0x00DB8E6C
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				if (LordGymController.Instance.IsInLordGymDungeon())
				{
					LordGymDifficultySelectViewParam param = new LordGymDifficultySelectViewParam
					{
						LordEntranceSetId = 200103,
						LordEntranceId = LordGymModel.Instance.EntranceEntityId,
						IsPlaySpecialSequence = true
					};
					TowerController.Instance.ClearAllHatredInTower();
					UiManager.Instance.OpenView(EUiViewName.LordGymThirdDifficultySelectView, param, null);
					return;
				}
				if (LordGymModel.Instance.SkipBossSelectInFlow)
				{
					LordGymModel.Instance.SkipBossSelectInFlow = false;
					LordGymDifficultySelectViewParam param2 = new LordGymDifficultySelectViewParam
					{
						LordEntranceSetId = 200103,
						LordEntranceId = LordGymModel.Instance.EntranceEntityId,
						IsPlaySpecialSequence = true
					};
					UiManager.Instance.OpenView(EUiViewName.LordGymThirdDifficultySelectView, param2, null);
					return;
				}
				LordGymLordEntranceSelectViewParam param3 = new LordGymLordEntranceSelectViewParam
				{
					EntranceSetId = 200103,
					IsPlaySpecialSequence = new bool?(true),
					NeedBlackScreenAnim = false
				};
				UiManager.Instance.OpenView(EUiViewName.LordGymThirdBossSelectView, param3, null);
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
