using System;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058E1 RID: 22753
	public class InstanceDungeonEntranceFlowTowerDefense : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x06039CD2 RID: 236754 RVA: 0x00DBB1D4 File Offset: 0x00DB93D4
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
