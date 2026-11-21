using System;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048B6 RID: 18614
	public class InstanceDungeonEntranceFlowNormal : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x0602EBEB RID: 191467 RVA: 0x00D09F80 File Offset: 0x00D08180
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				InstanceDungeonViewModelBase param;
				if (InstanceDungeonEntranceModel.Instance.EntranceId == 9000)
				{
					param = new SolarSpeedInstanceDungeonViewModel();
				}
				else
				{
					param = new BaseInstanceDungeonViewModel();
				}
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
