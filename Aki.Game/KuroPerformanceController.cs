using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using UnrealEngine;

// Token: 0x02001523 RID: 5411
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class KuroPerformanceController : ControllerBase
{
	// Token: 0x0600D875 RID: 55413 RVA: 0x00402F30 File Offset: 0x00401130
	protected override bool OnInit()
	{
		this.IsEnable = UKuroPerformanceBPLibrary.IsPerformanceAdaptiveInitialize();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Performance;
		ELogAuthor author = ELogAuthor.XWX;
		string message = "KuroPerformanceController.OnInit";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IsEnable", this.IsEnable);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (!this.IsEnable)
		{
			return true;
		}
		string currentActivePerformanceAdaptiveModuleName = UKuroPerformanceBPLibrary.GetCurrentActivePerformanceAdaptiveModuleName();
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Performance;
		ELogAuthor author2 = ELogAuthor.XWX;
		string message2 = "KuroPerformanceController.OnInit";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("name", currentActivePerformanceAdaptiveModuleName);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		UKuroPerformanceBPLibrary.StartService(79);
		UKuroPerformanceBPLibrary.InitGameConfigFPS(GameSettingsDeviceRender.Instance.FrameRate);
		UKuroPerformanceBPLibrary.InitGameConfigSceneTransition(false);
		Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasEnteredForegroundDelegate, new Action(this.ApplicationHasEnteredForeground));
		Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillEnterBackgroundDelegate, new Action(this.ApplicationWillEnterBackground));
		EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		EventSystem.Instance.Add<int>(EEventName.SettingFrameRateChanged, new Action<int>(this.OnSettingFrameRateChanged));
		EventSystem.Instance.Add<bool, bool>(EEventName.ChangePerformanceLimitMode, new Action<bool, bool>(this.OnPerformanceLimitModeChanged));
		EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		return true;
	}

	// Token: 0x0600D876 RID: 55414 RVA: 0x00403090 File Offset: 0x00401290
	private void ApplicationHasEnteredForeground()
	{
		bool flag = UKuroPerformanceBPLibrary.SetForeground(true);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Performance;
		ELogAuthor author = ELogAuthor.XWX;
		string message = "ApplicationHasEnteredForeground设置前台";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", flag);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600D877 RID: 55415 RVA: 0x004030D4 File Offset: 0x004012D4
	private void ApplicationWillEnterBackground()
	{
		bool flag = UKuroPerformanceBPLibrary.SetForeground(false);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Performance;
		ELogAuthor author = ELogAuthor.XWX;
		string message = "ApplicationWillEnterBackground取消设置前台";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", flag);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600D878 RID: 55416 RVA: 0x00403118 File Offset: 0x00401318
	protected override bool OnClear()
	{
		if (!this.IsEnable)
		{
			return true;
		}
		Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasEnteredForegroundDelegate, new Action(this.ApplicationHasEnteredForeground));
		Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillEnterBackgroundDelegate, new Action(this.ApplicationWillEnterBackground));
		EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		EventSystem.Instance.Remove(EEventName.SettingFrameRateChanged, new Action<int>(this.OnSettingFrameRateChanged));
		EventSystem.Instance.Remove(EEventName.ChangePerformanceLimitMode, new Action<bool, bool>(this.OnPerformanceLimitModeChanged));
		EventSystem.Instance.Remove<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		this.ReportDelegate = null;
		UKuroPerformanceBPLibrary.StopService(79);
		return true;
	}

	// Token: 0x0600D879 RID: 55417 RVA: 0x004031F9 File Offset: 0x004013F9
	protected override void OnTick(float delta)
	{
		if (!this.IsEnable)
		{
			return;
		}
		this.TimeCount += delta;
		if (this.TimeCount > 1000f)
		{
			this.TimeCount = 0f;
			this.TickPerformanceAdaptive();
		}
	}

	// Token: 0x0600D87A RID: 55418 RVA: 0x00403230 File Offset: 0x00401430
	private void OnBattleStateChanged(bool bStart)
	{
		if (bStart)
		{
			this.BattleHandle = this.Open("Battle");
			return;
		}
		this.Close(this.BattleHandle);
	}

	// Token: 0x0600D87B RID: 55419 RVA: 0x00403253 File Offset: 0x00401453
	private void OnSettingFrameRateChanged(int frameRate)
	{
		if (this.PerformanceMap.Count > 0)
		{
			UKuroPerformanceBPLibrary.SetTargetFPS(frameRate, 0);
		}
		UKuroPerformanceBPLibrary.UpdateGameConfigFPS(frameRate);
	}

	// Token: 0x0600D87C RID: 55420 RVA: 0x00403272 File Offset: 0x00401472
	private void OnPerformanceLimitModeChanged(bool isPerformanceLimitMode, bool forceDisable)
	{
		if (isPerformanceLimitMode && !forceDisable)
		{
			this.PerformanceLimitModeHandle = this.Open("PerformanceLimitMode");
			return;
		}
		this.Close(this.PerformanceLimitModeHandle);
	}

	// Token: 0x0600D87D RID: 55421 RVA: 0x00403298 File Offset: 0x00401498
	private void OnTeleportStart(bool _)
	{
		bool flag = UKuroPerformanceBPLibrary.UpdateGameConfigSceneTransition(true);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Performance;
		ELogAuthor author = ELogAuthor.XWX;
		string message = "KuroPerformanceController.OnTeleportStart";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", flag);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600D87E RID: 55422 RVA: 0x004032DC File Offset: 0x004014DC
	[NullableContext(2)]
	private void OnTeleportComplete(TeleportContext _)
	{
		bool flag = UKuroPerformanceBPLibrary.UpdateGameConfigSceneTransition(false);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Performance;
		ELogAuthor author = ELogAuthor.XWX;
		string message = "KuroPerformanceController.OnTeleportComplete";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", flag);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600D87F RID: 55423 RVA: 0x00403320 File Offset: 0x00401520
	public unsafe int Open(string reason)
	{
		int num = this.PerformanceCount + 1;
		this.PerformanceCount = num;
		int num2 = num;
		this.PerformanceMap[num2] = reason;
		if (this.PerformanceMap.Count > 1)
		{
			return num2;
		}
		UKuroPerformanceBPLibrary.SetTargetFPS(GameSettingsDeviceRender.Instance.FrameRate, 0);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Performance;
		ELogAuthor author = ELogAuthor.HXY;
		string message = "KuroPerformanceController.Open";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Handle", num2);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return num2;
	}

	// Token: 0x0600D880 RID: 55424 RVA: 0x004033CC File Offset: 0x004015CC
	public unsafe void Close(int handle)
	{
		string item;
		if (!this.PerformanceMap.TryGetValue(handle, out item))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Performance;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "性能模式句柄不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Handle", handle);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.PerformanceMap.Remove(handle);
		if (this.PerformanceMap.Count > 0)
		{
			return;
		}
		UKuroPerformanceBPLibrary.SetTargetFPS(0, 0);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Performance;
		ELogAuthor author2 = ELogAuthor.HXY;
		string message2 = "KuroPerformanceController.Close";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", item);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Handle", handle);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0600D881 RID: 55425 RVA: 0x00403498 File Offset: 0x00401698
	private void TickPerformanceAdaptive()
	{
		int count = this.PerformanceMap.Count;
	}

	// Token: 0x0600D882 RID: 55426 RVA: 0x004034A8 File Offset: 0x004016A8
	private void OnGetTickedPerformanceReportAndAdvice(FKuroPerformanceReport performanceReport)
	{
	}

	// Token: 0x17001420 RID: 5152
	// (get) Token: 0x0600D883 RID: 55427 RVA: 0x004034B5 File Offset: 0x004016B5
	public static KuroPerformanceController Instance
	{
		get
		{
			return KuroPerformanceController._Instance;
		}
	}

	// Token: 0x0600D884 RID: 55428 RVA: 0x004034BC File Offset: 0x004016BC
	public static KuroPerformanceController GetOrCreateInstance()
	{
		if (KuroPerformanceController._Instance == null)
		{
			KuroPerformanceController.CreateInstance();
		}
		return KuroPerformanceController._Instance;
	}

	// Token: 0x0600D885 RID: 55429 RVA: 0x004034D0 File Offset: 0x004016D0
	public static bool CreateInstance()
	{
		if (KuroPerformanceController._Instance != null)
		{
			return true;
		}
		KuroPerformanceController._Instance = new KuroPerformanceController();
		return true;
	}

	// Token: 0x0600D886 RID: 55430 RVA: 0x004034E6 File Offset: 0x004016E6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D887 RID: 55431 RVA: 0x004034E8 File Offset: 0x004016E8
	public static void ResetStaticDefaultValue()
	{
		KuroPerformanceController._Instance = null;
	}

	// Token: 0x0600D888 RID: 55432 RVA: 0x004034F0 File Offset: 0x004016F0
	static KuroPerformanceController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroPerformanceController.CreateStaticDefaultValue), new Action(KuroPerformanceController.ResetStaticDefaultValue));
	}

	// Token: 0x0400791C RID: 31004
	private const bool BOOST_SWITCH = true;

	// Token: 0x0400791D RID: 31005
	private const float GAP_TIME = 1000f;

	// Token: 0x0400791E RID: 31006
	private const int SERVICE_CODE = 79;

	// Token: 0x0400791F RID: 31007
	public bool IsEnable = true;

	// Token: 0x04007920 RID: 31008
	private float TimeCount;

	// Token: 0x04007921 RID: 31009
	private int PerformanceCount;

	// Token: 0x04007922 RID: 31010
	private readonly Dictionary<int, string> PerformanceMap = new Dictionary<int, string>();

	// Token: 0x04007923 RID: 31011
	private int BattleHandle;

	// Token: 0x04007924 RID: 31012
	private int PerformanceLimitModeHandle;

	// Token: 0x04007925 RID: 31013
	private const bool DebugLogEnabled = false;

	// Token: 0x04007926 RID: 31014
	[Nullable(2)]
	private FGetTickedPerformanceReportAndAdviceDelegate ReportDelegate;

	// Token: 0x04007927 RID: 31015
	[Nullable(2)]
	private static KuroPerformanceController _Instance;
}
