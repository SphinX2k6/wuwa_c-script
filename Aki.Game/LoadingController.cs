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

// Token: 0x02001544 RID: 5444
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class LoadingController : UiControllerBase
{
	// Token: 0x0600DA07 RID: 55815 RVA: 0x004098E5 File Offset: 0x00407AE5
	protected override bool OnInit()
	{
		LoadingModel.Instance.Speed = 25;
		return true;
	}

	// Token: 0x0600DA08 RID: 55816 RVA: 0x004098F4 File Offset: 0x00407AF4
	protected override bool OnClear()
	{
		UNavigationSystemV1.SetGameLoadingFlag(GlobalData.GameInstance, false);
		return true;
	}

	// Token: 0x0600DA09 RID: 55817 RVA: 0x00409902 File Offset: 0x00407B02
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PushDataCompleteNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPushDataCompleteNotify));
		Net.Instance.Register(ENotifyMessageId.ServerConfigVersionInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnServerConfigVersionInfoNotify));
	}

	// Token: 0x0600DA0A RID: 55818 RVA: 0x00409939 File Offset: 0x00407B39
	private void OnPushDataCompleteNotify(IMessage msg, Net.CallbackStatus status)
	{
		EventSystem.Instance.Emit(EEventName.OnLoadingNetDataDone);
	}

	// Token: 0x0600DA0B RID: 55819 RVA: 0x0040994C File Offset: 0x00407B4C
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

	// Token: 0x0600DA0C RID: 55820 RVA: 0x004099F9 File Offset: 0x00407BF9
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PushDataCompleteNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ServerConfigVersionInfoNotify);
	}

	// Token: 0x0600DA0D RID: 55821 RVA: 0x00409A18 File Offset: 0x00407C18
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

	// Token: 0x0600DA0E RID: 55822 RVA: 0x00409AEC File Offset: 0x00407CEC
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

	// Token: 0x0600DA0F RID: 55823 RVA: 0x00409BBD File Offset: 0x00407DBD
	private void OnWorldDone()
	{
		this.UpdateUidViewShow();
	}

	// Token: 0x0600DA10 RID: 55824 RVA: 0x00409BC5 File Offset: 0x00407DC5
	private void OnWorldDoneAndCloseLoading()
	{
		this.OnLoadingEnd();
	}

	// Token: 0x0600DA11 RID: 55825 RVA: 0x00409BCD File Offset: 0x00407DCD
	private void OnBeforeLoadMap()
	{
		this.OnLoadingStart();
	}

	// Token: 0x0600DA12 RID: 55826 RVA: 0x00409BD5 File Offset: 0x00407DD5
	private void OnTeleportStart(bool b)
	{
		this.OnLoadingStart();
	}

	// Token: 0x0600DA13 RID: 55827 RVA: 0x00409BDD File Offset: 0x00407DDD
	private void OnTeleportComplete(TeleportContext teleportContext)
	{
		this.OnLoadingEnd();
	}

	// Token: 0x0600DA14 RID: 55828 RVA: 0x00409BE5 File Offset: 0x00407DE5
	private void OnInstanceChange(int lastInsId, int newInsId)
	{
		LoadingModel.Instance.LastInstanceId = lastInsId;
	}

	// Token: 0x0600DA15 RID: 55829 RVA: 0x00409BF2 File Offset: 0x00407DF2
	private void OnLoadingStart()
	{
		UNavigationSystemV1.SetGameLoadingFlag(GlobalData.GameInstance, true);
	}

	// Token: 0x0600DA16 RID: 55830 RVA: 0x00409BFF File Offset: 0x00407DFF
	private void OnLoadingEnd()
	{
		UNavigationSystemV1.SetGameLoadingFlag(GlobalData.GameInstance, false);
		LoadingModel.Instance.LastInstanceId = 0;
	}

	// Token: 0x0600DA17 RID: 55831 RVA: 0x00409C18 File Offset: 0x00407E18
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

	// Token: 0x0600DA18 RID: 55832 RVA: 0x00409CE2 File Offset: 0x00407EE2
	private void OnChangeTeam()
	{
		if (!LoadingModel.Instance.IsLoadingView)
		{
			return;
		}
		this.HandleRoleBuffChangeInLoading();
	}

	// Token: 0x0600DA19 RID: 55833 RVA: 0x00409CF8 File Offset: 0x00407EF8
	private UniTask HandleRoleBuffChangeInLoading()
	{
		LoadingController.<HandleRoleBuffChangeInLoading>d__18 <HandleRoleBuffChangeInLoading>d__;
		<HandleRoleBuffChangeInLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleRoleBuffChangeInLoading>d__.<>1__state = -1;
		<HandleRoleBuffChangeInLoading>d__.<>t__builder.Start<LoadingController.<HandleRoleBuffChangeInLoading>d__18>(ref <HandleRoleBuffChangeInLoading>d__);
		return <HandleRoleBuffChangeInLoading>d__.<>t__builder.Task;
	}

	// Token: 0x0600DA1A RID: 55834 RVA: 0x00409D34 File Offset: 0x00407F34
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

	// Token: 0x0600DA1B RID: 55835 RVA: 0x00409D80 File Offset: 0x00407F80
	public UniTask GameModeCloseLoading()
	{
		LoadingController.<GameModeCloseLoading>d__20 <GameModeCloseLoading>d__;
		<GameModeCloseLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GameModeCloseLoading>d__.<>4__this = this;
		<GameModeCloseLoading>d__.<>1__state = -1;
		<GameModeCloseLoading>d__.<>t__builder.Start<LoadingController.<GameModeCloseLoading>d__20>(ref <GameModeCloseLoading>d__);
		return <GameModeCloseLoading>d__.<>t__builder.Task;
	}

	// Token: 0x0600DA1C RID: 55836 RVA: 0x00409DC4 File Offset: 0x00407FC4
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

	// Token: 0x0600DA1D RID: 55837 RVA: 0x00409E30 File Offset: 0x00408030
	public UniTask CloseLoadingView()
	{
		LoadingController.<CloseLoadingView>d__22 <CloseLoadingView>d__;
		<CloseLoadingView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseLoadingView>d__.<>4__this = this;
		<CloseLoadingView>d__.<>1__state = -1;
		<CloseLoadingView>d__.<>t__builder.Start<LoadingController.<CloseLoadingView>d__22>(ref <CloseLoadingView>d__);
		return <CloseLoadingView>d__.<>t__builder.Task;
	}

	// Token: 0x0600DA1E RID: 55838 RVA: 0x00409E73 File Offset: 0x00408073
	public void OpenFadeLoadingView(TOpenViewCallBack finishCallback = null)
	{
		UiManager.Instance.OpenView(EUiViewName.FadeLoadingView, null, finishCallback);
	}

	// Token: 0x0600DA1F RID: 55839 RVA: 0x00409E86 File Offset: 0x00408086
	public void CloseFadeLoadingView(Action<bool> finishCallback = null)
	{
		UiManager.Instance.CloseView(EUiViewName.FadeLoadingView, finishCallback);
	}

	// Token: 0x0600DA20 RID: 55840 RVA: 0x00409E98 File Offset: 0x00408098
	public void OpenVideoCenterView(TOpenViewCallBack finishCallback = null, string textKey = null)
	{
		UiManager.Instance.OpenView(EUiViewName.PlotTransitionView, textKey, finishCallback);
	}

	// Token: 0x0600DA21 RID: 55841 RVA: 0x00409EAB File Offset: 0x004080AB
	public void CloseVideoCenterView(Action<bool> finishCallback = null)
	{
		UiManager.Instance.CloseView(EUiViewName.PlotTransitionView, finishCallback);
	}

	// Token: 0x0600DA22 RID: 55842 RVA: 0x00409EBD File Offset: 0x004080BD
	[NullableContext(1)]
	public void OpenSpecialTransitionView(ISpecialTransitionViewParams @params, [Nullable(2)] TOpenViewCallBack finishCallback)
	{
		UiManager.Instance.OpenView(EUiViewName.SpecialTransitionView, @params, finishCallback);
	}

	// Token: 0x0600DA23 RID: 55843 RVA: 0x00409ED0 File Offset: 0x004080D0
	public void CloseSpecialTransitionView(Action<bool> finishCallback)
	{
		UiManager.Instance.CloseView(EUiViewName.SpecialTransitionView, finishCallback);
	}

	// Token: 0x0600DA24 RID: 55844 RVA: 0x00409EE4 File Offset: 0x004080E4
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

	// Token: 0x0600DA25 RID: 55845 RVA: 0x00409F80 File Offset: 0x00408180
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

	// Token: 0x0600DA26 RID: 55846 RVA: 0x0040A068 File Offset: 0x00408268
	[NullableContext(0)]
	public UniTask<bool> RequestLoadingConfigAsync()
	{
		LoadingController.<RequestLoadingConfigAsync>d__31 <RequestLoadingConfigAsync>d__;
		<RequestLoadingConfigAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestLoadingConfigAsync>d__.<>1__state = -1;
		<RequestLoadingConfigAsync>d__.<>t__builder.Start<LoadingController.<RequestLoadingConfigAsync>d__31>(ref <RequestLoadingConfigAsync>d__);
		return <RequestLoadingConfigAsync>d__.<>t__builder.Task;
	}

	// Token: 0x1700145B RID: 5211
	// (get) Token: 0x0600DA27 RID: 55847 RVA: 0x0040A0A3 File Offset: 0x004082A3
	[Nullable(1)]
	public static LoadingController Instance
	{
		[NullableContext(1)]
		get
		{
			return LoadingController._Instance;
		}
	}

	// Token: 0x0600DA28 RID: 55848 RVA: 0x0040A0AA File Offset: 0x004082AA
	[NullableContext(1)]
	public static LoadingController GetOrCreateInstance()
	{
		if (LoadingController._Instance == null)
		{
			LoadingController.CreateInstance();
		}
		return LoadingController._Instance;
	}

	// Token: 0x0600DA29 RID: 55849 RVA: 0x0040A0BE File Offset: 0x004082BE
	public static bool CreateInstance()
	{
		if (LoadingController._Instance != null)
		{
			return true;
		}
		LoadingController._Instance = new LoadingController();
		return true;
	}

	// Token: 0x0600DA2A RID: 55850 RVA: 0x0040A0D4 File Offset: 0x004082D4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DA2B RID: 55851 RVA: 0x0040A0D6 File Offset: 0x004082D6
	public static void ResetStaticDefaultValue()
	{
		LoadingController._Instance = null;
	}

	// Token: 0x0600DA2C RID: 55852 RVA: 0x0040A0DE File Offset: 0x004082DE
	static LoadingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoadingController.CreateStaticDefaultValue), new Action(LoadingController.ResetStaticDefaultValue));
	}

	// Token: 0x040079B1 RID: 31153
	private static LoadingController _Instance;

	// Token: 0x020077E2 RID: 30690
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04026E8B RID: 159371
		[Nullable(0)]
		public static Action <0>__FinishEndPromise;
	}
}
