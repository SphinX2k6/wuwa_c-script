using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.GameSettings;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Util;
using UnrealEngine;

// Token: 0x0200027A RID: 634
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class GameSettingsController : ControllerBase
{
	// Token: 0x060026F2 RID: 9970 RVA: 0x000EB620 File Offset: 0x000E9820
	protected override bool OnInit()
	{
		Log.Instance.Info(ELogModule.Render, ELogAuthor.ZJF, "GameSettingsController-OnInit", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.KuroRenderQualityLocalIndex = -1;
		this.AddEvents();
		this.KuroRenderQualityVolumeManager = (UKuroRenderingRuntimeBPPluginBPLibrary.GetEngineSubsystem(UKuroRenderQualityVolumeManager.StaticClass()) as UKuroRenderQualityVolumeManager);
		this.AddKuroRenderQualityVolumeEvents();
		return true;
	}

	// Token: 0x060026F3 RID: 9971 RVA: 0x000EB677 File Offset: 0x000E9877
	protected override bool OnClear()
	{
		GameSettingsUtils.RestoreDistanceQualityDefaults();
		this.KuroRenderQualityLocalIndex = -1;
		this.RemoveEvents();
		this.RemoveKuroRenderQualityVolumeEvents();
		return true;
	}

	// Token: 0x060026F4 RID: 9972 RVA: 0x000EB694 File Offset: 0x000E9894
	private unsafe void KuroRenderQualityVolumeReApplyGameSettings()
	{
		GameSettingsManager.Instance.ReApply(EFunction.NPCDENSITY, EGameSettingsApplyReason.AnyTime, false);
		GameSettingsManager.Instance.ReApply(EFunction.NVIDIADLSSQUALITY, EGameSettingsApplyReason.AnyTime, false);
		GameSettingsManager.Instance.ReApply(EFunction.NIAGARAQUALITY, EGameSettingsApplyReason.AnyTime, false);
		if (Info.Instance.IsWindowsPlatform())
		{
			if (((this.KuroRenderQualityLocalIndex >= 80 && this.KuroRenderQualityLocalIndex < 100) || (this.KuroRenderQualityLocalIndex >= 110 && this.KuroRenderQualityLocalIndex < 130)) && UKismetSystemLibrary.GetConsoleVariableIntValue("r.RayTracing.Enable") == 0)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "UBInstancing.Enabled 0", null);
			}
			else
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "UBInstancing.Enabled 1", null);
			}
		}
		if (Info.Instance.IsWindowsPlatform() && GameSettingsDeviceRender.Instance.DeviceVideoGbRam >= 7 && UKismetSystemLibrary.GetConsoleVariableIntValue("sg.TextureQuality") == 3)
		{
			if (this.KuroRenderQualityLocalIndex >= 100 && this.KuroRenderQualityLocalIndex < 110)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Streaming.PoolSize 1350", null);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Render;
				ELogAuthor author = ELogAuthor.LQX;
				string message = "[局部性能盒子-TS] 高显存提升池子";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PoolSize:", 1350);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Streaming.PoolSize 1000", null);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Render;
				ELogAuthor author2 = ELogAuthor.LQX;
				string message2 = "[局部性能盒子-TS] 高显存恢复池子";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PoolSize:", 1000);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
		}
		if (Info.Instance.IsWindowsPlatform())
		{
			if (this.KuroRenderQualityLocalIndex >= 130 && this.KuroRenderQualityLocalIndex < 140 && UKuroStaticLibrary.GetVideoMemoryGB() < 9 && UKismetSystemLibrary.GetConsoleVariableIntValue("r.RayTracing.Enable") != 0)
			{
				if (this.LowVideoMemoryRayTracingOriginalPoolSize < 0)
				{
					this.LowVideoMemoryRayTracingOriginalPoolSize = UKismetSystemLibrary.GetConsoleVariableIntValue("r.Streaming.PoolSize");
				}
				UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Int("r.Streaming.PoolSize", 800);
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Render;
				ELogAuthor author3 = ELogAuthor.LQX;
				string message3 = "[局部性能盒子-TS] 低显存光追降低池子";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PoolSize:", 800);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OriginalPoolSize:", this.LowVideoMemoryRayTracingOriginalPoolSize);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (this.LowVideoMemoryRayTracingOriginalPoolSize >= 0)
			{
				UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Int("r.Streaming.PoolSize", this.LowVideoMemoryRayTracingOriginalPoolSize);
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Render;
				ELogAuthor author4 = ELogAuthor.LQX;
				string message4 = "[局部性能盒子-TS] 低显存光追恢复池子";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("PoolSize:", this.LowVideoMemoryRayTracingOriginalPoolSize);
				instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				this.LowVideoMemoryRayTracingOriginalPoolSize = -1;
			}
		}
	}

	// Token: 0x060026F5 RID: 9973 RVA: 0x000EB928 File Offset: 0x000E9B28
	private void AddKuroRenderQualityVolumeEvents()
	{
		Action callback = delegate()
		{
			Log.Instance.Info(ELogModule.Render, ELogAuthor.LQX, "[局部性能盒子-TS] 进入盒子", default(ReadOnlySpan<ValueTuple<string, object>>));
		};
		this.KuroRenderQualityVolumeManager.OnEnterVolumeBlueprintEvent.Add(callback);
		Action<int> callback2 = delegate(int localIndex)
		{
			this.KuroRenderQualityLocalIndex = localIndex;
			this.KuroRenderQualityVolumeReApplyGameSettings();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.LQX;
			string message = "[局部性能盒子-TS] 盒子应用索引";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LocalIndex:", localIndex);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		};
		this.KuroRenderQualityVolumeManager.OnApplyKuroRenderLocalSettingsBlueprintEvent.Add(callback2);
		Action callback3 = delegate()
		{
			this.KuroRenderQualityLocalIndex = -1;
			this.KuroRenderQualityVolumeReApplyGameSettings();
			Log.Instance.Info(ELogModule.Render, ELogAuthor.LQX, "[局部性能盒子-TS] 离开盒子", default(ReadOnlySpan<ValueTuple<string, object>>));
		};
		this.KuroRenderQualityVolumeManager.OnLeaveVolumeBlueprintEvent.Add(callback3);
	}

	// Token: 0x060026F6 RID: 9974 RVA: 0x000EB9A2 File Offset: 0x000E9BA2
	private void RemoveKuroRenderQualityVolumeEvents()
	{
		this.KuroRenderQualityVolumeManager.OnEnterVolumeBlueprintEvent.Clear();
		this.KuroRenderQualityVolumeManager.OnApplyKuroRenderLocalSettingsBlueprintEvent.Clear();
		this.KuroRenderQualityVolumeManager.OnLeaveVolumeBlueprintEvent.Clear();
	}

	// Token: 0x060026F7 RID: 9975 RVA: 0x000EB9D4 File Offset: 0x000E9BD4
	private void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnStartLoadingState, new Action(this.OnOpenLoading));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnOpenLevel));
		EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
		EventSystem.Instance.Add(EEventName.OnSubLevelAdded, new Action(this.OnSubLevelAdded));
		EventSystem.Instance.Add(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.OnBeforeOpenLoginView;
		Action handle;
		if ((handle = GameSettingsController.<>O.<0>__OnBeforeOpenLoginView) == null)
		{
			handle = (GameSettingsController.<>O.<0>__OnBeforeOpenLoginView = new Action(GameSettingsController.OnBeforeOpenLoginView));
		}
		instance.Add(name, handle);
		Application.Instance.AddWindowActivationHandler(new Action<bool>(this.OnWindowActive));
		this.AddFoldStateChangeEvent();
	}

	// Token: 0x060026F8 RID: 9976 RVA: 0x000EBAB4 File Offset: 0x000E9CB4
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnStartLoadingState, new Action(this.OnOpenLoading));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnOpenLevel));
		EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
		EventSystem.Instance.Remove(EEventName.OnSubLevelAdded, new Action(this.OnSubLevelAdded));
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.OnBeforeOpenLoginView;
		Action handle;
		if ((handle = GameSettingsController.<>O.<0>__OnBeforeOpenLoginView) == null)
		{
			handle = (GameSettingsController.<>O.<0>__OnBeforeOpenLoginView = new Action(GameSettingsController.OnBeforeOpenLoginView));
		}
		instance.Remove(name, handle);
		Application.Instance.RemoveWindowActivationHandler(new Action<bool>(this.OnWindowActive));
		this.RemoveFoldStateChangeEvent();
	}

	// Token: 0x060026F9 RID: 9977 RVA: 0x000EBB94 File Offset: 0x000E9D94
	private void AddFoldStateChangeEvent()
	{
		if (!Platform.Instance.IsOpenHarmonyPlatform() || Platform.Instance.IsRedMagicDevice())
		{
			return;
		}
		LauncherSdkBase launcherSdkBase = LauncherSdk.Get();
		if (!launcherSdkBase.IsFoldableScreen())
		{
			return;
		}
		this.FoldStateSdk = launcherSdkBase;
		launcherSdkBase.BindFoldStateChangeCallback(new Action<bool>(this.OnFoldStateChanged));
		this.OnFoldStateChanged(launcherSdkBase.IsScreenFolded());
	}

	// Token: 0x060026FA RID: 9978 RVA: 0x000EBBEE File Offset: 0x000E9DEE
	private void RemoveFoldStateChangeEvent()
	{
		LauncherSdkBase foldStateSdk = this.FoldStateSdk;
		if (foldStateSdk != null)
		{
			foldStateSdk.UnbindFoldStateChangeCallback(new Action<bool>(this.OnFoldStateChanged));
		}
		this.FoldStateSdk = null;
	}

	// Token: 0x060026FB RID: 9979 RVA: 0x000EBC14 File Offset: 0x000E9E14
	private void OnFoldStateChanged(bool isFolded)
	{
		UWorld world = GlobalData.World;
		if (this.FoldStateSdk != null && world != null)
		{
			LauncherGameSettingLib.Instance.ApplyFoldStateMobileContentScaleFactor(world, isFolded);
		}
	}

	// Token: 0x060026FC RID: 9980 RVA: 0x000EBC40 File Offset: 0x000E9E40
	private void OnOpenLoading()
	{
		if (GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading)
		{
			Log.Instance.Info(ELogModule.Render, ELogAuthor.WZ, "游戏设置已经初始化应用过", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log.Instance.Info(ELogModule.Render, ELogAuthor.ZJF, "初始化-应用设置参数1111", default(ReadOnlySpan<ValueTuple<string, object>>));
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Streaming.FullyLoadUsedTextures 0", null);
		if (UKuroStaticLibrary.IsLowMemoryDevice())
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Streaming.RenderAssetMinKuroBoostFactor 0.1", null);
		}
		GameSettingsManager.Instance.HandleInitDataOnOpenLoading();
		EventSystem.Instance.Emit(EEventName.AfterGameSettingsAppliedOnOpenLoading);
		GameSettingsDeviceRender.Instance.CancelAllPerformanceLimit();
		GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading = true;
	}

	// Token: 0x060026FD RID: 9981 RVA: 0x000EBCE8 File Offset: 0x000E9EE8
	private void OnOpenLevel()
	{
		if (!GameModeModel.Instance.UseWorldPartition)
		{
			Log.Instance.Info(ELogModule.Render, ELogAuthor.ZYT, "进入副本-调整渲染参数", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (!Info.Instance.IsPcOrGamepadPlatform())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Mobile.EnableKuroSpotlightsShadow 1", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.FogVisibilityCulling.Enable 0", null);
			}
			GameSettingsLevelRender.Instance.SetLevelRenderSettings();
			ALandscapeProxy.SetKuroLandscapeFOVFactor(0f);
			UStreamableRenderAsset.SetKuroStreamingLevelState(1);
			this.RemoveTimer();
			this.AddTimer();
		}
		else
		{
			Log.Instance.Info(ELogModule.Render, ELogAuthor.ZYT, "进入大世界-调整渲染参数", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (!Info.Instance.IsPcOrGamepadPlatform())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Mobile.EnableKuroSpotlightsShadow 0", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.FogVisibilityCulling.Enable 1", null);
			}
			ALandscapeProxy.SetKuroLandscapeFOVFactor(-1f);
			UStreamableRenderAsset.SetKuroStreamingLevelState(0);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CacheWholeSceneShadows 1", null);
			this.RemoveTimer();
		}
		GameSettingsManager.Instance.ReApply(EFunction.SCENEAO, EGameSettingsApplyReason.WhenLoading, true);
		GameSettingsManager.Instance.ReApply(EFunction.VegetationDither, EGameSettingsApplyReason.WhenLoading, true);
		GameSettingsUtils.ReApplyMaterialQualityLevel(null);
		GameSettingsManager.Instance.ReApply(EFunction.GamepadLeftStickDeadZone, EGameSettingsApplyReason.WhenLoading, false);
		GameSettingsManager.Instance.ReApply(EFunction.GamepadRightStickDeadZone, EGameSettingsApplyReason.WhenLoading, false);
		GameSettingsManager.Instance.ReApply(EFunction.GamepadLeftTriggerDeadZone, EGameSettingsApplyReason.WhenLoading, false);
		GameSettingsManager.Instance.ReApply(EFunction.GamepadRightTriggerDeadZone, EGameSettingsApplyReason.WhenLoading, false);
		GameSettingsUtils.ReApplyLoadingRangeScale();
	}

	// Token: 0x060026FE RID: 9982 RVA: 0x000EBE5C File Offset: 0x000EA05C
	private void OnClearWorld()
	{
		this.KuroRenderQualityLocalIndex = -1;
		if (!GameModeModel.Instance.UseWorldPartition)
		{
			Log.Instance.Info(ELogModule.Render, ELogAuthor.ZYT, "退出副本-调整渲染参数", default(ReadOnlySpan<ValueTuple<string, object>>));
			GameSettingsLevelRender.Instance.RevertLevelRenderSetting();
			ALandscapeProxy.SetKuroLandscapeFOVFactor(-1f);
			UStreamableRenderAsset.SetKuroStreamingLevelState(0);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CacheWholeSceneShadows 1", null);
			this.RemoveTimer();
		}
	}

	// Token: 0x060026FF RID: 9983 RVA: 0x000EBEC8 File Offset: 0x000EA0C8
	private void OnSubLevelAdded()
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CacheWholeSceneShadows 0", null);
		this.RemoveTimer();
		this.AddTimer();
	}

	// Token: 0x06002700 RID: 9984 RVA: 0x000EBEE6 File Offset: 0x000EA0E6
	private void OnTimer(float _)
	{
		this.TimerId = null;
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CacheWholeSceneShadows 1", null);
	}

	// Token: 0x06002701 RID: 9985 RVA: 0x000EBEFF File Offset: 0x000EA0FF
	private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		if (last == EInputControllerMainType.Gamepad || now == EInputControllerMainType.Gamepad)
		{
			GameSettingsUtils.RefreshViewRevertState(now);
		}
	}

	// Token: 0x06002702 RID: 9986 RVA: 0x000EBF10 File Offset: 0x000EA110
	private void OnWindowActive(bool bIsActive)
	{
		if (GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.BackendVolume, 0, true) == 1)
		{
			if (bIsActive)
			{
				AudioSystem.Instance.SetState("master_bus_by_focus_state", "none", true);
				return;
			}
			AudioSystem.Instance.SetState("master_bus_by_focus_state", "mute_all_sound", true);
		}
	}

	// Token: 0x06002703 RID: 9987 RVA: 0x000EBF5F File Offset: 0x000EA15F
	public void OnGameUserSettingsUINeedsUpdate()
	{
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			this.OnUEGameUserSettingsUpdate();
		}, null, null);
	}

	// Token: 0x06002704 RID: 9988 RVA: 0x000EBF7C File Offset: 0x000EA17C
	public void OnUEGameUserSettingsUpdate()
	{
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		if (gameUserSettings == null)
		{
			return;
		}
		int num = ((gameUserSettings.GetFullscreenMode() == EWindowMode.Windowed) > false) ? 1 : 0;
		int? num2 = new int?(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.DISPLAYMODE, 0, true));
		int num3 = num;
		if (!(num2.GetValueOrDefault() == num3 & num2 != null))
		{
			GameSettingsManager.Instance.HandleValueChange(EFunction.DISPLAYMODE, num, EGameSettingsApplyReason.AnyTime);
		}
		int? num4 = new int?(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RESOLUTION, 0, true));
		int resolutionIndexByList = GameSettingsDeviceRender.Instance.GetResolutionIndexByList(gameUserSettings.GetScreenResolution());
		num2 = num4;
		num3 = resolutionIndexByList;
		if (!(num2.GetValueOrDefault() == num3 & num2 != null))
		{
			GameSettingsManager.Instance.HandleValueChange(EFunction.RESOLUTION, resolutionIndexByList, EGameSettingsApplyReason.AnyTime);
		}
	}

	// Token: 0x06002705 RID: 9989 RVA: 0x000EC029 File Offset: 0x000EA229
	private void AddTimer()
	{
		this.TimerId = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.OnTimer), 1000f, null, null, true, 1f);
	}

	// Token: 0x06002706 RID: 9990 RVA: 0x000EC054 File Offset: 0x000EA254
	private void RemoveTimer()
	{
		if (this.TimerId != null)
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			}
			this.TimerId = null;
		}
	}

	// Token: 0x06002707 RID: 9991 RVA: 0x000EC088 File Offset: 0x000EA288
	private static void OnBeforeOpenLoginView()
	{
		Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.TZJ, "在打开登录界面之前-执行预设置逻辑", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (Platform.Instance.IsCloudGame())
		{
			Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.TZJ, "在云游戏平台下，执行预设置60FPS", default(ReadOnlySpan<ValueTuple<string, object>>));
			GameSettingsDeviceRender.Instance.ApplyFrameRate(60);
			return;
		}
		Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.TZJ, "在非云游戏平台下，执行预设置FPS", default(ReadOnlySpan<ValueTuple<string, object>>));
		GameSettingsUtils.ApplyHighestFps(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.HIGHESTFPS, 0, true));
	}

	// Token: 0x170005F6 RID: 1526
	// (get) Token: 0x06002708 RID: 9992 RVA: 0x000EC11F File Offset: 0x000EA31F
	[Nullable(1)]
	public static GameSettingsController Instance
	{
		[NullableContext(1)]
		get
		{
			return GameSettingsController._Instance;
		}
	}

	// Token: 0x06002709 RID: 9993 RVA: 0x000EC126 File Offset: 0x000EA326
	[NullableContext(1)]
	public static GameSettingsController GetOrCreateInstance()
	{
		if (GameSettingsController._Instance == null)
		{
			GameSettingsController.CreateInstance();
		}
		return GameSettingsController._Instance;
	}

	// Token: 0x0600270A RID: 9994 RVA: 0x000EC13A File Offset: 0x000EA33A
	public static bool CreateInstance()
	{
		if (GameSettingsController._Instance != null)
		{
			return true;
		}
		GameSettingsController._Instance = new GameSettingsController();
		return true;
	}

	// Token: 0x0600270B RID: 9995 RVA: 0x000EC150 File Offset: 0x000EA350
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600270C RID: 9996 RVA: 0x000EC152 File Offset: 0x000EA352
	public static void ResetStaticDefaultValue()
	{
		GameSettingsController._Instance = null;
	}

	// Token: 0x0600270D RID: 9997 RVA: 0x000EC15A File Offset: 0x000EA35A
	static GameSettingsController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsController.CreateStaticDefaultValue), new Action(GameSettingsController.ResetStaticDefaultValue));
	}

	// Token: 0x0400254E RID: 9550
	private TimerHandle TimerId;

	// Token: 0x0400254F RID: 9551
	private UKuroRenderQualityVolumeManager KuroRenderQualityVolumeManager;

	// Token: 0x04002550 RID: 9552
	private LauncherSdkBase FoldStateSdk;

	// Token: 0x04002551 RID: 9553
	public int KuroRenderQualityLocalIndex = -1;

	// Token: 0x04002552 RID: 9554
	private int LowVideoMemoryRayTracingOriginalPoolSize = -1;

	// Token: 0x04002553 RID: 9555
	private static GameSettingsController _Instance;

	// Token: 0x02006607 RID: 26119
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04021C2E RID: 138286
		[Nullable(0)]
		public static Action <0>__OnBeforeOpenLoginView;
	}
}
