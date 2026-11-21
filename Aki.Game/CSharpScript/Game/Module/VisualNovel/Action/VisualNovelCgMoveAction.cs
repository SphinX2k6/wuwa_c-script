using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037C8 RID: 14280
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelCgMoveAction : VisualNovelAction
	{
		// Token: 0x060252F2 RID: 152306 RVA: 0x00A7D534 File Offset: 0x00A7B734
		public VisualNovelCgMoveAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			this.Performance = (IVisualNovelPerformanceCgMove)performance;
		}

		// Token: 0x060252F3 RID: 152307 RVA: 0x00A7D54C File Offset: 0x00A7B74C
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelCgMoveAction.<ExecuteCoreAsync>d__4 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelCgMoveAction.<ExecuteCoreAsync>d__4>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252F4 RID: 152308 RVA: 0x00A7D58F File Offset: 0x00A7B78F
		public override bool TryComplete()
		{
			if (!base.IsExecuting)
			{
				return false;
			}
			this.FinishPerformance();
			return true;
		}

		// Token: 0x060252F5 RID: 152309 RVA: 0x00A7D5A2 File Offset: 0x00A7B7A2
		internal override void Release()
		{
			if (base.IsExecuting)
			{
				this.FinishPerformance();
			}
		}

		// Token: 0x060252F6 RID: 152310 RVA: 0x00A7D5B2 File Offset: 0x00A7B7B2
		private void FinishPerformance()
		{
			this.IsCompleted = true;
			if (base.Context.IsReady)
			{
				base.Context.View.SetCgTransform(this.Target);
			}
		}

		// Token: 0x04014917 RID: 84247
		private readonly IVisualNovelPerformanceCgMove Performance;

		// Token: 0x04014918 RID: 84248
		private VisualNovelTransform Target;

		// Token: 0x04014919 RID: 84249
		private bool IsCompleted;
	}
}
