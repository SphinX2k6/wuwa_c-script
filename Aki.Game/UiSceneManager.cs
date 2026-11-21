using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Kpose.Blueprint;
using AkiClient.Game.Aki.Map.UISceneLevel.UI_Scene.UI_BP;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiComponent;
using CSharpScript.Game.Render;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020021B9 RID: 8633
[NullableContext(1)]
[Nullable(0)]
public class UiSceneManager : Singleton, ITickable
{
	// Token: 0x060153EA RID: 87018 RVA: 0x0062D388 File Offset: 0x0062B588
	public void Initialize()
	{
		GlobalData.SetUiState(EKuroUI3DState.NotLoaded);
		this.CurUiSceneId = string.Empty;
		this.CurUiScenePathSet.Clear();
		EventSystem.Instance.Add(EEventName.ResetModuleAfterResetToBattleView, new Action(this.ForceCloseUiSceneImmediately));
	}

	// Token: 0x060153EB RID: 87019 RVA: 0x0062D3C4 File Offset: 0x0062B5C4
	private unsafe void UnloadLastAndRecordCurrentUiScene(string sceneId)
	{
		UKuroUiSceneSystem kuroUiSceneSystem = UKuroUiSceneSystem.GetKuroUiSceneSystem(GlobalData.World);
		UiSceneCsv? sceneConfig = UiViewConfig.Instance.GetSceneConfig(sceneId);
		if (sceneConfig == null)
		{
			return;
		}
		HashSet<string> hashSet = new HashSet<string>(sceneConfig.Value.SceneList());
		foreach (string text in this.CurUiScenePathSet)
		{
			if (!hashSet.Contains(text))
			{
				kuroUiSceneSystem.UnloadUiScene(text);
			}
		}
		this.CurUiScenePathSet = hashSet;
		this.GlobalGiMainScene = sceneConfig.Value.MainScene;
		kuroUiSceneSystem.CurrentShowScenePath = this.GlobalGiMainScene;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiSceneManager;
		ELogAuthor author = ELogAuthor.LYX;
		string message = "当前应用到GlobalGI的场景路径";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("sceneId", sceneId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GlobalGIMainScene", this.GlobalGiMainScene);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x060153EC RID: 87020 RVA: 0x0062D4E0 File Offset: 0x0062B6E0
	private void PreloadAllUiScene()
	{
		UKuroUiSceneSystem kuroUiSceneSystem = UKuroUiSceneSystem.GetKuroUiSceneSystem(GlobalData.World);
		FVectorDouble kuroUiSceneLoadOffset = RenderModuleController.Instance.GetKuroUiSceneLoadOffset();
		foreach (string scenePath in this.CurUiScenePathSet)
		{
			kuroUiSceneSystem.PreloadUiScene(scenePath, kuroUiSceneLoadOffset);
		}
	}

	// Token: 0x060153ED RID: 87021 RVA: 0x0062D550 File Offset: 0x0062B750
	private void EndAllUiSceneRendering()
	{
		UKuroUiSceneSystem kuroUiSceneSystem = UKuroUiSceneSystem.GetKuroUiSceneSystem(GlobalData.World);
		foreach (string text in this.CurUiScenePathSet)
		{
			if (kuroUiSceneSystem.AllStreamingLevelInfo.Get(text) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiSceneManager;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "退出3d ui 关卡，关卡不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ScenePath", text);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				break;
			}
		}
		kuroUiSceneSystem.EndUiSceneRendering();
		this.CurUiScenePathSet.Clear();
		this.GlobalGiMainScene = string.Empty;
	}

	// Token: 0x060153EE RID: 87022 RVA: 0x0062D5FC File Offset: 0x0062B7FC
	private void StartAllUiSceneRendering()
	{
		UKuroUiSceneSystem kuroUiSceneSystem = UKuroUiSceneSystem.GetKuroUiSceneSystem(GlobalData.World);
		foreach (string text in this.CurUiScenePathSet)
		{
			if (kuroUiSceneSystem.AllStreamingLevelInfo.Get(text) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiSceneManager;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "渲染3d ui 场景，关卡不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ScenePath", text);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				break;
			}
		}
		kuroUiSceneSystem.StartUiSceneRendering();
	}

