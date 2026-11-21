using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x020057DF RID: 22495
	public class DangoBrawlRoundSettleState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x0603785B RID: 227419 RVA: 0x00F84D18 File Offset: 0x00F82F18
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

		// Token: 0x0603785C RID: 227420 RVA: 0x00F84DA8 File Offset: 0x00F82FA8
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

		// Token: 0x0603785D RID: 227421 RVA: 0x00F84DEE File Offset: 0x00F82FEE
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

		// Token: 0x0401D49F RID: 119967
		protected bool? IsFinalRoundRecord;
	}
}
