using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018FD RID: 6397
[NullableContext(1)]
[Nullable(0)]
public class MediaPlayer
{
	// Token: 0x0600BB9C RID: 48028 RVA: 0x002A8AD8 File Offset: 0x002A6CD8
	public MediaPlayer(UUITexture texture)
	{
		this.CgTexture = texture;
		UMediaTexture umediaTexture = this.CgTexture.GetTexture() as UMediaTexture;
		this.MediaPlayerObj = ((umediaTexture != null) ? umediaTexture.GetMediaPlayer() : null);
		if (this.MediaPlayerObj == null)
		{
			Log.Instance.Error(ELogModule.Video, ELogAuthor.YYZ, "[MediaPlayer] 获取MediaPlayer异常", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.MediaPlayerObj.OnMediaOpened.Add(new Action<string>(this.OnMediaOpen));
		this.MediaPlayerObj.OnEndReached.Add(new Action(this.OnVideoEnd));
		this.MediaPlayerObj.OnMediaOpenFailed.Add(new Action<string>(this.OnVideoOpenFailed));
	}

	// Token: 0x0600BB9D RID: 48029 RVA: 0x002A8B98 File Offset: 0x002A6D98
	public void Clear()
	{
		this.CleanVideo();
		UMediaPlayer mediaPlayerObj = this.MediaPlayerObj;
		if (mediaPlayerObj != null)
		{
			mediaPlayerObj.OnMediaOpened.Remove(new Action<string>(this.OnMediaOpen));
		}
		UMediaPlayer mediaPlayerObj2 = this.MediaPlayerObj;
		if (mediaPlayerObj2 != null)
		{
			mediaPlayerObj2.OnEndReached.Remove(new Action(this.OnVideoEnd));
		}
		UMediaPlayer mediaPlayerObj3 = this.MediaPlayerObj;
		if (mediaPlayerObj3 != null)
		{
			mediaPlayerObj3.OnMediaOpenFailed.Remove(new Action<string>(this.OnVideoOpenFailed));
		}
		UMediaPlayer mediaPlayerObj4 = this.MediaPlayerObj;
		if (mediaPlayerObj4 != null)
		{
			mediaPlayerObj4.Close();
		}
		this.MediaPlayerObj = null;
	}

	// Token: 0x0600BB9E RID: 48030 RVA: 0x002A8C2C File Offset: 0x002A6E2C
	private void OnMediaOpen(string _)
	{
		if (this.StartSeekTime != null)
		{
			UMediaPlayer mediaPlayerObj = this.MediaPlayerObj;
			if (mediaPlayerObj != null)
			{
				mediaPlayerObj.Seek(this.StartSeekTime);
			}
			this.StartSeekTime = null;
		}
		UMediaPlayer mediaPlayerObj2 = this.MediaPlayerObj;
		if (mediaPlayerObj2 != null)
		{
			mediaPlayerObj2.Play();
		}
		Action<string> onVideoStartCallback = this.OnVideoStartCallback;
		if (onVideoStartCallback == null)
		{
			return;
		}
		onVideoStartCallback(this.VideoName);
	}

	// Token: 0x0600BB9F RID: 48031 RVA: 0x002A8C8E File Offset: 0x002A6E8E
	private void OnVideoEnd()
	{
		Action<string> onVideoEndCallback = this.OnVideoEndCallback;
		if (onVideoEndCallback == null)
		{
			return;
		}
		onVideoEndCallback(this.VideoName);
	}

	// Token: 0x0600BBA0 RID: 48032 RVA: 0x002A8CA8 File Offset: 0x002A6EA8
	private void OnVideoOpenFailed(string _)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Video;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[MediaPlayer] 视频文件打开失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("视频名称", this.VideoName);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600BBA1 RID: 48033 RVA: 0x002A8CE4 File Offset: 0x002A6EE4
	private void CleanVideo()
	{
		if (this.LoadHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadHandle);
			this.LoadHandle = -1;
		}
		if (this.MediaPlayerObj != null && !this.MediaPlayerObj.IsClosed())
		{
			this.MediaPlayerObj.Close();
		}
		this.VideoName = null;
	}

	// Token: 0x0600BBA2 RID: 48034 RVA: 0x002A8D38 File Offset: 0x002A6F38
	public unsafe void PlayVideo(string videoName, string videoPath, bool isLooping = false)
	{
		if (string.IsNullOrEmpty(videoPath))
		{
			return;
		}
		this.CleanVideo();
		this.LoadHandle = ResourceSystem.Instance.LoadAsync<UMediaSource>(videoPath, delegate([Nullable(2)] UMediaSource mediaSource, string _)
		{
			if (mediaSource == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Video;
				ELogAuthor author2 = ELogAuthor.YYZ;
				string message2 = "[MediaPlayer] mediaSource加载失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("配置名称", videoName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("视频路径", videoPath);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			this.LoadHandle = -1;
			if (!this.MediaPlayerObj.OpenSource(mediaSource))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Video;
				ELogAuthor author3 = ELogAuthor.YYZ;
				string message3 = "[MediaPlayer] 打开视频失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("配置名称", videoName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("视频路径", videoPath);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				this.MediaPlayerObj.Close();
				return;
			}
			this.MediaPlayerObj.SetLooping(isLooping);
			this.VideoName = videoName;
		}, 100, "Ui.UiVideo");
		if (this.LoadHandle < 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Video;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[MediaPlayer] mediaSource加载失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("配置名称", videoName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("视频路径", videoPath);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x0600BBA3 RID: 48035 RVA: 0x002A8E10 File Offset: 0x002A7010
	public UniTask LoadVideoAndPlay(string videoName, string videoPath, bool isLooping = false)
	{
		MediaPlayer.<LoadVideoAndPlay>d__14 <LoadVideoAndPlay>d__;
		<LoadVideoAndPlay>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadVideoAndPlay>d__.<>4__this = this;
		<LoadVideoAndPlay>d__.videoName = videoName;
		<LoadVideoAndPlay>d__.videoPath = videoPath;
		<LoadVideoAndPlay>d__.isLooping = isLooping;
		<LoadVideoAndPlay>d__.<>1__state = -1;
		<LoadVideoAndPlay>d__.<>t__builder.Start<MediaPlayer.<LoadVideoAndPlay>d__14>(ref <LoadVideoAndPlay>d__);
		return <LoadVideoAndPlay>d__.<>t__builder.Task;
	}

	// Token: 0x0600BBA4 RID: 48036 RVA: 0x002A8E6B File Offset: 0x002A706B
	public void StopVideo(string videoName)
	{
		if (this.VideoName != videoName)
		{
			return;
		}
		if (this.MediaPlayerObj.IsPlaying() || this.MediaPlayerObj.IsPaused())
		{
			this.MediaPlayerObj.Close();
		}
		this.VideoName = null;
	}

	// Token: 0x0600BBA5 RID: 48037 RVA: 0x002A8EA8 File Offset: 0x002A70A8
	public void PauseVideo(string videoName)
	{
		if (this.VideoName != videoName)
		{
			return;
		}
		if (this.MediaPlayerObj.IsPlaying())
		{
			this.MediaPlayerObj.Pause();
		}
	}

	// Token: 0x0600BBA6 RID: 48038 RVA: 0x002A8ED2 File Offset: 0x002A70D2
	public void ResumeVideo(string videoName)
	{
		if (this.VideoName != videoName)
		{
			return;
		}
		if (this.MediaPlayerObj.IsPaused())
		{
			this.MediaPlayerObj.Play();
		}
	}

	// Token: 0x0600BBA7 RID: 48039 RVA: 0x002A8EFC File Offset: 0x002A70FC
	public void BindCallbackOnVideoEnd([Nullable(new byte[]
	{
		1,
		2
	})] Action<string> callback)
	{
		this.OnVideoEndCallback = callback;
	}

	// Token: 0x0600BBA8 RID: 48040 RVA: 0x002A8F05 File Offset: 0x002A7105
	public void BindCallbackOnVideoStart([Nullable(new byte[]
	{
		1,
		2
	})] Action<string> callback)
	{
		this.OnVideoStartCallback = callback;
	}

	// Token: 0x0600BBA9 RID: 48041 RVA: 0x002A8F0E File Offset: 0x002A710E
	public float GetVideoAspect(int trackIndex = 0, int formatIndex = 0)
	{
		return this.MediaPlayerObj.GetVideoTrackAspectRatio(trackIndex, formatIndex);
	}

	// Token: 0x0600BBAA RID: 48042 RVA: 0x002A8F1D File Offset: 0x002A711D
	[NullableContext(2)]
	public FTimespan GetPlayTime()
	{
		UMediaPlayer mediaPlayerObj = this.MediaPlayerObj;
		if (mediaPlayerObj == null)
		{
			return null;
		}
		return mediaPlayerObj.GetTime();
	}

	// Token: 0x0600BBAB RID: 48043 RVA: 0x002A8F30 File Offset: 0x002A7130
	[NullableContext(2)]
	public void SetStartSeekTime(FTimespan time)
	{
		this.StartSeekTime = time;
	}

	// Token: 0x0400551F RID: 21791
	[Nullable(2)]
	protected UUITexture CgTexture;

	// Token: 0x04005520 RID: 21792
	[Nullable(2)]
	protected UMediaPlayer MediaPlayerObj;

	// Token: 0x04005521 RID: 21793
	[Nullable(2)]
	protected string VideoName;

	// Token: 0x04005522 RID: 21794
	private int LoadHandle = -1;

	// Token: 0x04005523 RID: 21795
	[Nullable(2)]
	private Action<string> OnVideoEndCallback;

	// Token: 0x04005524 RID: 21796
	[Nullable(2)]
	private Action<string> OnVideoStartCallback;

	// Token: 0x04005525 RID: 21797
	[Nullable(2)]
	private FTimespan StartSeekTime;
}
