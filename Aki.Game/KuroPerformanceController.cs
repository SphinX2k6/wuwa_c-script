using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using UnrealEngine;

// Token: 0x02002050 RID: 8272
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class KuroPerformanceController : ControllerBase
{
	// Token: 0x0601040D RID: 66573 RVA: 0x003F6964 File Offset: 0x003F4B64
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
		this.ReportDelegate = this.CreatePerformanceReportDelegate();
		return true;
	}

	// Token: 0x0601040E RID: 66574 RVA: 0x003F6AD0 File Offset: 0x003F4CD0
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

	// Token: 0x0601040F RID: 66575 RVA: 0x003F6B14 File Offset: 0x003F4D14
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

	// Token: 0x06010410 RID: 66576 RVA: 0x003F6B58 File Offset: 0x003F4D58
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

	// Token: 0x06010411 RID: 66577 RVA: 0x003F6C39 File Offset: 0x003F4E39
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

	// Token: 0x06010412 RID: 66578 RVA: 0x003F6C70 File Offset: 0x003F4E70
	private void OnBattleStateChanged(bool bStart)
	{
		if (bStart)
		{
			this.BattleHandle = this.Open("Battle");
			return;
		}
		this.Close(this.BattleHandle);
	}

	// Token: 0x06010413 RID: 66579 RVA: 0x003F6C93 File Offset: 0x003F4E93
	private void OnSettingFrameRateChanged(int frameRate)
	{
		if (this.PerformanceMap.Count > 0)
		{
			UKuroPerformanceBPLibrary.SetTargetFPS(frameRate, 0);
		}
		UKuroPerformanceBPLibrary.UpdateGameConfigFPS(frameRate);
	}

	// Token: 0x06010414 RID: 66580 RVA: 0x003F6CB2 File Offset: 0x003F4EB2
	private void OnPerformanceLimitModeChanged(bool isPerformanceLimitMode, bool forceDisable)
	{
		if (isPerformanceLimitMode && !forceDisable)
		{
			this.PerformanceLimitModeHandle = this.Open("PerformanceLimitMode");
			return;
		}
		this.Close(this.PerformanceLimitModeHandle);
	}

	// Token: 0x06010415 RID: 66581 RVA: 0x003F6CD8 File Offset: 0x003F4ED8
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

	// Token: 0x06010416 RID: 66582 RVA: 0x003F6D1C File Offset: 0x003F4F1C
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

	// Token: 0x06010417 RID: 66583 RVA: 0x003F6D60 File Offset: 0x003F4F60
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

	// Token: 0x06010418 RID: 66584 RVA: 0x003F6E0C File Offset: 0x003F500C
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

	// Token: 0x06010419 RID: 66585 RVA: 0x003F6ED8 File Offset: 0x003F50D8
	private void TickPerformanceAdaptive()
	{
		if (this.PerformanceMap.Count > 0)
		{
			MethodInfo method = typeof(UKuroPerformanceBPLibrary).GetMethod("GetTickedPerformanceReportAndAdvice", BindingFlags.Static | BindingFlags.Public);
			if (method != null)
			{
				method.Invoke(null, new object[]
				{
					this.ReportDelegate
				});
			}
		}
	}

	// Token: 0x0601041A RID: 66586 RVA: 0x003F6F2C File Offset: 0x003F512C
	[NullableContext(2)]
	private Delegate CreatePerformanceReportDelegate()
	{
		MethodInfo method = base.GetType().GetMethod("OnGetTickedPerformanceReportAndAdvice", BindingFlags.Instance | BindingFlags.NonPublic);
		MethodInfo method2 = typeof(UKuroPerformanceBPLibrary).GetMethod("GetTickedPerformanceReportAndAdvice", BindingFlags.Static | BindingFlags.Public);
		if (method == null || method2 == null)
		{
			return null;
		}
		ParameterInfo[] parameters = method2.GetParameters();
		if (parameters.Length != 1)
		{
			return null;
		}
		Delegate result;
		try
		{
			result = Delegate.CreateDelegate(parameters[0].ParameterType, this, method, false);
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0601041B RID: 66587 RVA: 0x003F6FB0 File Offset: 0x003F51B0
	private void OnGetTickedPerformanceReportAndAdvice(FKuroPerformanceReport performanceReport)
	{
	}

	// Token: 0x170013F3 RID: 5107
	// (get) Token: 0x0601041C RID: 66588 RVA: 0x003F6FBD File Offset: 0x003F51BD
	public static KuroPerformanceController Instance
	{
		get
		{
			return KuroPerformanceController._Instance;
		}
	}

	// Token: 0x0601041D RID: 66589 RVA: 0x003F6FC4 File Offset: 0x003F51C4
	public static KuroPerformanceController GetOrCreateInstance()
	{
		if (KuroPerformanceController._Instance == null)
		{
			KuroPerformanceController.CreateInstance();
		}
		return KuroPerformanceController._Instance;
	}

	// Token: 0x0601041E RID: 66590 RVA: 0x003F6FD8 File Offset: 0x003F51D8
	public static bool CreateInstance()
	{
		if (KuroPerformanceController._Instance != null)
		{
			return true;
		}
		KuroPerformanceController._Instance = new KuroPerformanceController();
		return true;
	}

	// Token: 0x0601041F RID: 66591 RVA: 0x003F6FEE File Offset: 0x003F51EE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010420 RID: 66592 RVA: 0x003F6FF0 File Offset: 0x003F51F0
	public static void ResetStaticDefaultValue()
	{
		KuroPerformanceController._Instance = null;
	}

	// Token: 0x06010421 RID: 66593 RVA: 0x003F6FF8 File Offset: 0x003F51F8
	static KuroPerformanceController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroPerformanceController.CreateStaticDefaultValue), new Action(KuroPerformanceController.ResetStaticDefaultValue));
	}

	// Token: 0x04007833 RID: 30771
	private const bool BOOST_SWITCH = true;

	// Token: 0x04007834 RID: 30772
	private const float GAP_TIME = 1000f;

	// Token: 0x04007835 RID: 30773
	private const int SERVICE_CODE = 79;

	// Token: 0x04007836 RID: 30774
	public bool IsEnable = true;

	// Token: 0x04007837 RID: 30775
	private float TimeCount;

	// Token: 0x04007838 RID: 30776
	private int PerformanceCount;

	// Token: 0x04007839 RID: 30777
	private readonly Dictionary<int, string> PerformanceMap = new Dictionary<int, string>();

	// Token: 0x0400783A RID: 30778
	private int BattleHandle;

	// Token: 0x0400783B RID: 30779
	private int PerformanceLimitModeHandle;

	// Token: 0x0400783C RID: 30780
	private const bool DebugLogEnabled = false;

	// Token: 0x0400783D RID: 30781
	[Nullable(2)]
	private Delegate ReportDelegate;

	// Token: 0x0400783E RID: 30782
	[Nullable(2)]
	private static KuroPerformanceController _Instance;
}
