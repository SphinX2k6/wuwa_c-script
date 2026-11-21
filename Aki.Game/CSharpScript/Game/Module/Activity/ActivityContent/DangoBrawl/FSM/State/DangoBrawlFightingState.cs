using System;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x020057DA RID: 22490
	public class DangoBrawlFightingState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x06037845 RID: 227397 RVA: 0x00F849B8 File Offset: 0x00F82BB8
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

		// Token: 0x06037846 RID: 227398 RVA: 0x00F84A14 File Offset: 0x00F82C14
		public override UniTask EnterAsync(EDangoBrawlFsmState? prev)
		{
			DangoBrawlFightingState.<EnterAsync>d__2 <EnterAsync>d__;
			<EnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnterAsync>d__.prev = prev;
			<EnterAsync>d__.<>1__state = -1;
			<EnterAsync>d__.<>t__builder.Start<DangoBrawlFightingState.<EnterAsync>d__2>(ref <EnterAsync>d__);
			return <EnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037847 RID: 227399 RVA: 0x00F84A58 File Offset: 0x00F82C58
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

		// Token: 0x06037848 RID: 227400 RVA: 0x00F84AA7 File Offset: 0x00F82CA7
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

		// Token: 0x06037849 RID: 227401 RVA: 0x00F84ADF File Offset: 0x00F82CDF
		public override void Exit(EDangoBrawlFsmState? next)
		{
			this.ReportReady = false;
		}

		// Token: 0x0603784A RID: 227402 RVA: 0x00F84AE8 File Offset: 0x00F82CE8
		protected bool IsTickValid()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			return battleManager != null && battleManager.CheckDangoReady();
		}

		// Token: 0x0401D49E RID: 119966
		protected bool ReportReady;
	}
}
