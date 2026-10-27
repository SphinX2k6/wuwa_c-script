using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Sequence.Seq_BP.BPSeqDissolve;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002CE3 RID: 11491
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class VideoBpController : ControllerBase
{
	// Token: 0x060181D7 RID: 98775 RVA: 0x00621F25 File Offset: 0x00620125
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x060181D8 RID: 98776 RVA: 0x00621F28 File Offset: 0x00620128
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x060181D9 RID: 98777 RVA: 0x00621F2B File Offset: 0x0062012B
	[NullableContext(2)]
	private BP_MediaDissolveManagea_C SpawnOrGetBp()
	{
		return VideoBpModel.Instance.SpawnOrGetVideoBp();
	}

	// Token: 0x060181DA RID: 98778 RVA: 0x00621F37 File Offset: 0x00620137
	public void RemoveBp()
	{
		VideoBpModel.Instance.RemoveOnVideoEnd();
	}

	// Token: 0x060181DB RID: 98779 RVA: 0x00621F43 File Offset: 0x00620143
	public void RemovePreload()
	{
		VideoBpModel.Instance.RemovePreload();
	}

	// Token: 0x060181DC RID: 98780 RVA: 0x00621F50 File Offset: 0x00620150
	public UniTask PreloadMp4s(List<string> mp4s)
	{
		VideoBpController.<PreloadMp4s>d__5 <PreloadMp4s>d__;
		<PreloadMp4s>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadMp4s>d__.<>4__this = this;
		<PreloadMp4s>d__.mp4s = mp4s;
		<PreloadMp4s>d__.<>1__state = -1;
		<PreloadMp4s>d__.<>t__builder.Start<VideoBpController.<PreloadMp4s>d__5>(ref <PreloadMp4s>d__);
		return <PreloadMp4s>d__.<>t__builder.Task;
	}

	// Token: 0x060181DD RID: 98781 RVA: 0x00621F9C File Offset: 0x0062019C
	private UniTask PreloadMp4Internal(string id)
	{
		VideoBpController.<PreloadMp4Internal>d__6 <PreloadMp4Internal>d__;
		<PreloadMp4Internal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadMp4Internal>d__.id = id;
		<PreloadMp4Internal>d__.<>1__state = -1;
		<PreloadMp4Internal>d__.<>t__builder.Start<VideoBpController.<PreloadMp4Internal>d__6>(ref <PreloadMp4Internal>d__);
		return <PreloadMp4Internal>d__.<>t__builder.Task;
	}

	// Token: 0x060181DE RID: 98782 RVA: 0x00621FE0 File Offset: 0x006201E0
	public unsafe bool PlayEffect(IPlayDissolveEffect inParams)
	{
		BP_MediaDissolveManagea_C bp = this.SpawnOrGetBp();
		if (bp == null)
		{
			global::Log.Instance.Info(ELogModule.Preload, ELogAuthor.JYS, "[VideoBp]生成VideoBp蓝图失败", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		VideoData? videoData = VideoConfig.Instance.GetVideoData(inParams.Path);
		if (videoData == null)
		{
			global::Log.Instance.Info(ELogModule.Preload, ELogAuthor.JYS, "[VideoBp]获取VideoData失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		UMediaSource fromPreloadMap = VideoBpModel.Instance.GetFromPreloadMap(videoData.Value.CgName);
		if (fromPreloadMap != null)
		{
			bp.PlayEffect(videoData.Value.CgFile, new FVector2D(inParams.ScreenPos.X.GetValueOrDefault(), inParams.ScreenPos.Y.GetValueOrDefault()), inParams.Scale.GetValueOrDefault(1f), inParams.FadeInTime.GetValueOrDefault(1f), inParams.FadeOutTime.GetValueOrDefault(1f), fromPreloadMap, inParams.IsFullScreenMask.GetValueOrDefault());
			return true;
		}
		ResourceSystem.Instance.LoadAsync<UMediaSource>(videoData.Value.CgFile, delegate([Nullable(2)] UMediaSource loadedMediaSource, string _)
		{
			if (loadedMediaSource == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Video;
				ELogAuthor author = ELogAuthor.JYS;
				string message = "VideoBpController mediaSource加载失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("配置名称", videoData.Value.CgName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("视频路径", videoData.Value.CgFile);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			bp.PlayEffect(videoData.Value.CgFile, new FVector2D(inParams.ScreenPos.X.GetValueOrDefault(), inParams.ScreenPos.Y.GetValueOrDefault()), inParams.Scale.GetValueOrDefault(1f), inParams.FadeInTime.GetValueOrDefault(1f), inParams.FadeOutTime.GetValueOrDefault(1f), loadedMediaSource, inParams.IsFullScreenMask.GetValueOrDefault());
		}, ResourceSystem.EResourceLoadPriority.Ui, "js_undefined");
		return true;
	}

	// Token: 0x17002081 RID: 8321
	// (get) Token: 0x060181DF RID: 98783 RVA: 0x0062217D File Offset: 0x0062037D
	public static VideoBpController Instance
	{
		get
		{
			return VideoBpController._Instance;
		}
	}

	// Token: 0x060181E0 RID: 98784 RVA: 0x00622184 File Offset: 0x00620384
	public static VideoBpController GetOrCreateInstance()
	{
		if (VideoBpController._Instance == null)
		{
			VideoBpController.CreateInstance();
		}
		return VideoBpController._Instance;
	}

	// Token: 0x060181E1 RID: 98785 RVA: 0x00622198 File Offset: 0x00620398
	public static bool CreateInstance()
	{
		if (VideoBpController._Instance != null)
		{
			return true;
		}
		VideoBpController._Instance = new VideoBpController();
		return true;
	}

	// Token: 0x060181E2 RID: 98786 RVA: 0x006221AE File Offset: 0x006203AE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060181E3 RID: 98787 RVA: 0x006221B0 File Offset: 0x006203B0
	public static void ResetStaticDefaultValue()
	{
		VideoBpController._Instance = null;
	}

	// Token: 0x060181E4 RID: 98788 RVA: 0x006221B8 File Offset: 0x006203B8
	static VideoBpController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VideoBpController.CreateStaticDefaultValue), new Action(VideoBpController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B35B RID: 45915
	[Nullable(2)]
	private static VideoBpController _Instance;
}
