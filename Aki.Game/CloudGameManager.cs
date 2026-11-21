using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.Platform;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020003A7 RID: 935
[NullableContext(1)]
[Nullable(0)]
public class CloudGameManager : Singleton
{
	// Token: 0x0600338F RID: 13199 RVA: 0x00127F18 File Offset: 0x00126118
	public unsafe CloudGameManager()
	{
		this.DeviceMargin = "";
		this.CloudGameDpiInternal = 180;
		this.DeviceScreenWidthInternal = 1920;
		this.DeviceScreenHeightInternal = 1080;
		this.ScreenWidthInternal = 1920;
		this.ScreenHeightInternal = 1080;
		this.WaitingForDbFlagFilePath = UKismetSystemLibrary.ConvertToAbsolutePath(UKuroLauncherLibrary.GameSavedDir() + "waiting_for_db.txt");
		this.WaitingForDbSavePath = UKismetSystemLibrary.ConvertToAbsolutePath(UKuroLauncherLibrary.GameSavedDir() + "SaveDownloadDone.json");
	}

	// Token: 0x1700077C RID: 1916
	// (get) Token: 0x06003390 RID: 13200 RVA: 0x00127FD1 File Offset: 0x001261D1
	public bool IsCloudGame
	{
		get
		{
			return Platform.Instance.IsCloudGame();
		}
	}

	// Token: 0x1700077D RID: 1917
	// (get) Token: 0x06003391 RID: 13201 RVA: 0x00127FDD File Offset: 0x001261DD
	public bool IsWebPlatform
	{
		get
		{
			return this.IsWeb;
		}
	}

	// Token: 0x1700077E RID: 1918
	// (get) Token: 0x06003392 RID: 13202 RVA: 0x00127FE5 File Offset: 0x001261E5
	public string CloudGameTraceId
	{
		get
		{
			ICloudGameUserInfo userInfo = this.UserInfo;
			return ((userInfo != null) ? userInfo.TraceId : null) ?? "";
		}
	}

