using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037CB RID: 14283
	public sealed class VisualNovelCharacterIntroductionAction : VisualNovelAction
	{
		// Token: 0x06025304 RID: 152324 RVA: 0x00A7D85C File Offset: 0x00A7BA5C
		[NullableContext(1)]
		public VisualNovelCharacterIntroductionAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			IVisualNovelPerformanceRoleIntroduction visualNovelPerformanceRoleIntroduction = (IVisualNovelPerformanceRoleIntroduction)performance;
			IVisualNovelRoleIntroductionSolarSchool roleIntroductionConfig = visualNovelPerformanceRoleIntroduction.RoleIntroductionConfig;
			this.CharacterId = ((roleIntroductionConfig != null) ? roleIntroductionConfig.IntroductionId : 0);
			IVisualNovelRoleIntroductionSolarSchool roleIntroductionConfig2 = visualNovelPerformanceRoleIntroduction.RoleIntroductionConfig;
			this.Duration = (((roleIntroductionConfig2 != null) ? roleIntroductionConfig2.Duration : null) ?? context.CharacterIntroductionDuration);
		}

		// Token: 0x06025305 RID: 152325 RVA: 0x00A7D8C8 File Offset: 0x00A7BAC8
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelCharacterIntroductionAction.<ExecuteCoreAsync>d__5 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelCharacterIntroductionAction.<ExecuteCoreAsync>d__5>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025306 RID: 152326 RVA: 0x00A7D90B File Offset: 0x00A7BB0B
		public override void SetPlaybackRate(float playbackRate)
		{
			base.SetPlaybackRate(playbackRate);
			VisualNovelDelayAction displayDuration = this.DisplayDuration;
			if (displayDuration == null)
			{
				return;
			}
			displayDuration.SetPlaybackRate(playbackRate);
		}

		// Token: 0x06025307 RID: 152327 RVA: 0x00A7D925 File Offset: 0x00A7BB25
		public override void SetPaused(bool paused)
		{
			base.SetPaused(paused);
			VisualNovelDelayAction displayDuration = this.DisplayDuration;
			if (displayDuration == null)
			{
				return;
			}
			displayDuration.SetPaused(paused);
		}

		// Token: 0x06025308 RID: 152328 RVA: 0x00A7D93F File Offset: 0x00A7BB3F
		public override bool TryComplete()
		{
			if (!base.IsExecuting)
			{
				return false;
			}
			this.CompleteRequested = true;
			VisualNovelDelayAction displayDuration = this.DisplayDuration;
			if (displayDuration != null && displayDuration.TryComplete())
			{
				return true;
			}
			base.Context.View.HideCharacterIntroduction();
			return true;
		}

		// Token: 0x06025309 RID: 152329 RVA: 0x00A7D979 File Offset: 0x00A7BB79
		internal override void Release()
		{
			this.CompleteRequested = true;
			VisualNovelDelayAction displayDuration = this.DisplayDuration;
			if (displayDuration != null)
			{
				displayDuration.Release();
			}
			this.DisplayDuration = null;
			base.Context.View.HideCharacterIntroduction();
		}

		// Token: 0x04014923 RID: 84259
		private readonly int CharacterId;

		// Token: 0x04014924 RID: 84260
		private readonly float Duration;

		// Token: 0x04014925 RID: 84261
		[Nullable(2)]
		private VisualNovelDelayAction DisplayDuration;

		// Token: 0x04014926 RID: 84262
		private bool CompleteRequested;
	}
}
