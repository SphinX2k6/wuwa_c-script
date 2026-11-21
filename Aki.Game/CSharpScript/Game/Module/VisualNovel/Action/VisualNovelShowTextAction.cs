using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037DA RID: 14298
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelShowTextAction : VisualNovelAction
	{
		// Token: 0x06025362 RID: 152418 RVA: 0x00A7E999 File Offset: 0x00A7CB99
		public VisualNovelShowTextAction(VisualNovelContext context, VisualNovelItem item) : base(context)
		{
			this.Item = item;
		}

		// Token: 0x06025363 RID: 152419 RVA: 0x00A7E9AC File Offset: 0x00A7CBAC
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelShowTextAction.<ExecuteCoreAsync>d__2 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelShowTextAction.<ExecuteCoreAsync>d__2>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025364 RID: 152420 RVA: 0x00A7E9EF File Offset: 0x00A7CBEF
		public override bool TryComplete()
		{
			if (!base.IsExecuting || !base.Context.View.IsTyping)
			{
				return false;
			}
			base.Context.View.CompleteTyping();
			return true;
		}

		// Token: 0x06025365 RID: 152421 RVA: 0x00A7EA1E File Offset: 0x00A7CC1E
		internal override void Release()
		{
			if (base.IsExecuting)
			{
				base.Context.View.CompleteTyping();
			}
		}

		// Token: 0x04014950 RID: 84304
		private readonly VisualNovelItem Item;
	}
}
