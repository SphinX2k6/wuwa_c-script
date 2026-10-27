using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.GameSettings;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

// Token: 0x02000DC8 RID: 3528
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GameSettingsController : ControllerBase
{
	// Token: 0x0600537E RID: 21374 RVA: 0x000E5080 File Offset: 0x000E3280
	protected override bool OnInit()
	{
		Log.Instance.Info(ELogModule.Render, ELogAuthor.ZJF, "GameSettingsController-OnInit", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.AddEvents();
		this.KuroRenderQualityVolumeManager = (UKuroRenderingRuntimeBPPluginBPLibrary.GetEngineSubsystem(UKuroRenderQualityVolumeManager.StaticClass()) as UKuroRenderQualityVolumeManager);
		this.AddKuroRenderQualityVolumeEvents();
		return true;
	}

	// Token: 0x0600537F RID: 21375 RVA: 0x000E50D0 File Offset: 0x000E32D0
	protected override bool OnClear()
	{
		this.RemoveEvents();
		this.RemoveKuroRenderQualityVolumeEvents();
		return true;
	}

	// Token: 0x06005380 RID: 21376 RVA: 0x000E50E0 File Offset: 0x000E32E0
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
		if (GameSettingsDeviceRender.Instance.DeviceVideoGbRam <= 12 && this.KuroRenderQualityLocalIndex >= 70 && this.KuroRenderQualityLocalIndex < 90)
		{
			float consoleVariableFloatValue = UKismetSystemLibrary.GetConsoleVariableFloatValue("wp.Runtime.LoadingRangeScale");
			if (consoleVariableFloatValue > 1f)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Render;
				ELogAuthor author = ELogAuthor.LQX;
				string message = "[局部性能盒子-TS] 低显存限制流送系数";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("OldValue:", consoleVariableFloatValue);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Value:", 1);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float("wp.Runtime.LoadingRangeScale", 1f);
			}
		}
		if (Info.Instance.IsWindowsPlatform() && GameSettingsDeviceRender.Instance.DeviceVideoGbRam >= 7 && UKismetSystemLibrary.GetConsoleVariableIntValue("sg.TextureQuality") == 3)
		{
			if (this.KuroRenderQualityLocalIndex >= 100 && this.KuroRenderQualityLocalIndex < 110)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Streaming.PoolSize 1350", null);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Render;
				ELogAuthor author2 = ELogAuthor.LQX;
				string message2 = "[局部性能盒子-TS] 高显存提升池子";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PoolSize:", 1350);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Streaming.PoolSize 1000", null);
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Render;
			ELogAuthor author3 = ELogAuthor.LQX;
			string message3 = "[局部性能盒子-TS] 高显存恢复池子";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PoolSize:", 1000);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
	}

	// Token: 0x06005381 RID: 21377 RVA: 0x000E52F0 File Offset: 0x000E34F0
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

	// Token: 0x06005382 RID: 21378 RVA: 0x000E536A File Offset: 0x000E356A
	private void RemoveKuroRenderQualityVolumeEvents()
	{
		this.KuroRenderQualityVolumeManager.OnEnterVolumeBlueprintEvent.Clear();
		this.KuroRenderQualityVolumeManager.OnApplyKuroRenderLocalSettingsBlueprintEvent.Clear();
		this.KuroRenderQualityVolumeManager.OnLeaveVolumeBlueprintEvent.Clear();
	}

	// Token: 0x06005383 RID: 21379 RVA: 0x000E539C File Offset: 0x000E359C
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
	}

	// Token: 0x06005384 RID: 21380 RVA: 0x000E5478 File Offset: 0x000E3678
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
	}

	// Token: 0x06005385 RID: 21381 RVA: 0x000E5554 File Offset: 0x000E3754
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
		if (Platform.Instance.IsPs5Platform())
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "sg.ViewDistanceQuality 2", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "sg.AntiAliasingQuality 2", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "sg.PostProcessQuality 2", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "sg.TextureQuality 2", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "sg.EffectsQuality 3", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "sg.FoliageQuality 2", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.CapsuleKuroAO 1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.LandscapeReverseLODScaleFactor 0", null);
		}
		GameSettingsManager.Instance.HandleInitDataOnOpenLoading();
		EventSystem.Instance.Emit(EEventName.AfterGameSettingsAppliedOnOpenLoading);
		if (Info.Instance.IsPlayInEditor && false)
		{
			string command = "wp.Runtime.OverrideMultipleRuntimeGridNames Grid_Near&Grid_Middle&Grid_Middle_Far&Grid_Far&Grid_SuperFar&Grid_SSuperFar&Grid_HLOD_Small&Grid_HLOD_Middle&Grid_HLOD&Grid_HLOD_Volume_Small&Grid_HLOD_Volume_Middle&Grid_HLOD_Volume&Grid_Water&Grid_Impostor&Grid_ISM_Near&Grid_ISM_Middle&Grid_ISM_Far&Grid_ISM_SuperFar&Grid_Foliage_Near&Grid_Foliage_Grass&Grid_Foliage_Middle&Grid_Foliage_Far&Grid_ReverseFar&Grid_SSuperFarReverse&Grid_EnclosedSpaceNear&Grid_EnclosedSpaceMiddle&Grid_EnclosedSpaceFar&Grid_EnclosedSpaceSuperFar&Grid_EnclosedSpaceSSuperFar";
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, command, null);
			command = "wp.Runtime.OverrideMultipleRuntimeGridLoadingRangeValues 50&80&180&100&450&1800&150&200&300&150&200&300&480&250&50&80&100&150&40&80&100&100&300&1800&50&80&100&450&600";
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, command, null);
			command = "r.Kuro.SkeletalMesh.LODDistanceScale 1.0";
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, command, null);
			command = "r.Kuro.Foliage.GrassCullDistanceMax 3000";
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, command, null);
			command = "r.Kuro.MaterialDesktopQualityShoulderRender 0";
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, command, null);
			command = "r.Kuro.GlobalPointCloudStreamEnabled 0";
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, command, null);
			Log.Instance.Info(ELogModule.World, ELogAuthor.XMC, "Editor: TopSpeedMode is on.", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		GameSettingsDeviceRender.Instance.CancelAllPerformanceLimit();
		GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading = true;
	}

	// Token: 0x06005386 RID: 21382 RVA: 0x000E5728 File Offset: 0x000E3928
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
	}

	// Token: 0x06005387 RID: 21383 RVA: 0x000E5898 File Offset: 0x000E3A98
	private void OnClearWorld()
	{
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

	// Token: 0x06005388 RID: 21384 RVA: 0x000E58FD File Offset: 0x000E3AFD
	private void OnSubLevelAdded()
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CacheWholeSceneShadows 0", null);
		this.RemoveTimer();
		this.AddTimer();
	}

	// Token: 0x06005389 RID: 21385 RVA: 0x000E591B File Offset: 0x000E3B1B
	private void OnTimer(float _)
	{
		this.TimerId = null;
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CacheWholeSceneShadows 1", null);
	}

	// Token: 0x0600538A RID: 21386 RVA: 0x000E5934 File Offset: 0x000E3B34
	private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		if (last == EInputControllerMainType.Gamepad || now == EInputControllerMainType.Gamepad)
		{
			GameSettingsUtils.RefreshViewRevertState(now);
		}
	}

	// Token: 0x0600538B RID: 21387 RVA: 0x000E5944 File Offset: 0x000E3B44
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

	// Token: 0x0600538C RID: 21388 RVA: 0x000E5993 File Offset: 0x000E3B93
	public void OnGameUserSettingsUINeedsUpdate()
	{
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			this.OnUEGameUserSettingsUpdate();
		}, null, null);
	}

	// Token: 0x0600538D RID: 21389 RVA: 0x000E59B0 File Offset: 0x000E3BB0
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

	// Token: 0x0600538E RID: 21390 RVA: 0x000E5A5D File Offset: 0x000E3C5D
	private void AddTimer()
	{
		this.TimerId = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.OnTimer), 1000f, null, null, true, 1f);
	}

	// Token: 0x0600538F RID: 21391 RVA: 0x000E5A88 File Offset: 0x000E3C88
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

	// Token: 0x06005390 RID: 21392 RVA: 0x000E5ABC File Offset: 0x000E3CBC
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

	// Token: 0x170005D0 RID: 1488
	// (get) Token: 0x06005391 RID: 21393 RVA: 0x000E5B53 File Offset: 0x000E3D53
	public static GameSettingsController Instance
	{
		get
		{
			return GameSettingsController._Instance;
		}
	}

	// Token: 0x06005392 RID: 21394 RVA: 0x000E5B5A File Offset: 0x000E3D5A
	public static GameSettingsController GetOrCreateInstance()
	{
		if (GameSettingsController._Instance == null)
		{
			GameSettingsController.CreateInstance();
		}
		return GameSettingsController._Instance;
	}

	// Token: 0x06005393 RID: 21395 RVA: 0x000E5B6E File Offset: 0x000E3D6E
	public static bool CreateInstance()
	{
		if (GameSettingsController._Instance != null)
		{
			return true;
		}
		GameSettingsController._Instance = new GameSettingsController();
		return true;
	}

	// Token: 0x06005394 RID: 21396 RVA: 0x000E5B84 File Offset: 0x000E3D84
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005395 RID: 21397 RVA: 0x000E5B86 File Offset: 0x000E3D86
	public static void ResetStaticDefaultValue()
	{
		GameSettingsController._Instance = null;
	}

	// Token: 0x06005396 RID: 21398 RVA: 0x000E5B8E File Offset: 0x000E3D8E
	static GameSettingsController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsController.CreateStaticDefaultValue), new Action(GameSettingsController.ResetStaticDefaultValue));
	}

	// Token: 0x040024CE RID: 9422
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x040024CF RID: 9423
	[Nullable(2)]
	private UKuroRenderQualityVolumeManager KuroRenderQualityVolumeManager;

	// Token: 0x040024D0 RID: 9424
	public int KuroRenderQualityLocalIndex = -1;

	// Token: 0x040024D1 RID: 9425
	[Nullable(2)]
	private static GameSettingsController _Instance;

	// Token: 0x02007476 RID: 29814
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040268F0 RID: 157936
		[Nullable(0)]
		public static Action <0>__OnBeforeOpenLoginView;
	}
}
