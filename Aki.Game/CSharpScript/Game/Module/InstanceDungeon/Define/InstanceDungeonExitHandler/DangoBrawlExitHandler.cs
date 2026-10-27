using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058E9 RID: 22761
	public class DangoBrawlExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D06 RID: 236806 RVA: 0x00DBB784 File Offset: 0x00DB9984
		public override bool Checker()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.Value.InstSubType == 58;
		}

		// Token: 0x06039D07 RID: 236807 RVA: 0x00DBB7D8 File Offset: 0x00DB99D8
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			EDangoBrawlFsmState? edangoBrawlFsmState;
			if (battleManager == null)
			{
				edangoBrawlFsmState = null;
			}
			else
			{
				DangoBrawlFsm battleFsm = battleManager.GetBattleFsm();
				edangoBrawlFsmState = ((battleFsm != null) ? new EDangoBrawlFsmState?(battleFsm.GetCurrentStateType()) : null);
			}
			EDangoBrawlFsmState? edangoBrawlFsmState2 = edangoBrawlFsmState;
			if (edangoBrawlFsmState2.GetValueOrDefault() == EDangoBrawlFsmState.RoundSettle)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlGeneral_1028", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlPauseView, EDangoBrawlPauseViewFrom.BattlePanel, null);
		}
	}
}
