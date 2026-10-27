using System;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058DD RID: 22749
	public class InstanceDungeonEntranceFlowMowingRisk : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x06039CC4 RID: 236740 RVA: 0x00DBAF7C File Offset: 0x00DB917C
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				MowingRiskInstanceDungeonViewModel param = new MowingRiskInstanceDungeonViewModel();
				UiManager.Instance.OpenView(EUiViewName.InstanceDungeonEntranceView, param, null);
			});
			base.AddStep(delegate
			{
				FormationController.Instance.OpenBattleTeamView(InstanceDungeonEntranceModel.Instance.InstanceId, false, true, false, null);
			});
			base.AddStep(delegate
			{
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
