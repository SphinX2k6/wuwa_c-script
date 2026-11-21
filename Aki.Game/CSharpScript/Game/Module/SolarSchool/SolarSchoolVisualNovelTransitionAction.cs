using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Module.VisualNovel.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A77 RID: 23159
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelTransitionAction : VisualNovelAction
	{
		// Token: 0x060390F8 RID: 233720 RVA: 0x00FFAF9F File Offset: 0x00FF919F
		public SolarSchoolVisualNovelTransitionAction(VisualNovelContext context, IVisualNovelPerformanceBase performance, [Nullable(2)] SolarSchoolRootView rootView) : base(context)
		{
			this.Performance = (IVisualNovelPerformanceTransition)performance;
			this.RootView = rootView;
		}

		// Token: 0x060390F9 RID: 233721 RVA: 0x00FFAFBC File Offset: 0x00FF91BC
		protected override UniTask ExecuteCoreAsync()
		{
			SolarSchoolVisualNovelTransitionAction.<ExecuteCoreAsync>d__4 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelTransitionAction.<ExecuteCoreAsync>d__4>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060390FA RID: 233722 RVA: 0x00FFAFFF File Offset: 0x00FF91FF
		public override void SetPlaybackRate(float playbackRate)
		{
			base.SetPlaybackRate(playbackRate);
			SolarSchoolVisualNovelTransition transition = this.Transition;
			if (transition == null)
			{
				return;
			}
			transition.SetPlaybackRate(playbackRate);
		}

		// Token: 0x060390FB RID: 233723 RVA: 0x00FFB019 File Offset: 0x00FF9219
		public override void SetPaused(bool paused)
		{
			base.SetPaused(paused);
			SolarSchoolVisualNovelTransition transition = this.Transition;
			if (transition == null)
			{
				return;
			}
			transition.SetPaused(paused);
		}

		// Token: 0x060390FC RID: 233724 RVA: 0x00FFB033 File Offset: 0x00FF9233
		public override bool TryComplete()
		{
			if (!base.IsExecuting)
			{
				return false;
			}
			SolarSchoolVisualNovelTransition transition = this.Transition;
			if (transition != null)
			{
				transition.Finish();
			}
			return true;
		}

		// Token: 0x060390FD RID: 233725 RVA: 0x00FFB051 File Offset: 0x00FF9251
		internal override void Release()
		{
			if (base.IsExecuting)
			{
				SolarSchoolVisualNovelTransition transition = this.Transition;
				if (transition == null)
				{
					return;
				}
				transition.Finish();
			}
		}

		// Token: 0x0401E05F RID: 122975
		private readonly IVisualNovelPerformanceTransition Performance;

		// Token: 0x0401E060 RID: 122976
		[Nullable(2)]
		private readonly SolarSchoolRootView RootView;

		// Token: 0x0401E061 RID: 122977
		[Nullable(2)]
		private SolarSchoolVisualNovelTransition Transition;
	}
}
