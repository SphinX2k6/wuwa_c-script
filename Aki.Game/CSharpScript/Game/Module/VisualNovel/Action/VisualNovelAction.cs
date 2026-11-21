using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037C4 RID: 14276
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class VisualNovelAction
	{
		// Token: 0x17004C8F RID: 19599
		// (get) Token: 0x060252DB RID: 152283 RVA: 0x00A7D238 File Offset: 0x00A7B438
		protected VisualNovelContext Context { get; }

		// Token: 0x17004C90 RID: 19600
		// (get) Token: 0x060252DC RID: 152284 RVA: 0x00A7D240 File Offset: 0x00A7B440
		protected float PlaybackRate
		{
			get
			{
				return this.PlaybackRateValue;
			}
		}

		// Token: 0x17004C91 RID: 19601
		// (get) Token: 0x060252DD RID: 152285 RVA: 0x00A7D248 File Offset: 0x00A7B448
		protected bool IsPaused
		{
			get
			{
				return this.IsPausedValue;
			}
		}

		// Token: 0x17004C92 RID: 19602
		// (get) Token: 0x060252DE RID: 152286 RVA: 0x00A7D250 File Offset: 0x00A7B450
		protected bool IsExecuting
		{
			get
			{
				return this.IsExecutingValue;
			}
		}

		// Token: 0x060252DF RID: 152287 RVA: 0x00A7D258 File Offset: 0x00A7B458
		protected VisualNovelAction(VisualNovelContext context)
		{
			this.Context = context;
			this.PlaybackRateValue = context.PlaybackRate;
			this.IsPausedValue = context.IsPaused;
		}

		// Token: 0x060252E0 RID: 152288 RVA: 0x00A7D280 File Offset: 0x00A7B480
		public UniTask ExecuteAsync()
		{
			VisualNovelAction.<ExecuteAsync>d__13 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<VisualNovelAction.<ExecuteAsync>d__13>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252E1 RID: 152289 RVA: 0x00A7D2C3 File Offset: 0x00A7B4C3
		public virtual void SetPlaybackRate(float playbackRate)
		{
			this.PlaybackRateValue = playbackRate;
		}

		// Token: 0x060252E2 RID: 152290 RVA: 0x00A7D2CC File Offset: 0x00A7B4CC
		public virtual void SetPaused(bool paused)
		{
			this.IsPausedValue = paused;
		}

		// Token: 0x060252E3 RID: 152291 RVA: 0x00A7D2D5 File Offset: 0x00A7B4D5
		public virtual bool TryComplete()
		{
			return false;
		}

		// Token: 0x060252E4 RID: 152292 RVA: 0x00A7D2D8 File Offset: 0x00A7B4D8
		internal virtual void Release()
		{
		}

		// Token: 0x060252E5 RID: 152293
		protected abstract UniTask ExecuteCoreAsync();

		// Token: 0x0401490C RID: 84236
		private float PlaybackRateValue;

		// Token: 0x0401490D RID: 84237
		private bool IsPausedValue;

		// Token: 0x0401490E RID: 84238
		private bool IsExecutingValue;
	}
}
