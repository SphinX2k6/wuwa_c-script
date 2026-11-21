using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037C9 RID: 14281
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelCharacterEnterAction : VisualNovelAction
	{
		// Token: 0x060252F7 RID: 152311 RVA: 0x00A7D5DE File Offset: 0x00A7B7DE
		public VisualNovelCharacterEnterAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			this.Performance = (IVisualNovelPerformanceEnter)performance;
		}

		// Token: 0x060252F8 RID: 152312 RVA: 0x00A7D5F4 File Offset: 0x00A7B7F4
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelCharacterEnterAction.<ExecuteCoreAsync>d__6 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelCharacterEnterAction.<ExecuteCoreAsync>d__6>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252F9 RID: 152313 RVA: 0x00A7D637 File Offset: 0x00A7B837
		public override bool TryComplete()
		{
			if (!base.IsExecuting)
			{
				return false;
			}
			this.IsCompletionRequested = true;
			this.FinishPerformance();
			return true;
		}

		// Token: 0x060252FA RID: 152314 RVA: 0x00A7D651 File Offset: 0x00A7B851
		internal override void Release()
		{
			this.IsReleased = true;
			if (base.IsExecuting)
			{
				this.FinishPerformance();
			}
		}

		// Token: 0x060252FB RID: 152315 RVA: 0x00A7D668 File Offset: 0x00A7B868
		private void FinishPerformance()
		{
			if (this.Character != null && this.VisibilityVersion != null)
			{
				this.Character.FinishShow(this.VisibilityVersion.Value);
			}
		}

		// Token: 0x0401491A RID: 84250
		private readonly IVisualNovelPerformanceEnter Performance;

		// Token: 0x0401491B RID: 84251
		[Nullable(2)]
		private VisualNovelCharacter Character;

		// Token: 0x0401491C RID: 84252
		private int? VisibilityVersion;

		// Token: 0x0401491D RID: 84253
		private bool IsCompletionRequested;

		// Token: 0x0401491E RID: 84254
		private bool IsReleased;
	}
}
