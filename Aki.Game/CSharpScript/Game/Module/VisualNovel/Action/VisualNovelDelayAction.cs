using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037CE RID: 14286
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class VisualNovelDelayAction : VisualNovelAction
	{
		// Token: 0x06025315 RID: 152341 RVA: 0x00A7DB4D File Offset: 0x00A7BD4D
		[NullableContext(1)]
		public VisualNovelDelayAction(VisualNovelContext context, float duration) : base(context)
		{
			this.Duration = Math.Max(duration, 0f);
		}

		// Token: 0x06025316 RID: 152342 RVA: 0x00A7DB68 File Offset: 0x00A7BD68
		protected override UniTask ExecuteCoreAsync()
		{
			if (this.Duration <= 0f)
			{
				return UniTask.CompletedTask;
			}
			this.Completion = new UniTaskCompletionSource();
			this.Timer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.Complete(false);
			}, Math.Max(this.Duration * 1000f, 20f), null, "VisualNovelDelayAction", true, base.PlaybackRate);
			if (base.IsPaused)
			{
				TimerHandle timer = this.Timer;
				if (timer != null)
				{
					timer.Pause();
				}
			}
			if (this.Timer != null)
			{
				return this.Completion.Task;
			}
			UniTaskCompletionSource completion = this.Completion;
			this.Completion = null;
			completion.TrySetResult();
			return UniTask.CompletedTask;
		}

		// Token: 0x06025317 RID: 152343 RVA: 0x00A7DC18 File Offset: 0x00A7BE18
		public override void SetPlaybackRate(float playbackRate)
		{
			base.SetPlaybackRate(playbackRate);
			TimerHandle timer = this.Timer;
			if (timer == null)
			{
				return;
			}
			timer.ChangeDilation(base.PlaybackRate);
		}

		// Token: 0x06025318 RID: 152344 RVA: 0x00A7DC38 File Offset: 0x00A7BE38
		public override void SetPaused(bool paused)
		{
			base.SetPaused(paused);
			if (this.Timer == null || this.Timer.IsPause() == paused)
			{
				return;
			}
			if (paused)
			{
				this.Timer.Pause();
				return;
			}
			this.Timer.Resume();
		}

		// Token: 0x06025319 RID: 152345 RVA: 0x00A7DC74 File Offset: 0x00A7BE74
		public override bool TryComplete()
		{
			if (this.Completion == null)
			{
				return false;
			}
			this.Complete(true);
			return true;
		}

		// Token: 0x0602531A RID: 152346 RVA: 0x00A7DC88 File Offset: 0x00A7BE88
		internal override void Release()
		{
			this.Complete(true);
		}

		// Token: 0x0602531B RID: 152347 RVA: 0x00A7DC94 File Offset: 0x00A7BE94
		private void Complete(bool removeTimer)
		{
			TimerHandle timer = this.Timer;
			UniTaskCompletionSource completion = this.Completion;
			this.Timer = null;
			this.Completion = null;
			if (removeTimer && timer != null && timer.Valid())
			{
				timer.Remove();
			}
			if (completion == null)
			{
				return;
			}
			completion.TrySetResult();
		}

		// Token: 0x04014931 RID: 84273
		private readonly float Duration;

		// Token: 0x04014932 RID: 84274
		private TimerHandle Timer;

		// Token: 0x04014933 RID: 84275
		private UniTaskCompletionSource Completion;
	}
}
