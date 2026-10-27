using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002CED RID: 11501
[NullableContext(2)]
[Nullable(0)]
public class VideoLauncher : IStaticVariableResetter
{
	// Token: 0x0601824F RID: 98895 RVA: 0x00622A89 File Offset: 0x00620C89
	static VideoLauncher()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VideoLauncher.CreateStaticDefaultValue), new Action(VideoLauncher.ResetStaticDefaultValue));
	}

	// Token: 0x06018250 RID: 98896 RVA: 0x00622AA8 File Offset: 0x00620CA8
	public static void CreateStaticDefaultValue()
	{
		VideoLauncher.CloseCallback = null;
		VideoLauncher.Param = null;
		VideoLauncher.FrameEvents = null;
	}

	// Token: 0x06018251 RID: 98897 RVA: 0x00622ABC File Offset: 0x00620CBC
	public static void ResetStaticDefaultValue()
	{
		VideoLauncher.CloseCallback = null;
		VideoLauncher.Param = null;
		VideoLauncher.FrameEvents = null;
	}

	// Token: 0x06018252 RID: 98898 RVA: 0x00622AD0 File Offset: 0x00620CD0
	private static void DoCallback()
	{
		if (VideoLauncher.CloseCallback != null)
		{
			Action closeCallback = VideoLauncher.CloseCallback;
			VideoLauncher.CloseCallback = null;
			closeCallback();
		}
	}

	// Token: 0x06018253 RID: 98899 RVA: 0x00622AE9 File Offset: 0x00620CE9
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

	// Token: 0x06018254 RID: 98900 RVA: 0x00622B0C File Offset: 0x00620D0C
	public static UniTask ShowVideoCgAsync([Nullable(1)] string videoName, Action videoCloseCb = null, IShowVideoCgConfig config = null)
	{
		VideoLauncher.<ShowVideoCgAsync>d__8 <ShowVideoCgAsync>d__;
		<ShowVideoCgAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowVideoCgAsync>d__.videoName = videoName;
		<ShowVideoCgAsync>d__.videoCloseCb = videoCloseCb;
		<ShowVideoCgAsync>d__.config = config;
		<ShowVideoCgAsync>d__.<>1__state = -1;
		<ShowVideoCgAsync>d__.<>t__builder.Start<VideoLauncher.<ShowVideoCgAsync>d__8>(ref <ShowVideoCgAsync>d__);
		return <ShowVideoCgAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06018255 RID: 98901 RVA: 0x00622B5F File Offset: 0x00620D5F
	public static void CloseVideoCg(Action<bool> callback = null)
	{
		VideoLauncher.CloseCallback = null;
		UiManager.Instance.CloseView(EUiViewName.VideoView, callback);
	}

	// Token: 0x06018256 RID: 98902 RVA: 0x00622B78 File Offset: 0x00620D78
	public static void SetupFrameEvent([Nullable(new byte[]
	{
		2,
		1
	})] List<IMp4FrameEvent> frameEvents)
	{
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

	// Token: 0x06018257 RID: 98903 RVA: 0x00622BDC File Offset: 0x00620DDC
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
			VideoLauncher.FrameEvents = VideoLauncher.FrameEvents.Take(num).ToList<IMp4FrameEvent>();
			FlowController.Instance.ExecuteSubActions(mp4FrameEvent2.EventActions, null, true);
		}
	}

	// Token: 0x0400B37E RID: 45950
	private static Action CloseCallback;

	// Token: 0x0400B37F RID: 45951
	private static IVideoParamHub Param;

	// Token: 0x0400B380 RID: 45952
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static List<IMp4FrameEvent> FrameEvents;

	// Token: 0x02009274 RID: 37492
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402F5CC RID: 193996
		[Nullable(0)]
		public static Action <0>__DoCallback;
	}
}