	// Token: 0x1700077F RID: 1919
	// (get) Token: 0x06003393 RID: 13203 RVA: 0x00128002 File Offset: 0x00126202
	// (set) Token: 0x06003394 RID: 13204 RVA: 0x0012800C File Offset: 0x0012620C
	public ICloudGameUserInfo CloudUserInfo
	{
		get
		{
			return this.UserInfo;
		}
		set
		{
			this.UserInfo = value;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CloudGame;
			ELogAuthor author = ELogAuthor.TL;
			string message = "设置云游戏userInfo";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("userInfo", value);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x06003395 RID: 13205 RVA: 0x0012804A File Offset: 0x0012624A
	public ILoginInfo GetCloudGameLoginInfo()
	{
		return this.UserInfo.LoginInfo;
	}

	// Token: 0x17000780 RID: 1920
	// (get) Token: 0x06003396 RID: 13206 RVA: 0x00128057 File Offset: 0x00126257
	[Nullable(2)]
	public ICloudGamePadInfo CloudGamePadInfo
	{
		[NullableContext(2)]
		get
		{
			return this.CloudGamePadInfoInternal;
		}
	}

	// Token: 0x17000781 RID: 1921
	// (get) Token: 0x06003397 RID: 13207 RVA: 0x0012805F File Offset: 0x0012625F
	public int CloudGameDpi
	{
		get
		{
			return this.CloudGameDpiInternal;
		}
	}

	// Token: 0x17000782 RID: 1922
	// (get) Token: 0x06003398 RID: 13208 RVA: 0x00128067 File Offset: 0x00126267
	public int DeviceScreenWidth
	{
		get
		{
			return this.DeviceScreenWidthInternal;
		}
	}

	// Token: 0x17000783 RID: 1923
	// (get) Token: 0x06003399 RID: 13209 RVA: 0x0012806F File Offset: 0x0012626F
	public int DeviceScreenHeight
	{
		get
		{
			return this.DeviceScreenHeightInternal;
		}
	}

	// Token: 0x17000784 RID: 1924
	// (get) Token: 0x0600339A RID: 13210 RVA: 0x00128077 File Offset: 0x00126277
	public int ScreenWidth
	{
		get
		{
			return this.ScreenWidthInternal;
		}
	}

	// Token: 0x17000785 RID: 1925
	// (get) Token: 0x0600339B RID: 13211 RVA: 0x0012807F File Offset: 0x0012627F
	public int ScreenHeight
	{
		get
		{
			return this.ScreenHeightInternal;
		}
	}

	// Token: 0x0600339C RID: 13212 RVA: 0x00128088 File Offset: 0x00126288
	public void Init()
	{
		string commandLine = UKismetSystemLibrary.GetCommandLine();
		this.IsReboot = commandLine.Contains("-Reboot");
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "云游戏初始化";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IsReboot", this.IsReboot);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (!this.IsCloudGame)
		{
			return;
		}
		UPerfSightHelper.PostEvent(601, "1");
		UKuroCloudGameWrapper ukuroCloudGameWrapper = new UKuroCloudGameWrapper();
		this.KuroCloudGameWrapper = ukuroCloudGameWrapper;
		ukuroCloudGameWrapper.CloudGameOnReceiveDataDelegate.Bind(new Action<string>(this.OnReceiveData));
		ukuroCloudGameWrapper.CloudGameOnReceiveDataWithKeyDelegate.Bind(new Action<string, string>(this.OnReceiveDataWithKey));
		ukuroCloudGameWrapper.CloudGameOnChangeResolutionDelegate.Bind(this.OnResolutionChange);
		this.BindFunction(ECloudGameReceiveDataKey.OnGamePadDeviceChange, new TCloudGameOnReceiveDataFunction(this.OnGamePadDeviceChange));
		this.BindFunction(ECloudGameReceiveDataKey.OnGameWindowStatusChanged, new TCloudGameOnReceiveDataFunction(this.OnGameWindowStatusChanged));
		this.BindFunction(ECloudGameReceiveDataKey.OnPostRedDotRefresh, new TCloudGameOnReceiveDataFunction(this.OnPostRedDotRefresh));
		this.BindFunction(ECloudGameReceiveDataKey.OnCustomerRedDotRefresh, new TCloudGameOnReceiveDataFunction(this.OnCustomerRedDotRefresh));
		if (CloudGameManagerLauncher.Instance.IsPreLaunch)
		{
			this.BindFunction(ECloudGameReceiveDataKey.OnCloudGameLoginPreLaunch, new TCloudGameOnReceiveDataFunction(this.OnUserLoginPreLaunch));
			this.BindFunction(ECloudGameReceiveDataKey.SetIsWebPlatform, new TCloudGameOnReceiveDataFunction(this.OnSetWebPlatform));
		}
		else
		{
			this.ParseCommandLine();
			this.BindFunction(ECloudGameReceiveDataKey.OnCloudGameLogin, new TCloudGameOnReceiveDataFunction(this.OnUserLogin));
		}
		this.InitSettings();
	}

	// Token: 0x0600339D RID: 13213 RVA: 0x001281E4 File Offset: 0x001263E4
	private void OnGameWindowStatusChanged(string resultJson)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "Cloud KuroGameWinStateBindFunction";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", resultJson);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		string text = this.ParseGameWindowStateStatus(resultJson);
		if (text == null)
		{
			return;
		}
		KuroSdkModel.Instance.OnSdkFocusChange(text == "0");
	}

	// Token: 0x0600339E RID: 13214 RVA: 0x0012823C File Offset: 0x0012643C
	private void OnPostRedDotRefresh(string dataJson)
	{
		if (KuroSdkController.Instance == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CloudGame;
			ELogAuthor author = ELogAuthor.TL;
			string message = "OnPostRedDotRefresh: KuroSdkController未就绪，丢弃推送";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", dataJson);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		bool postWebViewRedPointState = !string.IsNullOrEmpty(dataJson) && dataJson.Contains("showRed") && (dataJson.Contains("1") || dataJson.Contains("YES"));
		KuroSdkController.Instance.SetPostWebViewRedPointState(postWebViewRedPointState);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x0600339F RID: 13215 RVA: 0x001282CC File Offset: 0x001264CC
	private void OnCustomerRedDotRefresh(string dataJson)
	{
		if (KuroSdkController.Instance == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CloudGame;
			ELogAuthor author = ELogAuthor.TL;
			string message = "OnCustomerRedDotRefresh: KuroSdkController未就绪，丢弃推送";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", dataJson);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		Match match = string.IsNullOrEmpty(dataJson) ? Match.Empty : Regex.Match(dataJson, "\"isredot\"\\s*:\\s*(-?\\d+)");
		if (!match.Success)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CloudGame;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "OnCustomerRedDotRefresh: 未找到isredot字段，丢弃推送";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("data", dataJson);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		bool customerServiceRedPointState = int.Parse(match.Groups[1].Value) > 0;
		KuroSdkController.Instance.SetCustomerServiceRedPointState(customerServiceRedPointState);
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x060033A0 RID: 13216 RVA: 0x00128390 File Offset: 0x00126590
	[return: Nullable(2)]
	private string ParseGameWindowStateStatus(string result)
	{
		if (string.IsNullOrEmpty(result))
		{
			return null;
		}
		if (!result.StartsWith('{') && !result.StartsWith('['))
		{
			string[] array = result.Split(',', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split('=', StringSplitOptions.None);
				if (array2.Length == 2 && array2[0] == "status")
				{
					return array2[1];
				}
			}
			return null;
		}
		GameWindowStateData gameWindowStateData = Json.Parse<GameWindowStateData>(result, null);
		if (gameWindowStateData == null)
		{
			return null;
		}
		return gameWindowStateData.status;
	}

	// Token: 0x060033A1 RID: 13217 RVA: 0x0012840C File Offset: 0x0012660C
	private void InitCloudGamePlatform(string platform)
	{
		Platform.Instance.CloudGamePlatform = platform;
		if (platform == "Android" || platform == "IOS")
		{
			Info.Instance.SwitchInputControllerType(EInputControllerType.Touch, "InitCloudGame Mobile");
		}
		else if (platform == "Mac" || platform == "Windows")
		{
			Info.Instance.SwitchInputControllerType(EInputControllerType.Keyboard, "InitCloudGame Desktop");
		}
		this.TryRequestGamePadDevice();
	}

	// Token: 0x060033A2 RID: 13218 RVA: 0x00128480 File Offset: 0x00126680
	private void InitSettings()
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wp.Runtime.OverrideMultipleRuntimeGridNames Grid_Near&Grid_Middle&Grid_Middle_Far&Grid_Far&Grid_SuperFar&Grid_SSuperFar&Grid_HLOD_Small&Grid_HLOD_Middle&Grid_HLOD&Grid_HLOD_Volume_Small&Grid_HLOD_Volume_Middle&Grid_HLOD_Volume&GridRuntime_Landscape&GridRuntime_LandscapeHLOD&Grid_Water&Grid_Impostor&Grid_ExtremeFarFoliage&Grid_Foliage_Normal&Grid_ISM_Near&Grid_ISM_Middle&Grid_ISM_Far&Grid_ISM_SuperFar&Grid_Foliage_Near&Grid_Foliage_Grass&Grid_Foliage_Middle&Grid_Foliage_Far&Grid_Foliage_SuperFar&Grid_ReverseMiddle&Grid_ReverseFar&Grid_ReverseSuperFar&Grid_SSuperFarReverse&Grid_EnclosedSpaceNear&Grid_EnclosedSpaceMiddle&Grid_EnclosedSpaceFar&Grid_EnclosedSpaceSuperFar&Grid_EnclosedSpaceSSuperFar&Grid_AudioNear&Grid_AudioMiddle&Grid_AudioFar&Grid_AudioSuperFar&Grid_PcgWater&Grid_Light_Middle&Grid_Light_Far&Grid_HighResLandscape&Grid_MSuperFar&HLOD0_200m_300m&HLOD0_300m_500m&HLOD1_400m_800m&HLOD0_500m_1000m&HLOD0_500m_1500m&HLOD1_600m_1200m&HLOD1_800m_2500m&HLOD1_800m_4000m", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wp.Runtime.OverrideMultipleRuntimeGridLoadingRangeValues 60&85&200&180&650&2600&100&140&170&100&190&250&440&3500&610&450&1300&274&60&83&100&150&40&80&100&100&196&260&430&860&2600&50&80&130&650&860&40&80&252&86&440&120&156&300&1300&260&430&690&860&1300&1040&2160&3460", null);
	}

	// Token: 0x060033A3 RID: 13219 RVA: 0x001284A4 File Offset: 0x001266A4
	private void OnReceiveData(string dataJson)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "OnReceiveData:";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", dataJson);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		ECloudGameReceiveDataKey key;
		if (!Enum.TryParse<ECloudGameReceiveDataKey>(dataJson, out key) || !this.FunctionLookup.ContainsKey(key))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CloudGame;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "OnReceiveData: 函数未绑定";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("key", dataJson);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		this.FunctionLookup[key](dataJson);
	}

	// Token: 0x060033A4 RID: 13220 RVA: 0x00128530 File Offset: 0x00126730
	private unsafe void OnReceiveDataWithKey(string key, string data)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "OnReceiveDataWithKey:";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("data", data);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		ECloudGameReceiveDataKey key2;
		if (!Enum.TryParse<ECloudGameReceiveDataKey>(key, out key2) || !this.FunctionLookup.ContainsKey(key2))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CloudGame;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "OnReceiveDataWithKey: 函数未绑定";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("data", data);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		this.FunctionLookup[key2](data);
	}

