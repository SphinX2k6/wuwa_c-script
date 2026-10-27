using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02000E3F RID: 3647
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class OpenHarmonySdkController : ControllerBase
{
	// Token: 0x060057AC RID: 22444 RVA: 0x000FC928 File Offset: 0x000FAB28
	public void SetEnable(bool enable)
	{
		this.IsEnable = enable;
	}

	// Token: 0x060057AD RID: 22445 RVA: 0x000FC931 File Offset: 0x000FAB31
	public bool CanUse()
	{
		return this.IsEnable && Info.Instance.IsOpenHarmonyPlatform();
	}

	// Token: 0x060057AE RID: 22446 RVA: 0x000FC947 File Offset: 0x000FAB47
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

	// Token: 0x060057AF RID: 22447 RVA: 0x000FC966 File Offset: 0x000FAB66
	protected override bool OnClear()
	{
		if (this.EventBound)
		{
			this.UnRegisterSettingsListener();
		}
		this.IsInitialized = false;
		return true;
	}

	// Token: 0x060057B0 RID: 22448 RVA: 0x000FC980 File Offset: 0x000FAB80
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
		FKuroHarmonyGamePackageInfo fkuroHarmonyGamePackageInfo = new FKuroHarmonyGamePackageInfo(0, text, appVersion, 1, engineVersion, 2, flag);
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

	// Token: 0x060057B1 RID: 22449 RVA: 0x000FCA94 File Offset: 0x000FAC94
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
		FKuroHarmonyGameConfigInfo fkuroHarmonyGameConfigInfo = new FKuroHarmonyGameConfigInfo(1, lastOptionsValue, currentValueSafely, maxFrameRate, frameRate, maxResolution, currentResolutionStr, bAntiAliasing, false, false, false, false);
		UKuroOpenHarmonyLibrary.UpdateGameConfigInfo(fkuroHarmonyGameConfigInfo);
	}

	// Token: 0x060057B2 RID: 22450 RVA: 0x000FCB40 File Offset: 0x000FAD40
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

	// Token: 0x060057B3 RID: 22451 RVA: 0x000FCB8C File Offset: 0x000FAD8C
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

	// Token: 0x060057B4 RID: 22452 RVA: 0x000FCBE4 File Offset: 0x000FADE4
	private void UnRegisterSettingsListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnMenuSettingChanged));
		EventSystem.Instance.Remove(EEventName.SettingFrameRateChanged, new Action<int>(this.OnFrameRateChanged));
		this.EventBound = false;
	}

	// Token: 0x060057B5 RID: 22453 RVA: 0x000FCC30 File Offset: 0x000FAE30
	private void OnMenuSettingChanged(EFunction functionId)
	{
		if (functionId == EFunction.MOBILERESOLUTION || functionId == EFunction.HIGHESTFPS || functionId == EFunction.ANTIALISING)
		{
			this.UpdateGameConfigInfo();
		}
	}

	// Token: 0x060057B6 RID: 22454 RVA: 0x000FCC47 File Offset: 0x000FAE47
	private void OnFrameRateChanged(int frameRate)
	{
		this.UpdateGameConfigInfo();
	}

	// Token: 0x060057B7 RID: 22455 RVA: 0x000FCC50 File Offset: 0x000FAE50
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

	// Token: 0x17000659 RID: 1625
	// (get) Token: 0x060057B8 RID: 22456 RVA: 0x000FCCA9 File Offset: 0x000FAEA9
	public static OpenHarmonySdkController Instance
	{
		get
		{
			return OpenHarmonySdkController._Instance;
		}
	}

	// Token: 0x060057B9 RID: 22457 RVA: 0x000FCCB0 File Offset: 0x000FAEB0
	public static OpenHarmonySdkController GetOrCreateInstance()
	{
		if (OpenHarmonySdkController._Instance == null)
		{
			OpenHarmonySdkController.CreateInstance();
		}
		return OpenHarmonySdkController._Instance;
	}

	// Token: 0x060057BA RID: 22458 RVA: 0x000FCCC4 File Offset: 0x000FAEC4
	public static bool CreateInstance()
	{
		if (OpenHarmonySdkController._Instance != null)
		{
			return true;
		}
		OpenHarmonySdkController._Instance = new OpenHarmonySdkController();
		return true;
	}

	// Token: 0x060057BB RID: 22459 RVA: 0x000FCCDA File Offset: 0x000FAEDA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060057BC RID: 22460 RVA: 0x000FCCDC File Offset: 0x000FAEDC
	public static void ResetStaticDefaultValue()
	{
		OpenHarmonySdkController._Instance = null;
	}

	// Token: 0x060057BD RID: 22461 RVA: 0x000FCCE4 File Offset: 0x000FAEE4
	static OpenHarmonySdkController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(OpenHarmonySdkController.CreateStaticDefaultValue), new Action(OpenHarmonySdkController.ResetStaticDefaultValue));
	}

	// Token: 0x04002873 RID: 10355
	private const int MESSAGE_TYPE_PACKAGE_INFO = 0;

	// Token: 0x04002874 RID: 10356
	private const int MESSAGE_TYPE_CONFIG_INFO = 1;

	// Token: 0x04002875 RID: 10357
	private const int ENGINE_TYPE_UE = 1;

	// Token: 0x04002876 RID: 10358
	private const int GAME_TYPE = 2;

	// Token: 0x04002877 RID: 10359
	private const string BUNDLE_NAME = "com.kurogame.mingchao.hongmeng.huawei";

	// Token: 0x04002878 RID: 10360
	public bool IsEnable = true;

	// Token: 0x04002879 RID: 10361
	private bool IsInitialized;

	// Token: 0x0400287A RID: 10362
	private bool EventBound;

	// Token: 0x0400287B RID: 10363
	[Nullable(2)]
	private static OpenHarmonySdkController _Instance;
}
