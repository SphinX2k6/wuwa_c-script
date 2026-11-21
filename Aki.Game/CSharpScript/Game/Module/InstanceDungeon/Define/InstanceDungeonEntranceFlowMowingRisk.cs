using System;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048B5 RID: 18613
	public class InstanceDungeonEntranceFlowMowingRisk : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x0602EBE7 RID: 191463 RVA: 0x00D09ED4 File Offset: 0x00D080D4
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
