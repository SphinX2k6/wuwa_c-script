using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050C8 RID: 20680
	public class FlowActionPlayMovie : FlowActionBase
	{
		// Token: 0x06034F08 RID: 216840 RVA: 0x00C8A054 File Offset: 0x00C88254
		protected override void OnExecute()
		{
			PlayMovie playMovie = this.ActionInfo.Params as PlayMovie;
			ActionInfo nextAction = FlowController.Instance.GetNextAction(true);
			bool value = nextAction != null && nextAction.Name == EAction.PlayMovie;
			string videoName = (playMovie != null) ? playMovie.VideoName : null;
			Action videoCloseCb = delegate()
			{
				VideoLauncher.SetupFrameEvent(null);
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
			VideoLauncher.SetupFrameEvent(playMovie.Mp4FrameEvents);
		}

		// Token: 0x06034F09 RID: 216841 RVA: 0x00C8A12C File Offset: 0x00C8832C
		protected override void OnInterruptExecute()
		{
			VideoLauncher.CloseVideoCg(null);
			VideoLauncher.SetupFrameEvent(null);
			base.FinishExecute(true, true);
		}
	}
}
