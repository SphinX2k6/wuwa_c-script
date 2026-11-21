using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002247 RID: 8775
[NullableContext(2)]
[Nullable(0)]
public class VideoLauncher : IStaticVariableResetter
{
	// Token: 0x06015ADE RID: 88798 RVA: 0x00648741 File Offset: 0x00646941
	static VideoLauncher()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VideoLauncher.CreateStaticDefaultValue), new Action(VideoLauncher.ResetStaticDefaultValue));
	}

	// Token: 0x06015ADF RID: 88799 RVA: 0x00648760 File Offset: 0x00646960
	public static void CreateStaticDefaultValue()
	{
		VideoLauncher.CloseCallback = null;
		VideoLauncher.Param = null;
		VideoLauncher.FrameEvents = null;
		VideoLauncher.FrameEventExecutor = null;
	}

	// Token: 0x06015AE0 RID: 88800 RVA: 0x0064877A File Offset: 0x0064697A
	public static void ResetStaticDefaultValue()
	{
		VideoLauncher.CloseCallback = null;
		VideoLauncher.Param = null;
		VideoLauncher.FrameEvents = null;
		VideoLauncher.FrameEventExecutor = null;
	}

	// Token: 0x06015AE1 RID: 88801 RVA: 0x00648794 File Offset: 0x00646994
	private static void DoCallback()
	{
		if (VideoLauncher.CloseCallback != null)
		{
			Action closeCallback = VideoLauncher.CloseCallback;
			VideoLauncher.CloseCallback = null;
			closeCallback();
		}
	}

	// Token: 0x06015AE2 RID: 88802 RVA: 0x006487AD File Offset: 0x006469AD
	public static void ShowVideoCg(string videoName, Action videoCloseCb = null, IShowVideoCgConfig config = null)
	{
		if (string.IsNullOrEmpty(videoName))
		{
			if (videoCloseCb != null)
			{
				videoCloseCb();
			}
			return;
		}
		VideoLauncher.ShowVideoCgAsync(videoName, videoCloseCb, config).Forget();
	}

	// Token: 0x06015AE3 RID: 88803 RVA: 0x006487D0 File Offset: 0x006469D0
	public static UniTask ShowVideoCgAsync([Nullable(1)] string videoName, Action videoCloseCb = null, IShowVideoCgConfig config = null)
	{
		VideoLauncher.<ShowVideoCgAsync>d__9 <ShowVideoCgAsync>d__;
		<ShowVideoCgAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowVideoCgAsync>d__.videoName = videoName;
		<ShowVideoCgAsync>d__.videoCloseCb = videoCloseCb;
		<ShowVideoCgAsync>d__.config = config;
		<ShowVideoCgAsync>d__.<>1__state = -1;
		<ShowVideoCgAsync>d__.<>t__builder.Start<VideoLauncher.<ShowVideoCgAsync>d__9>(ref <ShowVideoCgAsync>d__);
		return <ShowVideoCgAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015AE4 RID: 88804 RVA: 0x00648823 File Offset: 0x00646A23
	public static void CloseVideoCg(Action<bool> callback = null)
	{
		VideoLauncher.CloseCallback = null;
		UiManager.Instance.CloseView(EUiViewName.VideoView, callback);
	}

	// Token: 0x06015AE5 RID: 88805 RVA: 0x0064883C File Offset: 0x00646A3C
	public static void SetupFrameEvent([Nullable(new byte[]
	{
		2,
		1
	})] List<IMp4FrameEvent> frameEvents, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Action<List<ActionInfo>> executor = null)
	{
		VideoLauncher.FrameEventExecutor = executor;
		if (frameEvents == null)
		{
			VideoLauncher.FrameEvents = null;
			return;
		}
		VideoLauncher.FrameEvents = new List<IMp4FrameEvent>();
		VideoLauncher.FrameEvents.AddRange(frameEvents);
		if (VideoLauncher.FrameEvents.Count > 0)
		{
			VideoLauncher.FrameEvents.Sort((IMp4FrameEvent a, IMp4FrameEvent b) => b.Second.CompareTo(a.Second));
		}
	}

	// Token: 0x06015AE6 RID: 88806 RVA: 0x006488A4 File Offset: 0x00646AA4
	public static void OnCheckFrameEvent(int playTime)
	{
		if (VideoLauncher.FrameEvents == null)
		{
			return;
		}
		while (VideoLauncher.FrameEvents.Count > 0)
		{
			int num = VideoLauncher.FrameEvents.Count - 1;
			IMp4FrameEvent mp4FrameEvent = VideoLauncher.FrameEvents[num];
			if (mp4FrameEvent.Second > (float)playTime * 0.001f)
			{
				break;
			}
			IMp4FrameEvent mp4FrameEvent2 = mp4FrameEvent;
			VideoLauncher.FrameEvents = VideoLauncher.FrameEvents.GetRange(0, num);
			if (VideoLauncher.FrameEventExecutor != null)
			{
				VideoLauncher.FrameEventExecutor(mp4FrameEvent2.EventActions);
			}
			else
			{
				FlowController.Instance.ExecuteSubActions(mp4FrameEvent2.EventActions, null, true);
			}
		}
	}

	// Token: 0x0400B6F1 RID: 46833
	private static Action CloseCallback;

	// Token: 0x0400B6F2 RID: 46834
	private static IVideoParamHub Param;

	// Token: 0x0400B6F3 RID: 46835
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static List<IMp4FrameEvent> FrameEvents;

	// Token: 0x0400B6F4 RID: 46836
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Action<List<ActionInfo>> FrameEventExecutor;

	// Token: 0x0200849B RID: 33947
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402AC50 RID: 175184
		[Nullable(0)]
		public static Action <0>__DoCallback;
	}
}
