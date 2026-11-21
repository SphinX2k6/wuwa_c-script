using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037C6 RID: 14278
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelBackgroundMoveAction : VisualNovelAction
	{
		// Token: 0x060252EA RID: 152298 RVA: 0x00A7D3DE File Offset: 0x00A7B5DE
		public VisualNovelBackgroundMoveAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			this.Performance = (IVisualNovelPerformanceBackgroundMove)performance;
		}

		// Token: 0x060252EB RID: 152299 RVA: 0x00A7D3F4 File Offset: 0x00A7B5F4
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelBackgroundMoveAction.<ExecuteCoreAsync>d__5 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelBackgroundMoveAction.<ExecuteCoreAsync>d__5>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252EC RID: 152300 RVA: 0x00A7D437 File Offset: 0x00A7B637
		public override bool TryComplete()
		{
			if (!base.IsExecuting)
			{
				return false;
			}
			this.FinishPerformance();
			return true;
		}

		// Token: 0x060252ED RID: 152301 RVA: 0x00A7D44A File Offset: 0x00A7B64A
		internal override void Release()
		{
			if (base.IsExecuting)
			{
				this.FinishPerformance();
			}
		}

		// Token: 0x060252EE RID: 152302 RVA: 0x00A7D45A File Offset: 0x00A7B65A
		private void FinishPerformance()
		{
			this.IsCompleted = true;
			VisualNovelBackground background = this.Background;
			if (background == null)
			{
				return;
			}
			background.SetTransformImmediately(this.Target);
		}

		// Token: 0x04014912 RID: 84242
		private readonly IVisualNovelPerformanceBackgroundMove Performance;

		// Token: 0x04014913 RID: 84243
		private VisualNovelTransform Target;

		// Token: 0x04014914 RID: 84244
		[Nullable(2)]
		private VisualNovelBackground Background;

		// Token: 0x04014915 RID: 84245
		private bool IsCompleted;
	}
}
