using System;
using System.Collections.Generic;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048BA RID: 18618
	public class InstanceDungeonEntranceFlowTrapDefense : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x0602EBF9 RID: 191481 RVA: 0x00D0A1E4 File Offset: 0x00D083E4
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				BaseInstanceDungeonViewModel param = new BaseInstanceDungeonViewModel();
				UiManager.Instance.OpenView(EUiViewName.InstanceDungeonEntranceView, param, null);
			});
			base.AddStep(delegate
			{
				FormationController.Instance.OpenBattleTeamView(InstanceDungeonEntranceModel.Instance.InstanceId, false, true, false, null);
			});
			base.AddStep(delegate
			{
				int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
				TrapDefenseLevelData valueOrDefault = TrapDefenseModel.Instance.LevelDataFromInstIdMap.GetValueOrDefault(instanceId);
				int configId = (valueOrDefault != null) ? valueOrDefault.Config.Id : 1;
				InstanceDungeonModel.Instance.InstanceEnterContentText.TrapDefenseCtx = new TrapDefenseCtx
				{
					ConfigId = configId,
					NewChallenge = false
				};
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
