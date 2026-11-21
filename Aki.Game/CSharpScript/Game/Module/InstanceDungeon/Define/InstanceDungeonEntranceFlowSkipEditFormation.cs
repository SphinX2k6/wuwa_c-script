using System;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048B8 RID: 18616
	public class InstanceDungeonEntranceFlowSkipEditFormation : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x0602EBF1 RID: 191473 RVA: 0x00D0A0B0 File Offset: 0x00D082B0
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
