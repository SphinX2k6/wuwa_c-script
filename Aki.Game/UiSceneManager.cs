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
using CSharpScript.Game.Render;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C60 RID: 11360
[NullableContext(1)]
[Nullable(0)]
public class UiSceneManager : Singleton, ITickable
{
	// Token: 0x06017B76 RID: 97142 RVA: 0x006078C4 File Offset: 0x00605AC4
	public void Initialize()
	{
		GlobalData.SetUiState(EKuroUI3DState.NotLoaded);
		this.CurUiSceneId = string.Empty;
		this.CurUiScenePathSet.Clear();
		EventSystem.Instance.Add(EEventName.ResetModuleAfterResetToBattleView, new Action(this.ForceCloseUiSceneImmediately));
	}

	// Token: 0x06017B77 RID: 97143 RVA: 0x00607900 File Offset: 0x00605B00
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

	// Token: 0x06017B78 RID: 97144 RVA: 0x00607A1C File Offset: 0x00605C1C
	private void PreloadAllUiScene()
	{
		UKuroUiSceneSystem kuroUiSceneSystem = UKuroUiSceneSystem.GetKuroUiSceneSystem(GlobalData.World);
		FVectorDouble kuroUiSceneLoadOffset = RenderModuleController.Instance.GetKuroUiSceneLoadOffset();
		foreach (string scenePath in this.CurUiScenePathSet)
		{
			kuroUiSceneSystem.PreloadUiScene(scenePath, kuroUiSceneLoadOffset);
		}
	}

	// Token: 0x06017B79 RID: 97145 RVA: 0x00607A8C File Offset: 0x00605C8C
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

	// Token: 0x06017B7A RID: 97146 RVA: 0x00607B38 File Offset: 0x00605D38
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

	// Token: 0x06017B7B RID: 97147 RVA: 0x00607BCC File Offset: 0x00605DCC
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

	// Token: 0x06017B7C RID: 97148 RVA: 0x00607C24 File Offset: 0x00605E24
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

	// Token: 0x06017B7D RID: 97149 RVA: 0x00607CBC File Offset: 0x00605EBC
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

	// Token: 0x06017B7E RID: 97150 RVA: 0x00607D0C File Offset: 0x00605F0C
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

