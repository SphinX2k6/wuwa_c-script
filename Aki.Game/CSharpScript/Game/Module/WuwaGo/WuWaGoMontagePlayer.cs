using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200471D RID: 18205
	[NullableContext(1)]
	[Nullable(0)]
	internal class WuWaGoMontagePlayer : IWuWaGoTimeStopParticipant
	{
		// Token: 0x0602F93F RID: 194879 RVA: 0x00B05311 File Offset: 0x00B03511
		public WuWaGoMontagePlayer(UAnimInstance animInstance, UAnimMontage montage, EWuWaGoMontageWaitMode waitMode)
		{
		}

		// Token: 0x170076F2 RID: 30450
		// (get) Token: 0x0602F940 RID: 194880 RVA: 0x00B05339 File Offset: 0x00B03539
		// (set) Token: 0x0602F941 RID: 194881 RVA: 0x00B05341 File Offset: 0x00B03541
		public bool PausedByTimeStop { get; set; }

		// Token: 0x0602F942 RID: 194882 RVA: 0x00B0534C File Offset: 0x00B0354C
		public UniTask Play()
		{
			WuWaGoMontagePlayer.<Play>d__12 <Play>d__;
			<Play>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Play>d__.<>4__this = this;
			<Play>d__.<>1__state = -1;
			<Play>d__.<>t__builder.Start<WuWaGoMontagePlayer.<Play>d__12>(ref <Play>d__);
			return <Play>d__.<>t__builder.Task;
		}

		// Token: 0x0602F943 RID: 194883 RVA: 0x00B0538F File Offset: 0x00B0358F
		public void PauseByTimeStop()
		{
			WuWaGoTimeStop.PauseTimerHandle(this.TimerHandle);
		}

		// Token: 0x0602F944 RID: 194884 RVA: 0x00B0539C File Offset: 0x00B0359C
		public void ResumeByTimeStop()
		{
			WuWaGoTimeStop.ResumeTimerHandle(this.TimerHandle);
		}

		// Token: 0x0602F945 RID: 194885 RVA: 0x00B053A9 File Offset: 0x00B035A9
		public void CancelByTimeStop(string reason)
		{
			this.Finish();
		}

		// Token: 0x0602F946 RID: 194886 RVA: 0x00B053B1 File Offset: 0x00B035B1
		private float GetMontagePlayRate()
		{
			return WuWaGoUtil.GetMontagePlayRate();
		}

		// Token: 0x0602F947 RID: 194887 RVA: 0x00B053B8 File Offset: 0x00B035B8
		[NullableContext(2)]
		private void OnMontageBlendingOut(UAnimMontage montage1, bool bInterrupted)
		{
			if (montage1 != this.<montage>P)
			{
				return;
			}
			this.Finish();
		}

		// Token: 0x0602F948 RID: 194888 RVA: 0x00B053CA File Offset: 0x00B035CA
		[NullableContext(2)]
		private void OnMontageEnded(UAnimMontage montage1, bool bInterrupted)
		{
			if (montage1 != this.<montage>P)
			{
				return;
			}
			this.Finish();
		}

		// Token: 0x0602F949 RID: 194889 RVA: 0x00B053DC File Offset: 0x00B035DC
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

		// Token: 0x0602F94A RID: 194890 RVA: 0x00B05420 File Offset: 0x00B03620
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

		// Token: 0x04019B19 RID: 105241
		[CompilerGenerated]
		private UAnimInstance <animInstance>P = animInstance;

		// Token: 0x04019B1A RID: 105242
		[CompilerGenerated]
		private UAnimMontage <montage>P = montage;

		// Token: 0x04019B1B RID: 105243
		[CompilerGenerated]
		private EWuWaGoMontageWaitMode <waitMode>P = waitMode;

		// Token: 0x04019B1D RID: 105245
		private readonly CustomPromise<UniTaskVoid> Done = new CustomPromise<UniTaskVoid>();

		// Token: 0x04019B1E RID: 105246
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x04019B1F RID: 105247
		[Nullable(2)]
		private Action UnregisterTimeStop;

		// Token: 0x04019B20 RID: 105248
		private bool Resolved;
	}
}
