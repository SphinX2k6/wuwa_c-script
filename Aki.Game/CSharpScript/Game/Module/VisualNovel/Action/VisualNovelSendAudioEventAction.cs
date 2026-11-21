using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037D7 RID: 14295
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelSendAudioEventAction : VisualNovelAction
	{
		// Token: 0x0602534F RID: 152399 RVA: 0x00A7E6A8 File Offset: 0x00A7C8A8
		public VisualNovelSendAudioEventAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			IVisualNovelPerformanceSendAudioEvent visualNovelPerformanceSendAudioEvent = (IVisualNovelPerformanceSendAudioEvent)performance;
			this.AudioEvent = (visualNovelPerformanceSendAudioEvent.AudioEvent ?? string.Empty);
			this.FadeOutTime = visualNovelPerformanceSendAudioEvent.EndFadeOutTime.GetValueOrDefault();
			this.IsNotCountTimeAndNotInterrupted = visualNovelPerformanceSendAudioEvent.IsNotCountTimeAndNotInterrupted.GetValueOrDefault();
			this.SkipOnUltraFastForward = visualNovelPerformanceSendAudioEvent.SkipOnUltraFastForward.GetValueOrDefault(true);
		}

		// Token: 0x06025350 RID: 152400 RVA: 0x00A7E718 File Offset: 0x00A7C918
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelSendAudioEventAction.<ExecuteCoreAsync>d__6 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelSendAudioEventAction.<ExecuteCoreAsync>d__6>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025351 RID: 152401 RVA: 0x00A7E75B File Offset: 0x00A7C95B
		public override void SetPlaybackRate(float playbackRate)
		{
			base.SetPlaybackRate(playbackRate);
			if (this.ShouldSkip())
			{
				VisualNovelAudioEvent audioEventInstance = this.AudioEventInstance;
				if (audioEventInstance == null)
				{
					return;
				}
				audioEventInstance.Stop();
				return;
			}
			else
			{
				VisualNovelAudioEvent audioEventInstance2 = this.AudioEventInstance;
				if (audioEventInstance2 == null)
				{
					return;
				}
				audioEventInstance2.SetPlaybackRate(1f);
				return;
			}
		}

		// Token: 0x06025352 RID: 152402 RVA: 0x00A7E792 File Offset: 0x00A7C992
		public override void SetPaused(bool paused)
		{
			base.SetPaused(paused);
			VisualNovelAudioEvent audioEventInstance = this.AudioEventInstance;
			if (audioEventInstance == null)
			{
				return;
			}
			audioEventInstance.SetPaused(paused);
		}

		// Token: 0x06025353 RID: 152403 RVA: 0x00A7E7AC File Offset: 0x00A7C9AC
		public override bool TryComplete()
		{
			if (!base.IsExecuting || this.IsNotCountTimeAndNotInterrupted || this.AudioEventInstance == null)
			{
				return false;
			}
			this.AudioEventInstance.Stop();
			return true;
		}

		// Token: 0x06025354 RID: 152404 RVA: 0x00A7E7D4 File Offset: 0x00A7C9D4
		internal override void Release()
		{
			if (base.IsExecuting && !this.IsNotCountTimeAndNotInterrupted)
			{
				VisualNovelAudioEvent audioEventInstance = this.AudioEventInstance;
				if (audioEventInstance == null)
				{
					return;
				}
				audioEventInstance.Stop();
			}
		}

		// Token: 0x06025355 RID: 152405 RVA: 0x00A7E7F6 File Offset: 0x00A7C9F6
		private bool ShouldSkip()
		{
			return this.SkipOnUltraFastForward && base.Context.PlaybackMode == EVisualNovelPlaybackMode.UltraFastForward;
		}

		// Token: 0x04014946 RID: 84294
		private readonly string AudioEvent;

		// Token: 0x04014947 RID: 84295
		private readonly float FadeOutTime;

		// Token: 0x04014948 RID: 84296
		private readonly bool IsNotCountTimeAndNotInterrupted;

		// Token: 0x04014949 RID: 84297
		private readonly bool SkipOnUltraFastForward;

		// Token: 0x0401494A RID: 84298
		[Nullable(2)]
		private VisualNovelAudioEvent AudioEventInstance;
	}
}
