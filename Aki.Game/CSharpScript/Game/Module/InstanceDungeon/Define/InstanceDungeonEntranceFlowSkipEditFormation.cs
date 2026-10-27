using System;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058E0 RID: 22752
	public class InstanceDungeonEntranceFlowSkipEditFormation : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x06039CCE RID: 236750 RVA: 0x00DBB158 File Offset: 0x00DB9358
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				UiManager.Instance.OpenView(EUiViewName.InstanceDungeonEntranceView, null, null);
			});
			base.AddStep(delegate
			{
				InstanceDungeonEntranceController.Instance.EnterInstanceDungeonByAutoRole().ContinueWith(delegate(bool result)
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
