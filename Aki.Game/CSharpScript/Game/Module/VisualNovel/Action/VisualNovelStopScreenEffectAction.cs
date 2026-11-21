using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037DB RID: 14299
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelStopScreenEffectAction : VisualNovelAction
	{
		// Token: 0x06025366 RID: 152422 RVA: 0x00A7EA38 File Offset: 0x00A7CC38
		public VisualNovelStopScreenEffectAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			IVisualNovelPerformanceStopScreenEffect visualNovelPerformanceStopScreenEffect = (IVisualNovelPerformanceStopScreenEffect)performance;
			IVisualNovelStopScreenEffectPersistent effectConfig = visualNovelPerformanceStopScreenEffect.EffectConfig;
			this.EffectPath = (((effectConfig != null) ? effectConfig.PersistentEffectPath : null) ?? string.Empty);
		}

		// Token: 0x06025367 RID: 152423 RVA: 0x00A7EA74 File Offset: 0x00A7CC74
		protected override UniTask ExecuteCoreAsync()
		{
			return base.Context.View.StopScreenEffectAsync(this.EffectPath);
		}

		// Token: 0x06025368 RID: 152424 RVA: 0x00A7EA8C File Offset: 0x00A7CC8C
		public override bool TryComplete()
		{
			if (!base.IsExecuting)
			{
				return false;
			}
			base.Context.View.CompleteScreenEffect(this.EffectPath);
			return true;
		}

		// Token: 0x06025369 RID: 152425 RVA: 0x00A7EAAF File Offset: 0x00A7CCAF
		internal override void Release()
		{
			if (base.IsExecuting)
			{
				this.TryComplete();
			}
		}

		// Token: 0x04014951 RID: 84305
		private readonly string EffectPath;
	}
}
