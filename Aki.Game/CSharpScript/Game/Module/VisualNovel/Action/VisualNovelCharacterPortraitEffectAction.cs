using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037CD RID: 14285
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelCharacterPortraitEffectAction : VisualNovelAction
	{
		// Token: 0x06025310 RID: 152336 RVA: 0x00A7DA95 File Offset: 0x00A7BC95
		public VisualNovelCharacterPortraitEffectAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			this.Performance = (IVisualNovelPerformancePortraitEffect)performance;
		}

		// Token: 0x06025311 RID: 152337 RVA: 0x00A7DAAC File Offset: 0x00A7BCAC
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelCharacterPortraitEffectAction.<ExecuteCoreAsync>d__6 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelCharacterPortraitEffectAction.<ExecuteCoreAsync>d__6>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025312 RID: 152338 RVA: 0x00A7DAEF File Offset: 0x00A7BCEF
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

		// Token: 0x06025313 RID: 152339 RVA: 0x00A7DB09 File Offset: 0x00A7BD09
		internal override void Release()
		{
			this.IsReleased = true;
			if (base.IsExecuting)
			{
				this.FinishPerformance();
			}
		}

		// Token: 0x06025314 RID: 152340 RVA: 0x00A7DB20 File Offset: 0x00A7BD20
		private void FinishPerformance()
		{
			if (this.Character != null && this.EffectVersion != null)
			{
				this.Character.FinishEffect(this.EffectVersion.Value);
			}
		}

		// Token: 0x0401492C RID: 84268
		private readonly IVisualNovelPerformancePortraitEffect Performance;

		// Token: 0x0401492D RID: 84269
		[Nullable(2)]
		private VisualNovelCharacter Character;

		// Token: 0x0401492E RID: 84270
		private int? EffectVersion;

		// Token: 0x0401492F RID: 84271
		private bool IsCompletionRequested;

		// Token: 0x04014930 RID: 84272
		private bool IsReleased;
	}
}
