using System;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x020057DD RID: 22493
	public class DangoBrawlGameStartState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x06037853 RID: 227411 RVA: 0x00F84B94 File Offset: 0x00F82D94
		public override void Enter(EDangoBrawlFsmState? prev)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "[GameStartState] BattleManager 为空，无法决定下一个状态", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EDangoBrawlFsmState stateType = battleManager.IsRestoreFight ? EDangoBrawlFsmState.LoadingBattle : EDangoBrawlFsmState.ShopState;
			DangoBrawlFsm battleFsm = battleManager.GetBattleFsm();
			if (battleFsm == null)
			{
				return;
			}
			battleFsm.ChangeState(stateType);
		}

		// Token: 0x06037854 RID: 227412 RVA: 0x00F84BEF File Offset: 0x00F82DEF
		public override void Exit(EDangoBrawlFsmState? next)
		{
		}
	}
}
