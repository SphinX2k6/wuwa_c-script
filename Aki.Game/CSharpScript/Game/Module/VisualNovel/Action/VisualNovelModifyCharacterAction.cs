using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037D1 RID: 14289
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelModifyCharacterAction : VisualNovelAction
	{
		// Token: 0x06025327 RID: 152359 RVA: 0x00A7DE5E File Offset: 0x00A7C05E
		public VisualNovelModifyCharacterAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			this.Performance = (IVisualNovelPerformanceModifyRole)performance;
		}

		// Token: 0x06025328 RID: 152360 RVA: 0x00A7DE74 File Offset: 0x00A7C074
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelModifyCharacterAction.<ExecuteCoreAsync>d__3 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelModifyCharacterAction.<ExecuteCoreAsync>d__3>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025329 RID: 152361 RVA: 0x00A7DEB7 File Offset: 0x00A7C0B7
		internal override void Release()
		{
			this.IsReleased = true;
		}

		// Token: 0x04014937 RID: 84279
		private readonly IVisualNovelPerformanceModifyRole Performance;

		// Token: 0x04014938 RID: 84280
		private bool IsReleased;
	}
}
