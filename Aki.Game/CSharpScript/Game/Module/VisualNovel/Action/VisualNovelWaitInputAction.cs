using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037DE RID: 14302
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class VisualNovelWaitInputAction : VisualNovelAction
	{
		// Token: 0x06025379 RID: 152441 RVA: 0x00A7EFE0 File Offset: 0x00A7D1E0
		[NullableContext(1)]
		public VisualNovelWaitInputAction(VisualNovelContext context, float? endWaitTime = null) : base(context)
		{
			this.EndWaitTime = endWaitTime;
		}

		// Token: 0x0602537A RID: 152442 RVA: 0x00A7EFF0 File Offset: 0x00A7D1F0
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelWaitInputAction.<ExecuteCoreAsync>d__5 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelWaitInputAction.<ExecuteCoreAsync>d__5>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602537B RID: 152443 RVA: 0x00A7F033 File Offset: 0x00A7D233
		public override void SetPlaybackRate(float playbackRate)
		{
			base.SetPlaybackRate(playbackRate);
			TimerHandle autoTimer = this.AutoTimer;
			if (autoTimer == null)
			{
				return;
			}
			autoTimer.ChangeDilation(base.PlaybackRate);
		}

		// Token: 0x0602537C RID: 152444 RVA: 0x00A7F053 File Offset: 0x00A7D253
		public override void SetPaused(bool paused)
		{
			base.SetPaused(paused);
			this.RefreshAutoTimerPause();
		}

		// Token: 0x0602537D RID: 152445 RVA: 0x00A7F064 File Offset: 0x00A7D264
		public override bool TryComplete()
		{
			UniTaskCompletionSource completion = this.Completion;
			if (completion == null)
			{
				return false;
			}
			this.AutoAdvanceVersion++;
			this.Completion = null;
			this.RemoveAutoTimer();
			completion.TrySetResult();
			return true;
		}

		// Token: 0x0602537E RID: 152446 RVA: 0x00A7F0A0 File Offset: 0x00A7D2A0
		internal override void Release()
		{
			this.AutoAdvanceVersion++;
			base.Context.PlaybackModeChanged -= this.OnPlaybackModeChanged;
			base.Context.AutoAdvanceMutedChanged -= this.RefreshAutoTimerPause;
			this.RemoveAutoTimer();
			UniTaskCompletionSource completion = this.Completion;
			this.Completion = null;
			if (completion == null)
			{
				return;
			}
			completion.TrySetResult();
		}

		// Token: 0x0602537F RID: 152447 RVA: 0x00A7F107 File Offset: 0x00A7D307
		private void OnPlaybackModeChanged(EVisualNovelPlaybackMode playbackMode)
		{
			if (playbackMode == EVisualNovelPlaybackMode.Skip)
			{
				this.TryComplete();
				return;
			}
			this.RefreshAutoTimer();
		}

		// Token: 0x06025380 RID: 152448 RVA: 0x00A7F11C File Offset: 0x00A7D31C
		private void RefreshAutoTimer()
		{
			EVisualNovelPlaybackMode playbackMode = base.Context.PlaybackMode;
			bool flag = playbackMode - EVisualNovelPlaybackMode.Auto <= 2;
			bool flag2 = flag;
			if (this.Completion == null || !flag2)
			{
				this.AutoAdvanceVersion++;
				this.RemoveAutoTimer();
				return;
			}
			if (base.Context.PlaybackMode == EVisualNovelPlaybackMode.Auto)
			{
				this.RemoveAutoTimer();
				this.WaitVoiceBeforeAutoAdvance();
				return;
			}
			this.StartAutoTimer();
		}

		// Token: 0x06025381 RID: 152449 RVA: 0x00A7F184 File Offset: 0x00A7D384
		private void WaitVoiceBeforeAutoAdvance()
		{
			if (this.AutoTimer != null)
			{
				return;
			}
			int num = this.AutoAdvanceVersion + 1;
			this.AutoAdvanceVersion = num;
			int version = num;
			this.WaitVoiceAndStartAutoTimerAsync(version).Forget();
		}

		// Token: 0x06025382 RID: 152450 RVA: 0x00A7F1B8 File Offset: 0x00A7D3B8
		private UniTask WaitVoiceAndStartAutoTimerAsync(int version)
		{
			VisualNovelWaitInputAction.<WaitVoiceAndStartAutoTimerAsync>d__13 <WaitVoiceAndStartAutoTimerAsync>d__;
			<WaitVoiceAndStartAutoTimerAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitVoiceAndStartAutoTimerAsync>d__.<>4__this = this;
			<WaitVoiceAndStartAutoTimerAsync>d__.version = version;
			<WaitVoiceAndStartAutoTimerAsync>d__.<>1__state = -1;
			<WaitVoiceAndStartAutoTimerAsync>d__.<>t__builder.Start<VisualNovelWaitInputAction.<WaitVoiceAndStartAutoTimerAsync>d__13>(ref <WaitVoiceAndStartAutoTimerAsync>d__);
			return <WaitVoiceAndStartAutoTimerAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025383 RID: 152451 RVA: 0x00A7F204 File Offset: 0x00A7D404
		private void StartAutoTimer()
		{
			if (this.AutoTimer != null)
			{
				return;
			}
			this.AutoTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.AutoTimer = null;
				this.TryComplete();
			}, Math.Max((this.EndWaitTime ?? base.Context.AutoAdvanceDelay) * 1000f, 20f), null, "VisualNovelAutoAdvance", true, base.PlaybackRate);
			this.RefreshAutoTimerPause();
		}

		// Token: 0x06025384 RID: 152452 RVA: 0x00A7F280 File Offset: 0x00A7D480
		private void RefreshAutoTimerPause()
		{
			bool flag = base.IsPaused || base.Context.IsAutoAdvanceMuted;
			if (this.AutoTimer == null || this.AutoTimer.IsPause() == flag)
			{
				return;
			}
			if (flag)
			{
				this.AutoTimer.Pause();
				return;
			}
			this.AutoTimer.Resume();
		}

		// Token: 0x06025385 RID: 152453 RVA: 0x00A7F2D8 File Offset: 0x00A7D4D8
		private void RemoveAutoTimer()
		{
			TimerHandle autoTimer = this.AutoTimer;
			this.AutoTimer = null;
			if (autoTimer != null && autoTimer.Valid())
			{
				autoTimer.Remove();
			}
		}

		// Token: 0x04014962 RID: 84322
		private UniTaskCompletionSource Completion;

		// Token: 0x04014963 RID: 84323
		private TimerHandle AutoTimer;

		// Token: 0x04014964 RID: 84324
		private int AutoAdvanceVersion;

		// Token: 0x04014965 RID: 84325
		private readonly float? EndWaitTime;
	}
}
