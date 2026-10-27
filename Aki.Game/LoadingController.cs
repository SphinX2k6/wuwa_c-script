using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02002071 RID: 8305
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class LoadingController : UiControllerBase
{
	// Token: 0x0601059F RID: 66975 RVA: 0x003FD49D File Offset: 0x003FB69D
	protected override bool OnInit()
	{
		LoadingModel.Instance.Speed = 25;
		return true;
	}

	// Token: 0x060105A0 RID: 66976 RVA: 0x003FD4AC File Offset: 0x003FB6AC
	protected override bool OnClear()
	{
		UNavigationSystemV1.SetGameLoadingFlag(GlobalData.GameInstance, false);
		return true;
	}

	// Token: 0x060105A1 RID: 66977 RVA: 0x003FD4BA File Offset: 0x003FB6BA
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PushDataCompleteNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPushDataCompleteNotify));
		Net.Instance.Register(ENotifyMessageId.ServerConfigVersionInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnServerConfigVersionInfoNotify));
	}

	// Token: 0x060105A2 RID: 66978 RVA: 0x003FD4F1 File Offset: 0x003FB6F1
	private void OnPushDataCompleteNotify(IMessage msg, Net.CallbackStatus status)
	{
		EventSystem.Instance.Emit(EEventName.OnLoadingNetDataDone);
	}

	// Token: 0x060105A3 RID: 66979 RVA: 0x003FD504 File Offset: 0x003FB704
	private unsafe void OnServerConfigVersionInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		ServerConfigVersionInfoNotify serverConfigVersionInfoNotify = (ServerConfigVersionInfoNotify)msg;
		if (serverConfigVersionInfoNotify == null)
		{
			return;
		}
		LoginModel.Instance.ServerUniverseEditorVersion = new int?(serverConfigVersionInfoNotify.UniverseEditor);
		string configVersion = BaseConfigController.Instance.GetConfigVersion("UniverseEditorVersion");
		if (LoginModel.IsConfigVersionMismatch(configVersion, new int?(serverConfigVersionInfoNotify.UniverseEditor)))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.LJK;
			string message = "客户端与服务端配置版本不一致";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ClientUniverseEditor", configVersion);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ServerUniverseEditor", serverConfigVersionInfoNotify.UniverseEditor);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x060105A4 RID: 66980 RVA: 0x003FD5B1 File Offset: 0x003FB7B1
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PushDataCompleteNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ServerConfigVersionInfoNotify);
	}

	// Token: 0x060105A5 RID: 66981 RVA: 0x003FD5D0 File Offset: 0x003FB7D0
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		EventSystem.Instance.Add<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
	}

	// Token: 0x060105A6 RID: 66982 RVA: 0x003FD6A4 File Offset: 0x003FB8A4
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		EventSystem.Instance.Remove(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		EventSystem.Instance.Remove(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		EventSystem.Instance.Remove(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
	}

	// Token: 0x060105A7 RID: 66983 RVA: 0x003FD775 File Offset: 0x003FB975
	private void OnWorldDone()
	{
		this.UpdateUidViewShow();
	}

	// Token: 0x060105A8 RID: 66984 RVA: 0x003FD77D File Offset: 0x003FB97D
	private void OnWorldDoneAndCloseLoading()
	{
		this.OnLoadingEnd();
	}

	// Token: 0x060105A9 RID: 66985 RVA: 0x003FD785 File Offset: 0x003FB985
	private void OnBeforeLoadMap()
	{
		this.OnLoadingStart();
	}

	// Token: 0x060105AA RID: 66986 RVA: 0x003FD78D File Offset: 0x003FB98D
	private void OnTeleportStart(bool b)
	{
		this.OnLoadingStart();
	}

	// Token: 0x060105AB RID: 66987 RVA: 0x003FD795 File Offset: 0x003FB995
	private void OnTeleportComplete(TeleportContext teleportContext)
	{
		this.OnLoadingEnd();
	}

	// Token: 0x060105AC RID: 66988 RVA: 0x003FD79D File Offset: 0x003FB99D
	private void OnInstanceChange(int lastInsId, int newInsId)
	{
		LoadingModel.Instance.LastInstanceId = lastInsId;
	}

	// Token: 0x060105AD RID: 66989 RVA: 0x003FD7AA File Offset: 0x003FB9AA
	private void OnLoadingStart()
	{
		UNavigationSystemV1.SetGameLoadingFlag(GlobalData.GameInstance, true);
	}

	// Token: 0x060105AE RID: 66990 RVA: 0x003FD7B7 File Offset: 0x003FB9B7
	private void OnLoadingEnd()
	{
		UNavigationSystemV1.SetGameLoadingFlag(GlobalData.GameInstance, false);
		LoadingModel.Instance.LastInstanceId = 0;
	}

	// Token: 0x060105AF RID: 66991 RVA: 0x003FD7D0 File Offset: 0x003FB9D0
	public void UpdateUidViewShow()
	{
		bool isShowUidView = LoadingModel.Instance.IsShowUidView;
		if (UiManager.Instance.IsViewOpen(EUiViewName.UidView) != isShowUidView)
		{
			if (isShowUidView)
			{
				UiManager.Instance.OpenView(EUiViewName.UidView, null, null);
			}
			else
			{
				UiManager.Instance.CloseView(EUiViewName.UidView, null);
			}
		}
		if ((KuroApplication.IsBuildShipping() && KuroApplication.GetAppReleaseType() == "Product") || UKuroLauncherLibrary.GetAppInternalUseType() == "Marketing")
		{
			return;
		}
		if (!UiManager.Instance.IsViewOpen(EUiViewName.MView))
		{
			UiManager.Instance.OpenView(EUiViewName.MView, null, null);
		}
		if (!UiManager.Instance.IsViewOpen(EUiViewName.BcView) && BaseConfigController.Instance.GetRptIsOpen())
		{
			UiManager.Instance.OpenView(EUiViewName.BcView, null, null);
		}
	}

	// Token: 0x060105B0 RID: 66992 RVA: 0x003FD89A File Offset: 0x003FBA9A
	private void OnChangeTeam()
	{
		if (!LoadingModel.Instance.IsLoadingView)
		{
			return;
		}
		this.HandleRoleBuffChangeInLoading();
	}

	// Token: 0x060105B1 RID: 66993 RVA: 0x003FD8B0 File Offset: 0x003FBAB0
	private UniTask HandleRoleBuffChangeInLoading()
	{
		LoadingController.<HandleRoleBuffChangeInLoading>d__18 <HandleRoleBuffChangeInLoading>d__;
		<HandleRoleBuffChangeInLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleRoleBuffChangeInLoading>d__.<>1__state = -1;
		<HandleRoleBuffChangeInLoading>d__.<>t__builder.Start<LoadingController.<HandleRoleBuffChangeInLoading>d__18>(ref <HandleRoleBuffChangeInLoading>d__);
		return <HandleRoleBuffChangeInLoading>d__.<>t__builder.Task;
	}

	// Token: 0x060105B2 RID: 66994 RVA: 0x003FD8EC File Offset: 0x003FBAEC
	public UniTask GameModeOpenLoading(Action<bool> openCallback = null)
	{
		LoadingController.<GameModeOpenLoading>d__19 <GameModeOpenLoading>d__;
		<GameModeOpenLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GameModeOpenLoading>d__.<>4__this = this;
		<GameModeOpenLoading>d__.openCallback = openCallback;
		<GameModeOpenLoading>d__.<>1__state = -1;
		<GameModeOpenLoading>d__.<>t__builder.Start<LoadingController.<GameModeOpenLoading>d__19>(ref <GameModeOpenLoading>d__);
		return <GameModeOpenLoading>d__.<>t__builder.Task;
	}

	// Token: 0x060105B3 RID: 66995 RVA: 0x003FD938 File Offset: 0x003FBB38
	public UniTask GameModeCloseLoading()
	{
		LoadingController.<GameModeCloseLoading>d__20 <GameModeCloseLoading>d__;
		<GameModeCloseLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GameModeCloseLoading>d__.<>4__this = this;
		<GameModeCloseLoading>d__.<>1__state = -1;
		<GameModeCloseLoading>d__.<>t__builder.Start<LoadingController.<GameModeCloseLoading>d__20>(ref <GameModeCloseLoading>d__);
		return <GameModeCloseLoading>d__.<>t__builder.Task;
	}

	// Token: 0x060105B4 RID: 66996 RVA: 0x003FD97C File Offset: 0x003FBB7C
	public void OpenLoadingView(Action<bool> loadCallback = null, Action<bool> finishCallback = null)
	{
		NormalLoadingViewGlobalData.CreateFirstProgressPromise();
		NormalLoadingViewGlobalData.CreateFinishPromisePromise();
		this.SetProgress(10, null, 1, true, false);
		LoadingModel.Instance.SetIsLoading(true);
		EUiViewName openLoadingViewName = LoadingModel.Instance.GetOpenLoadingViewName();
		Action <>9__1;
		UiManager.Instance.OpenView(openLoadingViewName, null, delegate(bool result, int _)
		{
			Action<bool> loadCallback2 = loadCallback;
			if (loadCallback2 != null)
			{
				loadCallback2(result);
			}
			LoadingController <>4__this = this;
			int progress = 10;
			Action reachHandle;
			if ((reachHandle = <>9__1) == null)
			{
				reachHandle = (<>9__1 = delegate()
				{
					NormalLoadingViewGlobalData.FinishFirstProgressPromise();
					Action<bool> finishCallback2 = finishCallback;
					if (finishCallback2 == null)
					{
						return;
					}
					finishCallback2(true);
				});
			}
			<>4__this.SetProgress(progress, reachHandle, 1, false, false);
		});
	}

	// Token: 0x060105B5 RID: 66997 RVA: 0x003FD9E8 File Offset: 0x003FBBE8
	public UniTask CloseLoadingView()
	{
		LoadingController.<CloseLoadingView>d__22 <CloseLoadingView>d__;
		<CloseLoadingView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseLoadingView>d__.<>4__this = this;
		<CloseLoadingView>d__.<>1__state = -1;
		<CloseLoadingView>d__.<>t__builder.Start<LoadingController.<CloseLoadingView>d__22>(ref <CloseLoadingView>d__);
		return <CloseLoadingView>d__.<>t__builder.Task;
	}

	// Token: 0x060105B6 RID: 66998 RVA: 0x003FDA2B File Offset: 0x003FBC2B
	public void OpenFadeLoadingView(TOpenViewCallBack finishCallback = null)
	{
		UiManager.Instance.OpenView(EUiViewName.FadeLoadingView, null, finishCallback);
	}

	// Token: 0x060105B7 RID: 66999 RVA: 0x003FDA3E File Offset: 0x003FBC3E
	public void CloseFadeLoadingView(Action<bool> finishCallback = null)
	{
		UiManager.Instance.CloseView(EUiViewName.FadeLoadingView, finishCallback);
	}

	// Token: 0x060105B8 RID: 67000 RVA: 0x003FDA50 File Offset: 0x003FBC50
	public void OpenVideoCenterView(TOpenViewCallBack finishCallback = null, string textKey = null)
	{
		UiManager.Instance.OpenView(EUiViewName.PlotTransitionView, textKey, finishCallback);
	}

	// Token: 0x060105B9 RID: 67001 RVA: 0x003FDA63 File Offset: 0x003FBC63
	public void CloseVideoCenterView(Action<bool> finishCallback = null)
	{
		UiManager.Instance.CloseView(EUiViewName.PlotTransitionView, finishCallback);
	}

	// Token: 0x060105BA RID: 67002 RVA: 0x003FDA75 File Offset: 0x003FBC75
	[NullableContext(1)]
	public void OpenSpecialTransitionView(ISpecialTransitionViewParams @params, [Nullable(2)] TOpenViewCallBack finishCallback)
	{
		UiManager.Instance.OpenView(EUiViewName.SpecialTransitionView, @params, finishCallback);
	}

	// Token: 0x060105BB RID: 67003 RVA: 0x003FDA88 File Offset: 0x003FBC88
	public void CloseSpecialTransitionView(Action<bool> finishCallback)
	{
		UiManager.Instance.CloseView(EUiViewName.SpecialTransitionView, finishCallback);
	}

	// Token: 0x060105BC RID: 67004 RVA: 0x003FDA9C File Offset: 0x003FBC9C
	public void SetProgress(int progress, Action reachHandle = null, int speedRate = 1, bool reset = false, bool smooth = true)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Loading;
		ELogAuthor author = ELogAuthor.TL;
		string message = "SetProgress";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("progress", progress);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		LoadingModel instance2 = LoadingModel.Instance;
		if (reachHandle != null)
		{
			instance2.ReachHandleQueue.Push(new ValueTuple<int, Action>(progress, reachHandle));
		}
		if (reset)
		{
			instance2.CurrentProgress = 0f;
			instance2.ReachHandleQueue.Clear();
		}
		instance2.SpeedRate = speedRate;
		instance2.NextProgress = progress;
		instance2.NextProgress = Math.Min(instance2.NextProgress, 100);
		if (!smooth)
		{
			instance2.CurrentProgress = (float)progress;
		}
	}

	// Token: 0x060105BD RID: 67005 RVA: 0x003FDB38 File Offset: 0x003FBD38
	public unsafe void AddProgress(float progress, int maxProgress)
	{
		LoadingModel instance = LoadingModel.Instance;
		instance.NextProgress = (int)Math.Min((float)instance.NextProgress + progress, (float)maxProgress);
		instance.NextProgress = Math.Min(instance.NextProgress, 100);
		while (instance.ReachHandleQueue.Size > 0)
		{
			ValueTuple<int, Action> front = instance.ReachHandleQueue.Front;
			if ((float)front.Item1 > instance.CurrentProgress)
			{
				break;
			}
			instance.ReachHandleQueue.Pop();
			front.Item2();
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Loading;
			ELogAuthor author = ELogAuthor.TL;
			string message = "AddProgress";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("progress", progress);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("maxProgress", maxProgress);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x060105BE RID: 67006 RVA: 0x003FDC20 File Offset: 0x003FBE20
	[NullableContext(0)]
	public UniTask<bool> RequestLoadingConfigAsync()
	{
		LoadingController.<RequestLoadingConfigAsync>d__31 <RequestLoadingConfigAsync>d__;
		<RequestLoadingConfigAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestLoadingConfigAsync>d__.<>1__state = -1;
		<RequestLoadingConfigAsync>d__.<>t__builder.Start<LoadingController.<RequestLoadingConfigAsync>d__31>(ref <RequestLoadingConfigAsync>d__);
		return <RequestLoadingConfigAsync>d__.<>t__builder.Task;
	}

	// Token: 0x1700142E RID: 5166
	// (get) Token: 0x060105BF RID: 67007 RVA: 0x003FDC5B File Offset: 0x003FBE5B
	[Nullable(1)]
	public static LoadingController Instance
	{
		[NullableContext(1)]
		get
		{
			return LoadingController._Instance;
		}
	}

	// Token: 0x060105C0 RID: 67008 RVA: 0x003FDC62 File Offset: 0x003FBE62
	[NullableContext(1)]
	public static LoadingController GetOrCreateInstance()
	{
		if (LoadingController._Instance == null)
		{
			LoadingController.CreateInstance();
		}
		return LoadingController._Instance;
	}

	// Token: 0x060105C1 RID: 67009 RVA: 0x003FDC76 File Offset: 0x003FBE76
	public static bool CreateInstance()
	{
		if (LoadingController._Instance != null)
		{
			return true;
		}
		LoadingController._Instance = new LoadingController();
		return true;
	}

	// Token: 0x060105C2 RID: 67010 RVA: 0x003FDC8C File Offset: 0x003FBE8C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060105C3 RID: 67011 RVA: 0x003FDC8E File Offset: 0x003FBE8E
	public static void ResetStaticDefaultValue()
	{
		LoadingController._Instance = null;
	}

	// Token: 0x060105C4 RID: 67012 RVA: 0x003FDC96 File Offset: 0x003FBE96
	static LoadingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoadingController.CreateStaticDefaultValue), new Action(LoadingController.ResetStaticDefaultValue));
	}

	// Token: 0x040078C8 RID: 30920
	private static LoadingController _Instance;

	// Token: 0x0200865B RID: 34395
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402BB7C RID: 179068
		[Nullable(0)]
		public static Action <0>__FinishEndPromise;
	}
}
