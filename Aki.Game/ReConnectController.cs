using System;
using System.Collections.Frozen;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.UI.Module.Loading.View;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02001C35 RID: 7221
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ReConnectController : UiControllerBase
{
	// Token: 0x17001B40 RID: 6976
	// (get) Token: 0x06011EF3 RID: 73459 RVA: 0x00546F7C File Offset: 0x0054517C
	public bool IsAnyNetworkReconnectViewOpen
	{
		get
		{
			foreach (EUiViewName viewName in this.NetworkReconnectViewNames)
			{
				if (UiManager.Instance.IsViewOpen(viewName))
				{
					return true;
				}
			}
			return false;
		}
	}

	// Token: 0x06011EF4 RID: 73460 RVA: 0x00546FDC File Offset: 0x005451DC
	protected override bool OnInit()
	{
		Heartbeat.Instance.SetMaxTimeOutHandler(new Action(this.OnHeartbeatTimeout));
		Net.Instance.SetAddRequestMaskHandle(new Action<int>(this.OnRequestMaskAdd));
		Net.Instance.SetRemoveRequestMaskHandle(new Action<int>(this.OnRequestMaskRemove));
		Net.Instance.SetNetworkErrorHandle(new Net.TNetworkErrorHandle(this.OnNetWorkError));
		if (Info.Instance.IsMobilePlatform())
		{
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ApplicationHasReactivated));
		}
		return true;
	}

	// Token: 0x06011EF5 RID: 73461 RVA: 0x00547065 File Offset: 0x00545265
	protected override bool OnClear()
	{
		if (Info.Instance.IsMobilePlatform())
		{
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ApplicationHasReactivated));
		}
		return true;
	}

	// Token: 0x06011EF6 RID: 73462 RVA: 0x0054708B File Offset: 0x0054528B
	private void OnRequestMaskAdd(int rpcId)
	{
		ReConnectModel.Instance.AddRpc(rpcId);
		this.OpenNetworkMaskView();
		EventSystem.Instance.Emit<int>(EEventName.NetWorkMaskRpcAdd, rpcId);
	}

	// Token: 0x06011EF7 RID: 73463 RVA: 0x005470AF File Offset: 0x005452AF
	private void OnRequestMaskRemove(int rpcId)
	{
		ReConnectModel.Instance.DelRpc(rpcId);
		if (ReConnectModel.Instance.IsRpcEmpty())
		{
			UiManager.Instance.CloseView(EUiViewName.NetWorkMaskView, null);
		}
		EventSystem.Instance.Emit<int>(EEventName.NetWorkMaskRpcRemove, rpcId);
	}

	// Token: 0x06011EF8 RID: 73464 RVA: 0x005470E9 File Offset: 0x005452E9
	protected override void OnAddEvents()
	{
		ReConnectModel instance = ReConnectModel.Instance;
		instance.LastNetworkType = AppUtil.GetNetworkConnectionType();
		instance.NetworkListener.NetworkChangeDelegate.Add(new Action<byte>(this.OnNetworkTypeChange));
	}

	// Token: 0x06011EF9 RID: 73465 RVA: 0x00547116 File Offset: 0x00545316
	protected override void OnRemoveEvents()
	{
		ReConnectModel.Instance.NetworkListener.NetworkChangeDelegate.Remove(new Action<byte>(this.OnNetworkTypeChange));
	}

	// Token: 0x06011EFA RID: 73466 RVA: 0x00547138 File Offset: 0x00545338
	public unsafe void Logout(ELogoutReason reason)
	{
		bool flag = ReConnectModel.Instance.GetReConnectStatus() > EReConnectStatus.NoReConnect;
		if (flag)
		{
			ReconnectProcessReporter.ReportReconnectProcess(EReconnectProcessStep.ReconvCancel, Aki.Protocol.ErrorCode.Success);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Reconnect;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "调用登出";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("原因", reason.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("是否正在重连", flag);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		ReConnectModel.Instance.AddReConnectIncId();
		this.BackLoginView(EBackLoginViewReason.Logout, false);
	}

	// Token: 0x06011EFB RID: 73467 RVA: 0x005471D2 File Offset: 0x005453D2
	public void GmBackToLoginView(EBackLoginViewReason reason, bool reconnectFail)
	{
		this.BackLoginView(reason, reconnectFail);
	}

	// Token: 0x06011EFC RID: 73468 RVA: 0x005471DC File Offset: 0x005453DC
	private void OnHeartbeatTimeout()
	{
		if (Net.Instance.IsServerConnected())
		{
			this.TryReConnect(false, "Heartbeat max time out");
			return;
		}
		Log.Instance.Info(ELogModule.Reconnect, ELogAuthor.MZJ, "未完成连接，但是触发心跳超时最大次数", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06011EFD RID: 73469 RVA: 0x00547220 File Offset: 0x00545420
	public unsafe void TryReConnect(bool isSilent, string reason)
	{
		if (!this.CanReconnect(reason))
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Reconnect;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "尝试重连";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("调用函数", reason);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("是否静默重连", isSilent);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		ReConnectModel instance2 = ReConnectModel.Instance;
		instance2.SetReconnectDoing();
		Heartbeat.Instance.StopHeartBeat(HeartbeatDefine.EStopHeartbeat.ReconnectStart);
		if (isSilent)
		{
			instance2.StartShowMaskTimer(new Action(this.OpenNetworkMaskView));
		}
		else
		{
			this.OpenNetworkMaskView();
		}
		Net.Instance.Disconnect(Net.EDisconnectReason.Reconnect);
		instance2.ReconvTraceId = UKismetGuidLibrary.NewGuid().ToString();
		this.ReConnectServer(0).ContinueWith(new Action<ReconnectResult>(this.OnReconnectResult)).Forget(new Action<Exception>(this.OnReconnectReject), true);
	}

	// Token: 0x06011EFE RID: 73470 RVA: 0x00547310 File Offset: 0x00545510
	private void OnNetWorkError(int errorCode)
	{
		this.TryReConnect(false, "Net.OnNetworkError");
	}

	// Token: 0x06011EFF RID: 73471 RVA: 0x00547320 File Offset: 0x00545520
	private void OnNetworkTypeChange(byte newType)
	{
		ReConnectModel instance = ReConnectModel.Instance;
		if ((ENetworkType)newType != instance.LastNetworkType)
		{
			instance.LastNetworkType = (ENetworkType)newType;
			if (newType == 4 || newType == 3)
			{
				this.TryReConnect(true, "OnNetworkTypeChange");
			}
		}
	}

	// Token: 0x06011F00 RID: 73472 RVA: 0x0054735C File Offset: 0x0054555C
	private unsafe void ApplicationHasReactivated()
	{
		long num = DateTimeOffset.Now.ToUnixTimeMilliseconds();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Reconnect;
		ELogAuthor author = ELogAuthor.MZJ;
		string message = "Application Reactivated";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("nowMs", num);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("lastMs", Net.Instance.LastReceiveTimeMs);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if ((float)num - Net.Instance.LastReceiveTimeMs > (float)ReConnectModel.Instance.ServerChannelCloseTimeMs)
		{
			this.TryReConnect(true, "Application Reactivated and channel closed");
			return;
		}
		Heartbeat.Instance.SendHeartbeatImmediately();
	}

	// Token: 0x06011F01 RID: 73473 RVA: 0x00547410 File Offset: 0x00545610
	private bool CanReconnect(string reason)
	{
		if (ReConnectModel.Instance.GetReConnectStatus() != EReConnectStatus.NoReConnect)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Reconnect;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "正在尝试重连中, 请勿重复!";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("调用函数", reason);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (!Net.Instance.IsServerConnected())
		{
			return false;
		}
		if (!LoginModel.Instance.HasReconnectInfo())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Reconnect;
			ELogAuthor author2 = ELogAuthor.ZJC;
			string message2 = "没有重连信息！";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("调用函数", reason);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		if (!LoginController.Instance.CheckCanReConnect())
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Reconnect;
			ELogAuthor author3 = ELogAuthor.MZJ;
			string message3 = "当前还在登录界面, 不触发重连";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("调用函数", reason);
			instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return false;
		}
		return true;
	}

	// Token: 0x06011F02 RID: 73474 RVA: 0x005474CC File Offset: 0x005456CC
	private unsafe void BackLoginView(EBackLoginViewReason reason, bool reconnectFail = false)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Reconnect;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "返回登录界面";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("原因", reason);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("是否重连失败触发", reconnectFail);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		ReConnectModel.Instance.CancelShowMaskTimer();
		EventSystem.Instance.Emit(EEventName.BackLoginView);
		Net.Instance.Disconnect(Net.EDisconnectReason.Logout);
		Heartbeat.Instance.StopHeartBeat(HeartbeatDefine.EStopHeartbeat.BackLoginView);
		Action<bool> action = reconnectFail ? new Action<bool>(this.PromptBackToLoginView) : delegate(bool b)
		{
			this.BackToLoginScene();
		};
		if (UiManager.Instance.IsViewShow(EUiViewName.NetWorkMaskView))
		{
			UiManager.Instance.CloseView(EUiViewName.NetWorkMaskView, action);
			return;
		}
		action(true);
	}

	// Token: 0x06011F03 RID: 73475 RVA: 0x005475AC File Offset: 0x005457AC
	private UniTask BackToLoginScene()
	{
		ReConnectController.<BackToLoginScene>d__21 <BackToLoginScene>d__;
		<BackToLoginScene>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BackToLoginScene>d__.<>1__state = -1;
		<BackToLoginScene>d__.<>t__builder.Start<ReConnectController.<BackToLoginScene>d__21>(ref <BackToLoginScene>d__);
		return <BackToLoginScene>d__.<>t__builder.Task;
	}

	// Token: 0x06011F04 RID: 73476 RVA: 0x005475E8 File Offset: 0x005457E8
	[NullableContext(2)]
	public unsafe BackToGameData CreateBackToGameData(EBackToGameType backToGameType)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Reconnect;
		ELogAuthor author = ELogAuthor.LFJW;
		string message = "[BackToGame] 创建BackToGameData数据(开始)";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EBackToGameType", backToGameType);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (LoginModel.Instance.GetBackToGameData() != null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Reconnect;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "[BackToGame] 重复创建BackToGameData";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("BackToGameType", backToGameType);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		BackToGameData backToGameData = new BackToGameData();
		backToGameData.BackToGameType = backToGameType;
		backToGameData.LoadingTexturePath = LoadingModel.Instance.GetLoadingTexturePath();
		backToGameData.Progress = 0.01f;
		backToGameData.LoadingTitle = ConfigMultiTextLang.GetLocalTextNew(LoadingModel.Instance.GetLoadingTitle(), null);
		backToGameData.LoadingTips = ConfigMultiTextLang.GetLocalTextNew(LoadingModel.Instance.GetLoadingTips(), null);
		BackToGameLoginData backToGameLoginData = new BackToGameLoginData();
		backToGameLoginData.Uid = LoginModel.Instance.GetLoginUid();
		backToGameLoginData.UserName = LoginModel.Instance.GetLoginUserName();
		backToGameLoginData.Token = LoginModel.Instance.GetLoginToken();
		backToGameLoginData.SelectServerId = LoginServerModel.Instance.GetCurrentLoginServerId();
		backToGameLoginData.SelectServerIp = LoginServerModel.Instance.GetCurrentSelectServerIp();
		backToGameData.BackToGameLoginData = backToGameLoginData;
		if (!LoginModel.Instance.SaveBackToGameData(backToGameData, false))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Reconnect;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "[BackToGame] 保存BackToGameData到C++失败";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Reason", "CreateBackToGameData");
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return null;
		}
		Log instance4 = Log.Instance;
		ELogModule module4 = ELogModule.Reconnect;
		ELogAuthor author4 = ELogAuthor.LFJW;
		string message4 = "[BackToGame] 创建BackToGameData数据(结束)";
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Uid", backToGameLoginData.Uid);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("UserName", backToGameLoginData.UserName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SelectServerId", backToGameLoginData.Token);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("SelectServerId", backToGameLoginData.SelectServerId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("SelectServerIp", backToGameLoginData.SelectServerIp);
		instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		return backToGameData;
	}

	// Token: 0x06011F05 RID: 73477 RVA: 0x005477F8 File Offset: 0x005459F8
	public bool TryBackToGame()
	{
		BackToGameData backToGameData = LoginModel.Instance.GetBackToGameData();
		if (backToGameData == null)
		{
			Log.Instance.Error(ELogModule.Reconnect, ELogAuthor.ZJC, "[BackToGame] backToGameData无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Reconnect;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "[BackToGame] 返回登录界面并重新进游戏";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BackToGameType", backToGameData.BackToGameType);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (!GlobalData.GameInstance.IsValid() || !GlobalData.GameInstance.GetWorld().IsValid())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Reconnect;
			ELogAuthor author2 = ELogAuthor.ZJC;
			string message2 = "[BackToGame] 返回登录界面并重新进游戏失败，因为world无效";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("BackToGameType", backToGameData.BackToGameType);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			LoginModel.Instance.RemoveBackToGameData();
			return false;
		}
		WBP_UILoading_C wbp_UILoading_C = UUMGManager.CreateWidget(GlobalData.GameInstance.GetWorld(), WBP_UILoading_C.StaticClass()) as WBP_UILoading_C;
		if (wbp_UILoading_C == null || !wbp_UILoading_C.IsValid())
		{
			Log.Instance.Error(ELogModule.Reconnect, ELogAuthor.LFJW, "[BackToGame] 创建WBP_UILoading失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		wbp_UILoading_C.AddToViewport(0);
		if (!wbp_UILoading_C.IsInViewport())
		{
			Log.Instance.Error(ELogModule.Reconnect, ELogAuthor.LFJW, "[BackToGame] WBP_UILoading的IsInViewport为false", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		backToGameData.LoadingWidget = wbp_UILoading_C;
		FSlateFontInfo font = wbp_UILoading_C.Title.Font;
		FName? dynamicFName = FNameUtil.GetDynamicFName(LanguageSystem.Instance.GetLanguageDefineByCode(LanguageSystem.Instance.PackageLanguage).LanguageCode);
		font.TypefaceFontName = dynamicFName.Value;
		wbp_UILoading_C.Tips.Font.TypefaceFontName = dynamicFName.Value;
		wbp_UILoading_C.ProgressText.Font.TypefaceFontName = dynamicFName.Value;
		wbp_UILoading_C.Title.SetText(new FText(backToGameData.LoadingTitle));
		wbp_UILoading_C.Tips.SetText(new FText(backToGameData.LoadingTips));
		wbp_UILoading_C.SetProgress(backToGameData.Progress, wbp_UILoading_C.FirstProgressRatio, true);
		UTexture2D texture = ResourceSystem.Instance.Load<UTexture2D>(backToGameData.LoadingTexturePath, "js_undefined");
		UImage image_Background = wbp_UILoading_C.Image_Background;
		if (image_Background != null)
		{
			image_Background.SetBrushFromTexture(texture, false);
		}
		UKuroStaticLibrary.SynchronizeProperties(wbp_UILoading_C.Title);
		UKuroStaticLibrary.SynchronizeProperties(wbp_UILoading_C.Tips);
		UKuroStaticLibrary.SynchronizeProperties(wbp_UILoading_C.ProgressText);
		if (!LoginModel.Instance.SaveBackToGameData(backToGameData, true))
		{
			UKuroStaticLibrary.DestroyObject(wbp_UILoading_C);
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Reconnect;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "[BackToGame] 保存BackToGameData到C++失败";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Reason", "TryBackToGame");
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return false;
		}
		AudioSystem.Instance.SetState("reconnect_auto_login", "in_auto_login", true);
		ReConnectModel.Instance.CancelShowMaskTimer();
		EventSystem.Instance.Emit(EEventName.BackLoginView);
		Net.Instance.Disconnect(Net.EDisconnectReason.Logout);
		Heartbeat.Instance.StopHeartBeat(HeartbeatDefine.EStopHeartbeat.BackLoginAndEnterGame);
		if (UiManager.Instance.IsViewShow(EUiViewName.NetWorkMaskView))
		{
			UiManager.Instance.CloseView(EUiViewName.NetWorkMaskView, new Action<bool>(this.<TryBackToGame>g__CallFunction|23_0));
		}
		else
		{
			this.<TryBackToGame>g__CallFunction|23_0(true);
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.FEstimation.Enable 0", null);
		return true;
	}

	// Token: 0x06011F06 RID: 73478 RVA: 0x00547AEA File Offset: 0x00545CEA
	private void PromptBackToLoginView(bool isOpenSuccess)
	{
		if (UiManager.Instance.IsInited)
		{
			this.ShowBackLoginConfirmBox();
			return;
		}
		ReConnectModel.Instance.DisconnectedFunction = new Action(this.ShowBackLoginConfirmBox);
	}

	// Token: 0x06011F07 RID: 73479 RVA: 0x00547B18 File Offset: 0x00545D18
	private void ShowBackLoginConfirmBox()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(LoginModel.Instance.HasBackToGameData() ? EConfirmBoxConfigId.BackToLoginAndEnterGame : EConfirmBoxConfigId.BackLoginView);
		confirmBoxDataNew.SetCloseFunction(delegate
		{
			if (LoginModel.Instance.HasBackToGameData())
			{
				this.TryBackToGame();
				return;
			}
			this.BackToLoginScene();
		});
		ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
	}

	// Token: 0x06011F08 RID: 73480 RVA: 0x00547B5E File Offset: 0x00545D5E
	private void OpenNetworkMaskView()
	{
		if (UiManager.Instance.IsInited && !UiManager.Instance.IsViewOpen(EUiViewName.NetWorkMaskView))
		{
			UiManager.Instance.OpenView(EUiViewName.NetWorkMaskView, null, null);
		}
	}

	// Token: 0x06011F09 RID: 73481 RVA: 0x00547B90 File Offset: 0x00545D90
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<ReconnectResult> ReConnectServer(int lastReconnectIntervalMs)
	{
		ReConnectController.<ReConnectServer>d__27 <ReConnectServer>d__;
		<ReConnectServer>d__.<>t__builder = AsyncUniTaskMethodBuilder<ReconnectResult>.Create();
		<ReConnectServer>d__.<>4__this = this;
		<ReConnectServer>d__.<>1__state = -1;
		<ReConnectServer>d__.<>t__builder.Start<ReConnectController.<ReConnectServer>d__27>(ref <ReConnectServer>d__);
		return <ReConnectServer>d__.<>t__builder.Task;
	}

	// Token: 0x06011F0A RID: 73482 RVA: 0x00547BD4 File Offset: 0x00545DD4
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<ReconnectResult> ConnectGateway()
	{
		ReConnectController.<ConnectGateway>d__28 <ConnectGateway>d__;
		<ConnectGateway>d__.<>t__builder = AsyncUniTaskMethodBuilder<ReconnectResult>.Create();
		<ConnectGateway>d__.<>1__state = -1;
		<ConnectGateway>d__.<>t__builder.Start<ReConnectController.<ConnectGateway>d__28>(ref <ConnectGateway>d__);
		return <ConnectGateway>d__.<>t__builder.Task;
	}

	// Token: 0x06011F0B RID: 73483 RVA: 0x00547C10 File Offset: 0x00545E10
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<ReconnectResult> AskProtoKey()
	{
		ReConnectController.<AskProtoKey>d__29 <AskProtoKey>d__;
		<AskProtoKey>d__.<>t__builder = AsyncUniTaskMethodBuilder<ReconnectResult>.Create();
		<AskProtoKey>d__.<>1__state = -1;
		<AskProtoKey>d__.<>t__builder.Start<ReConnectController.<AskProtoKey>d__29>(ref <AskProtoKey>d__);
		return <AskProtoKey>d__.<>t__builder.Task;
	}

	// Token: 0x06011F0C RID: 73484 RVA: 0x00547C4C File Offset: 0x00545E4C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<ReconnectResult> ReconnectRequest()
	{
		ReConnectController.<ReconnectRequest>d__30 <ReconnectRequest>d__;
		<ReconnectRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<ReconnectResult>.Create();
		<ReconnectRequest>d__.<>1__state = -1;
		<ReconnectRequest>d__.<>t__builder.Start<ReConnectController.<ReconnectRequest>d__30>(ref <ReconnectRequest>d__);
		return <ReconnectRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06011F0D RID: 73485 RVA: 0x00547C88 File Offset: 0x00545E88
	private void OnReconnectReject(Exception error)
	{
		if (ReConnectModel.Instance != null)
		{
			ReConnectModel.Instance.ClearReconnectData();
		}
		Log.Instance.Info(ELogModule.Reconnect, ELogAuthor.ZJC, "由于其他原因, 重连流程中断", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.TryReConnect(false, "ReconnectController.ForceBreakReconnectHandle");
	}

	// Token: 0x06011F0E RID: 73486 RVA: 0x00547CD0 File Offset: 0x00545ED0
	private void OnReconnectResult(ReconnectResult result)
	{
		switch (result.Result)
		{
		case EReconnectResult.Success:
			this.ReconnectSuccess();
			return;
		case EReconnectResult.Fail:
			this.ReconnectFail(result.Step, result.ErrorCode, result.IsPermittedSilentLogin);
			return;
		case EReconnectResult.Cancel:
			Log.Instance.Info(ELogModule.Reconnect, ELogAuthor.ZJC, "由于用户登出, 重连流程不再执行", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		default:
			return;
		}
	}

	// Token: 0x06011F0F RID: 73487 RVA: 0x00547D34 File Offset: 0x00545F34
	private unsafe void ReconnectSuccess()
	{
		ReConnectModel.Instance.CancelShowMaskTimer();
		if (ReConnectModel.Instance.IsRpcEmpty() && UiManager.Instance.IsViewOpen(EUiViewName.NetWorkMaskView))
		{
			UiManager.Instance.CloseView(EUiViewName.NetWorkMaskView, null);
		}
		ReconnectProcessReporter.ReportReconnectProcess(EReconnectProcessStep.ReconvSuccess, Aki.Protocol.ErrorCode.Success);
		string reconnectToken = LoginModel.Instance.GetReconnectToken();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Reconnect;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "重连流程, 重登成功!";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("重连后下行包:", Net.Instance.GetDownStreamSeqNo());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("重连后token", reconnectToken);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		ReConnectModel.Instance.ClearReconnectData();
		ThirdPartySdkManager.Instance.Logout();
		int value = PlayerInfoModel.Instance.GetId().Value;
		ThirdPartySdkManager.Instance.SetUserInfoForTpSafe(value.ToString(), value);
		EventSystem.Instance.Emit(EEventName.ReConnectSuccess);
		Heartbeat.Instance.BeginHeartBeat(HeartbeatDefine.EBeginHeartbeat.ReConnectSuccess);
	}

	// Token: 0x06011F10 RID: 73488 RVA: 0x00547E40 File Offset: 0x00546040
	private void ReconnectFail(EReconnectProcessStep step, int? errorCode = null, bool isPermittedSilentLogin = false)
	{
		Net.Instance.Disconnect(Net.EDisconnectReason.Reconnect);
		ReConnectModel.Instance.ResetReconnectStatus();
		if (step == EReconnectProcessStep.ReconvRet && errorCode != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Reconnect;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "重连流程, 服务器拒绝，尝试重新进游戏";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ErrorCode", errorCode);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			ReconnectProcessReporter.ReportReconnectProcess(EReconnectProcessStep.ReconvFail, Aki.Protocol.ErrorCode.Success);
			if (isPermittedSilentLogin)
			{
				this.CreateBackToGameData(EBackToGameType.Normal);
			}
			this.BackLoginView(EBackLoginViewReason.ReconnectError, true);
			return;
		}
		if (!ReConnectModel.Instance.IsReConnectMaxCount())
		{
			int num = ReConnectModel.Instance.AddReConnectCount();
			double delayTimeMs = Math.Pow(2.0, (double)num) * 1000.0 + (new Random().NextDouble() * 2000.0 - 1000.0);
			TimerSystem.Instance.Delay(delegate(float _)
			{
				if (!ReConnectModel.Instance.IsReConnectIdSame())
				{
					return;
				}
				this.ReConnectServer((int)delayTimeMs).ContinueWith(new Action<ReconnectResult>(this.OnReconnectResult)).Forget(new Action<Exception>(this.OnReconnectReject), true);
			}, (float)((int)delayTimeMs), null, null, true, 1f);
			Net.Instance.StartReconnecting();
			return;
		}
		ReConnectModel.Instance.AddTryCount();
		ReConnectModel.Instance.ReSetReConnectCount();
		if (ReConnectModel.Instance.IsTryMaxCount())
		{
			Log.Instance.Info(ELogModule.Reconnect, ELogAuthor.ZJC, "已达最大重连流程次数,不再尝试重连!", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.BackLoginView(EBackLoginViewReason.ReconnectMax, true);
			ReconnectProcessReporter.ReportReconnectProcess(EReconnectProcessStep.ReconvFail, Aki.Protocol.ErrorCode.Success);
			return;
		}
		this.ReConnectServer(0).ContinueWith(new Action<ReconnectResult>(this.OnReconnectResult)).Forget(new Action<Exception>(this.OnReconnectReject), true);
		EventSystem.Instance.Emit(EEventName.ReConnectFail);
	}

	// Token: 0x17001B41 RID: 6977
	// (get) Token: 0x06011F11 RID: 73489 RVA: 0x00547FCF File Offset: 0x005461CF
	public static ReConnectController Instance
	{
		get
		{
			return ReConnectController._Instance;
		}
	}

	// Token: 0x06011F12 RID: 73490 RVA: 0x00547FD6 File Offset: 0x005461D6
	public static ReConnectController GetOrCreateInstance()
	{
		if (ReConnectController._Instance == null)
		{
			ReConnectController.CreateInstance();
		}
		return ReConnectController._Instance;
	}

	// Token: 0x06011F13 RID: 73491 RVA: 0x00547FEA File Offset: 0x005461EA
	public static bool CreateInstance()
	{
		if (ReConnectController._Instance != null)
		{
			return true;
		}
		ReConnectController._Instance = new ReConnectController();
		return true;
	}

	// Token: 0x06011F14 RID: 73492 RVA: 0x00548000 File Offset: 0x00546200
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011F15 RID: 73493 RVA: 0x00548002 File Offset: 0x00546202
	public static void ResetStaticDefaultValue()
	{
		ReConnectController._Instance = null;
	}

	// Token: 0x06011F16 RID: 73494 RVA: 0x0054800A File Offset: 0x0054620A
	static ReConnectController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ReConnectController.CreateStaticDefaultValue), new Action(ReConnectController.ResetStaticDefaultValue));
	}

	// Token: 0x06011F17 RID: 73495 RVA: 0x0054802C File Offset: 0x0054622C
	public unsafe ReConnectController()
	{
		<>y__InlineArray3<EUiViewName> <>y__InlineArray = default(<>y__InlineArray3<EUiViewName>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<EUiViewName>, EUiViewName>(ref <>y__InlineArray, 0) = EUiViewName.NetWorkMaskView;
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<EUiViewName>, EUiViewName>(ref <>y__InlineArray, 1) = EUiViewName.PlayStationNetWorkMaskView;
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<EUiViewName>, EUiViewName>(ref <>y__InlineArray, 2) = EUiViewName.NetWorkConfirmBoxView;
		this.NetworkReconnectViewNames = FrozenSet.Create<EUiViewName>(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<EUiViewName>, EUiViewName>(<>y__InlineArray, 3));
		base..ctor();
	}

	// Token: 0x06011F19 RID: 73497 RVA: 0x0054809C File Offset: 0x0054629C
	[CompilerGenerated]
	internal static UniTask <BackToLoginScene>g__Callback|21_0()
	{
		ReConnectController.<<BackToLoginScene>g__Callback|21_0>d <<BackToLoginScene>g__Callback|21_0>d;
		<<BackToLoginScene>g__Callback|21_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<<BackToLoginScene>g__Callback|21_0>d.<>1__state = -1;
		<<BackToLoginScene>g__Callback|21_0>d.<>t__builder.Start<ReConnectController.<<BackToLoginScene>g__Callback|21_0>d>(ref <<BackToLoginScene>g__Callback|21_0>d);
		return <<BackToLoginScene>g__Callback|21_0>d.<>t__builder.Task;
	}

	// Token: 0x06011F1A RID: 73498 RVA: 0x005480D7 File Offset: 0x005462D7
	[CompilerGenerated]
	private void <TryBackToGame>g__CallFunction|23_0(bool b)
	{
		this.BackToLoginScene();
	}

	// Token: 0x04009C52 RID: 40018
	private const int ONE_THOUSAND = 1000;

	// Token: 0x04009C53 RID: 40019
	private const int TWO_THOUSAND = 2000;

	// Token: 0x04009C54 RID: 40020
	private const int RECONNECT_TIME_OUT = 20000;

	// Token: 0x04009C55 RID: 40021
	private readonly FrozenSet<EUiViewName> NetworkReconnectViewNames;

	// Token: 0x04009C56 RID: 40022
	[Nullable(2)]
	private static ReConnectController _Instance;
}
