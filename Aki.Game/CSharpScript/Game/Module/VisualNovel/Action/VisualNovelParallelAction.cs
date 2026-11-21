using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037D5 RID: 14293
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelParallelAction : VisualNovelAction
	{
		// Token: 0x06025345 RID: 152389 RVA: 0x00A7E3B0 File Offset: 0x00A7C5B0
		public VisualNovelParallelAction(VisualNovelContext context, IReadOnlyList<VisualNovelAction> actions) : base(context)
		{
			this.Actions = actions;
		}

		// Token: 0x06025346 RID: 152390 RVA: 0x00A7E3C0 File Offset: 0x00A7C5C0
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelParallelAction.<ExecuteCoreAsync>d__2 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelParallelAction.<ExecuteCoreAsync>d__2>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025347 RID: 152391 RVA: 0x00A7E404 File Offset: 0x00A7C604
		public override void SetPlaybackRate(float playbackRate)
		{
			base.SetPlaybackRate(playbackRate);
			foreach (VisualNovelAction visualNovelAction in this.Actions)
			{
				visualNovelAction.SetPlaybackRate(playbackRate);
			}
		}

		// Token: 0x06025348 RID: 152392 RVA: 0x00A7E458 File Offset: 0x00A7C658
		public override void SetPaused(bool paused)
		{
			base.SetPaused(paused);
			foreach (VisualNovelAction visualNovelAction in this.Actions)
			{
				visualNovelAction.SetPaused(paused);
			}
		}

		// Token: 0x06025349 RID: 152393 RVA: 0x00A7E4AC File Offset: 0x00A7C6AC
		public override bool TryComplete()
		{
			if (!base.IsExecuting)
			{
				return false;
			}
			bool flag = false;
			foreach (VisualNovelAction visualNovelAction in this.Actions)
			{
				flag |= visualNovelAction.TryComplete();
			}
			return flag;
		}

		// Token: 0x0602534A RID: 152394 RVA: 0x00A7E508 File Offset: 0x00A7C708
		internal override void Release()
		{
			foreach (VisualNovelAction visualNovelAction in this.Actions)
			{
				visualNovelAction.Release();
			}
		}

		// Token: 0x04014943 RID: 84291
		private readonly IReadOnlyList<VisualNovelAction> Actions;
	}
}
