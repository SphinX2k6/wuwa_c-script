using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000DB6 RID: 3510
[NullableContext(1)]
[Nullable(0)]
public class MediaPlayer
{
	// Token: 0x06008F86 RID: 36742 RVA: 0x002B3234 File Offset: 0x002B1434
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

	// Token: 0x06008F87 RID: 36743 RVA: 0x002B32F4 File Offset: 0x002B14F4
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

	// Token: 0x06008F88 RID: 36744 RVA: 0x002B3388 File Offset: 0x002B1588
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

	// Token: 0x06008F89 RID: 36745 RVA: 0x002B33EA File Offset: 0x002B15EA
	private void OnVideoEnd()
	{
		Action<string> onVideoEndCallback = this.OnVideoEndCallback;
		if (onVideoEndCallback == null)
		{
			return;
		}
		onVideoEndCallback(this.VideoName);
	}

	// Token: 0x06008F8A RID: 36746 RVA: 0x002B3404 File Offset: 0x002B1604
	private void OnVideoOpenFailed(string _)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Video;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[MediaPlayer] 视频文件打开失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("视频名称", this.VideoName);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06008F8B RID: 36747 RVA: 0x002B3440 File Offset: 0x002B1640
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

	// Token: 0x06008F8C RID: 36748 RVA: 0x002B3494 File Offset: 0x002B1694
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

	// Token: 0x06008F8D RID: 36749 RVA: 0x002B356C File Offset: 0x002B176C
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

	// Token: 0x06008F8E RID: 36750 RVA: 0x002B35C7 File Offset: 0x002B17C7
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

	// Token: 0x06008F8F RID: 36751 RVA: 0x002B3604 File Offset: 0x002B1804
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

	// Token: 0x06008F90 RID: 36752 RVA: 0x002B362E File Offset: 0x002B182E
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

	// Token: 0x06008F91 RID: 36753 RVA: 0x002B3658 File Offset: 0x002B1858
	public void BindCallbackOnVideoEnd([Nullable(new byte[]
	{
		1,
		2
	})] Action<string> callback)
	{
		this.OnVideoEndCallback = callback;
	}

	// Token: 0x06008F92 RID: 36754 RVA: 0x002B3661 File Offset: 0x002B1861
	public void BindCallbackOnVideoStart([Nullable(new byte[]
	{
		1,
		2
	})] Action<string> callback)
	{
		this.OnVideoStartCallback = callback;
	}

	// Token: 0x06008F93 RID: 36755 RVA: 0x002B366A File Offset: 0x002B186A
	public float GetVideoAspect(int trackIndex = 0, int formatIndex = 0)
	{
		return this.MediaPlayerObj.GetVideoTrackAspectRatio(trackIndex, formatIndex);
	}

	// Token: 0x06008F94 RID: 36756 RVA: 0x002B3679 File Offset: 0x002B1879
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

	// Token: 0x06008F95 RID: 36757 RVA: 0x002B368C File Offset: 0x002B188C
	[NullableContext(2)]
	public void SetStartSeekTime(FTimespan time)
	{
		this.StartSeekTime = time;
	}

	// Token: 0x040055CA RID: 21962
	[Nullable(2)]
	protected UUITexture CgTexture;

	// Token: 0x040055CB RID: 21963
	[Nullable(2)]
	protected UMediaPlayer MediaPlayerObj;

	// Token: 0x040055CC RID: 21964
	[Nullable(2)]
	protected string VideoName;

	// Token: 0x040055CD RID: 21965
	private int LoadHandle = -1;

	// Token: 0x040055CE RID: 21966
	[Nullable(2)]
	private Action<string> OnVideoEndCallback;

	// Token: 0x040055CF RID: 21967
	[Nullable(2)]
	private Action<string> OnVideoStartCallback;

	// Token: 0x040055D0 RID: 21968
	[Nullable(2)]
	private FTimespan StartSeekTime;
}
