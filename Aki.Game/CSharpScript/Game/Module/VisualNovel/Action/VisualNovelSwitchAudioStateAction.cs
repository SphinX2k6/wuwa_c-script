using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037DC RID: 14300
	public sealed class VisualNovelSwitchAudioStateAction : VisualNovelAction
	{
		// Token: 0x0602536A RID: 152426 RVA: 0x00A7EAC0 File Offset: 0x00A7CCC0
		[NullableContext(1)]
		public VisualNovelSwitchAudioStateAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			IVisualNovelPerformanceSwitchAudioState visualNovelPerformanceSwitchAudioState = (IVisualNovelPerformanceSwitchAudioState)performance;
			this.AudioState = visualNovelPerformanceSwitchAudioState.AudioState;
		}

		// Token: 0x0602536B RID: 152427 RVA: 0x00A7EAE7 File Offset: 0x00A7CCE7
		protected override UniTask ExecuteCoreAsync()
		{
			base.Context.Audio.SwitchState(this.AudioState);
			return UniTask.CompletedTask;
		}

		// Token: 0x04014952 RID: 84306
		[Nullable(2)]
		private readonly IAudioState AudioState;
	}
}
