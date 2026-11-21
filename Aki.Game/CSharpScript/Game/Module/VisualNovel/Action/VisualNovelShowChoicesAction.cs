using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037D9 RID: 14297
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelShowChoicesAction : VisualNovelAction
	{
		// Token: 0x0602535C RID: 152412 RVA: 0x00A7E8DE File Offset: 0x00A7CADE
		public VisualNovelShowChoicesAction(VisualNovelContext context, VisualNovelItem item) : base(context)
		{
			this.Item = item;
		}

		// Token: 0x0602535D RID: 152413 RVA: 0x00A7E8F0 File Offset: 0x00A7CAF0
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelShowChoicesAction.<ExecuteCoreAsync>d__3 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelShowChoicesAction.<ExecuteCoreAsync>d__3>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602535E RID: 152414 RVA: 0x00A7E933 File Offset: 0x00A7CB33
		public override void SetPlaybackRate(float playbackRate)
		{
			base.SetPlaybackRate(playbackRate);
			VisualNovelAction optionPerformances = this.OptionPerformances;
			if (optionPerformances == null)
			{
				return;
			}
			optionPerformances.SetPlaybackRate(base.PlaybackRate);
		}

		// Token: 0x0602535F RID: 152415 RVA: 0x00A7E952 File Offset: 0x00A7CB52
		public override void SetPaused(bool paused)
		{
			base.SetPaused(paused);
			VisualNovelAction optionPerformances = this.OptionPerformances;
			if (optionPerformances == null)
			{
				return;
			}
			optionPerformances.SetPaused(paused);
		}

		// Token: 0x06025360 RID: 152416 RVA: 0x00A7E96C File Offset: 0x00A7CB6C
		public override bool TryComplete()
		{
			VisualNovelAction optionPerformances = this.OptionPerformances;
			return optionPerformances != null && optionPerformances.TryComplete();
		}

		// Token: 0x06025361 RID: 152417 RVA: 0x00A7E97F File Offset: 0x00A7CB7F
		internal override void Release()
		{
			VisualNovelAction optionPerformances = this.OptionPerformances;
			if (optionPerformances != null)
			{
				optionPerformances.Release();
			}
			this.OptionPerformances = null;
		}

		// Token: 0x0401494E RID: 84302
		private readonly VisualNovelItem Item;

		// Token: 0x0401494F RID: 84303
		[Nullable(2)]
		private VisualNovelAction OptionPerformances;
	}
}