	// Token: 0x06017B7F RID: 97151 RVA: 0x00607D70 File Offset: 0x00605F70
	public bool OpenUiScene(string sceneId, [Nullable(2)] Action successCallBack = null)
	{
		if (!this.CheckOpenUiScene(sceneId))
		{
			return false;
		}
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

	// Token: 0x06017B80 RID: 97152 RVA: 0x00607E3C File Offset: 0x0060603C
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

	// Token: 0x06017B81 RID: 97153 RVA: 0x00607EC4 File Offset: 0x006060C4
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

	// Token: 0x06017B82 RID: 97154 RVA: 0x00607F17 File Offset: 0x00606117
	public void CloseUiScene()
	{
		this.ForceHandleScene();
	}

	// Token: 0x06017B83 RID: 97155 RVA: 0x00607F1F File Offset: 0x0060611F
	private void ForceCloseUiSceneImmediately()
	{
		this.ForceHandleScene();
	}

	// Token: 0x06017B84 RID: 97156 RVA: 0x00607F28 File Offset: 0x00606128
	private void ForceHandleScene()
	{
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

	// Token: 0x06017B85 RID: 97157 RVA: 0x00607FC8 File Offset: 0x006061C8
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

	// Token: 0x06017B86 RID: 97158 RVA: 0x006080A8 File Offset: 0x006062A8
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

	// Token: 0x06017B87 RID: 97159 RVA: 0x00608100 File Offset: 0x00606300
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

	// Token: 0x06017B88 RID: 97160 RVA: 0x00608158 File Offset: 0x00606358
	private SkeletalObserverHandle SpawnSkeletalObserverHandle(EUiModelUseWay useWay)
	{
		if (GlobalData.World == null)
		{
			Log.Instance.Error(ELogModule.UiSceneManager, ELogAuthor.TL, "SpawnSkeletalObserverHandle failed, GlobalData.World is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return SkeletalObserverManager.NewSkeletalObserver(useWay);
	}

	// Token: 0x06017B89 RID: 97161 RVA: 0x00608190 File Offset: 0x00606390
	public SkeletalObserverHandle InitWeaponObserver(bool needMeshStreaming = false)
	{
		EUiModelUseWay useWay = needMeshStreaming ? EUiModelUseWay.WeaponWithLoadingIcon : EUiModelUseWay.WeaponInWeaponView;
		SkeletalObserverHandle skeletalObserverHandle = this.SpawnSkeletalObserverHandle(useWay);
		this.WeaponObserverStack.Push(skeletalObserverHandle);
		return skeletalObserverHandle;
	}

	// Token: 0x06017B8A RID: 97162 RVA: 0x006081BC File Offset: 0x006063BC
	public SkeletalObserverHandle GetWeaponObserver()
	{
		if (this.WeaponObserverStack.Empty)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[WeaponObserverStack]为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.WeaponObserverStack.Peek();
	}

	// Token: 0x06017B8B RID: 97163 RVA: 0x006081FF File Offset: 0x006063FF
	public void DestroyWeaponObserver(SkeletalObserverHandle weaponObserver)
	{
		if (this.WeaponObserverStack.Empty)
		{
			return;
		}
		this.WeaponObserverStack.Delete(weaponObserver);
		SkeletalObserverManager.DestroySkeletalObserver(weaponObserver);
	}

	// Token: 0x06017B8C RID: 97164 RVA: 0x00608224 File Offset: 0x00606424
	public void DestroyAllWeaponObserver()
	{
		while (!this.WeaponObserverStack.Empty)
		{
			SkeletalObserverHandle weaponObserver = this.WeaponObserverStack.Pop();
			this.DestroyWeaponObserver(weaponObserver);
		}
	}

	// Token: 0x06017B8D RID: 97165 RVA: 0x00608254 File Offset: 0x00606454
	public SkeletalObserverHandle InitWeaponScabbardObserver()
	{
		SkeletalObserverHandle skeletalObserverHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.WeaponInWeaponView);
		this.WeaponScabbardStack.Push(skeletalObserverHandle);
		return skeletalObserverHandle;
	}

	// Token: 0x06017B8E RID: 97166 RVA: 0x00608278 File Offset: 0x00606478
	public SkeletalObserverHandle GetWeaponScabbardObserver()
	{
		if (this.WeaponScabbardStack.Empty)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[WeaponScabbardStack]为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.WeaponScabbardStack.Peek();
	}

	// Token: 0x06017B8F RID: 97167 RVA: 0x006082BB File Offset: 0x006064BB
	public void DestroyWeaponScabbardObserver(SkeletalObserverHandle weaponScabbard)
	{
		if (this.WeaponScabbardStack.Empty)
		{
			return;
		}
		this.WeaponScabbardStack.Delete(weaponScabbard);
		SkeletalObserverManager.DestroySkeletalObserver(weaponScabbard);
	}

	// Token: 0x06017B90 RID: 97168 RVA: 0x006082E0 File Offset: 0x006064E0
	public void DestroyAllWeaponScabbardObserver()
	{
		while (!this.WeaponScabbardStack.Empty)
		{
			SkeletalObserverHandle weaponScabbard = this.WeaponScabbardStack.Pop();
			this.DestroyWeaponScabbardObserver(weaponScabbard);
		}
	}

	// Token: 0x06017B91 RID: 97169 RVA: 0x00608310 File Offset: 0x00606510
	public void InitPhantomObserver()
	{
		if (this.PhantomObserver != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[PhantomObserver]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PhantomObserver = this.SpawnSkeletalObserverHandle(EUiModelUseWay.VisionInRoleView);
	}

	// Token: 0x06017B92 RID: 97170 RVA: 0x00608350 File Offset: 0x00606550
	public SkeletalObserverHandle GetPhantomObserver()
	{
		if (this.PhantomObserver == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[PhantomObserver]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.PhantomObserver;
	}

	// Token: 0x06017B93 RID: 97171 RVA: 0x00608389 File Offset: 0x00606589
	public void DestroyPhantomObserver()
	{
		if (this.PhantomObserver == null)
		{
			return;
		}
		SkeletalObserverManager.DestroySkeletalObserver(this.PhantomObserver);
		this.PhantomObserver = null;
	}

	// Token: 0x06017B94 RID: 97172 RVA: 0x006083A6 File Offset: 0x006065A6
	public SkeletalObserverHandle InitHuluObserver()
	{
		this.HuluObserver = UiSceneManager.Instance.SpawnSkeletalObserverHandle(EUiModelUseWay.HuluInSkinView);
		return this.HuluObserver;
	}

	// Token: 0x06017B95 RID: 97173 RVA: 0x006083C0 File Offset: 0x006065C0
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

	// Token: 0x06017B96 RID: 97174 RVA: 0x006083F9 File Offset: 0x006065F9
	public void DestroyHuluObserver()
	{
		if (this.HuluObserver == null)
		{
			return;
		}
		SkeletalObserverManager.DestroySkeletalObserver(this.HuluObserver);
		this.HuluObserver = null;
	}

	// Token: 0x06017B97 RID: 97175 RVA: 0x00608418 File Offset: 0x00606618
	public void InitHandBookObserver()
	{
		if (this.HandBookObserver != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[HandBookObserver]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.HandBookObserver = this.SpawnSkeletalObserverHandle(EUiModelUseWay.VisionInRoleView);
	}

	// Token: 0x06017B98 RID: 97176 RVA: 0x00608458 File Offset: 0x00606658
	public SkeletalObserverHandle GetHandBookObserver()
	{
		if (this.HandBookObserver == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[HandBookObserver]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.HandBookObserver;
	}

	// Token: 0x06017B99 RID: 97177 RVA: 0x00608491 File Offset: 0x00606691
	public void DestroyHandBookObserver()
	{
		if (this.HandBookObserver == null)
		{
			return;
		}
		SkeletalObserverManager.DestroySkeletalObserver(this.HandBookObserver);
		this.HandBookObserver = null;
	}

	// Token: 0x06017B9A RID: 97178 RVA: 0x006084B0 File Offset: 0x006066B0
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

	// Token: 0x06017B9B RID: 97179 RVA: 0x006084EC File Offset: 0x006066EC
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

	// Token: 0x06017B9C RID: 97180 RVA: 0x0060852F File Offset: 0x0060672F
	public bool HasRoleSystemRoleActor()
	{
		return !this.RoleSystemActorStack.Empty;
	}

	// Token: 0x06017B9D RID: 97181 RVA: 0x00608540 File Offset: 0x00606740
	public void HideRoleSystemRoleActor()
	{
		if (this.RoleSystemActorStack.Empty)
		{
			return;
		}
		UiModelBase model = this.RoleSystemActorStack.Peek().Model;
		UiModelUtil.Instance.SetVisible(model, false);
	}

	// Token: 0x06017B9E RID: 97182 RVA: 0x0060857C File Offset: 0x0060677C
	public void ShowRoleSystemRoleActor()
	{
		if (this.RoleSystemActorStack.Empty)
		{
			return;
		}
		UiModelBase model = this.RoleSystemActorStack.Peek().Model;
		UiModelUtil.Instance.SetVisible(model, true);
	}

	// Token: 0x06017B9F RID: 97183 RVA: 0x006085B8 File Offset: 0x006067B8
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

	// Token: 0x06017BA0 RID: 97184 RVA: 0x00608628 File Offset: 0x00606828
	public void DestroyAllRoleSystemRoleActor()
	{
		while (!this.RoleSystemActorStack.Empty)
		{
			int roleActorIndex = this.RoleSystemActorStack.Pop().GetRoleActorIndex();
			UiSceneRoleActorManager.Instance.DestroyUiSceneRoleActor(roleActorIndex);
		}
	}

	// Token: 0x06017BA1 RID: 97185 RVA: 0x00608664 File Offset: 0x00606864
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

	// Token: 0x06017BA2 RID: 97186 RVA: 0x006086EC File Offset: 0x006068EC
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

	// Token: 0x06017BA3 RID: 97187 RVA: 0x00608752 File Offset: 0x00606952
	[NullableContext(2)]
	public TsUiSceneRoleActor GetCurrentSelectFormationRoleActor()
	{
		if (this.SelectFormationPosition == -1)
		{
			return null;
		}
		return this.GetRoleFormationActor(this.SelectFormationPosition);
	}

	// Token: 0x06017BA4 RID: 97188 RVA: 0x0060876C File Offset: 0x0060696C
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

	// Token: 0x06017BA5 RID: 97189 RVA: 0x006087BC File Offset: 0x006069BC
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

	// Token: 0x06017BA6 RID: 97190 RVA: 0x00608870 File Offset: 0x00606A70
	private void DestroyAllRoleFormationActor()
	{
		foreach (TsUiSceneRoleActor tsUiSceneRoleActor in this.RoleFormationActorList)
		{
			int roleActorIndex = tsUiSceneRoleActor.GetRoleActorIndex();
			UiSceneRoleActorManager.Instance.DestroyUiSceneRoleActor(roleActorIndex);
		}
		this.RoleFormationActorList.Clear();
	}

	// Token: 0x06017BA7 RID: 97191 RVA: 0x006088D8 File Offset: 0x00606AD8
	public void InitGachaItemObserver()
	{
		if (this.GachaItemObserver != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.TL, "[GachaItemObserver]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.GachaItemObserver = this.SpawnSkeletalObserverHandle(EUiModelUseWay.WeaponInWeaponView);
	}

	// Token: 0x06017BA8 RID: 97192 RVA: 0x00608918 File Offset: 0x00606B18
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

	// Token: 0x06017BA9 RID: 97193 RVA: 0x0060894E File Offset: 0x00606B4E
	public void DestroyGachaItemObserver()
	{
		if (this.GachaItemObserver != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.GachaItemObserver);
			this.GachaItemObserver = null;
		}
	}

	// Token: 0x06017BAA RID: 97194 RVA: 0x0060896C File Offset: 0x00606B6C
	public void InitDreamLinkRoleSkeletalHandle()
	{
		if (this.DreamLinkRoleSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.DreamLink, ELogAuthor.LPH, "[DreamLinkRoleSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.DreamLinkRoleSkeletalHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.RoleInDreamLinkView);
	}

	// Token: 0x06017BAB RID: 97195 RVA: 0x006089B0 File Offset: 0x00606BB0
	public SkeletalObserverHandle GetDreamLinkRoleSkeletalHandle()
	{
		if (this.DreamLinkRoleSkeletalHandle == null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LPH, "[DreamLinkRoleSkeletalHandle]未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.DreamLinkRoleSkeletalHandle;
	}

	// Token: 0x06017BAC RID: 97196 RVA: 0x006089E9 File Offset: 0x00606BE9
	public bool HasDreamLinkRoleSkeletalHandle()
	{
		return this.DreamLinkRoleSkeletalHandle != null;
	}

	// Token: 0x06017BAD RID: 97197 RVA: 0x006089F4 File Offset: 0x00606BF4
	public void DestroyDreamLinkRoleSkeletalHandle()
	{
		if (this.DreamLinkRoleSkeletalHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.DreamLinkRoleSkeletalHandle);
			this.DreamLinkRoleSkeletalHandle = null;
		}
	}

	// Token: 0x06017BAE RID: 97198 RVA: 0x00608A10 File Offset: 0x00606C10
	public SkeletalObserverHandle InitDreamLinkWeaponSkeletalHandle()
	{
		SkeletalObserverHandle skeletalObserverHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.WeaponInDreamLinkView);
		this.DreamLinkWeaponSkeletalHandleStack.Add(skeletalObserverHandle);
		return skeletalObserverHandle;
	}

	// Token: 0x06017BAF RID: 97199 RVA: 0x00608A33 File Offset: 0x00606C33
	public bool HasDreamLinkWeaponSkeletalHandle()
	{
		return this.DreamLinkWeaponSkeletalHandleStack.Count > 0;
	}

	// Token: 0x06017BB0 RID: 97200 RVA: 0x00608A44 File Offset: 0x00606C44
	public void DestroyAllDreamLinkWeaponSkeletalHandle()
	{
		foreach (SkeletalObserverHandle skeletalObserverHandle in this.DreamLinkWeaponSkeletalHandleStack)
		{
			SkeletalObserverManager.DestroySkeletalObserver(skeletalObserverHandle);
		}
		this.DreamLinkWeaponSkeletalHandleStack.Clear();
	}

	// Token: 0x06017BB1 RID: 97201 RVA: 0x00608AA0 File Offset: 0x00606CA0
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

	// Token: 0x06017BB2 RID: 97202 RVA: 0x00608B95 File Offset: 0x00606D95
	[NullableContext(2)]
	public BP_KposeBase_C GetHandBookVision()
	{
		return this.HandBookVision;
	}

	// Token: 0x06017BB3 RID: 97203 RVA: 0x00608B9D File Offset: 0x00606D9D
	public void ShowHandBookVision()
	{
		this.SetHandBookVisionVisible(true);
	}

	// Token: 0x06017BB4 RID: 97204 RVA: 0x00608BA6 File Offset: 0x00606DA6
	public void HideHandBookVision()
	{
		this.SetHandBookVisionVisible(false);
	}

	// Token: 0x06017BB5 RID: 97205 RVA: 0x00608BAF File Offset: 0x00606DAF
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

	// Token: 0x06017BB6 RID: 97206 RVA: 0x00608BF0 File Offset: 0x00606DF0
	private static void SetActorAndComponentTickEnabled(AActor actor, bool enabled)
	{
		actor.SetActorTickEnabled(enabled);
		TArray<UActorComponent> tarray = actor.K2_GetComponentsByClass(UActorComponent.StaticClass());
		for (int i = 0; i < tarray.Num(); i++)
		{
			tarray.Get(i).SetComponentTickEnabled(enabled);
		}
	}

	// Token: 0x06017BB7 RID: 97207 RVA: 0x00608C34 File Offset: 0x00606E34
	[NullableContext(2)]
	public AActor GetHandBookCaseActor()
	{
		return UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("MonsterCase").Value, ECollectActorType.UI);
	}

	// Token: 0x06017BB8 RID: 97208 RVA: 0x00608C59 File Offset: 0x00606E59
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

	// Token: 0x06017BB9 RID: 97209 RVA: 0x00608C90 File Offset: 0x00606E90
	public void InitVisionSkeletalHandle()
	{
		if (this.VisionSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.Phantom, ELogAuthor.TL, "[VisionSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.VisionSkeletalHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.VisionInRoleView);
	}

	// Token: 0x06017BBA RID: 97210 RVA: 0x00608CCF File Offset: 0x00606ECF
	public bool HasVisionSkeletalHandle()
	{
		return this.VisionSkeletalHandle != null;
	}

	// Token: 0x06017BBB RID: 97211 RVA: 0x00608CDC File Offset: 0x00606EDC
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

	// Token: 0x06017BBC RID: 97212 RVA: 0x00608D12 File Offset: 0x00606F12
	public void DestroyVisionSkeletalHandle()
	{
		if (this.VisionSkeletalHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.VisionSkeletalHandle);
			this.VisionSkeletalHandle = null;
		}
	}

	// Token: 0x06017BBD RID: 97213 RVA: 0x00608D30 File Offset: 0x00606F30
	public void InitAbyssDangoObserver()
	{
		if (this.AbyssDangoObserver != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.YZY, "[AbyssDangoObserver]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.AbyssDangoObserver = this.SpawnSkeletalObserverHandle(EUiModelUseWay.AbyssDango);
	}

	// Token: 0x06017BBE RID: 97214 RVA: 0x00608D70 File Offset: 0x00606F70
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

	// Token: 0x06017BBF RID: 97215 RVA: 0x00608DA6 File Offset: 0x00606FA6
	public void DestroyAbyssDangoObserver()
	{
		if (this.AbyssDangoObserver != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.AbyssDangoObserver);
			this.AbyssDangoObserver = null;
		}
	}

	// Token: 0x06017BC0 RID: 97216 RVA: 0x00608DC4 File Offset: 0x00606FC4
	public void InitLordSkeletalHandle()
	{
		if (this.LordSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LZK, "[LordSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.LordSkeletalHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.VisionInLordGymView);
	}

	// Token: 0x06017BC1 RID: 97217 RVA: 0x00608E04 File Offset: 0x00607004
	public bool HasLordSkeletalHandle()
	{
		return this.LordSkeletalHandle != null;
	}

	// Token: 0x06017BC2 RID: 97218 RVA: 0x00608E10 File Offset: 0x00607010
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

	// Token: 0x06017BC3 RID: 97219 RVA: 0x00608E46 File Offset: 0x00607046
	public void DestroyLordSkeletalHandle()
	{
		if (this.LordSkeletalHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.LordSkeletalHandle);
			this.LordSkeletalHandle = null;
		}
	}

	// Token: 0x06017BC4 RID: 97220 RVA: 0x00608E64 File Offset: 0x00607064
	public void InitAdamSmasherSkeletalHandle()
	{
		if (this.AdamSmasherSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.SWC, "[AdamSmasherSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.AdamSmasherSkeletalHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.AdamSmasher);
	}

	// Token: 0x06017BC5 RID: 97221 RVA: 0x00608EA4 File Offset: 0x006070A4
	public bool HasAdamSmasherSkeletalHandle()
	{
		return this.AdamSmasherSkeletalHandle != null;
	}

	// Token: 0x06017BC6 RID: 97222 RVA: 0x00608EB0 File Offset: 0x006070B0
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

	// Token: 0x06017BC7 RID: 97223 RVA: 0x00608EE6 File Offset: 0x006070E6
	public void DestroyAdamSmasherSkeletalHandle()
	{
		if (this.AdamSmasherSkeletalHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.AdamSmasherSkeletalHandle);
			this.AdamSmasherSkeletalHandle = null;
		}
	}

	// Token: 0x06017BC8 RID: 97224 RVA: 0x00608F02 File Offset: 0x00607102
	public TsUiSceneDangoActor InitDangoActor(EUiModelUseWay useWay)
	{
		return UiSceneDangoActorManager.CreateUiSceneDangoActor(useWay);
	}

	// Token: 0x06017BC9 RID: 97225 RVA: 0x00608F0A File Offset: 0x0060710A
	public void DestroyDangoActor(TsUiSceneDangoActor dango)
	{
		UiSceneDangoActorManager.DestroyUiSceneDangoActor(dango.GetActorIndex());
	}

	// Token: 0x06017BCA RID: 97226 RVA: 0x00608F18 File Offset: 0x00607118
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

	// Token: 0x06017BCB RID: 97227 RVA: 0x006090B0 File Offset: 0x006072B0
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

	// Token: 0x06017BCC RID: 97228 RVA: 0x00609104 File Offset: 0x00607304
	public void InitGliderSkeletalHandle()
	{
		if (this.GliderSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LZK, "[GliderSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.GliderSkeletalHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.GliderInSkinView);
	}

	// Token: 0x06017BCD RID: 97229 RVA: 0x00609144 File Offset: 0x00607344
	public bool HasGliderSkeletalHandle()
	{
		return this.GliderSkeletalHandle != null;
	}

	// Token: 0x06017BCE RID: 97230 RVA: 0x00609150 File Offset: 0x00607350
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

	// Token: 0x06017BCF RID: 97231 RVA: 0x00609186 File Offset: 0x00607386
	public void DestroyGliderSkeletalHandle()
	{
		if (this.GliderSkeletalHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.GliderSkeletalHandle);
			this.GliderSkeletalHandle = null;
		}
	}

	// Token: 0x06017BD0 RID: 97232 RVA: 0x006091A4 File Offset: 0x006073A4
	public void InitSpecialItemSummonSkeletalHandle()
	{
		if (this.SpecialItemSummonSkeletalHandle != null)
		{
			Log.Instance.Warn(ELogModule.UiSceneManager, ELogAuthor.LZK, "[SpecialItemSummonSkeletalHandle]重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.SpecialItemSummonSkeletalHandle = this.SpawnSkeletalObserverHandle(EUiModelUseWay.SpecialItemSummonInSkinView);
	}

	// Token: 0x06017BD1 RID: 97233 RVA: 0x006091E4 File Offset: 0x006073E4
	public bool HasSpecialItemSummonSkeletalHandle()
	{
		return this.SpecialItemSummonSkeletalHandle != null;
	}

	// Token: 0x06017BD2 RID: 97234 RVA: 0x006091F0 File Offset: 0x006073F0
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

	// Token: 0x06017BD3 RID: 97235 RVA: 0x00609226 File Offset: 0x00607426
	public void DestroySpecialItemSummonSkeletalHandle()
	{
		if (this.SpecialItemSummonSkeletalHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.SpecialItemSummonSkeletalHandle);
			this.SpecialItemSummonSkeletalHandle = null;
		}
	}

	// Token: 0x06017BD4 RID: 97236 RVA: 0x00609244 File Offset: 0x00607444
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

	// Token: 0x06017BD5 RID: 97237 RVA: 0x006092A0 File Offset: 0x006074A0
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

	// Token: 0x06017BD6 RID: 97238 RVA: 0x006092D8 File Offset: 0x006074D8
	public void DestroyMotorSkeletalHandle()
	{
		if (this.MotorSkeletalHandle != null)
		{
			Log.Instance.Info(ELogModule.UiSceneManager, ELogAuthor.LZK, "DestroyMotorSkeletalHandle", default(ReadOnlySpan<ValueTuple<string, object>>));
			SkeletalObserverManager.DestroySkeletalObserver(this.MotorSkeletalHandle);
			this.MotorSkeletalHandle = null;
		}
	}

	// Token: 0x06017BD7 RID: 97239 RVA: 0x0060931C File Offset: 0x0060751C
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

	// Token: 0x06017BD8 RID: 97240 RVA: 0x0060937C File Offset: 0x0060757C
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

	// Token: 0x06017BD9 RID: 97241 RVA: 0x006093FC File Offset: 0x006075FC
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

	// Token: 0x06017BDA RID: 97242 RVA: 0x00609450 File Offset: 0x00607650
	public UniTask ExitScene()
	{
		UiSceneManager.<ExitScene>d__129 <ExitScene>d__;
		<ExitScene>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExitScene>d__.<>4__this = this;
		<ExitScene>d__.<>1__state = -1;
		<ExitScene>d__.<>t__builder.Start<UiSceneManager.<ExitScene>d__129>(ref <ExitScene>d__);
		return <ExitScene>d__.<>t__builder.Task;
	}

	// Token: 0x06017BDB RID: 97243 RVA: 0x00609493 File Offset: 0x00607693
	private void RecordAndLandscapeValue()
	{
		this.LastHideLandscapeValue = UKismetSystemLibrary.GetConsoleVariableIntValue("r.Kuro.HideLandscape");
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.HideLandscape 0", null);
	}

	// Token: 0x06017BDC RID: 97244 RVA: 0x006094B8 File Offset: 0x006076B8
	private void ResetLandscapeValue()
	{
		UObject world = GlobalData.World;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
		defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.HideLandscape ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.LastHideLandscapeValue);
		UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
	}

	// Token: 0x06017BDD RID: 97245 RVA: 0x006094FC File Offset: 0x006076FC
	private void SetEnterSceneCamera()
	{
		if (GlobalData.World != null)
		{
			CameraController.Instance.ExitCameraMode(ECustomCameraMode.Widget, 0f, EViewTargetBlendFunction.VTBlend_EaseIn, 0f, null, "MainCamera", null);
			CameraController.Instance.EnterCameraMode(ECustomCameraMode.Widget, 0f, EViewTargetBlendFunction.VTBlend_EaseIn, 0f, null, false, "MainCamera", null);
		}
	}

	// Token: 0x06017BDE RID: 97246 RVA: 0x0060954D File Offset: 0x0060774D
	public void SetUiStartSequenceFrame(int startSequenceFrame)
	{
		if (this.StartSequenceFrame == 0)
		{
			this.StartSequenceFrame = startSequenceFrame;
		}
	}

	// Token: 0x06017BDF RID: 97247 RVA: 0x0060955E File Offset: 0x0060775E
	public void SetUiEndSequenceFrame(int endSequenceFrame)
	{
		if (this.EndSequenceFrame == 0)
		{
			this.EndSequenceFrame = endSequenceFrame;
		}
	}

	// Token: 0x06017BE0 RID: 97248 RVA: 0x0060956F File Offset: 0x0060776F
	public void ClearUiSequenceFrame()
	{
		this.StartSequenceFrame = 0;
		this.EndSequenceFrame = 0;
	}

	// Token: 0x06017BE1 RID: 97249 RVA: 0x0060957F File Offset: 0x0060777F
	public int GetUiStartSequenceFrame()
	{
		return this.StartSequenceFrame;
	}

	// Token: 0x06017BE2 RID: 97250 RVA: 0x00609587 File Offset: 0x00607787
	public int GetUiEndSequenceFrame()
	{
		return this.EndSequenceFrame;
	}

	// Token: 0x06017BE3 RID: 97251 RVA: 0x00609590 File Offset: 0x00607790
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

	// Token: 0x06017BE4 RID: 97252 RVA: 0x006095C4 File Offset: 0x006077C4
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

	// Token: 0x06017BE5 RID: 97253 RVA: 0x00609620 File Offset: 0x00607820
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

	// Token: 0x06017BE6 RID: 97254 RVA: 0x0060964C File Offset: 0x0060784C
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

	// Token: 0x17001FD9 RID: 8153
	// (get) Token: 0x06017BE7 RID: 97255 RVA: 0x006096A8 File Offset: 0x006078A8
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

	// Token: 0x06017BE8 RID: 97256 RVA: 0x006096CB File Offset: 0x006078CB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017BE9 RID: 97257 RVA: 0x006096CD File Offset: 0x006078CD
	public static void ResetStaticDefaultValue()
	{
		UiSceneManager instance = UiSceneManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiSceneManager._instance = null;
	}

	// Token: 0x06017BEA RID: 97258 RVA: 0x006096E6 File Offset: 0x006078E6
	static UiSceneManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiSceneManager.CreateStaticDefaultValue), new Action(UiSceneManager.ResetStaticDefaultValue));
	}

	// Token: 0x0400B0AF RID: 45231
	private readonly HashSet<string> DisableClvUiSceneIds = new HashSet<string>
	{
		"Instance_ChouKa_01",
		"UL_UIMap_ChallengeUI",
		"UL_UIMap_Bosslevel",
		"UL_UIMap_DaoGuanUI",
		"UL_UIMap_HologramUI"
	};

	// Token: 0x0400B0B0 RID: 45232
	private int? LastClvEnableValue;

	// Token: 0x0400B0B1 RID: 45233
	public string CurUiSceneId = string.Empty;

	// Token: 0x0400B0B2 RID: 45234
	public HashSet<string> CurUiScenePathSet = new HashSet<string>();

	// Token: 0x0400B0B3 RID: 45235
	public string GlobalGiMainScene = string.Empty;

	// Token: 0x0400B0B4 RID: 45236
	[Nullable(2)]
	protected Action LoadSuccessFunction;

	// Token: 0x0400B0B5 RID: 45237
	[Nullable(2)]
	protected Action<bool> SwitchUiSceneFunction;

	// Token: 0x0400B0B6 RID: 45238
	private readonly global::Stack<SkeletalObserverHandle> WeaponObserverStack = new global::Stack<SkeletalObserverHandle>();

	// Token: 0x0400B0B7 RID: 45239
	private readonly global::Stack<SkeletalObserverHandle> WeaponScabbardStack = new global::Stack<SkeletalObserverHandle>();

	// Token: 0x0400B0B8 RID: 45240
	private SkeletalObserverHandle PhantomObserver;

	// Token: 0x0400B0B9 RID: 45241
	[Nullable(2)]
	private SkeletalObserverHandle HuluObserver;

	// Token: 0x0400B0BA RID: 45242
	private SkeletalObserverHandle HandBookObserver;

	// Token: 0x0400B0BB RID: 45243
	private readonly global::Stack<TsUiSceneRoleActor> RoleSystemActorStack = new global::Stack<TsUiSceneRoleActor>();

	// Token: 0x0400B0BC RID: 45244
	public int SelectFormationPosition = -1;

	// Token: 0x0400B0BD RID: 45245
	private readonly List<TsUiSceneRoleActor> RoleFormationActorList = new List<TsUiSceneRoleActor>();

	// Token: 0x0400B0BE RID: 45246
	private SkeletalObserverHandle GachaItemObserver;

	// Token: 0x0400B0BF RID: 45247
	[Nullable(2)]
	private SkeletalObserverHandle DreamLinkRoleSkeletalHandle;

	// Token: 0x0400B0C0 RID: 45248
	private readonly List<SkeletalObserverHandle> DreamLinkWeaponSkeletalHandleStack = new List<SkeletalObserverHandle>();

	// Token: 0x0400B0C1 RID: 45249
	[Nullable(2)]
	private BP_KposeBase_C HandBookVision;

	// Token: 0x0400B0C2 RID: 45250
	[Nullable(2)]
	private SkeletalObserverHandle VisionSkeletalHandle;

	// Token: 0x0400B0C3 RID: 45251
	[Nullable(2)]
	private SkeletalObserverHandle AbyssDangoObserver;

	// Token: 0x0400B0C4 RID: 45252
	[Nullable(2)]
	private SkeletalObserverHandle LordSkeletalHandle;

	// Token: 0x0400B0C5 RID: 45253
	[Nullable(2)]
	private SkeletalObserverHandle AdamSmasherSkeletalHandle;

	// Token: 0x0400B0C6 RID: 45254
	private readonly global::Vector LocationOffset = global::Vector.Create();

	// Token: 0x0400B0C7 RID: 45255
	private FVector2D ScreenPosition = new FVector2D();

	// Token: 0x0400B0C8 RID: 45256
	private SkeletalObserverHandle GliderSkeletalHandle;

	// Token: 0x0400B0C9 RID: 45257
	[Nullable(2)]
	private SkeletalObserverHandle SpecialItemSummonSkeletalHandle;

	// Token: 0x0400B0CA RID: 45258
	[Nullable(2)]
	private SkeletalObserverHandle MotorSkeletalHandle;

	// Token: 0x0400B0CB RID: 45259
	private int LastStencilFixedValue;

	// Token: 0x0400B0CC RID: 45260
	private int LastHideLandscapeValue;

	// Token: 0x0400B0CD RID: 45261
	private int StartSequenceFrame;

	// Token: 0x0400B0CE RID: 45262
	private int EndSequenceFrame;

	// Token: 0x0400B0CF RID: 45263
	[Nullable(2)]
	private static UiSceneManager _instance;
}