	// Token: 0x060033A5 RID: 13221 RVA: 0x00128614 File Offset: 0x00126814
	public void BindFunction(ECloudGameReceiveDataKey key, TCloudGameOnReceiveDataFunction func)
	{
		this.FunctionLookup[key] = func;
	}

	// Token: 0x060033A6 RID: 13222 RVA: 0x00128623 File Offset: 0x00126823
	public void UnBindFunction(ECloudGameReceiveDataKey key)
	{
		this.FunctionLookup.Remove(key);
	}

	// Token: 0x060033A7 RID: 13223 RVA: 0x00128634 File Offset: 0x00126834
	public void SendData(ECloudGameSendData data)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "SendData";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", data);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKuroCloudGameWrapper.SendDataToPipeBinary(data.ToString());
	}

	// Token: 0x060033A8 RID: 13224 RVA: 0x00128684 File Offset: 0x00126884
	public unsafe void SendDataByKey(ECloudGameSendData key, string data)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "SendDataByKey";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("data", data);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		UKuroCloudGameWrapper.SendDataToPipeBinaryWithKey(key.ToString(), data);
	}

	// Token: 0x060033A9 RID: 13225 RVA: 0x001286FF File Offset: 0x001268FF
	public void TryRequestGamePadDevice()
	{
		if (!this.IsCloudGame)
		{
			return;
		}
		this.SendData(ECloudGameSendData.RequestGamePadDevice);
	}

	// Token: 0x060033AA RID: 13226 RVA: 0x00128714 File Offset: 0x00126914
	public void OnGamePadDeviceChange(string gamePadJson)
	{
		CloudGamePadInfo cloudGamePadInfo = Json.Decode<CloudGamePadInfo>(gamePadJson, null);
		if (cloudGamePadInfo == null)
		{
			Log.Instance.Error(ELogModule.CloudGame, ELogAuthor.TL, "OnGamePadDeviceChange error, gamePadInfo parse fail", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		bool flag = cloudGamePadInfo.IsConnectPad == 1;
		if (flag)
		{
			this.CloudGamePadInfoInternal = cloudGamePadInfo;
		}
		else
		{
			this.CloudGamePadInfoInternal = null;
		}
		EventSystem.Instance.Emit<bool, int, int>(EEventName.ControllerConnectChange, flag, cloudGamePadInfo.ProductId, cloudGamePadInfo.VendorId);
	}

	// Token: 0x060033AB RID: 13227 RVA: 0x00128788 File Offset: 0x00126988
	public void ExitGame(string str)
	{
		string data = Json.Encode(new ExitGameInfo
		{
			Content = str
		}, null);
		this.SendDataByKey(ECloudGameSendData.ExitGame, data);
	}

	// Token: 0x060033AC RID: 13228 RVA: 0x001287B4 File Offset: 0x001269B4
	public unsafe void ParseCommandLine()
	{
		string commandLine = UKismetSystemLibrary.GetCommandLine();
		Match match = CloudGameDefine.CloudGameDeviceRegex.Match(commandLine);
		if (match.Success)
		{
			this.DeviceMargin = match.Groups[1].Value;
		}
		Match match2 = CloudGameDefine.CloudGameDpiRegex.Match(commandLine);
		if (match2.Success)
		{
			float x;
			if (float.TryParse(match2.Groups[1].Value, NumberStyles.Float, CultureInfo.InvariantCulture, out x))
			{
				this.CloudGameDpiInternal = (int)MathF.Round(x);
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CloudGame;
				ELogAuthor author = ELogAuthor.TL;
				string message = "Dpi解析失败，使用默认值";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("value", match2.Groups[1].Value);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("defaultDpi", this.CloudGameDpiInternal);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		Match match3 = CloudGameDefine.CloudGameDeviceScreenResolution.Match(commandLine);
		if (match3.Success)
		{
			this.DeviceScreenWidthInternal = int.Parse(match3.Groups[1].Value);
			this.DeviceScreenHeightInternal = int.Parse(match3.Groups[2].Value);
		}
		Match match4 = CloudGameDefine.CloudGameScreenResolution.Match(commandLine);
		if (match4.Success)
		{
			this.ScreenWidthInternal = int.Parse(match4.Groups[1].Value);
			this.ScreenHeightInternal = int.Parse(match4.Groups[2].Value);
		}
		Match match5 = CloudGameDefine.CloudGameIsWeb.Match(commandLine);
		if (match5.Success)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CloudGame;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "isWebMatch";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", match5.Groups[1].Value);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (match5.Groups[1].Value != "%d")
			{
				this.IsWeb = (match5.Groups[1].Value == "1");
			}
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.CloudGame;
		ELogAuthor author3 = ELogAuthor.TL;
		string message3 = "初始化云游戏平台类型";
		<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("-CloudGame", this.IsCloudGame);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("-Device", this.DeviceMargin);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("-Dpi", this.CloudGameDpiInternal);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("-DeviceScreenWidth", this.DeviceScreenWidthInternal);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("-DeviceScreenHeight", this.DeviceScreenHeightInternal);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("-IsWeb", this.IsWeb);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
	}

	// Token: 0x060033AD RID: 13229 RVA: 0x00128AC8 File Offset: 0x00126CC8
	public void OnUserLogin(string loginInfoJson)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "OnUserLogin";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("loginInfoJson", loginInfoJson);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		CloudGameUserInfoLegacy cloudGameUserInfoLegacy = Json.Decode<CloudGameUserInfoLegacy>(loginInfoJson, null);
		if (cloudGameUserInfoLegacy == null)
		{
			Log.Instance.Error(ELogModule.CloudGame, ELogAuthor.TL, "OnUserLogin error, userInfo parse fail", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		LoginInfo loginInfo = new LoginInfo
		{
			LoginCode = cloudGameUserInfoLegacy.LoginCode,
			Uid = cloudGameUserInfoLegacy.Uid,
			UserName = cloudGameUserInfoLegacy.UserName,
			Token = cloudGameUserInfoLegacy.Token
		};
		CloudGameUserInfo cloudGameUserInfo = new CloudGameUserInfo
		{
			LoginInfo = loginInfo,
			TraceId = "",
			Platform = Platform.Instance.CloudGamePlatform,
			Fps = 0f,
			Dpi = 0f,
			DeviceResolution = new ResolutionInfo
			{
				Width = 0,
				Height = 0
			},
			ScreenResolution = new ResolutionInfo
			{
				Width = 0,
				Height = 0
			},
			ServerTag = "",
			Device = ""
		};
		this.CloudUserInfo = cloudGameUserInfo;
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.CloudGame;
		ELogAuthor author2 = ELogAuthor.TL;
		string message2 = "OnUserLogin";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("CloudUserInfo", cloudGameUserInfo);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		this.InitCloudGamePlatform(Platform.Instance.CloudGamePlatform);
		LoginController.Instance.OnSdkLogin(this.GetCloudGameLoginInfo());
	}

	// Token: 0x060033AE RID: 13230 RVA: 0x00128C38 File Offset: 0x00126E38
	public void OnSetWebPlatform(string isWeb)
	{
		this.IsWeb = (isWeb == "1");
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "OnSetWebPlatform";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IsWeb", isWeb);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060033AF RID: 13231 RVA: 0x00128C80 File Offset: 0x00126E80
	public unsafe void OnUserLoginPreLaunch(string loginInfoJson)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "OnUserLoginPreLaunch 1";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("loginInfoJson", loginInfoJson);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (this.WaitingForUserDb == null)
		{
			Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.TL, "OnUserLoginPreLaunch error, not waiting", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		CloudGameUserInfo cloudGameUserInfo = Json.Decode<CloudGameUserInfo>(loginInfoJson, null);
		if (cloudGameUserInfo == null)
		{
			Log.Instance.Error(ELogModule.CloudGame, ELogAuthor.TL, "OnUserLoginPreLaunch error, userInfo parse fail", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.CloudUserInfo = cloudGameUserInfo;
		this.InitCloudGamePlatform(cloudGameUserInfo.Platform);
		this.DeviceMargin = cloudGameUserInfo.Device;
		this.CloudGameDpiInternal = (int)MathF.Round(cloudGameUserInfo.Dpi);
		this.DeviceScreenWidthInternal = cloudGameUserInfo.DeviceResolution.Width;
		this.DeviceScreenHeightInternal = cloudGameUserInfo.DeviceResolution.Height;
		this.ScreenWidthInternal = cloudGameUserInfo.ScreenResolution.Width;
		this.ScreenHeightInternal = cloudGameUserInfo.ScreenResolution.Height;
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		gameUserSettings.SetScreenResolution(new FIntPoint(this.ScreenWidth, this.ScreenHeight));
		gameUserSettings.ApplySettings(true);
		if (this.IsRefreshLogin)
		{
			this.IsRefreshLogin = false;
			CustomPromise waitingForUserDb = this.WaitingForUserDb;
			if (waitingForUserDb != null)
			{
				waitingForUserDb.SetResult();
			}
			this.WaitingForUserDb = null;
			Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.CWC, "OnUserLoginPreLaunch RefreshLogin Done", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (UBlueprintPathsLibrary.FileExists(this.WaitingForDbFlagFilePath))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CloudGame;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "OnUserLoginPreLaunch delete file";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("WaitingForDbFlagFilePath", this.WaitingForDbFlagFilePath);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			UKuroLauncherLibrary.DeleteFile(this.WaitingForDbFlagFilePath);
		}
		ResetTimeController.GetOrCreateInstance().ResetTime();
		LoadModeManager.Instance.SetLoadModeByReason(ELoadMode.Loading, ELoadModeReason.GameProcedureOnStart);
		int tryTimes = 0;
		this.TimeoutTimer = TimerSystem.Instance.Forever(delegate(float _)
		{
			int tryTimes = tryTimes;
			tryTimes++;
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.CloudGame;
			ELogAuthor author3 = ELogAuthor.TL;
			string message3 = "OnUserLoginPreLaunch Wait DB replaced";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("tryTimes", tryTimes);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			bool flag = UBlueprintPathsLibrary.FileExists(this.WaitingForDbSavePath);
			if (flag || tryTimes >= 10)
			{
				if (this.TimeoutTimer != null)
				{
					TimerSystem.Instance.Remove(this.TimeoutTimer);
					this.TimeoutTimer = null;
				}
				CustomPromise waitingForUserDb2 = this.WaitingForUserDb;
				if (waitingForUserDb2 != null)
				{
					waitingForUserDb2.SetResult();
				}
				this.WaitingForUserDb = null;
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.CloudGame;
				ELogAuthor author4 = ELogAuthor.TL;
				string message4 = "OnUserLoginPreLaunch Done";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("replaced", flag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tryTimes", tryTimes);
				instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}, 500f, 1f, null, null, true);
	}

	// Token: 0x060033B0 RID: 13232 RVA: 0x00128E88 File Offset: 0x00127088
	private void OnWaitingForUser()
	{
		if (this.WaitingForUserDb == null)
		{
			this.WaitingForUserDb = new CustomPromise();
		}
		UKuroStaticLibrary.SaveStringToFile("OnWaitingForUser", this.WaitingForDbFlagFilePath, false);
		LoadModeManager.Instance.ResetLoadModeByReason(ELoadModeReason.GameProcedureOnStart);
		this.SendData(ECloudGameSendData.RequestLoginPreLaunch);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "OnWaitingForUser save file";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("WaitingForDbFlagFilePath", this.WaitingForDbFlagFilePath);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060033B1 RID: 13233 RVA: 0x00128EFC File Offset: 0x001270FC
	public UniTask WaitForUser()
	{
		CloudGameManager.<WaitForUser>d__62 <WaitForUser>d__;
		<WaitForUser>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitForUser>d__.<>4__this = this;
		<WaitForUser>d__.<>1__state = -1;
		<WaitForUser>d__.<>t__builder.Start<CloudGameManager.<WaitForUser>d__62>(ref <WaitForUser>d__);
		return <WaitForUser>d__.<>t__builder.Task;
	}

	// Token: 0x060033B2 RID: 13234 RVA: 0x00128F40 File Offset: 0x00127140
	public void RequestRefreshLogin()
	{
		Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.CWC, "RequestRefreshLogin", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.IsRefreshLogin = true;
		if (this.WaitingForUserDb == null)
		{
			this.WaitingForUserDb = new CustomPromise();
		}
		this.SendData(ECloudGameSendData.RequestLoginPreLaunch);
	}

	// Token: 0x060033B3 RID: 13235 RVA: 0x00128F90 File Offset: 0x00127190
	public unsafe IReadOnlyList<float> GetCloudGameSafeZone()
	{
		if (!this.IsCloudGame)
		{
			return CloudGameDefine.DefaultDeviceMargin;
		}
		IReadOnlyList<float> readOnlyList = CloudGameDefine.DefaultDeviceMargin;
		if (CloudGameDefine.DeviceMarginMap.ContainsKey(this.DeviceMargin))
		{
			readOnlyList = CloudGameDefine.DeviceMarginMap[this.DeviceMargin];
		}
		if (readOnlyList == null || readOnlyList.Count < 4)
		{
			return CloudGameDefine.DefaultDeviceMargin;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "设置UiSafeZone";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("left", readOnlyList[0]);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("top", readOnlyList[2]);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("right", readOnlyList[1]);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("bottom", readOnlyList[3]);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		return readOnlyList;
	}

	// Token: 0x17000786 RID: 1926
	// (get) Token: 0x060033B4 RID: 13236 RVA: 0x00129099 File Offset: 0x00127299
	public static CloudGameManager Instance
	{
		get
		{
			if (CloudGameManager._instance == null)
			{
				CloudGameManager._instance = new CloudGameManager();
				CloudGameManager._instance.OnInit();
			}
			return CloudGameManager._instance;
		}
	}

	// Token: 0x060033B5 RID: 13237 RVA: 0x001290BC File Offset: 0x001272BC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060033B6 RID: 13238 RVA: 0x001290BE File Offset: 0x001272BE
	public static void ResetStaticDefaultValue()
	{
		CloudGameManager instance = CloudGameManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CloudGameManager._instance = null;
	}

	// Token: 0x060033B7 RID: 13239 RVA: 0x001290D7 File Offset: 0x001272D7
	static CloudGameManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CloudGameManager.CreateStaticDefaultValue), new Action(CloudGameManager.ResetStaticDefaultValue));
	}

	// Token: 0x04002C43 RID: 11331
	[Nullable(2)]
	public UKuroCloudGameWrapper KuroCloudGameWrapper;

	// Token: 0x04002C44 RID: 11332
	private readonly Dictionary<ECloudGameReceiveDataKey, TCloudGameOnReceiveDataFunction> FunctionLookup = new Dictionary<ECloudGameReceiveDataKey, TCloudGameOnReceiveDataFunction>();

	// Token: 0x04002C45 RID: 11333
	[Nullable(2)]
	private ICloudGameUserInfo UserInfo;

	// Token: 0x04002C46 RID: 11334
	[Nullable(2)]
	private ICloudGamePadInfo CloudGamePadInfoInternal;

	// Token: 0x04002C47 RID: 11335
	private string DeviceMargin;

	// Token: 0x04002C48 RID: 11336
	private int CloudGameDpiInternal;

	// Token: 0x04002C49 RID: 11337
	private bool IsReboot;

	// Token: 0x04002C4A RID: 11338
	private bool IsWeb;

	// Token: 0x04002C4B RID: 11339
	[Nullable(2)]
	private CustomPromise WaitingForUserDb;

	// Token: 0x04002C4C RID: 11340
	private bool IsRefreshLogin;

	// Token: 0x04002C4D RID: 11341
	private readonly string WaitingForDbFlagFilePath;

	// Token: 0x04002C4E RID: 11342
	private readonly string WaitingForDbSavePath;

	// Token: 0x04002C4F RID: 11343
	private int DeviceScreenWidthInternal;

	// Token: 0x04002C50 RID: 11344
	private int DeviceScreenHeightInternal;

	// Token: 0x04002C51 RID: 11345
	private int ScreenWidthInternal;

	// Token: 0x04002C52 RID: 11346
	private int ScreenHeightInternal;

	// Token: 0x04002C53 RID: 11347
	[Nullable(2)]
	private TimerHandle TimeoutTimer;

	// Token: 0x04002C54 RID: 11348
	private readonly Action<int, int> OnResolutionChange = delegate(int width, int height)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "OnResolutionChange:";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("width", width);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("height", height);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		FIntPoint screenResolution = new FIntPoint(width, height);
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		gameUserSettings.SetScreenResolution(screenResolution);
		gameUserSettings.ApplySettings(true);
	};

	// Token: 0x04002C55 RID: 11349
	[Nullable(2)]
	private static CloudGameManager _instance;
}
