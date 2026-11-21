using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037D0 RID: 14288
	public sealed class VisualNovelLeaveBlackScreenAction : VisualNovelAction
	{
		// Token: 0x06025322 RID: 152354 RVA: 0x00A7DDB4 File Offset: 0x00A7BFB4
		[NullableContext(1)]
		public VisualNovelLeaveBlackScreenAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			this.FadeOutTime = (((IVisualNovelPerformanceLeaveBlackScreen)performance).FadeOutTime ?? context.BlackScreenDuration);
		}

		// Token: 0x06025323 RID: 152355 RVA: 0x00A7DDF4 File Offset: 0x00A7BFF4
		protected override UniTask ExecuteCoreAsync()
		{
			float duration = VisualNovelPerformanceUtility.ResolveDuration(this.FadeOutTime, base.Context.PlaybackMode);
			return base.Context.Effects.LeaveBlackScreenAsync(duration);
		}

		// Token: 0x06025324 RID: 152356 RVA: 0x00A7DE29 File Offset: 0x00A7C029
		public override bool TryComplete()
		{
			if (!base.IsExecuting)
			{
				return false;
			}
			this.FinishPerformance();
			return true;
		}

		// Token: 0x06025325 RID: 152357 RVA: 0x00A7DE3C File Offset: 0x00A7C03C
		internal override void Release()
		{
			if (base.IsExecuting)
			{
				this.FinishPerformance();
			}
		}

		// Token: 0x06025326 RID: 152358 RVA: 0x00A7DE4C File Offset: 0x00A7C04C
		private void FinishPerformance()
		{
			base.Context.Effects.FinishLeaveBlackScreen();
		}

		// Token: 0x04014936 RID: 84278
		private readonly float FadeOutTime;
	}
}
