using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200364D RID: 13901
	[NullableContext(1)]
	[Nullable(0)]
	internal class WuWaGoMontagePlayer : IWuWaGoTimeStopParticipant
	{
		// Token: 0x06024105 RID: 147717 RVA: 0x00A34FE1 File Offset: 0x00A331E1
		public WuWaGoMontagePlayer(UAnimInstance animInstance, UAnimMontage montage, EWuWaGoMontageWaitMode waitMode)
		{
		}

		// Token: 0x170049AE RID: 18862
		// (get) Token: 0x06024106 RID: 147718 RVA: 0x00A35009 File Offset: 0x00A33209
		// (set) Token: 0x06024107 RID: 147719 RVA: 0x00A35011 File Offset: 0x00A33211
		public bool PausedByTimeStop { get; set; }

		// Token: 0x06024108 RID: 147720 RVA: 0x00A3501C File Offset: 0x00A3321C
		public UniTask Play()
		{
			WuWaGoMontagePlayer.<Play>d__12 <Play>d__;
			<Play>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Play>d__.<>4__this = this;
			<Play>d__.<>1__state = -1;
			<Play>d__.<>t__builder.Start<WuWaGoMontagePlayer.<Play>d__12>(ref <Play>d__);
			return <Play>d__.<>t__builder.Task;
		}

		// Token: 0x06024109 RID: 147721 RVA: 0x00A3505F File Offset: 0x00A3325F
		public void PauseByTimeStop()
		{
			WuWaGoTimeStop.PauseTimerHandle(this.TimerHandle);
		}

		// Token: 0x0602410A RID: 147722 RVA: 0x00A3506C File Offset: 0x00A3326C
		public void ResumeByTimeStop()
		{
			WuWaGoTimeStop.ResumeTimerHandle(this.TimerHandle);
		}

		// Token: 0x0602410B RID: 147723 RVA: 0x00A35079 File Offset: 0x00A33279
		public void CancelByTimeStop(string reason)
		{
			this.Finish();
		}

		// Token: 0x0602410C RID: 147724 RVA: 0x00A35081 File Offset: 0x00A33281
		private float GetMontagePlayRate()
		{
			return WuWaGoUtil.GetMontagePlayRate();
		}

		// Token: 0x0602410D RID: 147725 RVA: 0x00A35088 File Offset: 0x00A33288
		[NullableContext(2)]
		private void OnMontageBlendingOut(UAnimMontage montage1, bool bInterrupted)
		{
			if (montage1 != this.<montage>P)
			{
				return;
			}
			this.Finish();
		}

		// Token: 0x0602410E RID: 147726 RVA: 0x00A3509A File Offset: 0x00A3329A
		[NullableContext(2)]
		private void OnMontageEnded(UAnimMontage montage1, bool bInterrupted)
		{
			if (montage1 != this.<montage>P)
			{
				return;
			}
			this.Finish();
		}

		// Token: 0x0602410F RID: 147727 RVA: 0x00A350AC File Offset: 0x00A332AC
		private void OnTimeout(float delta)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WuWaGo;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "Montage 超时兜底触发";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("montage", this.<montage>P);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.Finish();
		}

		// Token: 0x06024110 RID: 147728 RVA: 0x00A350F0 File Offset: 0x00A332F0
		private void Finish()
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
			this.<animInstance>P.OnMontageBlendingOut.Remove(new Action<UAnimMontage, bool>(this.OnMontageBlendingOut));
			this.<animInstance>P.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.OnMontageEnded));
			TimerHandle timerHandle = this.TimerHandle;
			if (timerHandle != null && timerHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
			}
			this.Done.SetResult(default(UniTaskVoid));
		}

		// Token: 0x040141C8 RID: 82376
		[CompilerGenerated]
		private UAnimInstance <animInstance>P = animInstance;

		// Token: 0x040141C9 RID: 82377
		[CompilerGenerated]
		private UAnimMontage <montage>P = montage;

		// Token: 0x040141CA RID: 82378
		[CompilerGenerated]
		private EWuWaGoMontageWaitMode <waitMode>P = waitMode;

		// Token: 0x040141CC RID: 82380
		private readonly CustomPromise<UniTaskVoid> Done = new CustomPromise<UniTaskVoid>();

		// Token: 0x040141CD RID: 82381
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x040141CE RID: 82382
		[Nullable(2)]
		private Action UnregisterTimeStop;

		// Token: 0x040141CF RID: 82383
		private bool Resolved;
	}
}
