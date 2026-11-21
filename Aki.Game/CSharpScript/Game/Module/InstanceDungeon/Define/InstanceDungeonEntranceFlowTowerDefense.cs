using System;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048B9 RID: 18617
	public class InstanceDungeonEntranceFlowTowerDefense : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x0602EBF5 RID: 191477 RVA: 0x00D0A12C File Offset: 0x00D0832C
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				TowerDefenseController.Instance.SetIsUiFlowOpen(true);
				UiManager.Instance.OpenView(EUiViewName.TowerDefenseLevelView, null, null);
			});
			base.AddStep(delegate
			{
				FormationController.Instance.OpenBattleTeamView(InstanceDungeonEntranceModel.Instance.InstanceId, false, true, false, null);
				TowerDefenseController.Instance.SetPhantomViewOpened(false);
			});
			base.AddStep(delegate
			{
				TowerDefenseController.Instance.EnterTowerDefense().ContinueWith(delegate(bool result)
				{
					FormationController.Instance.CloseBattleTeamView();
					if (result)
					{
						base.Reset();
						TowerDefenseController.Instance.SetIsUiFlowOpen(false);
						return;
					}
					base.RevertStep();
				});
			});
		}
	}
}
