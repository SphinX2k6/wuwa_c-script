using System;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058D6 RID: 22742
	public class InstanceDungeonEntranceFlowAttached : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x06039C9E RID: 236702 RVA: 0x00DBA564 File Offset: 0x00DB8764
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				MowingInstanceDungeonViewModel param = new MowingInstanceDungeonViewModel();
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
