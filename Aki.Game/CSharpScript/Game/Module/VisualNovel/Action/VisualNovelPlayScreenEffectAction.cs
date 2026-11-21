using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037D6 RID: 14294
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelPlayScreenEffectAction : VisualNovelAction
	{
		// Token: 0x0602534B RID: 152395 RVA: 0x00A7E554 File Offset: 0x00A7C754
		public VisualNovelPlayScreenEffectAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			this.EffectConfig = ((IVisualNovelPerformancePlayScreenEffect)performance).EffectConfig;
		}

		// Token: 0x0602534C RID: 152396 RVA: 0x00A7E57C File Offset: 0x00A7C77C
		protected override UniTask ExecuteCoreAsync()
		{
			IVisualNovelPlayScreenEffectConfigBase effectConfig = this.EffectConfig;
			IVisualNovelPlayScreenEffectOneShot visualNovelPlayScreenEffectOneShot = effectConfig as IVisualNovelPlayScreenEffectOneShot;
			if (visualNovelPlayScreenEffectOneShot != null)
			{
				this.EffectPath = visualNovelPlayScreenEffectOneShot.OneShotEffectPath;
				return base.Context.View.PlayScreenEffectAsync(this.EffectPath, false);
			}
			IVisualNovelPlayScreenEffectPersistent visualNovelPlayScreenEffectPersistent = effectConfig as IVisualNovelPlayScreenEffectPersistent;
			if (visualNovelPlayScreenEffectPersistent != null)
			{
				this.EffectPath = visualNovelPlayScreenEffectPersistent.PersistentEffectPath;
				return base.Context.View.PlayScreenEffectAsync(this.EffectPath, true);
			}
			IVisualNovelPlayScreenEffectCustom visualNovelPlayScreenEffectCustom = effectConfig as IVisualNovelPlayScreenEffectCustom;
			if (visualNovelPlayScreenEffectCustom == null)
			{
				global::Log.Instance.Error(ELogModule.VisualNovel, ELogAuthor.LZK, "视觉小说 PlayScreenEffect 缺少有效的 EffectConfig", default(ReadOnlySpan<ValueTuple<string, object>>));
				return UniTask.CompletedTask;
			}
			return base.Context.View.PlayCustomScreenEffectAsync(visualNovelPlayScreenEffectCustom.CustomType);
		}

		// Token: 0x0602534D RID: 152397 RVA: 0x00A7E634 File Offset: 0x00A7C834
		public override bool TryComplete()
		{
			if (!base.IsExecuting)
			{
				return false;
			}
			IVisualNovelPlayScreenEffectCustom visualNovelPlayScreenEffectCustom = this.EffectConfig as IVisualNovelPlayScreenEffectCustom;
			if (visualNovelPlayScreenEffectCustom != null)
			{
				base.Context.View.CompleteCustomScreenEffect(visualNovelPlayScreenEffectCustom.CustomType);
			}
			else if (!string.IsNullOrEmpty(this.EffectPath))
			{
				base.Context.View.CompleteScreenEffect(this.EffectPath);
			}
			return true;
		}

		// Token: 0x0602534E RID: 152398 RVA: 0x00A7E696 File Offset: 0x00A7C896
		internal override void Release()
		{
			if (base.IsExecuting)
			{
				this.TryComplete();
			}
		}

		// Token: 0x04014944 RID: 84292
		private readonly IVisualNovelPlayScreenEffectConfigBase EffectConfig;

		// Token: 0x04014945 RID: 84293
		private string EffectPath = string.Empty;
	}
}
