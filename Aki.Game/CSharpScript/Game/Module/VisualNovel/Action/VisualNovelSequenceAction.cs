using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037D8 RID: 14296
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelSequenceAction : VisualNovelAction
	{
		// Token: 0x06025356 RID: 152406 RVA: 0x00A7E810 File Offset: 0x00A7CA10
		public VisualNovelSequenceAction(VisualNovelContext context, IReadOnlyList<VisualNovelAction> actions) : base(context)
		{
			this.Actions = actions;
		}

		// Token: 0x06025357 RID: 152407 RVA: 0x00A7E820 File Offset: 0x00A7CA20
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelSequenceAction.<ExecuteCoreAsync>d__4 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelSequenceAction.<ExecuteCoreAsync>d__4>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025358 RID: 152408 RVA: 0x00A7E863 File Offset: 0x00A7CA63
		public override void SetPlaybackRate(float playbackRate)
		{
			base.SetPlaybackRate(playbackRate);
			VisualNovelAction currentAction = this.CurrentAction;
			if (currentAction == null)
			{
				return;
			}
			currentAction.SetPlaybackRate(playbackRate);
		}

		// Token: 0x06025359 RID: 152409 RVA: 0x00A7E87D File Offset: 0x00A7CA7D
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

		// Token: 0x0602535A RID: 152410 RVA: 0x00A7E897 File Offset: 0x00A7CA97
		public override bool TryComplete()
		{
			if (!base.IsExecuting || this.CurrentAction == null)
			{
				return false;
			}
			this.CompleteRequested = true;
			return this.CurrentAction.TryComplete();
		}

		// Token: 0x0602535B RID: 152411 RVA: 0x00A7E8BD File Offset: 0x00A7CABD
		internal override void Release()
		{
			VisualNovelAction currentAction = this.CurrentAction;
			if (currentAction != null)
			{
				currentAction.Release();
			}
			this.CurrentAction = null;
			this.CompleteRequested = false;
		}

		// Token: 0x0401494B RID: 84299
		private readonly IReadOnlyList<VisualNovelAction> Actions;

		// Token: 0x0401494C RID: 84300
		[Nullable(2)]
		private VisualNovelAction CurrentAction;

		// Token: 0x0401494D RID: 84301
		private bool CompleteRequested;
	}
}
