using System;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x0200688A RID: 26762
	public class DangoBrawlFightingState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x06042CED RID: 273645 RVA: 0x01043438 File Offset: 0x01041638
		public override void Enter(EDangoBrawlFsmState? prev)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (prev.GetValueOrDefault() == EDangoBrawlFsmState.ShopState || prev.GetValueOrDefault() == EDangoBrawlFsmState.LoadingBattle)
			{
				return;
			}
			if (battleManager != null)
			{
				battleManager.InitTimerSystem();
			}
			this.ReportReady = (battleManager != null && battleManager.CheckDangoReady());
			if (this.ReportReady)
			{
				DangoBrawlModel.Instance.ApplyPlayRate();
			}
		}

		// Token: 0x06042CEE RID: 273646 RVA: 0x01043494 File Offset: 0x01041694
		public override UniTask EnterAsync(EDangoBrawlFsmState? prev)
		{
			DangoBrawlFightingState.<EnterAsync>d__2 <EnterAsync>d__;
			<EnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnterAsync>d__.prev = prev;
			<EnterAsync>d__.<>1__state = -1;
			<EnterAsync>d__.<>t__builder.Start<DangoBrawlFightingState.<EnterAsync>d__2>(ref <EnterAsync>d__);
			return <EnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042CEF RID: 273647 RVA: 0x010434D8 File Offset: 0x010416D8
		public void SetReportReady()
		{
			if (this.ReportReady)
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			this.ReportReady = (battleManager != null && battleManager.CheckDangoReady());
			if (this.ReportReady)
			{
				if (battleManager != null)
				{
					battleManager.InitTimerSystem();
				}
				DangoBrawlModel.Instance.ApplyPlayRate();
			}
		}

		// Token: 0x06042CF0 RID: 273648 RVA: 0x01043527 File Offset: 0x01041727
		public override void Tick(float delta)
		{
			if (!this.IsTickValid())
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			battleManager.FightingClock.Tick(delta);
			if (battleManager == null)
			{
				return;
			}
			DangoBrawlBattleReportPlayer battleReportPlayer = battleManager.BattleReportPlayer;
			if (battleReportPlayer == null)
			{
				return;
			}
			battleReportPlayer.Tick(delta);
		}

		// Token: 0x06042CF1 RID: 273649 RVA: 0x0104355F File Offset: 0x0104175F
		public override void Exit(EDangoBrawlFsmState? next)
		{
			this.ReportReady = false;
		}

		// Token: 0x06042CF2 RID: 273650 RVA: 0x01043568 File Offset: 0x01041768
		protected bool IsTickValid()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			return battleManager != null && battleManager.CheckDangoReady();
		}

		// Token: 0x04022C42 RID: 142402
		protected bool ReportReady;
	}
}
