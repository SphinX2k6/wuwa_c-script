using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037D3 RID: 14291
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelNoTextAction : VisualNovelAction
	{
		// Token: 0x06025335 RID: 152373 RVA: 0x00A7E136 File Offset: 0x00A7C336
		public VisualNovelNoTextAction(VisualNovelContext context, VisualNovelItem item) : base(context)
		{
			this.Item = item;
		}

		// Token: 0x06025336 RID: 152374 RVA: 0x00A7E148 File Offset: 0x00A7C348
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelNoTextAction.<ExecuteCoreAsync>d__3 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelNoTextAction.<ExecuteCoreAsync>d__3>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025337 RID: 152375 RVA: 0x00A7E18B File Offset: 0x00A7C38B
		public override void SetPlaybackRate(float playbackRate)
		{
			base.SetPlaybackRate(playbackRate);
			VisualNovelAction currentAction = this.CurrentAction;
			if (currentAction == null)
			{
				return;
			}
			currentAction.SetPlaybackRate(base.PlaybackRate);
		}

		// Token: 0x06025338 RID: 152376 RVA: 0x00A7E1AA File Offset: 0x00A7C3AA
		public override void SetPaused(bool paused)
		{
			base.SetPaused(paused);
			VisualNovelAction currentAction = this.CurrentAction;
			if (currentAction == null)
			{
				return;
			}
			currentAction.SetPaused(paused);
		}

		// Token: 0x06025339 RID: 152377 RVA: 0x00A7E1C4 File Offset: 0x00A7C3C4
		public override bool TryComplete()
		{
			VisualNovelAction currentAction = this.CurrentAction;
			return currentAction != null && currentAction.TryComplete();
		}

		// Token: 0x0602533A RID: 152378 RVA: 0x00A7E1D7 File Offset: 0x00A7C3D7
		internal override void Release()
		{
			this.ReleaseCurrentAction();
		}

		// Token: 0x0602533B RID: 152379 RVA: 0x00A7E1E0 File Offset: 0x00A7C3E0
		private UniTask ExecutePerformancesAsync(bool isStart)
		{
			VisualNovelNoTextAction.<ExecutePerformancesAsync>d__8 <ExecutePerformancesAsync>d__;
			<ExecutePerformancesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecutePerformancesAsync>d__.<>4__this = this;
			<ExecutePerformancesAsync>d__.isStart = isStart;
			<ExecutePerformancesAsync>d__.<>1__state = -1;
			<ExecutePerformancesAsync>d__.<>t__builder.Start<VisualNovelNoTextAction.<ExecutePerformancesAsync>d__8>(ref <ExecutePerformancesAsync>d__);
			return <ExecutePerformancesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602533C RID: 152380 RVA: 0x00A7E22B File Offset: 0x00A7C42B
		private void ReleaseCurrentAction()
		{
			if (this.CurrentAction == null)
			{
				return;
			}
			this.CurrentAction.Release();
			this.CurrentAction = null;
		}

		// Token: 0x0401493E RID: 84286
		private readonly VisualNovelItem Item;

		// Token: 0x0401493F RID: 84287
		[Nullable(2)]
		private VisualNovelAction CurrentAction;
	}
}
