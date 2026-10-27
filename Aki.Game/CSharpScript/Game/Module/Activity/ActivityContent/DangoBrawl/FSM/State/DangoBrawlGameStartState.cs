using System;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x0200688D RID: 26765
	public class DangoBrawlGameStartState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x06042CFB RID: 273659 RVA: 0x01043614 File Offset: 0x01041814
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

		// Token: 0x06042CFC RID: 273660 RVA: 0x0104366F File Offset: 0x0104186F
		public override void Exit(EDangoBrawlFsmState? next)
		{
		}
	}
}
