using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200364A RID: 13898
	internal class WuWaGoTimeStopWait : IWuWaGoTimeStopParticipant
	{
		// Token: 0x060240CD RID: 147661 RVA: 0x00A3407B File Offset: 0x00A3227B
		public WuWaGoTimeStopWait(int durationMs)
		{
		}

		// Token: 0x170049AC RID: 18860
		// (get) Token: 0x060240CE RID: 147662 RVA: 0x00A34095 File Offset: 0x00A32295
		// (set) Token: 0x060240CF RID: 147663 RVA: 0x00A3409D File Offset: 0x00A3229D
		public bool PausedByTimeStop { get; set; }

		// Token: 0x060240D0 RID: 147664 RVA: 0x00A340A8 File Offset: 0x00A322A8
		public UniTask<EWuWaGoTimeStopWaitResult> Run()
		{
			WuWaGoTimeStopWait.<Run>d__10 <Run>d__;
			<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder<EWuWaGoTimeStopWaitResult>.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<WuWaGoTimeStopWait.<Run>d__10>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x060240D1 RID: 147665 RVA: 0x00A340EB File Offset: 0x00A322EB
		public void PauseByTimeStop()
		{
			WuWaGoTimeStop.PauseTimerHandle(this.TimerHandle);
		}

		// Token: 0x060240D2 RID: 147666 RVA: 0x00A340F8 File Offset: 0x00A322F8
		public void ResumeByTimeStop()
		{
			WuWaGoTimeStop.ResumeTimerHandle(this.TimerHandle);
		}

		// Token: 0x060240D3 RID: 147667 RVA: 0x00A34105 File Offset: 0x00A32305
		[NullableContext(1)]
		public void CancelByTimeStop(string reason)
		{
			this.Finish(EWuWaGoTimeStopWaitResult.Canceled);
		}

		// Token: 0x060240D4 RID: 147668 RVA: 0x00A3410E File Offset: 0x00A3230E
		private void OnCompleted(float delta)
		{
			this.Finish(EWuWaGoTimeStopWaitResult.Completed);
		}

		// Token: 0x060240D5 RID: 147669 RVA: 0x00A34118 File Offset: 0x00A32318
		private void Finish(EWuWaGoTimeStopWaitResult result)
		{
			if (this.Resolved)
			{
				return;
			}
			this.Resolved = true;
			Action unregisterTimeStop = this.UnregisterTimeStop;
			if (unregisterTimeStop != null)
			{
				unregisterTimeStop();
			}
			this.UnregisterTimeStop = null;
			TimerHandle timerHandle = this.TimerHandle;
			if (timerHandle != null && timerHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
			}
			this.Done.SetResult(result);
		}

		// Token: 0x040141BC RID: 82364
		[CompilerGenerated]
		private int <durationMs>P = durationMs;

		// Token: 0x040141BE RID: 82366
		[Nullable(1)]
		private readonly CustomPromise<EWuWaGoTimeStopWaitResult> Done = new CustomPromise<EWuWaGoTimeStopWaitResult>();

		// Token: 0x040141BF RID: 82367
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x040141C0 RID: 82368
		[Nullable(2)]
		private Action UnregisterTimeStop;

		// Token: 0x040141C1 RID: 82369
		private bool Resolved;
	}
}
