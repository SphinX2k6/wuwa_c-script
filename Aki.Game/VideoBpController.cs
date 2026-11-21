using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Sequence.Seq_BP.BPSeqDissolve;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200223C RID: 8764
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class VideoBpController : ControllerBase
{
	// Token: 0x06015A56 RID: 88662 RVA: 0x00647B99 File Offset: 0x00645D99
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06015A57 RID: 88663 RVA: 0x00647B9C File Offset: 0x00645D9C
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06015A58 RID: 88664 RVA: 0x00647B9F File Offset: 0x00645D9F
	[NullableContext(2)]
	private BP_MediaDissolveManagea_C SpawnOrGetBp()
	{
		return VideoBpModel.Instance.SpawnOrGetVideoBp();
	}

	// Token: 0x06015A59 RID: 88665 RVA: 0x00647BAB File Offset: 0x00645DAB
	public void RemoveBp()
	{
		VideoBpModel.Instance.RemoveOnVideoEnd();
	}

	// Token: 0x06015A5A RID: 88666 RVA: 0x00647BB7 File Offset: 0x00645DB7
	public void RemovePreload()
	{
		VideoBpModel.Instance.RemovePreload();
	}

	// Token: 0x06015A5B RID: 88667 RVA: 0x00647BC4 File Offset: 0x00645DC4
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

	// Token: 0x06015A5C RID: 88668 RVA: 0x00647C10 File Offset: 0x00645E10
	private UniTask PreloadMp4Internal(string id)
	{
		VideoBpController.<PreloadMp4Internal>d__6 <PreloadMp4Internal>d__;
		<PreloadMp4Internal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadMp4Internal>d__.id = id;
		<PreloadMp4Internal>d__.<>1__state = -1;
		<PreloadMp4Internal>d__.<>t__builder.Start<VideoBpController.<PreloadMp4Internal>d__6>(ref <PreloadMp4Internal>d__);
		return <PreloadMp4Internal>d__.<>t__builder.Task;
	}

	// Token: 0x06015A5D RID: 88669 RVA: 0x00647C54 File Offset: 0x00645E54
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

	// Token: 0x170020D4 RID: 8404
	// (get) Token: 0x06015A5E RID: 88670 RVA: 0x00647DF1 File Offset: 0x00645FF1
	public static VideoBpController Instance
	{
		get
		{
			return VideoBpController._Instance;
		}
	}

	// Token: 0x06015A5F RID: 88671 RVA: 0x00647DF8 File Offset: 0x00645FF8
	public static VideoBpController GetOrCreateInstance()
	{
		if (VideoBpController._Instance == null)
		{
			VideoBpController.CreateInstance();
		}
		return VideoBpController._Instance;
	}

	// Token: 0x06015A60 RID: 88672 RVA: 0x00647E0C File Offset: 0x0064600C
	public static bool CreateInstance()
	{
		if (VideoBpController._Instance != null)
		{
			return true;
		}
		VideoBpController._Instance = new VideoBpController();
		return true;
	}

	// Token: 0x06015A61 RID: 88673 RVA: 0x00647E22 File Offset: 0x00646022
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015A62 RID: 88674 RVA: 0x00647E24 File Offset: 0x00646024
	public static void ResetStaticDefaultValue()
	{
		VideoBpController._Instance = null;
	}

	// Token: 0x06015A63 RID: 88675 RVA: 0x00647E2C File Offset: 0x0064602C
	static VideoBpController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VideoBpController.CreateStaticDefaultValue), new Action(VideoBpController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B6C7 RID: 46791
	[Nullable(2)]
	private static VideoBpController _Instance;
}
