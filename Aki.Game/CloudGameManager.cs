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

// Token: 0x02000EF2 RID: 3826
[NullableContext(1)]
[Nullable(0)]
public class CloudGameManager : Singleton
{
	// Token: 0x06005FF9 RID: 24569 RVA: 0x0012008C File Offset: 0x0011E28C
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

	// Token: 0x1700075A RID: 1882
	// (get) Token: 0x06005FFA RID: 24570 RVA: 0x00120145 File Offset: 0x0011E345
	public bool IsCloudGame
	{
		get
		{
			return Platform.Instance.IsCloudGame();
		}
	}

	// Token: 0x1700075B RID: 1883
	// (get) Token: 0x06005FFB RID: 24571 RVA: 0x00120151 File Offset: 0x0011E351
	public bool IsWebPlatform
	{
		get
		{
			return this.IsWeb;
		}
	}

	// Token: 0x1700075C RID: 1884
	// (get) Token: 0x06005FFC RID: 24572 RVA: 0x00120159 File Offset: 0x0011E359
	public string CloudGameTraceId
	{
		get
		{
			ICloudGameUserInfo userInfo = this.UserInfo;
			return ((userInfo != null) ? userInfo.TraceId : null) ?? "";
		}
	}

	// Token: 0x1700075D RID: 1885
	// (get) Token: 0x06005FFD RID: 24573 RVA: 0x00120176 File Offset: 0x0011E376
	// (set) Token: 0x06005FFE RID: 24574 RVA: 0x00120180 File Offset: 0x0011E380
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

	// Token: 0x06005FFF RID: 24575 RVA: 0x001201BE File Offset: 0x0011E3BE
	public ILoginInfo GetCloudGameLoginInfo()
	{
		return this.UserInfo.LoginInfo;
	}

	// Token: 0x1700075E RID: 1886
	// (get) Token: 0x06006000 RID: 24576 RVA: 0x001201CB File Offset: 0x0011E3CB
	[Nullable(2)]
	public ICloudGamePadInfo CloudGamePadInfo
	{
		[NullableContext(2)]
		get
		{
			return this.CloudGamePadInfoInternal;
		}
	}

	// Token: 0x1700075F RID: 1887
	// (get) Token: 0x06006001 RID: 24577 RVA: 0x001201D3 File Offset: 0x0011E3D3
	public int CloudGameDpi
	{
		get
		{
			return this.CloudGameDpiInternal;
		}
	}

	// Token: 0x17000760 RID: 1888
	// (get) Token: 0x06006002 RID: 24578 RVA: 0x001201DB File Offset: 0x0011E3DB
	public int DeviceScreenWidth
	{
		get
		{
			return this.DeviceScreenWidthInternal;
		}
	}

	// Token: 0x17000761 RID: 1889
	// (get) Token: 0x06006003 RID: 24579 RVA: 0x001201E3 File Offset: 0x0011E3E3
	public int DeviceScreenHeight
	{
		get
		{
			return this.DeviceScreenHeightInternal;
		}
	}

	// Token: 0x17000762 RID: 1890
	// (get) Token: 0x06006004 RID: 24580 RVA: 0x001201EB File Offset: 0x0011E3EB
	public int ScreenWidth
	{
		get
		{
			return this.ScreenWidthInternal;
		}
	}

	// Token: 0x17000763 RID: 1891
	// (get) Token: 0x06006005 RID: 24581 RVA: 0x001201F3 File Offset: 0x0011E3F3
	public int ScreenHeight
	{
		get
		{
			return this.ScreenHeightInternal;
		}
	}

	// Token: 0x06006006 RID: 24582 RVA: 0x001201FC File Offset: 0x0011E3FC
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

	// Token: 0x06006007 RID: 24583 RVA: 0x00120334 File Offset: 0x0011E534
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

	// Token: 0x06006008 RID: 24584 RVA: 0x0012038C File Offset: 0x0011E58C
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

	// Token: 0x06006009 RID: 24585 RVA: 0x00120408 File Offset: 0x0011E608
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

