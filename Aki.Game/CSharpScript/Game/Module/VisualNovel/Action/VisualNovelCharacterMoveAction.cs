using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037CC RID: 14284
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelCharacterMoveAction : VisualNovelAction
	{
		// Token: 0x0602530A RID: 152330 RVA: 0x00A7D9AA File Offset: 0x00A7BBAA
		public VisualNovelCharacterMoveAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			this.Performance = (IVisualNovelPerformanceMove)performance;
		}

		// Token: 0x0602530B RID: 152331 RVA: 0x00A7D9C0 File Offset: 0x00A7BBC0
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelCharacterMoveAction.<ExecuteCoreAsync>d__6 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelCharacterMoveAction.<ExecuteCoreAsync>d__6>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602530C RID: 152332 RVA: 0x00A7DA03 File Offset: 0x00A7BC03
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

		// Token: 0x0602530D RID: 152333 RVA: 0x00A7DA1D File Offset: 0x00A7BC1D
		internal override void Release()
		{
			this.IsReleased = true;
			if (base.IsExecuting)
			{
				this.FinishPerformance();
			}
		}

		// Token: 0x0602530E RID: 152334 RVA: 0x00A7DA34 File Offset: 0x00A7BC34
		private bool CanContinue(VisualNovelScene scene)
		{
			return !this.IsReleased && !base.Context.IsStopped && base.Context.IsReady && base.Context.Scene == scene;
		}

		// Token: 0x0602530F RID: 152335 RVA: 0x00A7DA68 File Offset: 0x00A7BC68
		private void FinishPerformance()
		{
			if (this.Character != null && this.TransformVersion != null)
			{
				this.Character.FinishMove(this.TransformVersion.Value);
			}
		}

		// Token: 0x04014927 RID: 84263
		private readonly IVisualNovelPerformanceMove Performance;

		// Token: 0x04014928 RID: 84264
		[Nullable(2)]
		private VisualNovelCharacter Character;

		// Token: 0x04014929 RID: 84265
		private int? TransformVersion;

		// Token: 0x0401492A RID: 84266
		private bool IsCompletionRequested;

		// Token: 0x0401492B RID: 84267
		private bool IsReleased;
	}
}
