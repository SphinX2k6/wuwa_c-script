using System;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058DE RID: 22750
	public class InstanceDungeonEntranceFlowNormal : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x06039CC8 RID: 236744 RVA: 0x00DBB028 File Offset: 0x00DB9228
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
