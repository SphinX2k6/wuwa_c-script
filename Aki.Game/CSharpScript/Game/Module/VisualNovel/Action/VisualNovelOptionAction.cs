using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037D4 RID: 14292
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelOptionAction : VisualNovelAction
	{
		// Token: 0x0602533D RID: 152381 RVA: 0x00A7E248 File Offset: 0x00A7C448
		public VisualNovelOptionAction(VisualNovelContext context, VisualNovelItem item) : base(context)
		{
			this.Item = item;
		}

		// Token: 0x0602533E RID: 152382 RVA: 0x00A7E258 File Offset: 0x00A7C458
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelOptionAction.<ExecuteCoreAsync>d__4 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelOptionAction.<ExecuteCoreAsync>d__4>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602533F RID: 152383 RVA: 0x00A7E29B File Offset: 0x00A7C49B
		public override void SetPlaybackRate(float playbackRate)
		{
			base.SetPlaybackRate(playbackRate);
			VisualNovelAction currentPerformanceAction = this.CurrentPerformanceAction;
			if (currentPerformanceAction != null)
			{
				currentPerformanceAction.SetPlaybackRate(base.PlaybackRate);
			}
			VisualNovelShowChoicesAction showChoices = this.ShowChoices;
			if (showChoices == null)
			{
				return;
			}
			showChoices.SetPlaybackRate(base.PlaybackRate);
		}

		// Token: 0x06025340 RID: 152384 RVA: 0x00A7E2D1 File Offset: 0x00A7C4D1
		public override void SetPaused(bool paused)
		{
			base.SetPaused(paused);
			VisualNovelAction currentPerformanceAction = this.CurrentPerformanceAction;
			if (currentPerformanceAction != null)
			{
				currentPerformanceAction.SetPaused(paused);
			}
			VisualNovelShowChoicesAction showChoices = this.ShowChoices;
			if (showChoices == null)
			{
				return;
			}
			showChoices.SetPaused(paused);
		}

		// Token: 0x06025341 RID: 152385 RVA: 0x00A7E2FD File Offset: 0x00A7C4FD
		public override bool TryComplete()
		{
			VisualNovelShowChoicesAction showChoices = this.ShowChoices;
			if (showChoices == null || !showChoices.TryComplete())
			{
				VisualNovelAction currentPerformanceAction = this.CurrentPerformanceAction;
				return currentPerformanceAction != null && currentPerformanceAction.TryComplete();
			}
			return true;
		}

		// Token: 0x06025342 RID: 152386 RVA: 0x00A7E326 File Offset: 0x00A7C526
		internal override void Release()
		{
			VisualNovelShowChoicesAction showChoices = this.ShowChoices;
			if (showChoices != null)
			{
				showChoices.Release();
			}
			this.ShowChoices = null;
			this.ReleaseCurrentPerformanceAction();
		}

		// Token: 0x06025343 RID: 152387 RVA: 0x00A7E348 File Offset: 0x00A7C548
		private UniTask ExecutePerformancesAsync(bool isStart)
		{
			VisualNovelOptionAction.<ExecutePerformancesAsync>d__9 <ExecutePerformancesAsync>d__;
			<ExecutePerformancesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecutePerformancesAsync>d__.<>4__this = this;
			<ExecutePerformancesAsync>d__.isStart = isStart;
			<ExecutePerformancesAsync>d__.<>1__state = -1;
			<ExecutePerformancesAsync>d__.<>t__builder.Start<VisualNovelOptionAction.<ExecutePerformancesAsync>d__9>(ref <ExecutePerformancesAsync>d__);
			return <ExecutePerformancesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025344 RID: 152388 RVA: 0x00A7E393 File Offset: 0x00A7C593
		private void ReleaseCurrentPerformanceAction()
		{
			if (this.CurrentPerformanceAction == null)
			{
				return;
			}
			this.CurrentPerformanceAction.Release();
			this.CurrentPerformanceAction = null;
		}

		// Token: 0x04014940 RID: 84288
		private readonly VisualNovelItem Item;

		// Token: 0x04014941 RID: 84289
		[Nullable(2)]
		private VisualNovelAction CurrentPerformanceAction;

		// Token: 0x04014942 RID: 84290
		[Nullable(2)]
		private VisualNovelShowChoicesAction ShowChoices;
	}
}
