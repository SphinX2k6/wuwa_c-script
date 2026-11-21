using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037CF RID: 14287
	public sealed class VisualNovelEnterBlackScreenAction : VisualNovelAction
	{
		// Token: 0x0602531D RID: 152349 RVA: 0x00A7DCE8 File Offset: 0x00A7BEE8
		[NullableContext(1)]
		public VisualNovelEnterBlackScreenAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			IVisualNovelPerformanceEnterBlackScreen visualNovelPerformanceEnterBlackScreen = (IVisualNovelPerformanceEnterBlackScreen)performance;
			this.ScreenType = visualNovelPerformanceEnterBlackScreen.ScreenType.GetValueOrDefault();
			this.FadeInTime = (visualNovelPerformanceEnterBlackScreen.FadeInTime ?? context.BlackScreenDuration);
		}

		// Token: 0x0602531E RID: 152350 RVA: 0x00A7DD3C File Offset: 0x00A7BF3C
		protected override UniTask ExecuteCoreAsync()
		{
			float duration = VisualNovelPerformanceUtility.ResolveDuration(this.FadeInTime, base.Context.PlaybackMode);
			return base.Context.Effects.EnterBlackScreenAsync(this.ScreenType, duration);
		}

		// Token: 0x0602531F RID: 152351 RVA: 0x00A7DD77 File Offset: 0x00A7BF77
		public override bool TryComplete()
		{
			if (!base.IsExecuting)
			{
				return false;
			}
			this.FinishPerformance();
			return true;
		}

		// Token: 0x06025320 RID: 152352 RVA: 0x00A7DD8A File Offset: 0x00A7BF8A
		internal override void Release()
		{
			if (base.IsExecuting)
			{
				this.FinishPerformance();
			}
		}

		// Token: 0x06025321 RID: 152353 RVA: 0x00A7DD9A File Offset: 0x00A7BF9A
		private void FinishPerformance()
		{
			base.Context.Effects.FinishEnterBlackScreen(this.ScreenType);
		}

		// Token: 0x04014934 RID: 84276
		private readonly EVisualNovelBlackScreenType ScreenType;

		// Token: 0x04014935 RID: 84277
		private readonly float FadeInTime;
	}
}