	// Token: 0x060153EF RID: 87023 RVA: 0x0062D690 File Offset: 0x0062B890
	private bool CheckOpenUiScene(string sceneId)
	{
		if (GlobalData.World == null)
		{
			return false;
		}
		if (GlobalData.IsUiSceneLoading)
		{
			return false;
		}
		if (UiViewConfig.Instance.GetScenePathList(sceneId).Length == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiSceneManager;
			ELogAuthor author = ELogAuthor.LYX;
			string message = "检查ui场景id配置，场景列表不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sceneId", sceneId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return true;
	}

	// Token: 0x060153F0 RID: 87024 RVA: 0x0062D6E8 File Offset: 0x0062B8E8
	private void SetKuroUiSceneLoadOffset(string sceneId)
	{
		UiSceneCsv? sceneConfig = UiViewConfig.Instance.GetSceneConfig(sceneId);
		if (sceneConfig == null)
		{
			return;
		}
		FVectorDouble kuroUiSceneLoadOffset = new FVectorDouble((double)sceneConfig.Value.WorldOffset.Value.X, (double)sceneConfig.Value.WorldOffset.Value.Y, (double)sceneConfig.Value.WorldOffset.Value.Z);
		RenderModuleController.Instance.SetKuroUiSceneLoadOffset(kuroUiSceneLoadOffset);
	}

	// Token: 0x060153F1 RID: 87025 RVA: 0x0062D780 File Offset: 0x0062B980
	private bool DisableClvForUiScene(string sceneId)
	{
		if (!this.DisableClvUiSceneIds.Contains(sceneId))
		{
			return false;
		}
		if (this.LastClvEnableValue == null)
		{
			this.LastClvEnableValue = new int?(UKismetSystemLibrary.GetConsoleVariableIntValue("r.clv.enable"));
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.clv.enable 0", null);
		return true;
	}

	// Token: 0x060153F2 RID: 87026 RVA: 0x0062D7D0 File Offset: 0x0062B9D0
	private void RestoreClvEnableValue()
	{
		if (this.LastClvEnableValue == null)
		{
			return;
		}
		UObject world = GlobalData.World;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral("r.clv.enable ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.LastClvEnableValue.Value);
		UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		this.LastClvEnableValue = null;
	}

	// Token: 0x060153F3 RID: 87027 RVA: 0x0062D834 File Offset: 0x0062BA34
	public bool OpenUiScene(string sceneId, [Nullable(2)] Action successCallBack = null)
	{
		if (!this.CheckOpenUiScene(sceneId))
		{
			return false;
		}
		UiSceneUtils.RecordSceneFloorReflection();
		if (this.CurUiSceneId == sceneId)
		{
			if (successCallBack != null)
			{
				successCallBack();
			}
			return true;
		}
		bool flag = this.DisableClvForUiScene(sceneId);
		this.SetKuroUiSceneLoadOffset(sceneId);
		FVectorDouble kuroUiSceneLoadOffset = RenderModuleController.Instance.GetKuroUiSceneLoadOffset();
		this.UnloadLastAndRecordCurrentUiScene(sceneId);
		if (!flag)
		{
			this.RestoreClvEnableValue();
		}
		this.PreloadAllUiScene();
		this.HandleEnterUiSceneParams();
		this.CurUiSceneId = sceneId;
		FTransformDouble value = RenderModuleController.Instance.UiSceneOffsetTransform.Value;
		value.SetLocation(kuroUiSceneLoadOffset);
		RenderModuleController.Instance.UiSceneOffsetTransform = new FTransformDouble?(value);
		RenderModuleController.Instance.DebugUiSceneLoadOffset = new FVectorDouble?(kuroUiSceneLoadOffset);
		RenderModuleController.Instance.DebugInUiSceneRendering = true;
		this.LoadSuccessFunction = successCallBack;
		GlobalData.SetUiState(EKuroUI3DState.Loading);
		EventSystem.Instance.Emit(EEventName.UiSceneStartLoad);
		return true;
	}

	// Token: 0x060153F4 RID: 87028 RVA: 0x0062D904 File Offset: 0x0062BB04
	public void SwitchUiScene(string sceneId, [Nullable(2)] Action<bool> callBack = null)
	{
		this.SwitchUiSceneFunction = callBack;
		if (!this.OpenUiScene(sceneId, delegate
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.UiSceneManager;
			ELogAuthor author2 = ELogAuthor.LZK;
			string message2 = "切换3d ui场景成功";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("sceneId", sceneId);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			Action<bool> switchUiSceneFunction2 = this.SwitchUiSceneFunction;
			if (switchUiSceneFunction2 != null)
			{
				switchUiSceneFunction2(true);
			}
			this.SwitchUiSceneFunction = null;
		}))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiSceneManager;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "切换3d ui场景失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sceneId", sceneId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Action<bool> switchUiSceneFunction = this.SwitchUiSceneFunction;
			if (switchUiSceneFunction != null)
			{
				switchUiSceneFunction(false);
			}
			this.SwitchUiSceneFunction = null;
		}
	}

	// Token: 0x060153F5 RID: 87029 RVA: 0x0062D98C File Offset: 0x0062BB8C
	public UniTask SwitchUiSceneWithBlackScreen(string sceneId, [Nullable(2)] Func<bool, UniTask> callBack = null)
	{
		UiSceneManager.<SwitchUiSceneWithBlackScreen>d__18 <SwitchUiSceneWithBlackScreen>d__;
		<SwitchUiSceneWithBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SwitchUiSceneWithBlackScreen>d__.<>4__this = this;
		<SwitchUiSceneWithBlackScreen>d__.sceneId = sceneId;
		<SwitchUiSceneWithBlackScreen>d__.callBack = callBack;
		<SwitchUiSceneWithBlackScreen>d__.<>1__state = -1;
		<SwitchUiSceneWithBlackScreen>d__.<>t__builder.Start<UiSceneManager.<SwitchUiSceneWithBlackScreen>d__18>(ref <SwitchUiSceneWithBlackScreen>d__);
		return <SwitchUiSceneWithBlackScreen>d__.<>t__builder.Task;
	}

	// Token: 0x060153F6 RID: 87030 RVA: 0x0062D9DF File Offset: 0x0062BBDF
	public void CloseUiScene()
	{
		this.ForceHandleScene();
	}

	// Token: 0x060153F7 RID: 87031 RVA: 0x0062D9E7 File Offset: 0x0062BBE7
	private void ForceCloseUiSceneImmediately()
	{
		this.ForceHandleScene();
	}

	// Token: 0x060153F8 RID: 87032 RVA: 0x0062D9F0 File Offset: 0x0062BBF0
	private void ForceHandleScene()
	{
		UiSceneUtils.RestoreSceneFloorReflection();
		if (StringUtils.IsEmpty(this.CurUiSceneId))
		{
			return;
		}
		this.CurUiSceneId = string.Empty;
		if (GlobalData.World != null)
		{
			this.HandleExitUiSceneParams();
			RenderModuleController.Instance.DebugInUiSceneRendering = false;
			RenderModuleController.Instance.DebugStartShowingUiSceneRendering = false;
			this.EndAllUiSceneRendering();
			this.RestoreClvEnableValue();
			GlobalData.SetUiState(EKuroUI3DState.NotLoaded);
		}
		if (this.SwitchUiSceneFunction != null)
		{
			this.SwitchUiSceneFunction(false);
			this.SwitchUiSceneFunction = null;
		}
		this.LoadSuccessFunction = null;
		if (!Info.Instance.IsPcOrGamepadPlatform())
		{
			GameSettingsManager.Instance.ReApply(EFunction.MOBILERESOLUTION, EGameSettingsApplyReason.AnyTime, true);
			ULGUIBPLibrary.FreeUnusedResourcesInRenderTargetPool();
		}
	}

	// Token: 0x060153F9 RID: 87033 RVA: 0x0062DA94 File Offset: 0x0062BC94
	public void Tick(float delta)
	{
		if (!GlobalData.IsUiSceneLoading)
		{
			return;
		}
		EKuroUiSceneLoadingState allUiSceneLoadingState = UKuroUiSceneSystem.GetKuroUiSceneSystem(GlobalData.World).GetAllUiSceneLoadingState();
		if (allUiSceneLoadingState == EKuroUiSceneLoadingState.NotLoaded || allUiSceneLoadingState == EKuroUiSceneLoadingState.Loading)
		{
			GlobalData.SetUiState(EKuroUI3DState.Loading);
			return;
		}
		if (allUiSceneLoadingState == EKuroUiSceneLoadingState.LoadedNotVisible && !RenderModuleController.Instance.DebugStartShowingUiSceneRendering)
		{
			this.StartAllUiSceneRendering();
			RenderModuleController.Instance.DebugStartShowingUiSceneRendering = true;
			GlobalData.SetUiState(EKuroUI3DState.Loading);
			return;
		}
		if (allUiSceneLoadingState == EKuroUiSceneLoadingState.LoadedAndVisible)
		{
			GlobalData.SetUiState(EKuroUI3DState.Loaded);
			Action loadSuccessFunction = this.LoadSuccessFunction;
			if (loadSuccessFunction != null)
			{
				loadSuccessFunction();
			}
			if (!Info.Instance.IsPcOrGamepadPlatform())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAA.Sharpness 1.0", null);
				if (GameSettingsDeviceRender.Instance.IsAndroidPlatformLowest())
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ScreenPercentage 80", null);
				}
				else
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ScreenPercentage 100", null);
				}
			}
			EventSystem.Instance.Emit(EEventName.UiSceneLoaded);
			RenderModuleController.Instance.DebugStartShowingUiSceneRendering = false;
			return;
		}
		GlobalData.SetUiState(EKuroUI3DState.Loading);
	}

	// Token: 0x060153FA RID: 87034 RVA: 0x0062DB74 File Offset: 0x0062BD74
	private void HandleEnterUiSceneParams()
	{
		UKuroGISystem kuroGISystem = UKuroGISystem.GetKuroGISystem(GlobalData.World);
		if (kuroGISystem == null)
		{
			return;
		}
		BP_GlobalGI_C bp_GlobalGI_C = kuroGISystem.GetKuroGlobalGIActor() as BP_GlobalGI_C;
		bp_GlobalGI_C.UINeedLerpData = true;
		if (bp_GlobalGI_C.GlobalUiScenePostProcess != null)
		{
			bp_GlobalGI_C.GlobalUiScenePostProcess.bEnabled = false;
		}
		if (bp_GlobalGI_C.GlobalPostProcessVolume != null)
		{
			bp_GlobalGI_C.GlobalPostProcessVolume.bIsUISceneRendering = true;
		}
	}

	// Token: 0x060153FB RID: 87035 RVA: 0x0062DBCC File Offset: 0x0062BDCC
	private void HandleExitUiSceneParams()
	{
		UKuroGISystem kuroGISystem = UKuroGISystem.GetKuroGISystem(GlobalData.World);
		if (kuroGISystem == null)
		{
			return;
		}
		BP_GlobalGI_C bp_GlobalGI_C = kuroGISystem.GetKuroGlobalGIActor() as BP_GlobalGI_C;
		bp_GlobalGI_C.UINeedLerpData = false;
		if (bp_GlobalGI_C.GlobalUiScenePostProcess != null)
		{
			bp_GlobalGI_C.GlobalUiScenePostProcess.bEnabled = true;
		}
		if (bp_GlobalGI_C.GlobalPostProcessVolume != null)
		{
			bp_GlobalGI_C.GlobalPostProcessVolume.bIsUISceneRendering = false;
		}
	}

	// Token: 0x060153FC RID: 87036 RVA: 0x0062DC24 File Offset: 0x0062BE24
	private SkeletalObserverHandle SpawnSkeletalObserverHandle(EUiModelUseWay useWay)
	{
		if (GlobalData.World == null)
		{
			Log.Instance.Error(ELogModule.UiSceneManager, ELogAuthor.TL, "SpawnSkeletalObserverHandle failed, GlobalData.World is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return SkeletalObserverManager.NewSkeletalObserver(useWay);
	}

	// Token: 0x060153FD RID: 87037 RVA: 0x0062DC5C File Offset: 0x0062BE5C
	public SkeletalObserverHandle InitWeaponObserver(bool needMeshStreaming = false)
	{
		EUiModelUseWay useWay = needMeshStreaming ? EUiModelUseWay.WeaponWithLoadingIcon : EUiModelUseWay.WeaponInWeaponView;
		SkeletalObserverHandle skeletalObserverHandle = this.SpawnSkeletalObserverHandle(useWay);
		this.WeaponObserverStack.Push(skeletalObserverHandle);
		return skeletalObserverHandle;
	}

	// Token: 0x060153FE RID: 87038 RVA: 0x0062DC88 File Offset: 0x0062BE88
	public SkeletalObserverHandle GetWeaponObserver()
	{
		if (this.WeaponObserverStack.Empty)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[WeaponObserverStack]为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.WeaponObserverStack.Peek();
	}

	// Token: 0x060153FF RID: 87039 RVA: 0x0062DCCB File Offset: 0x0062BECB
	public void DestroyWeaponObserver(SkeletalObserverHandle weaponObserver)
	{
		if (this.WeaponObserverStack.Empty)
		{
			return;
		}
		this.WeaponObserverStack.Delete(weaponObserver);
		SkeletalObserverManager.DestroySkeletalObserver(weaponObserver);
	}

	// Token: 0x06015400 RID: 87040 RVA: 0x0062DCF0 File Offset: 0x0062BEF0
	public void DestroyAllWeaponObserver()
	{
		while (!this.WeaponObserverStack.Empty)
		{
			SkeletalObserverHandle weaponObserver = this.WeaponObserverStack.Pop();
			this.DestroyWeaponObserver(weaponObserver);
		}
	}

	// Token: 0x06015401 RID: 87041 RVA: 0x0062DD20 File Offset: 0x0062BF20
	public SkeletalObserverHandle InitWeaponScabbardObserver()
	{
		SkeletalObserverHandle skeletalObserverHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.WeaponInWeaponView);
		this.WeaponScabbardStack.Push(skeletalObserverHandle);
		return skeletalObserverHandle;
	}

	// Token: 0x06015402 RID: 87042 RVA: 0x0062DD44 File Offset: 0x0062BF44
	public SkeletalObserverHandle GetWeaponScabbardObserver()
	{
		if (this.WeaponScabbardStack.Empty)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[WeaponScabbardStack]为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.WeaponScabbardStack.Peek();
	}

	// Token: 0x06015403 RID: 87043 RVA: 0x0062DD87 File Offset: 0x0062BF87
	public void DestroyWeaponScabbardObserver(SkeletalObserverHandle weaponScabbard)
	{
		if (this.WeaponScabbardStack.Empty)
		{
			return;
		}
		this.WeaponScabbardStack.Delete(weaponScabbard);
		SkeletalObserverManager.DestroySkeletalObserver(weaponScabbard);
	}

	// Token: 0x06015404 RID: 87044 RVA: 0x0062DDAC File Offset: 0x0062BFAC
	public void DestroyAllWeaponScabbardObserver()
	{
		while (!this.WeaponScabbardStack.Empty)
		{
			SkeletalObserverHandle weaponScabbard = this.WeaponScabbardStack.Pop();
			this.DestroyWeaponScabbardObserver(weaponScabbard);
		}
	}

	// Token: 0x06015405 RID: 87045 RVA: 0x0062DDDC File Offset: 0x0062BFDC
	public void InitPhantomObserver()
	{
		if (this.PhantomObserver != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[PhantomObserver]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PhantomObserver = this.SpawnSkeletalObserverHandle(EUiModelUseWay.VisionInRoleView);
	}

	// Token: 0x06015406 RID: 87046 RVA: 0x0062DE1C File Offset: 0x0062C01C
	public SkeletalObserverHandle GetPhantomObserver()
	{
		if (this.PhantomObserver == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[PhantomObserver]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.PhantomObserver;
	}

	// Token: 0x06015407 RID: 87047 RVA: 0x0062DE55 File Offset: 0x0062C055
	public void DestroyPhantomObserver()
	{
		if (this.PhantomObserver == null)
		{
			return;
		}
		SkeletalObserverManager.DestroySkeletalObserver(this.PhantomObserver);
		this.PhantomObserver = null;
	}

	// Token: 0x06015408 RID: 87048 RVA: 0x0062DE72 File Offset: 0x0062C072
	public SkeletalObserverHandle InitHuluObserver()
	{
		this.HuluObserver = UiSceneManager.Instance.SpawnSkeletalObserverHandle(EUiModelUseWay.HuluInSkinView);
		return this.HuluObserver;
	}

	// Token: 0x06015409 RID: 87049 RVA: 0x0062DE8C File Offset: 0x0062C08C
	[NullableContext(2)]
	public SkeletalObserverHandle GetHuluObserver()
	{
		if (this.HuluObserver == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[HuluObserver]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.HuluObserver;
	}

	// Token: 0x0601540A RID: 87050 RVA: 0x0062DEC5 File Offset: 0x0062C0C5
	public void DestroyHuluObserver()
	{
		if (this.HuluObserver == null)
		{
			return;
		}
		SkeletalObserverManager.DestroySkeletalObserver(this.HuluObserver);
		this.HuluObserver = null;
	}

	// Token: 0x0601540B RID: 87051 RVA: 0x0062DEE4 File Offset: 0x0062C0E4
	public void InitHandBookObserver()
	{
		if (this.HandBookObserver != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[HandBookObserver]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.HandBookObserver = this.SpawnSkeletalObserverHandle(EUiModelUseWay.VisionInRoleView);
	}

	// Token: 0x0601540C RID: 87052 RVA: 0x0062DF24 File Offset: 0x0062C124
	public SkeletalObserverHandle GetHandBookObserver()
	{
		if (this.HandBookObserver == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[HandBookObserver]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.HandBookObserver;
	}

	// Token: 0x0601540D RID: 87053 RVA: 0x0062DF5D File Offset: 0x0062C15D
	public void DestroyHandBookObserver()
	{
		if (this.HandBookObserver == null)
		{
			return;
		}
		SkeletalObserverManager.DestroySkeletalObserver(this.HandBookObserver);
		this.HandBookObserver = null;
	}

	// Token: 0x0601540E RID: 87054 RVA: 0x0062DF7C File Offset: 0x0062C17C
	public TsUiSceneRoleActor InitRoleSystemRoleActor(EUiModelUseWay useWay)
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.RoleSystemActorStack.Peek();
		if (tsUiSceneRoleActor != null)
		{
			tsUiSceneRoleActor.SetMoveOutActor();
		}
		TsUiSceneRoleActor tsUiSceneRoleActor2 = UiSceneRoleActorManager.Instance.CreateUiSceneRoleActor(useWay);
		this.RoleSystemActorStack.Push(tsUiSceneRoleActor2);
		return tsUiSceneRoleActor2;
	}

	// Token: 0x0601540F RID: 87055 RVA: 0x0062DFB8 File Offset: 0x0062C1B8
	[NullableContext(2)]
	public TsUiSceneRoleActor GetRoleSystemRoleActor()
	{
		if (this.RoleSystemActorStack.Empty)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[RoleSystemActorStack]为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.RoleSystemActorStack.Peek();
	}

	// Token: 0x06015410 RID: 87056 RVA: 0x0062DFFB File Offset: 0x0062C1FB
	public bool HasRoleSystemRoleActor()
	{
		return !this.RoleSystemActorStack.Empty;
	}

	// Token: 0x06015411 RID: 87057 RVA: 0x0062E00C File Offset: 0x0062C20C
	public void HideRoleSystemRoleActor()
	{
		if (this.RoleSystemActorStack.Empty)
		{
			return;
		}
		UiModelBase model = this.RoleSystemActorStack.Peek().Model;
		UiModelUtil.Instance.SetVisible(model, false);
	}

	// Token: 0x06015412 RID: 87058 RVA: 0x0062E048 File Offset: 0x0062C248
	public void ShowRoleSystemRoleActor()
	{
		if (this.RoleSystemActorStack.Empty)
		{
			return;
		}
		UiModelBase model = this.RoleSystemActorStack.Peek().Model;
		UiModelUtil.Instance.SetVisible(model, true);
	}

	// Token: 0x06015413 RID: 87059 RVA: 0x0062E084 File Offset: 0x0062C284
	public bool DestroyRoleSystemRoleActor(TsUiSceneRoleActor roleActor)
	{
		bool result = false;
		bool flag = false;
		if (!this.RoleSystemActorStack.Empty)
		{
			flag = (this.RoleSystemActorStack.Peek() == roleActor);
			this.RoleSystemActorStack.Delete(roleActor);
			int roleActorIndex = roleActor.GetRoleActorIndex();
			result = UiSceneRoleActorManager.Instance.DestroyUiSceneRoleActor(roleActorIndex);
		}
		if (!this.RoleSystemActorStack.Empty && flag)
		{
			this.RoleSystemActorStack.Peek().SetMoveInActor();
		}
		return result;
	}

	// Token: 0x06015414 RID: 87060 RVA: 0x0062E0F4 File Offset: 0x0062C2F4
	public void DestroyAllRoleSystemRoleActor()
	{
		while (!this.RoleSystemActorStack.Empty)
		{
			int roleActorIndex = this.RoleSystemActorStack.Pop().GetRoleActorIndex();
			UiSceneRoleActorManager.Instance.DestroyUiSceneRoleActor(roleActorIndex);
		}
	}

	// Token: 0x06015415 RID: 87061 RVA: 0x0062E130 File Offset: 0x0062C330
	public unsafe TsUiSceneRoleActor InitRoleFormationActor(EUiModelUseWay useWay)
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = UiSceneRoleActorManager.Instance.CreateUiSceneRoleActor(useWay);
		this.RoleFormationActorList.Add(tsUiSceneRoleActor);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiSceneManager;
		ELogAuthor author = ELogAuthor.BB;
		string message = "InitRoleFormationRoleActor";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActorIndex", tsUiSceneRoleActor.GetRoleActorIndex());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("UseWay", useWay);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return tsUiSceneRoleActor;
	}

	// Token: 0x06015416 RID: 87062 RVA: 0x0062E1B8 File Offset: 0x0062C3B8
	public bool DestroyRoleFormationActor(TsUiSceneRoleActor roleActor)
	{
		int num = this.RoleFormationActorList.IndexOf(roleActor);
		if (num != -1)
		{
			this.RoleFormationActorList.RemoveAt(num);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiSceneManager;
		ELogAuthor author = ELogAuthor.BB;
		string message = "DestroyRoleFormationRoleActor";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActorIndex", num);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return UiSceneRoleActorManager.Instance.DestroyUiSceneRoleActor(roleActor.GetRoleActorIndex());
	}

	// Token: 0x06015417 RID: 87063 RVA: 0x0062E21E File Offset: 0x0062C41E
	[NullableContext(2)]
	public TsUiSceneRoleActor GetCurrentSelectFormationRoleActor()
	{
		if (this.SelectFormationPosition == -1)
		{
			return null;
		}
		return this.GetRoleFormationActor(this.SelectFormationPosition);
	}

	// Token: 0x06015418 RID: 87064 RVA: 0x0062E238 File Offset: 0x0062C438
	[NullableContext(2)]
	public TsUiSceneRoleActor GetRoleFormationActor(int position)
	{
		for (int i = this.RoleFormationActorList.Count - 1; i >= 0; i--)
		{
			TsUiSceneRoleActor tsUiSceneRoleActor = this.RoleFormationActorList[i];
			UiFormationRoleDataComponent uiFormationRoleDataComponent = tsUiSceneRoleActor.Model.CheckGetComponent<UiFormationRoleDataComponent>();
			if (uiFormationRoleDataComponent != null && uiFormationRoleDataComponent.Position == position)
			{
				return tsUiSceneRoleActor;
			}
		}
		return null;
	}

	// Token: 0x06015419 RID: 87065 RVA: 0x0062E288 File Offset: 0x0062C488
	public void SetRoleFormationActorsVisibleExcept(int exceptPosition, bool othersVisible)
	{
		foreach (TsUiSceneRoleActor tsUiSceneRoleActor in this.RoleFormationActorList)
		{
			UiModelBase model = tsUiSceneRoleActor.Model;
			int? num;
			if (model == null)
			{
				num = null;
			}
			else
			{
				UiFormationRoleDataComponent uiFormationRoleDataComponent = model.CheckGetComponent<UiFormationRoleDataComponent>();
				num = ((uiFormationRoleDataComponent != null) ? new int?(uiFormationRoleDataComponent.Position) : null);
			}
			int? num2 = num;
			bool visible = (num2.GetValueOrDefault() == exceptPosition & num2 != null) || othersVisible;
			if (tsUiSceneRoleActor.Model != null)
			{
				UiModelUtil.Instance.SetVisible(tsUiSceneRoleActor.Model, visible);
			}
		}
	}

	// Token: 0x0601541A RID: 87066 RVA: 0x0062E33C File Offset: 0x0062C53C
	private void DestroyAllRoleFormationActor()
	{
		foreach (TsUiSceneRoleActor tsUiSceneRoleActor in this.RoleFormationActorList)
		{
			int roleActorIndex = tsUiSceneRoleActor.GetRoleActorIndex();
			UiSceneRoleActorManager.Instance.DestroyUiSceneRoleActor(roleActorIndex);
		}
		this.RoleFormationActorList.Clear();
	}

	// Token: 0x0601541B RID: 87067 RVA: 0x0062E3A4 File Offset: 0x0062C5A4
	public void InitGachaItemObserver()
	{
		if (this.GachaItemObserver != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[GachaItemObserver]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.GachaItemObserver = this.SpawnSkeletalObserverHandle(EUiModelUseWay.WeaponInWeaponView);
	}

	// Token: 0x0601541C RID: 87068 RVA: 0x0062E3E4 File Offset: 0x0062C5E4
	public SkeletalObserverHandle GetGachaItemObserver()
	{
		SkeletalObserverHandle gachaItemObserver = this.GachaItemObserver;
		if (gachaItemObserver == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[GachaItemObserver]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return gachaItemObserver;
	}

	// Token: 0x0601541D RID: 87069 RVA: 0x0062E41A File Offset: 0x0062C61A
	public void DestroyGachaItemObserver()
	{
		if (this.GachaItemObserver != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.GachaItemObserver);
			this.GachaItemObserver = null;
		}
	}

	// Token: 0x0601541E RID: 87070 RVA: 0x0062E438 File Offset: 0x0062C638
	public void InitDreamLinkRoleSkeletalHandle()
	{
		if (this.DreamLinkRoleSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.DreamLink, ELogAuthor.LPH, "[DreamLinkRoleSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.DreamLinkRoleSkeletalHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.RoleInDreamLinkView);
	}

	// Token: 0x0601541F RID: 87071 RVA: 0x0062E47C File Offset: 0x0062C67C
	public SkeletalObserverHandle GetDreamLinkRoleSkeletalHandle()
	{
		if (this.DreamLinkRoleSkeletalHandle == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LPH, "[DreamLinkRoleSkeletalHandle]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.DreamLinkRoleSkeletalHandle;
	}

	// Token: 0x06015420 RID: 87072 RVA: 0x0062E4B5 File Offset: 0x0062C6B5
	public bool HasDreamLinkRoleSkeletalHandle()
	{
		return this.DreamLinkRoleSkeletalHandle != null;
	}

	// Token: 0x06015421 RID: 87073 RVA: 0x0062E4C0 File Offset: 0x0062C6C0
	public void DestroyDreamLinkRoleSkeletalHandle()
	{
		if (this.DreamLinkRoleSkeletalHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.DreamLinkRoleSkeletalHandle);
			this.DreamLinkRoleSkeletalHandle = null;
		}
	}

	// Token: 0x06015422 RID: 87074 RVA: 0x0062E4DC File Offset: 0x0062C6DC
	public SkeletalObserverHandle InitDreamLinkWeaponSkeletalHandle()
	{
		SkeletalObserverHandle skeletalObserverHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.WeaponInDreamLinkView);
		this.DreamLinkWeaponSkeletalHandleStack.Add(skeletalObserverHandle);
		return skeletalObserverHandle;
	}

	// Token: 0x06015423 RID: 87075 RVA: 0x0062E4FF File Offset: 0x0062C6FF
	public bool HasDreamLinkWeaponSkeletalHandle()
	{
		return this.DreamLinkWeaponSkeletalHandleStack.Count > 0;
	}

	// Token: 0x06015424 RID: 87076 RVA: 0x0062E510 File Offset: 0x0062C710
	public void DestroyAllDreamLinkWeaponSkeletalHandle()
	{
		foreach (SkeletalObserverHandle skeletalObserverHandle in this.DreamLinkWeaponSkeletalHandleStack)
		{
			SkeletalObserverManager.DestroySkeletalObserver(skeletalObserverHandle);
		}
		this.DreamLinkWeaponSkeletalHandleStack.Clear();
	}

	// Token: 0x06015425 RID: 87077 RVA: 0x0062E56C File Offset: 0x0062C76C
	public void CreateHandBookVision(UClass csClass)
	{
		BP_KposeBase_C bp_KposeBase_C = ActorSystem.Instance.Spawn<BP_KposeBase_C>(csClass.ClassStackOnlyPtr, new FTransformDouble(), null);
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("MonsterCase").Value, ECollectActorType.UI);
		TArray<UActorComponent> tarray = (bp_KposeBase_C != null) ? bp_KposeBase_C.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass()) : null;
		if (tarray != null)
		{
			for (int i = 0; i < tarray.Num(); i++)
			{
				tarray.Get(i).SetTickableWhenPaused(true);
			}
		}
		TArray<UActorComponent> tarray2 = (bp_KposeBase_C != null) ? bp_KposeBase_C.K2_GetComponentsByClass(UStaticMeshComponent.StaticClass()) : null;
		if (tarray2 != null)
		{
			for (int j = 0; j < tarray2.Num(); j++)
			{
				tarray2.Get(j).SetTickableWhenPaused(true);
			}
		}
		FVectorDouble newLocation = actorWithTag.D_K2_GetActorLocation();
		FRotator newRotation = actorWithTag.K2_GetActorRotation();
		bp_KposeBase_C.D_K2_SetActorLocationAndRotation(newLocation, newRotation, false, ref WorldGlobal.SweepHitResult, false);
		if (this.HandBookVision != null)
		{
			this.DestroyHandBookVision();
		}
		this.HandBookVision = bp_KposeBase_C;
		this.HideHandBookVision();
	}

	// Token: 0x06015426 RID: 87078 RVA: 0x0062E661 File Offset: 0x0062C861
	[NullableContext(2)]
	public BP_KposeBase_C GetHandBookVision()
	{
		return this.HandBookVision;
	}

	// Token: 0x06015427 RID: 87079 RVA: 0x0062E669 File Offset: 0x0062C869
	public void ShowHandBookVision()
	{
		this.SetHandBookVisionVisible(true);
	}

	// Token: 0x06015428 RID: 87080 RVA: 0x0062E672 File Offset: 0x0062C872
	public void HideHandBookVision()
	{
		this.SetHandBookVisionVisible(false);
	}

	// Token: 0x06015429 RID: 87081 RVA: 0x0062E67B File Offset: 0x0062C87B
	private void SetHandBookVisionVisible(bool visible)
	{
		if (this.HandBookVision == null)
		{
			return;
		}
		if (visible)
		{
			UiSceneManager.SetActorAndComponentTickEnabled(this.HandBookVision, true);
			this.HandBookVision.SetActorHiddenInGame(false);
			return;
		}
		this.HandBookVision.SetActorHiddenInGame(true);
		UiSceneManager.SetActorAndComponentTickEnabled(this.HandBookVision, false);
	}

	// Token: 0x0601542A RID: 87082 RVA: 0x0062E6BC File Offset: 0x0062C8BC
	private static void SetActorAndComponentTickEnabled(AActor actor, bool enabled)
	{
		actor.SetActorTickEnabled(enabled);
		TArray<UActorComponent> tarray = actor.K2_GetComponentsByClass(UActorComponent.StaticClass());
		for (int i = 0; i < tarray.Num(); i++)
		{
			tarray.Get(i).SetComponentTickEnabled(enabled);
		}
	}

	// Token: 0x0601542B RID: 87083 RVA: 0x0062E700 File Offset: 0x0062C900
	[NullableContext(2)]
	public AActor GetHandBookCaseActor()
	{
		return UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("MonsterCase").Value, ECollectActorType.UI);
	}

	// Token: 0x0601542C RID: 87084 RVA: 0x0062E725 File Offset: 0x0062C925
	public void DestroyHandBookVision()
	{
		if (this.HandBookVision == null)
		{
			return;
		}
		this.HandBookVision.PlayEnd();
		ActorSystem.Instance.Put("UiSceneManager.DestroyHandBookVision", this.HandBookVision, null);
		this.HandBookVision = null;
	}

	// Token: 0x0601542D RID: 87085 RVA: 0x0062E75C File Offset: 0x0062C95C
	public void InitVisionSkeletalHandle()
	{
		if (this.VisionSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.Phantom, ELogAuthor.TL, "[VisionSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.VisionSkeletalHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.VisionInRoleView);
	}

	// Token: 0x0601542E RID: 87086 RVA: 0x0062E79B File Offset: 0x0062C99B
	public bool HasVisionSkeletalHandle()
	{
		return this.VisionSkeletalHandle != null;
	}

	// Token: 0x0601542F RID: 87087 RVA: 0x0062E7A8 File Offset: 0x0062C9A8
	[NullableContext(2)]
	public SkeletalObserverHandle GetVisionSkeletalHandle()
	{
		SkeletalObserverHandle visionSkeletalHandle = this.VisionSkeletalHandle;
		if (visionSkeletalHandle == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[VisionSkeletalHandle]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return visionSkeletalHandle;
	}

	// Token: 0x06015430 RID: 87088 RVA: 0x0062E7DE File Offset: 0x0062C9DE
	public void DestroyVisionSkeletalHandle()
	{
		if (this.VisionSkeletalHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.VisionSkeletalHandle);
			this.VisionSkeletalHandle = null;
		}
	}

	// Token: 0x06015431 RID: 87089 RVA: 0x0062E7FC File Offset: 0x0062C9FC
	public void InitAbyssDangoObserver()
	{
		if (this.AbyssDangoObserver != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.YZY, "[AbyssDangoObserver]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.AbyssDangoObserver = this.SpawnSkeletalObserverHandle(EUiModelUseWay.AbyssDango);
	}

	// Token: 0x06015432 RID: 87090 RVA: 0x0062E83C File Offset: 0x0062CA3C
	[NullableContext(2)]
	public SkeletalObserverHandle GetAbyssDangoObserver()
	{
		SkeletalObserverHandle abyssDangoObserver = this.AbyssDangoObserver;
		if (abyssDangoObserver == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.YZY, "[AbyssDangoObserver]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return abyssDangoObserver;
	}

	// Token: 0x06015433 RID: 87091 RVA: 0x0062E872 File Offset: 0x0062CA72
	public void DestroyAbyssDangoObserver()
	{
		if (this.AbyssDangoObserver != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.AbyssDangoObserver);
			this.AbyssDangoObserver = null;
		}
	}

	// Token: 0x06015434 RID: 87092 RVA: 0x0062E890 File Offset: 0x0062CA90
	public void InitLordSkeletalHandle()
	{
		if (this.LordSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LZK, "[LordSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.LordSkeletalHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.VisionInLordGymView);
	}

	// Token: 0x06015435 RID: 87093 RVA: 0x0062E8D0 File Offset: 0x0062CAD0
	public bool HasLordSkeletalHandle()
	{
		return this.LordSkeletalHandle != null;
	}

	// Token: 0x06015436 RID: 87094 RVA: 0x0062E8DC File Offset: 0x0062CADC
	[NullableContext(2)]
	public SkeletalObserverHandle GetLordSkeletalHandle()
	{
		SkeletalObserverHandle lordSkeletalHandle = this.LordSkeletalHandle;
		if (lordSkeletalHandle == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LZK, "[LordSkeletalHandle]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return lordSkeletalHandle;
	}

	// Token: 0x06015437 RID: 87095 RVA: 0x0062E912 File Offset: 0x0062CB12
	public void DestroyLordSkeletalHandle()
	{
		if (this.LordSkeletalHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.LordSkeletalHandle);
			this.LordSkeletalHandle = null;
		}
	}

	// Token: 0x06015438 RID: 87096 RVA: 0x0062E930 File Offset: 0x0062CB30
	public void InitAdamSmasherSkeletalHandle()
	{
		if (this.AdamSmasherSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.SWC, "[AdamSmasherSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.AdamSmasherSkeletalHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.AdamSmasher);
	}

	// Token: 0x06015439 RID: 87097 RVA: 0x0062E970 File Offset: 0x0062CB70
	public bool HasAdamSmasherSkeletalHandle()
	{
		return this.AdamSmasherSkeletalHandle != null;
	}

	// Token: 0x0601543A RID: 87098 RVA: 0x0062E97C File Offset: 0x0062CB7C
	[NullableContext(2)]
	public SkeletalObserverHandle GetAdamSmasherSkeletalHandle()
	{
		SkeletalObserverHandle adamSmasherSkeletalHandle = this.AdamSmasherSkeletalHandle;
		if (adamSmasherSkeletalHandle == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.SWC, "[AdamSmasherSkeletalHandle]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return adamSmasherSkeletalHandle;
	}

	// Token: 0x0601543B RID: 87099 RVA: 0x0062E9B2 File Offset: 0x0062CBB2
	public void DestroyAdamSmasherSkeletalHandle()
	{
		if (this.AdamSmasherSkeletalHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.AdamSmasherSkeletalHandle);
			this.AdamSmasherSkeletalHandle = null;
		}
	}

	// Token: 0x0601543C RID: 87100 RVA: 0x0062E9CE File Offset: 0x0062CBCE
	public TsUiSceneDangoActor InitDangoActor(EUiModelUseWay useWay)
	{
		return UiSceneDangoActorManager.CreateUiSceneDangoActor(useWay);
	}

	// Token: 0x0601543D RID: 87101 RVA: 0x0062E9D6 File Offset: 0x0062CBD6
	public void DestroyDangoActor(TsUiSceneDangoActor dango)
	{
		UiSceneDangoActorManager.DestroyUiSceneDangoActor(dango.GetActorIndex());
	}

	// Token: 0x0601543E RID: 87102 RVA: 0x0062E9E4 File Offset: 0x0062CBE4
	[NullableContext(2)]
	public TsUiSceneDangoActor RayTraceDangoActor(FVector viewportPosition)
	{
		TsCharacterController characterController = Global.CharacterController;
		if (characterController == null)
		{
			return null;
		}
		FVector fvector = new FVector();
		FVector fvector2 = new FVector();
		this.ScreenPosition.Set(viewportPosition.X, viewportPosition.Y);
		if (!UGameplayStatics.DeprojectScreenToWorld(characterController, this.ScreenPosition, ref fvector, ref fvector2))
		{
			return null;
		}
		FVector fvector3 = fvector;
		FVector fvector4 = fvector2;
		global::Vector locationOffset = this.LocationOffset;
		FVector fvector5 = characterController.GetViewTarget().K2_GetActorLocation();
		FVectorDouble fvectorDouble = fvector5;
		locationOffset.DeepCopy(fvectorDouble);
		CameraController.Instance.MainModel.CameraLocation.Subtraction(this.LocationOffset, this.LocationOffset);
		global::Vector commonStartLocation = TraceElementModel.Instance.CommonStartLocation;
		global::Vector vector = commonStartLocation;
		fvectorDouble = fvector3;
		vector.DeepCopy(fvectorDouble);
		commonStartLocation.Addition(this.LocationOffset, commonStartLocation);
		global::Vector commonEndLocation = TraceElementModel.Instance.CommonEndLocation;
		fvector5 = fvector4 * 5000f;
		fvector3 = fvector3 + fvector5;
		global::Vector vector2 = commonEndLocation;
		fvectorDouble = fvector3;
		vector2.DeepCopy(fvectorDouble);
		commonEndLocation.Addition(this.LocationOffset, commonEndLocation);
		UTraceLineElement lineTrace = TraceElementModel.Instance.GetLineTrace();
		lineTrace.WorldContextObject = GlobalData.World;
		lineTrace.ActorsToIgnore.Empty(true);
		TraceElementCommon.Instance.SetStartLocation(lineTrace, commonStartLocation);
		TraceElementCommon.Instance.SetEndLocation(lineTrace, commonEndLocation);
		if (!TraceElementCommon.Instance.LineTrace(lineTrace, "RayTraceDangoActor"))
		{
			lineTrace.ClearCacheData(false);
			return null;
		}
		TsUiSceneDangoActor tsUiSceneDangoActor = lineTrace.HitResult.Actors.Get(0).Get() as TsUiSceneDangoActor;
		if (tsUiSceneDangoActor != null)
		{
			return tsUiSceneDangoActor;
		}
		return null;
	}

	// Token: 0x0601543F RID: 87103 RVA: 0x0062EB7C File Offset: 0x0062CD7C
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public UniTask<List<TsUiSceneDangoActor>> LoadDangoActorList(List<IRacingBetsDangoActorData> dangoOddsList, Action<TsUiSceneDangoActor> createCallback = null)
	{
		UiSceneManager.<LoadDangoActorList>d__110 <LoadDangoActorList>d__;
		<LoadDangoActorList>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<TsUiSceneDangoActor>>.Create();
		<LoadDangoActorList>d__.<>4__this = this;
		<LoadDangoActorList>d__.dangoOddsList = dangoOddsList;
		<LoadDangoActorList>d__.createCallback = createCallback;
		<LoadDangoActorList>d__.<>1__state = -1;
		<LoadDangoActorList>d__.<>t__builder.Start<UiSceneManager.<LoadDangoActorList>d__110>(ref <LoadDangoActorList>d__);
		return <LoadDangoActorList>d__.<>t__builder.Task;
	}

	// Token: 0x06015440 RID: 87104 RVA: 0x0062EBD0 File Offset: 0x0062CDD0
	public void InitGliderSkeletalHandle()
	{
		if (this.GliderSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LZK, "[GliderSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.GliderSkeletalHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.GliderInSkinView);
	}

	// Token: 0x06015441 RID: 87105 RVA: 0x0062EC10 File Offset: 0x0062CE10
	public bool HasGliderSkeletalHandle()
	{
		return this.GliderSkeletalHandle != null;
	}

	// Token: 0x06015442 RID: 87106 RVA: 0x0062EC1C File Offset: 0x0062CE1C
	public SkeletalObserverHandle GetGliderSkeletalHandle()
	{
		SkeletalObserverHandle gliderSkeletalHandle = this.GliderSkeletalHandle;
		if (gliderSkeletalHandle == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LZK, "[GliderSkeletalHandle]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return gliderSkeletalHandle;
	}

	// Token: 0x06015443 RID: 87107 RVA: 0x0062EC52 File Offset: 0x0062CE52
	public void DestroyGliderSkeletalHandle()
	{
		if (this.GliderSkeletalHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.GliderSkeletalHandle);
			this.GliderSkeletalHandle = null;
		}
	}

	// Token: 0x06015444 RID: 87108 RVA: 0x0062EC70 File Offset: 0x0062CE70
	public void InitSpecialItemSummonSkeletalHandle()
	{
		if (this.SpecialItemSummonSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LZK, "[SpecialItemSummonSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.SpecialItemSummonSkeletalHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.SpecialItemSummonInSkinView);
	}

	// Token: 0x06015445 RID: 87109 RVA: 0x0062ECB0 File Offset: 0x0062CEB0
	public bool HasSpecialItemSummonSkeletalHandle()
	{
		return this.SpecialItemSummonSkeletalHandle != null;
	}

	// Token: 0x06015446 RID: 87110 RVA: 0x0062ECBC File Offset: 0x0062CEBC
	[NullableContext(2)]
	public SkeletalObserverHandle GetSpecialItemSummonSkeletalHandle()
	{
		SkeletalObserverHandle specialItemSummonSkeletalHandle = this.SpecialItemSummonSkeletalHandle;
		if (specialItemSummonSkeletalHandle == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LZK, "[SpecialItemSummonSkeletalHandle]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return specialItemSummonSkeletalHandle;
	}

	// Token: 0x06015447 RID: 87111 RVA: 0x0062ECF2 File Offset: 0x0062CEF2
	public void DestroySpecialItemSummonSkeletalHandle()
	{
		if (this.SpecialItemSummonSkeletalHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.SpecialItemSummonSkeletalHandle);
			this.SpecialItemSummonSkeletalHandle = null;
		}
	}

	// Token: 0x06015448 RID: 87112 RVA: 0x0062ED10 File Offset: 0x0062CF10
	public void InitMotorSkeletalHandle(EUiModelUseWay useWay = EUiModelUseWay.MotorInMotorView)
	{
		if (this.MotorSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LZK, "[MotorSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log.Instance.Info(ELogModule.UiSceneManager, ELogAuthor.LZK, "InitMotorSkeletalHandle", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.MotorSkeletalHandle = this.SpawnSkeletalObserverHandle(useWay);
	}

	// Token: 0x06015449 RID: 87113 RVA: 0x0062ED6C File Offset: 0x0062CF6C
	[NullableContext(2)]
	public SkeletalObserverHandle GetMotorSkeletalHandle()
	{
		SkeletalObserverHandle motorSkeletalHandle = this.MotorSkeletalHandle;
		if (motorSkeletalHandle == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LZK, "[MotorSkeletalHandle]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return motorSkeletalHandle;
	}

	// Token: 0x0601544A RID: 87114 RVA: 0x0062EDA4 File Offset: 0x0062CFA4
	public void DestroyMotorSkeletalHandle()
	{
		if (this.MotorSkeletalHandle != null)
		{
			Log.Instance.Info(ELogModule.UiSceneManager, ELogAuthor.LZK, "DestroyMotorSkeletalHandle", default(ReadOnlySpan<ValueTuple<string, object>>));
			SkeletalObserverManager.DestroySkeletalObserver(this.MotorSkeletalHandle);
			this.MotorSkeletalHandle = null;
		}
	}

	// Token: 0x0601544B RID: 87115 RVA: 0x0062EDE8 File Offset: 0x0062CFE8
	[NullableContext(2)]
	public void AddUiShowRoomShowActor(AActor actor, bool includeFromChildActors)
	{
		FName? dynamicFName = FNameUtil.GetDynamicFName("BP_UIShowRoom");
		BP_UIShowRoom_C bp_UIShowRoom_C = (dynamicFName == null) ? null : (UKuroCollectActorComponent.GetActorWithTag(dynamicFName.Value, ECollectActorType.UI) as BP_UIShowRoom_C);
		if (bp_UIShowRoom_C == null)
		{
			Log.Instance.Error(ELogModule.UiSceneManager, ELogAuthor.XXJ, "当前场景找不到反射地板蓝图类BP_UIShowRoom", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		bp_UIShowRoom_C.AddShowActor(ref actor, includeFromChildActors);
	}

	// Token: 0x0601544C RID: 87116 RVA: 0x0062EE48 File Offset: 0x0062D048
	public void SetUiShowRoomFloorReflection(bool enable)
	{
		FName? dynamicFName = FNameUtil.GetDynamicFName("BP_UIShowRoom");
		BP_UIShowRoom_C bp_UIShowRoom_C = (dynamicFName == null) ? null : (UKuroCollectActorComponent.GetActorWithTag(dynamicFName.Value, ECollectActorType.UI) as BP_UIShowRoom_C);
		if (bp_UIShowRoom_C == null)
		{
			Log.Instance.Error(ELogModule.UiSceneManager, ELogAuthor.SYB, "当前场景找不到反射地板蓝图类BP_UIShowRoom", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UPlanarReflectionComponent planarReflection = bp_UIShowRoom_C.PlanarReflection;
		UStaticMeshComponent floorMesh = bp_UIShowRoom_C.FloorMesh;
		if (planarReflection == null || floorMesh == null)
		{
			return;
		}
		if (enable)
		{
			planarReflection.ClearHiddenComponents();
			return;
		}
		planarReflection.HideComponent(floorMesh);
	}

	// Token: 0x0601544D RID: 87117 RVA: 0x0062EEC8 File Offset: 0x0062D0C8
	public UniTask LoadScene(string sceneId, Action callBack)
	{
		UiSceneManager.<LoadScene>d__128 <LoadScene>d__;
		<LoadScene>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadScene>d__.<>4__this = this;
		<LoadScene>d__.sceneId = sceneId;
		<LoadScene>d__.callBack = callBack;
		<LoadScene>d__.<>1__state = -1;
		<LoadScene>d__.<>t__builder.Start<UiSceneManager.<LoadScene>d__128>(ref <LoadScene>d__);
		return <LoadScene>d__.<>t__builder.Task;
	}

	// Token: 0x0601544E RID: 87118 RVA: 0x0062EF1C File Offset: 0x0062D11C
	public UniTask ExitScene()
	{
		UiSceneManager.<ExitScene>d__129 <ExitScene>d__;
		<ExitScene>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExitScene>d__.<>4__this = this;
		<ExitScene>d__.<>1__state = -1;
		<ExitScene>d__.<>t__builder.Start<UiSceneManager.<ExitScene>d__129>(ref <ExitScene>d__);
		return <ExitScene>d__.<>t__builder.Task;
	}

	// Token: 0x0601544F RID: 87119 RVA: 0x0062EF5F File Offset: 0x0062D15F
	private void RecordAndLandscapeValue()
	{
		this.LastHideLandscapeValue = UKismetSystemLibrary.GetConsoleVariableIntValue("r.Kuro.HideLandscape");
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.HideLandscape 0", null);
	}

	// Token: 0x06015450 RID: 87120 RVA: 0x0062EF84 File Offset: 0x0062D184
	private void ResetLandscapeValue()
	{
		UObject world = GlobalData.World;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
		defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.HideLandscape ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.LastHideLandscapeValue);
		UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
	}

	// Token: 0x06015451 RID: 87121 RVA: 0x0062EFC8 File Offset: 0x0062D1C8
	private void SetEnterSceneCamera()
	{
		if (GlobalData.World != null)
		{
			CameraController.Instance.ExitCameraMode(ECustomCameraMode.Widget, 0f, EViewTargetBlendFunction.VTBlend_EaseIn, 0f, null, "MainCamera", null);
			CameraController.Instance.EnterCameraMode(ECustomCameraMode.Widget, 0f, EViewTargetBlendFunction.VTBlend_EaseIn, 0f, null, false, "MainCamera", null);
		}
	}

	// Token: 0x06015452 RID: 87122 RVA: 0x0062F019 File Offset: 0x0062D219
	public void SetUiStartSequenceFrame(int startSequenceFrame)
	{
		if (this.StartSequenceFrame == 0)
		{
			this.StartSequenceFrame = startSequenceFrame;
		}
	}

	// Token: 0x06015453 RID: 87123 RVA: 0x0062F02A File Offset: 0x0062D22A
	public void SetUiEndSequenceFrame(int endSequenceFrame)
	{
		if (this.EndSequenceFrame == 0)
		{
			this.EndSequenceFrame = endSequenceFrame;
		}
	}

	// Token: 0x06015454 RID: 87124 RVA: 0x0062F03B File Offset: 0x0062D23B
	public void ClearUiSequenceFrame()
	{
		this.StartSequenceFrame = 0;
		this.EndSequenceFrame = 0;
	}

	// Token: 0x06015455 RID: 87125 RVA: 0x0062F04B File Offset: 0x0062D24B
	public int GetUiStartSequenceFrame()
	{
		return this.StartSequenceFrame;
	}

	// Token: 0x06015456 RID: 87126 RVA: 0x0062F053 File Offset: 0x0062D253
	public int GetUiEndSequenceFrame()
	{
		return this.EndSequenceFrame;
	}

	// Token: 0x06015457 RID: 87127 RVA: 0x0062F05C File Offset: 0x0062D25C
	public void HideObserver(SkeletalObserverHandle observer, string effectId)
	{
		if (observer == null)
		{
			return;
		}
		UiModelBase model = observer.Model;
		if (UiModelUtil.Instance.SetVisible(model, false))
		{
			UiModelUtil.Instance.PlayEffectOnRoot(model, effectId);
		}
	}

	// Token: 0x06015458 RID: 87128 RVA: 0x0062F090 File Offset: 0x0062D290
	public void HideObserverWithCallback(SkeletalObserverHandle observer, string effectId, Action<SkeletalObserverHandle> callback)
	{
		if (observer == null)
		{
			return;
		}
		UiModelBase model = observer.Model;
		if (UiModelUtil.Instance.SetVisible(model, false))
		{
			UiModelUtil.Instance.PlayEffectOnRootWithCallback(model, effectId, delegate(int _)
			{
				callback(observer);
			});
		}
	}

	// Token: 0x06015459 RID: 87129 RVA: 0x0062F0EC File Offset: 0x0062D2EC
	[return: Nullable(2)]
	public AActor GetActorByTag(string tag)
	{
		FName? dynamicFName = FNameUtil.GetDynamicFName(tag);
		if (dynamicFName == null)
		{
			return null;
		}
		return UKuroCollectActorComponent.GetActorWithTag(dynamicFName.Value, ECollectActorType.UI);
	}

	// Token: 0x0601545A RID: 87130 RVA: 0x0062F118 File Offset: 0x0062D318
	public void Clear()
	{
		SkeletalObserverManager.ClearAllSkeletalObserver();
		UiSceneRoleActorManager.Instance.ClearAllUiSceneRoleActor();
		UiSceneDangoActorManager.ClearAllUiSceneDangoActor();
		DangoAbyssActorManager.ClearAllDangoSkeletalObserverHandle();
		this.DestroyGachaItemObserver();
		this.DestroyHandBookObserver();
		this.DestroyHandBookVision();
		this.DestroyPhantomObserver();
		this.DestroyAllRoleSystemRoleActor();
		this.DestroyAllRoleFormationActor();
		this.DestroyAllWeaponObserver();
		this.DestroyAllWeaponScabbardObserver();
		this.DestroyHuluObserver();
	}

	// Token: 0x1700202A RID: 8234
	// (get) Token: 0x0601545B RID: 87131 RVA: 0x0062F174 File Offset: 0x0062D374
	public static UiSceneManager Instance
	{
		get
		{
			if (UiSceneManager._instance == null)
			{
				UiSceneManager._instance = new UiSceneManager();
				UiSceneManager._instance.OnInit();
			}
			return UiSceneManager._instance;
		}
	}

	// Token: 0x0601545C RID: 87132 RVA: 0x0062F197 File Offset: 0x0062D397
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601545D RID: 87133 RVA: 0x0062F199 File Offset: 0x0062D399
	public static void ResetStaticDefaultValue()
	{
		UiSceneManager instance = UiSceneManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiSceneManager._instance = null;
	}

	// Token: 0x0601545E RID: 87134 RVA: 0x0062F1B2 File Offset: 0x0062D3B2
	static UiSceneManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiSceneManager.CreateStaticDefaultValue), new Action(UiSceneManager.ResetStaticDefaultValue));
	}

	// Token: 0x0400B41B RID: 46107
	private readonly HashSet<string> DisableClvUiSceneIds = new HashSet<string>
	{
		"Instance_ChouKa_01",
		"UL_UIMap_ChallengeUI",
		"UL_UIMap_Bosslevel",
		"UL_UIMap_DaoGuanUI",
		"UL_UIMap_HologramUI"
	};

	// Token: 0x0400B41C RID: 46108
	private int? LastClvEnableValue;

	// Token: 0x0400B41D RID: 46109
	public string CurUiSceneId = string.Empty;

	// Token: 0x0400B41E RID: 46110
	public HashSet<string> CurUiScenePathSet = new HashSet<string>();

	// Token: 0x0400B41F RID: 46111
	public string GlobalGiMainScene = string.Empty;

	// Token: 0x0400B420 RID: 46112
	[Nullable(2)]
	protected Action LoadSuccessFunction;

	// Token: 0x0400B421 RID: 46113
	[Nullable(2)]
	protected Action<bool> SwitchUiSceneFunction;

	// Token: 0x0400B422 RID: 46114
	private readonly global::Stack<SkeletalObserverHandle> WeaponObserverStack = new global::Stack<SkeletalObserverHandle>();

	// Token: 0x0400B423 RID: 46115
	private readonly global::Stack<SkeletalObserverHandle> WeaponScabbardStack = new global::Stack<SkeletalObserverHandle>();

	// Token: 0x0400B424 RID: 46116
	private SkeletalObserverHandle PhantomObserver;

	// Token: 0x0400B425 RID: 46117
	[Nullable(2)]
	private SkeletalObserverHandle HuluObserver;

	// Token: 0x0400B426 RID: 46118
	private SkeletalObserverHandle HandBookObserver;

	// Token: 0x0400B427 RID: 46119
	private readonly global::Stack<TsUiSceneRoleActor> RoleSystemActorStack = new global::Stack<TsUiSceneRoleActor>();

	// Token: 0x0400B428 RID: 46120
	public int SelectFormationPosition = -1;

	// Token: 0x0400B429 RID: 46121
	private readonly List<TsUiSceneRoleActor> RoleFormationActorList = new List<TsUiSceneRoleActor>();

	// Token: 0x0400B42A RID: 46122
	private SkeletalObserverHandle GachaItemObserver;

	// Token: 0x0400B42B RID: 46123
	[Nullable(2)]
	private SkeletalObserverHandle DreamLinkRoleSkeletalHandle;

	// Token: 0x0400B42C RID: 46124
	private readonly List<SkeletalObserverHandle> DreamLinkWeaponSkeletalHandleStack = new List<SkeletalObserverHandle>();

	// Token: 0x0400B42D RID: 46125
	[Nullable(2)]
	private BP_KposeBase_C HandBookVision;

	// Token: 0x0400B42E RID: 46126
	[Nullable(2)]
	private SkeletalObserverHandle VisionSkeletalHandle;

	// Token: 0x0400B42F RID: 46127
	[Nullable(2)]
	private SkeletalObserverHandle AbyssDangoObserver;

	// Token: 0x0400B430 RID: 46128
	[Nullable(2)]
	private SkeletalObserverHandle LordSkeletalHandle;

	// Token: 0x0400B431 RID: 46129
	[Nullable(2)]
	private SkeletalObserverHandle AdamSmasherSkeletalHandle;

	// Token: 0x0400B432 RID: 46130
	private readonly global::Vector LocationOffset = global::Vector.Create();

	// Token: 0x0400B433 RID: 46131
	private FVector2D ScreenPosition = new FVector2D();

	// Token: 0x0400B434 RID: 46132
	private SkeletalObserverHandle GliderSkeletalHandle;

	// Token: 0x0400B435 RID: 46133
	[Nullable(2)]
	private SkeletalObserverHandle SpecialItemSummonSkeletalHandle;

	// Token: 0x0400B436 RID: 46134
	[Nullable(2)]
	private SkeletalObserverHandle MotorSkeletalHandle;

	// Token: 0x0400B437 RID: 46135
	private int LastStencilFixedValue;

	// Token: 0x0400B438 RID: 46136
	private int LastHideLandscapeValue;

	// Token: 0x0400B439 RID: 46137
	private int StartSequenceFrame;

	// Token: 0x0400B43A RID: 46138
	private int EndSequenceFrame;

	// Token: 0x0400B43B RID: 46139
	[Nullable(2)]
	private static UiSceneManager _instance;
}
