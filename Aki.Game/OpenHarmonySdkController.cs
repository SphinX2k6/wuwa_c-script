using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020002F4 RID: 756
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class OpenHarmonySdkController : ControllerBase
{
	// Token: 0x06002B3C RID: 11068 RVA: 0x001041A4 File Offset: 0x001023A4
	public void SetEnable(bool enable)
	{
		this.IsEnable = enable;
	}

	// Token: 0x06002B3D RID: 11069 RVA: 0x001041AD File Offset: 0x001023AD
	public bool CanUse()
	{
		return this.IsEnable && Info.Instance.IsOpenHarmonyPlatform();
	}

	// Token: 0x06002B3E RID: 11070 RVA: 0x001041C3 File Offset: 0x001023C3
	protected override bool OnInit()
	{
		if (!this.CanUse())
		{
			return true;
		}
		this.InitGamePerformance();
		this.UpdateGameConfigInfo();
		this.RegisterSettingsListener();
		return true;
	}

	// Token: 0x06002B3F RID: 11071 RVA: 0x001041E2 File Offset: 0x001023E2
	protected override bool OnClear()
	{
		if (this.EventBound)
		{
			this.UnRegisterSettingsListener();
		}
		this.IsInitialized = false;
		return true;
	}

	// Token: 0x06002B40 RID: 11072 RVA: 0x001041FC File Offset: 0x001023FC
	public unsafe void InitGamePerformance()
	{
		if (!this.CanUse())
		{
			return;
		}
		string text = "com.kurogame.mingchao.hongmeng.huawei";
		string appVersion = UKuroLauncherLibrary.GetAppVersion();
		string engineVersion = UKismetSystemLibrary.GetEngineVersion();
		bool flag = GameSettingsDeviceRender.Instance.IsVulkanRHI() > 0;
		FKuroHarmonyGamePackageInfo fkuroHarmonyGamePackageInfo = new FKuroHarmonyGamePackageInfo
		{
			MessageType = 0,
			BundleName = text,
			AppVersion = appVersion,
			EngineType = 1,
			EngineVersion = engineVersion,
			GameType = 2,
			bVulkanSupported = flag
		};
		UKuroOpenHarmonyLibrary.InitGamePerformance(fkuroHarmonyGamePackageInfo);
		this.IsInitialized = true;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "[OpenHarmonySdk] InitGamePerformance";
		<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BundleName", text);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AppVersion", appVersion);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EngineType", 1);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("EngineVersion", engineVersion);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("GameType", 2);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("bVulkanSupported", flag);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
	}

	// Token: 0x06002B41 RID: 11073 RVA: 0x0010433C File Offset: 0x0010253C
	public void UpdateGameConfigInfo()
	{
		if (!this.CanUse())
		{
			return;
		}
		if (!this.IsInitialized)
		{
			Log.Instance.Warn(ELogModule.KuroSdk, ELogAuthor.YZY, "[OpenHarmonySdk] UpdateGameConfigInfo skip: not initialized", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int currentValueSafely = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.MOBILERESOLUTION, 0, true);
		string currentResolutionStr = this.GetCurrentResolutionStr();
		int lastOptionsValue = this.GetLastOptionsValue(EFunction.MOBILERESOLUTION, currentValueSafely);
		int frameRate = GameSettingsDeviceRender.Instance.FrameRate;
		int maxFrameRate = GameSettingsDeviceRenderDefine.FrameRateListOpenHarmony[GameSettingsDeviceRenderDefine.FrameRateListOpenHarmony.Length - 1];
		string maxResolution = currentResolutionStr;
		bool bAntiAliasing = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.ANTIALISING, 0, true) != 0;
		FKuroHarmonyGameConfigInfo fkuroHarmonyGameConfigInfo = new FKuroHarmonyGameConfigInfo
		{
			MessageType = 1,
			MaxPictureQualityLevel = lastOptionsValue,
			CurrentPictureQualityLevel = currentValueSafely,
			MaxFrameRate = maxFrameRate,
			CurrentFrameRate = frameRate,
			MaxResolution = maxResolution,
			CurrentResolution = currentResolutionStr,
			bAntiAliasing = bAntiAliasing,
			bShadow = false,
			bMultithreading = false,
			bParticle = false,
			bHdMode = false
		};
		UKuroOpenHarmonyLibrary.UpdateGameConfigInfo(fkuroHarmonyGameConfigInfo);
	}

	// Token: 0x06002B42 RID: 11074 RVA: 0x00104430 File Offset: 0x00102630
	private int GetLastOptionsValue(EFunction functionId, int fallback)
	{
		MenuConfig? valueOrNull = GameSettingsManager.Instance.ValidApplyConfigMap.GetValueOrNull(functionId);
		int[] array = (valueOrNull != null) ? valueOrNull.GetValueOrDefault().OptionsValue() : null;
		if (array == null || array.Length == 0)
		{
			return fallback;
		}
		return array[array.Length - 1];
	}

	// Token: 0x06002B43 RID: 11075 RVA: 0x0010447C File Offset: 0x0010267C
	private void RegisterSettingsListener()
	{
		if (this.EventBound)
		{
			return;
		}
		EventSystem.Instance.Add<EFunction>(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnMenuSettingChanged));
		EventSystem.Instance.Add<int>(EEventName.SettingFrameRateChanged, new Action<int>(this.OnFrameRateChanged));
		this.EventBound = true;
	}

	// Token: 0x06002B44 RID: 11076 RVA: 0x001044D4 File Offset: 0x001026D4
	private void UnRegisterSettingsListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnMenuSettingChanged));
		EventSystem.Instance.Remove(EEventName.SettingFrameRateChanged, new Action<int>(this.OnFrameRateChanged));
		this.EventBound = false;
	}

	// Token: 0x06002B45 RID: 11077 RVA: 0x00104520 File Offset: 0x00102720
	private void OnMenuSettingChanged(EFunction functionId)
	{
		if (functionId == EFunction.MOBILERESOLUTION || functionId == EFunction.HIGHESTFPS || functionId == EFunction.ANTIALISING)
		{
			this.UpdateGameConfigInfo();
		}
	}

	// Token: 0x06002B46 RID: 11078 RVA: 0x00104537 File Offset: 0x00102737
	private void OnFrameRateChanged(int frameRate)
	{
		this.UpdateGameConfigInfo();
	}

	// Token: 0x06002B47 RID: 11079 RVA: 0x00104540 File Offset: 0x00102740
	private string GetCurrentResolutionStr()
	{
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		if (gameUserSettings == null)
		{
			return "";
		}
		FIntPoint screenResolution = gameUserSettings.GetScreenResolution();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(screenResolution.X);
		defaultInterpolatedStringHandler.AppendLiteral("x");
		defaultInterpolatedStringHandler.AppendFormatted<int>(screenResolution.Y);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x1700067D RID: 1661
	// (get) Token: 0x06002B48 RID: 11080 RVA: 0x00104599 File Offset: 0x00102799
	public static OpenHarmonySdkController Instance
	{
		get
		{
			return OpenHarmonySdkController._Instance;
		}
	}

	// Token: 0x06002B49 RID: 11081 RVA: 0x001045A0 File Offset: 0x001027A0
	public static OpenHarmonySdkController GetOrCreateInstance()
	{
		if (OpenHarmonySdkController._Instance == null)
		{
			OpenHarmonySdkController.CreateInstance();
		}
		return OpenHarmonySdkController._Instance;
	}

	// Token: 0x06002B4A RID: 11082 RVA: 0x001045B4 File Offset: 0x001027B4
	public static bool CreateInstance()
	{
		if (OpenHarmonySdkController._Instance != null)
		{
			return true;
		}
		OpenHarmonySdkController._Instance = new OpenHarmonySdkController();
		return true;
	}

	// Token: 0x06002B4B RID: 11083 RVA: 0x001045CA File Offset: 0x001027CA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06002B4C RID: 11084 RVA: 0x001045CC File Offset: 0x001027CC
	public static void ResetStaticDefaultValue()
	{
		OpenHarmonySdkController._Instance = null;
	}

	// Token: 0x06002B4D RID: 11085 RVA: 0x001045D4 File Offset: 0x001027D4
	static OpenHarmonySdkController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(OpenHarmonySdkController.CreateStaticDefaultValue), new Action(OpenHarmonySdkController.ResetStaticDefaultValue));
	}

	// Token: 0x0400290C RID: 10508
	private const int MESSAGE_TYPE_PACKAGE_INFO = 0;

	// Token: 0x0400290D RID: 10509
	private const int MESSAGE_TYPE_CONFIG_INFO = 1;

	// Token: 0x0400290E RID: 10510
	private const int ENGINE_TYPE_UE = 1;

	// Token: 0x0400290F RID: 10511
	private const int GAME_TYPE = 2;

	// Token: 0x04002910 RID: 10512
	private const string BUNDLE_NAME = "com.kurogame.mingchao.hongmeng.huawei";

	// Token: 0x04002911 RID: 10513
	public bool IsEnable = true;

	// Token: 0x04002912 RID: 10514
	private bool IsInitialized;

	// Token: 0x04002913 RID: 10515
	private bool EventBound;

	// Token: 0x04002914 RID: 10516
	[Nullable(2)]
	private static OpenHarmonySdkController _Instance;
}