	// Token: 0x0600600A RID: 24586 RVA: 0x0012047C File Offset: 0x0011E67C
	private void InitSettings()
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wp.Runtime.OverrideMultipleRuntimeGridNames Grid_Near&Grid_Middle&Grid_Middle_Far&Grid_Far&Grid_SuperFar&Grid_SSuperFar&Grid_HLOD_Small&Grid_HLOD_Middle&Grid_HLOD&Grid_HLOD_Volume_Small&Grid_HLOD_Volume_Middle&Grid_HLOD_Volume&GridRuntime_Landscape&GridRuntime_LandscapeHLOD&Grid_Water&Grid_Impostor&Grid_ExtremeFarFoliage&Grid_Foliage_Normal&Grid_ISM_Near&Grid_ISM_Middle&Grid_ISM_Far&Grid_ISM_SuperFar&Grid_Foliage_Near&Grid_Foliage_Grass&Grid_Foliage_Middle&Grid_Foliage_Far&Grid_Foliage_SuperFar&Grid_ReverseMiddle&Grid_ReverseFar&Grid_ReverseSuperFar&Grid_SSuperFarReverse&Grid_EnclosedSpaceNear&Grid_EnclosedSpaceMiddle&Grid_EnclosedSpaceFar&Grid_EnclosedSpaceSuperFar&Grid_EnclosedSpaceSSuperFar&Grid_AudioNear&Grid_AudioMiddle&Grid_AudioFar&Grid_AudioSuperFar&Grid_PcgWater&Grid_Light_Middle&Grid_Light_Far&Grid_HighResLandscape&Grid_MSuperFar&HLOD0_200m_300m&HLOD0_300m_500m&HLOD1_400m_800m&HLOD0_500m_1000m&HLOD0_500m_1500m&HLOD1_600m_1200m&HLOD1_800m_2500m&HLOD1_800m_4000m", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wp.Runtime.OverrideMultipleRuntimeGridLoadingRangeValues 60&85&200&180&650&2600&100&140&170&100&190&250&440&3500&610&450&1300&274&60&83&100&150&40&80&100&100&196&260&430&860&2600&50&80&130&650&860&40&80&252&86&440&120&156&300&1300&260&430&690&860&1300&1040&2160&3460", null);
	}

	// Token: 0x0600600B RID: 24587 RVA: 0x001204A0 File Offset: 0x0011E6A0
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

	// Token: 0x0600600C RID: 24588 RVA: 0x0012052C File Offset: 0x0011E72C
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

	// Token: 0x0600600D RID: 24589 RVA: 0x00120610 File Offset: 0x0011E810
	public void BindFunction(ECloudGameReceiveDataKey key, TCloudGameOnReceiveDataFunction func)
	{
		this.FunctionLookup[key] = func;
	}

	// Token: 0x0600600E RID: 24590 RVA: 0x0012061F File Offset: 0x0011E81F
	public void UnBindFunction(ECloudGameReceiveDataKey key)
	{
		this.FunctionLookup.Remove(key);
	}

	// Token: 0x0600600F RID: 24591 RVA: 0x00120630 File Offset: 0x0011E830
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

	// Token: 0x06006010 RID: 24592 RVA: 0x00120680 File Offset: 0x0011E880
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

	// Token: 0x06006011 RID: 24593 RVA: 0x001206FB File Offset: 0x0011E8FB
	public void TryRequestGamePadDevice()
	{
		if (!this.IsCloudGame)
		{
			return;
		}
		this.SendData(ECloudGameSendData.RequestGamePadDevice);
	}

	// Token: 0x06006012 RID: 24594 RVA: 0x00120710 File Offset: 0x0011E910
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

	// Token: 0x06006013 RID: 24595 RVA: 0x00120784 File Offset: 0x0011E984
	public void ExitGame(string str)
	{
		string data = Json.Encode(new ExitGameInfo
		{
			Content = str
		}, null);
		this.SendDataByKey(ECloudGameSendData.ExitGame, data);
	}

	// Token: 0x06006014 RID: 24596 RVA: 0x001207B0 File Offset: 0x0011E9B0
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

	// Token: 0x06006015 RID: 24597 RVA: 0x00120AC4 File Offset: 0x0011ECC4
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

	// Token: 0x06006016 RID: 24598 RVA: 0x00120C34 File Offset: 0x0011EE34
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

	// Token: 0x06006017 RID: 24599 RVA: 0x00120C7C File Offset: 0x0011EE7C
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

	// Token: 0x06006018 RID: 24600 RVA: 0x00120E84 File Offset: 0x0011F084
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

	// Token: 0x06006019 RID: 24601 RVA: 0x00120EF8 File Offset: 0x0011F0F8
	public UniTask WaitForUser()
	{
		CloudGameManager.<WaitForUser>d__60 <WaitForUser>d__;
		<WaitForUser>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitForUser>d__.<>4__this = this;
		<WaitForUser>d__.<>1__state = -1;
		<WaitForUser>d__.<>t__builder.Start<CloudGameManager.<WaitForUser>d__60>(ref <WaitForUser>d__);
		return <WaitForUser>d__.<>t__builder.Task;
	}

	// Token: 0x0600601A RID: 24602 RVA: 0x00120F3C File Offset: 0x0011F13C
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

	// Token: 0x0600601B RID: 24603 RVA: 0x00120F8C File Offset: 0x0011F18C
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

	// Token: 0x17000764 RID: 1892
	// (get) Token: 0x0600601C RID: 24604 RVA: 0x00121095 File Offset: 0x0011F295
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

	// Token: 0x0600601D RID: 24605 RVA: 0x001210B8 File Offset: 0x0011F2B8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600601E RID: 24606 RVA: 0x001210BA File Offset: 0x0011F2BA
	public static void ResetStaticDefaultValue()
	{
		CloudGameManager instance = CloudGameManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CloudGameManager._instance = null;
	}

	// Token: 0x0600601F RID: 24607 RVA: 0x001210D3 File Offset: 0x0011F2D3
	static CloudGameManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CloudGameManager.CreateStaticDefaultValue), new Action(CloudGameManager.ResetStaticDefaultValue));
	}

	// Token: 0x04002BAA RID: 11178
	[Nullable(2)]
	public UKuroCloudGameWrapper KuroCloudGameWrapper;

	// Token: 0x04002BAB RID: 11179
	private readonly Dictionary<ECloudGameReceiveDataKey, TCloudGameOnReceiveDataFunction> FunctionLookup = new Dictionary<ECloudGameReceiveDataKey, TCloudGameOnReceiveDataFunction>();

	// Token: 0x04002BAC RID: 11180
	[Nullable(2)]
	private ICloudGameUserInfo UserInfo;

	// Token: 0x04002BAD RID: 11181
	[Nullable(2)]
	private ICloudGamePadInfo CloudGamePadInfoInternal;

	// Token: 0x04002BAE RID: 11182
	private string DeviceMargin;

	// Token: 0x04002BAF RID: 11183
	private int CloudGameDpiInternal;

	// Token: 0x04002BB0 RID: 11184
	private bool IsReboot;

	// Token: 0x04002BB1 RID: 11185
	private bool IsWeb;

	// Token: 0x04002BB2 RID: 11186
	[Nullable(2)]
	private CustomPromise WaitingForUserDb;

	// Token: 0x04002BB3 RID: 11187
	private bool IsRefreshLogin;

	// Token: 0x04002BB4 RID: 11188
	private readonly string WaitingForDbFlagFilePath;

	// Token: 0x04002BB5 RID: 11189
	private readonly string WaitingForDbSavePath;

	// Token: 0x04002BB6 RID: 11190
	private int DeviceScreenWidthInternal;

	// Token: 0x04002BB7 RID: 11191
	private int DeviceScreenHeightInternal;

	// Token: 0x04002BB8 RID: 11192
	private int ScreenWidthInternal;

	// Token: 0x04002BB9 RID: 11193
	private int ScreenHeightInternal;

	// Token: 0x04002BBA RID: 11194
	[Nullable(2)]
	private TimerHandle TimeoutTimer;

	// Token: 0x04002BBB RID: 11195
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

	// Token: 0x04002BBC RID: 11196
	[Nullable(2)]
	private static CloudGameManager _instance;
}
