using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037B7 RID: 14263
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelEffects
	{
		// Token: 0x060251B3 RID: 151987 RVA: 0x00A77E01 File Offset: 0x00A76001
		public VisualNovelEffects(VisualNovelContext context, string blackScreenTag)
		{
			this.Context = context;
			this.BlackScreenTag = blackScreenTag;
		}

		// Token: 0x060251B4 RID: 151988 RVA: 0x00A77E18 File Offset: 0x00A76018
		public UniTask EnterBlackScreenAsync(EVisualNovelBlackScreenType screenType, float duration)
		{
			VisualNovelEffects.<EnterBlackScreenAsync>d__8 <EnterBlackScreenAsync>d__;
			<EnterBlackScreenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnterBlackScreenAsync>d__.<>4__this = this;
			<EnterBlackScreenAsync>d__.screenType = screenType;
			<EnterBlackScreenAsync>d__.duration = duration;
			<EnterBlackScreenAsync>d__.<>1__state = -1;
			<EnterBlackScreenAsync>d__.<>t__builder.Start<VisualNovelEffects.<EnterBlackScreenAsync>d__8>(ref <EnterBlackScreenAsync>d__);
			return <EnterBlackScreenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060251B5 RID: 151989 RVA: 0x00A77E6C File Offset: 0x00A7606C
		public UniTask LeaveBlackScreenAsync(float duration)
		{
			VisualNovelEffects.<LeaveBlackScreenAsync>d__9 <LeaveBlackScreenAsync>d__;
			<LeaveBlackScreenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LeaveBlackScreenAsync>d__.<>4__this = this;
			<LeaveBlackScreenAsync>d__.duration = duration;
			<LeaveBlackScreenAsync>d__.<>1__state = -1;
			<LeaveBlackScreenAsync>d__.<>t__builder.Start<VisualNovelEffects.<LeaveBlackScreenAsync>d__9>(ref <LeaveBlackScreenAsync>d__);
			return <LeaveBlackScreenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060251B6 RID: 151990 RVA: 0x00A77EB7 File Offset: 0x00A760B7
		public void Destroy()
		{
			if (this.IsDestroyed)
			{
				return;
			}
			this.IsDestroyed = true;
			this.StopBlackScreenTimer();
			this.RemoveBlackScreenImmediately();
		}

		// Token: 0x060251B7 RID: 151991 RVA: 0x00A77ED8 File Offset: 0x00A760D8
		public void FinishEnterBlackScreen(EVisualNovelBlackScreenType screenType)
		{
			this.StopBlackScreenTimer();
			EFadeInScreenShowType screenType2 = (screenType == EVisualNovelBlackScreenType.White) ? EFadeInScreenShowType.White : EFadeInScreenShowType.Black;
			BlackScreenFadeController.Instance.ChangeColor(screenType2);
			BlackScreenFadeController.Instance.AddFadeBlackScreen(0f, false, false, null, this.BlackScreenTag);
			this.IsBlackScreenVisible = true;
		}

		// Token: 0x060251B8 RID: 151992 RVA: 0x00A77F26 File Offset: 0x00A76126
		public void FinishLeaveBlackScreen()
		{
			this.StopBlackScreenTimer();
			BlackScreenFadeController.Instance.RemoveFadeBlackScreen(0f, this.BlackScreenTag);
			this.IsBlackScreenVisible = false;
		}

		// Token: 0x060251B9 RID: 151993 RVA: 0x00A77F4C File Offset: 0x00A7614C
		private UniTask WaitForBlackScreenAsync(float duration, string reason)
		{
			this.StopBlackScreenTimer();
			if (duration <= 0f)
			{
				return UniTask.CompletedTask;
			}
			UniTaskCompletionSource uniTaskCompletionSource = new UniTaskCompletionSource();
			this.BlackScreenPromise = uniTaskCompletionSource;
			this.BlackScreenTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.CompleteBlackScreenTimer(false);
			}, Math.Max(duration * 1000f, 20f), null, reason, true, this.Context.PlaybackRate);
			if (this.BlackScreenTimer == null)
			{
				this.BlackScreenPromise = null;
				return UniTask.CompletedTask;
			}
			if (this.IsPaused)
			{
				this.BlackScreenTimer.Pause();
			}
			return uniTaskCompletionSource.Task;
		}

		// Token: 0x060251BA RID: 151994 RVA: 0x00A77FE4 File Offset: 0x00A761E4
		private void CompleteBlackScreenTimer(bool removeTimer)
		{
			TimerHandle blackScreenTimer = this.BlackScreenTimer;
			UniTaskCompletionSource blackScreenPromise = this.BlackScreenPromise;
			this.BlackScreenTimer = null;
			this.BlackScreenPromise = null;
			if (removeTimer && blackScreenTimer != null && blackScreenTimer.Valid())
			{
				blackScreenTimer.Remove();
			}
			if (blackScreenPromise == null)
			{
				return;
			}
			blackScreenPromise.TrySetResult();
		}

		// Token: 0x060251BB RID: 151995 RVA: 0x00A7802C File Offset: 0x00A7622C
		private void StopBlackScreenTimer()
		{
			this.CompleteBlackScreenTimer(true);
		}

		// Token: 0x060251BC RID: 151996 RVA: 0x00A78035 File Offset: 0x00A76235
		private void RemoveBlackScreenImmediately()
		{
			if (!this.IsBlackScreenVisible)
			{
				return;
			}
			BlackScreenFadeController.Instance.RemoveFadeBlackScreen(0f, this.BlackScreenTag);
			this.IsBlackScreenVisible = false;
		}

		// Token: 0x060251BD RID: 151997 RVA: 0x00A7805C File Offset: 0x00A7625C
		public void SetPlaybackRate(float playbackRate)
		{
			TimerHandle blackScreenTimer = this.BlackScreenTimer;
			if (blackScreenTimer == null)
			{
				return;
			}
			blackScreenTimer.ChangeDilation(playbackRate);
		}

		// Token: 0x060251BE RID: 151998 RVA: 0x00A78070 File Offset: 0x00A76270
		public void SetPaused(bool paused)
		{
			this.IsPaused = paused;
			VisualNovelEffects.SetTimerPaused(this.BlackScreenTimer, paused);
		}

		// Token: 0x060251BF RID: 151999 RVA: 0x00A78085 File Offset: 0x00A76285
		[NullableContext(2)]
		private static void SetTimerPaused(TimerHandle timer, bool paused)
		{
			if (timer == null || !timer.Valid() || timer.IsPause() == paused)
			{
				return;
			}
			if (paused)
			{
				timer.Pause();
				return;
			}
			timer.Resume();
		}

		// Token: 0x04014863 RID: 84067
		private readonly VisualNovelContext Context;

		// Token: 0x04014864 RID: 84068
		private readonly string BlackScreenTag;

		// Token: 0x04014865 RID: 84069
		[Nullable(2)]
		private TimerHandle BlackScreenTimer;

		// Token: 0x04014866 RID: 84070
		[Nullable(2)]
		private UniTaskCompletionSource BlackScreenPromise;

		// Token: 0x04014867 RID: 84071
		private bool IsBlackScreenVisible;

		// Token: 0x04014868 RID: 84072
		private bool IsPaused;

		// Token: 0x04014869 RID: 84073
		private bool IsDestroyed;
	}
}
