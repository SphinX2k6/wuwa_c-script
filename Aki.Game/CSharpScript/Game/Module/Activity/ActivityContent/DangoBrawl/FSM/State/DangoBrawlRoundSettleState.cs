using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x0200688F RID: 26767
	public class DangoBrawlRoundSettleState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x06042D03 RID: 273667 RVA: 0x01043798 File Offset: 0x01041998
		public override void Enter(EDangoBrawlFsmState? prev)
		{
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlEnterRoundSettle);
			DangoBrawlModel.Instance.ResetPlayRate();
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "[RoundSettleState] BattleManager 为空，无法决定下一个状态", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			bool valueOrDefault = battleManager.IsWin.GetValueOrDefault();
			UiManager.Instance.OpenView(valueOrDefault ? EUiViewName.DangoBrawlRoundSuccessSettleView : EUiViewName.DangoBrawlRoundFailureSettleView, null, null);
			this.IsFinalRoundRecord = new bool?(battleManager.IsFinalRound());
		}

		// Token: 0x06042D04 RID: 273668 RVA: 0x01043828 File Offset: 0x01041A28
		public override void Tick(float delta)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (((battleManager != null) ? battleManager.FightingClock : null) == null)
			{
				return;
			}
			battleManager.FightingClock.Tick(delta);
			DangoBrawlBattleReportPlayer battleReportPlayer = battleManager.BattleReportPlayer;
			if (battleReportPlayer == null)
			{
				return;
			}
			battleReportPlayer.Tick(delta);
		}

		// Token: 0x06042D05 RID: 273669 RVA: 0x0104386E File Offset: 0x01041A6E
		public override void Exit(EDangoBrawlFsmState? next)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager != null)
			{
				battleManager.ClearTimerSystem();
			}
			if (battleManager == null)
			{
				return;
			}
			battleManager.DestroyBattleReportPlayer();
		}

		// Token: 0x04022C43 RID: 142403
		protected bool? IsFinalRoundRecord;
	}
}
