using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200471A RID: 18202
	internal class WuWaGoTimeStopWait : IWuWaGoTimeStopParticipant
	{
		// Token: 0x0602F907 RID: 194823 RVA: 0x00B043AB File Offset: 0x00B025AB
		public WuWaGoTimeStopWait(int durationMs)
		{
		}

		// Token: 0x170076F0 RID: 30448
		// (get) Token: 0x0602F908 RID: 194824 RVA: 0x00B043C5 File Offset: 0x00B025C5
		// (set) Token: 0x0602F909 RID: 194825 RVA: 0x00B043CD File Offset: 0x00B025CD
		public bool PausedByTimeStop { get; set; }

		// Token: 0x0602F90A RID: 194826 RVA: 0x00B043D8 File Offset: 0x00B025D8
		public UniTask<EWuWaGoTimeStopWaitResult> Run()
		{
			WuWaGoTimeStopWait.<Run>d__10 <Run>d__;
			<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder<EWuWaGoTimeStopWaitResult>.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<WuWaGoTimeStopWait.<Run>d__10>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x0602F90B RID: 194827 RVA: 0x00B0441B File Offset: 0x00B0261B
		public void PauseByTimeStop()
		{
			WuWaGoTimeStop.PauseTimerHandle(this.TimerHandle);
		}

		// Token: 0x0602F90C RID: 194828 RVA: 0x00B04428 File Offset: 0x00B02628
		public void ResumeByTimeStop()
		{
			WuWaGoTimeStop.ResumeTimerHandle(this.TimerHandle);
		}

		// Token: 0x0602F90D RID: 194829 RVA: 0x00B04435 File Offset: 0x00B02635
		[NullableContext(1)]
		public void CancelByTimeStop(string reason)
		{
			this.Finish(EWuWaGoTimeStopWaitResult.Canceled);
		}

		// Token: 0x0602F90E RID: 194830 RVA: 0x00B0443E File Offset: 0x00B0263E
		private void OnCompleted(float delta)
		{
			this.Finish(EWuWaGoTimeStopWaitResult.Completed);
		}

		// Token: 0x0602F90F RID: 194831 RVA: 0x00B04448 File Offset: 0x00B02648
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

		// Token: 0x04019B0D RID: 105229
		[CompilerGenerated]
		private int <durationMs>P = durationMs;

		// Token: 0x04019B0F RID: 105231
		[Nullable(1)]
		private readonly CustomPromise<EWuWaGoTimeStopWaitResult> Done = new CustomPromise<EWuWaGoTimeStopWaitResult>();

		// Token: 0x04019B10 RID: 105232
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x04019B11 RID: 105233
		[Nullable(2)]
		private Action UnregisterTimeStop;

		// Token: 0x04019B12 RID: 105234
		private bool Resolved;
	}
}
