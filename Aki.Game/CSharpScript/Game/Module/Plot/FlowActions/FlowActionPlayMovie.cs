using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004098 RID: 16536
	public class FlowActionPlayMovie : FlowActionBase
	{
		// Token: 0x06029E01 RID: 171521 RVA: 0x00BD733C File Offset: 0x00BD553C
		protected override void OnExecute()
		{
			PlayMovie playMovie = this.ActionInfo.Params as PlayMovie;
			ActionInfo nextAction = FlowController.Instance.GetNextAction(true);
			bool value = nextAction != null && nextAction.Name == EAction.PlayMovie;
			string videoName = (playMovie != null) ? playMovie.VideoName : null;
			Action videoCloseCb = delegate()
			{
				VideoLauncher.SetupFrameEvent(null, null);
				FlowController.Instance.EnableSkip(false);
				base.FinishExecute(true, true);
			};
			ShowVideoCgConfig showVideoCgConfig = new ShowVideoCgConfig();
			showVideoCgConfig.BackgroundFade = playMovie.BackgroundFade;
			showVideoCgConfig.RemainViewWhenEnd = new bool?(value);
			showVideoCgConfig.InPlot = new bool?(true);
			showVideoCgConfig.ProgramSpecialConfig = playMovie.ProgramSpecialConfig;
			showVideoCgConfig.Mp4FadeOutTime = playMovie.Mp4FadeOutTime;
			showVideoCgConfig.BlackBorderFadeOutTime = playMovie.BlackBorderFadeOutTime;
			showVideoCgConfig.Mp4BlendAnim = playMovie.Mp4BlendAnim;
			FlowContext context = this.Context;
			showVideoCgConfig.SeamlessEndOnTick = new bool?(context != null && context.SeamlessPlot);
			VideoLauncher.ShowVideoCg(videoName, videoCloseCb, showVideoCgConfig);
			VideoLauncher.SetupFrameEvent(playMovie.Mp4FrameEvents, null);
		}

		// Token: 0x06029E02 RID: 171522 RVA: 0x00BD7415 File Offset: 0x00BD5615
		protected override void OnInterruptExecute()
		{
			VideoLauncher.CloseVideoCg(null);
			VideoLauncher.SetupFrameEvent(null, null);
			base.FinishExecute(true, true);
		}
	}
}
