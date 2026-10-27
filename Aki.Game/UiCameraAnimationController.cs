using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002C32 RID: 11314
[NullableContext(1)]
[Nullable(0)]
public class UiCameraAnimationController : ControllerBase
{
	// Token: 0x0601794D RID: 96589 RVA: 0x005FF99C File Offset: 0x005FDB9C
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<EUiTabViewName?, UiTabViewBase>(EEventName.OpenTabView, new Action<EUiTabViewName?, UiTabViewBase>(this.OnOpenTabView));
		EventSystem.Instance.Add<EUiViewName>(EEventName.OnViewLoadCompleted, new Action<EUiViewName>(this.OnViewLoadCompleted));
		EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
		EventSystem.Instance.Add(EEventName.ResetModuleAfterResetToBattleView, new Action(this.OnResetCameraByResetToBattleView));
		EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Add(EEventName.DestroyAllUiCameraAnimationHandles, new Action(this.OnDestroyAllUiCameraAnimationHandles));
		EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.Add<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
		EventSystem.Instance.Add(EEventName.OnSelectedRoleChanged, new Action(this.OnRoleSystemChangeRole));
		EventSystem.Instance.Add(EEventName.OnRoleMorphTypeChanged, new Action(this.OnRoleMorphTypeChanged));
		EventSystem.Instance.Add(EEventName.UiSceneLoaded, new Action(this.OnUiSceneLoaded));
		UiCameraAnimationManager.Instance.Initialize();
		return true;
	}

	// Token: 0x0601794E RID: 96590 RVA: 0x005FFAE0 File Offset: 0x005FDCE0
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.OpenTabView, new Action<EUiTabViewName?, UiTabViewBase>(this.OnOpenTabView));
		EventSystem.Instance.Remove(EEventName.OnViewLoadCompleted, new Action<EUiViewName>(this.OnViewLoadCompleted));
		EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
		EventSystem.Instance.Remove(EEventName.ResetModuleAfterResetToBattleView, new Action(this.OnResetCameraByResetToBattleView));
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Remove(EEventName.DestroyAllUiCameraAnimationHandles, new Action(this.OnDestroyAllUiCameraAnimationHandles));
		EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.Remove(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
		EventSystem.Instance.Remove(EEventName.OnSelectedRoleChanged, new Action(this.OnRoleSystemChangeRole));
		EventSystem.Instance.Remove(EEventName.OnRoleMorphTypeChanged, new Action(this.OnRoleMorphTypeChanged));
		EventSystem.Instance.Remove(EEventName.UiSceneLoaded, new Action(this.OnUiSceneLoaded));
		this.ResetDelayPush();
		UiCameraAnimationManager.Instance.ClearDisplay();
		return true;
	}

	// Token: 0x0601794F RID: 96591 RVA: 0x005FFC28 File Offset: 0x005FDE28
	protected override bool OnLeaveLevel()
	{
		this.ResetDelayPush();
		UiCameraAnimationManager.Instance.ClearDisplay();
		return true;
	}

	// Token: 0x06017950 RID: 96592 RVA: 0x005FFC3C File Offset: 0x005FDE3C
	public unsafe void PushCameraHandle(EUiViewName viewName, int? viewId = null, bool bBlend = true)
	{
		if (viewName == UiModel.Instance.MainViewName)
		{
			if (UiCameraAnimationManager.Instance.IsActivate())
			{
				Log.Instance.Error(ELogModule.CameraAnimation, ELogAuthor.BB, "当打开主界面时，Ui镜头栈有未抛出的数据，检查是否没有关闭界面，或手动播放了Ui镜头但没有手动抛出", default(ReadOnlySpan<ValueTuple<string, object>>));
				foreach (UiCameraHandleData uiCameraHandleData in UiCameraAnimationManager.Instance.GetHandleDataStack())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.CameraAnimation;
					ELogAuthor author = ELogAuthor.BB;
					string message = "未抛出的Ui镜头数据";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleName", uiCameraHandleData.HandleName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewName", uiCameraHandleData.ViewName);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				UiCameraAnimationManager.Instance.ClearDisplay();
			}
			return;
		}
		UiCameraMappingData cameraMappingData = UiCameraAnimationManager.Instance.GetCameraMappingData(viewName);
		if (cameraMappingData == null)
		{
			return;
		}
		float uiCameraDelayTime = cameraMappingData.GetUiCameraDelayTime();
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.CameraAnimation;
		ELogAuthor author2 = ELogAuthor.BB;
		string message2 = "当打开界面时";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("viewName", viewName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("delayTime", uiCameraDelayTime);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		if (uiCameraDelayTime > 0f && bBlend)
		{
			this.DelayPushCameraHandleByOpenView(uiCameraDelayTime, viewName, viewId);
			return;
		}
		this.ResetDelayPush();
		UiCameraAnimationManager.Instance.PushCameraHandleByOpenView(viewName, viewId, bBlend, null, null);
	}

	// Token: 0x06017951 RID: 96593 RVA: 0x005FFDF0 File Offset: 0x005FDFF0
	private unsafe void OnOpenTabView(EUiTabViewName? tabViewName, UiTabViewBase uiTabViewBase)
	{
		UiCameraMappingData cameraMappingData = UiCameraAnimationManager.Instance.GetCameraMappingData(tabViewName.Value);
		if (cameraMappingData == null)
		{
			return;
		}
		float uiCameraDelayTime = cameraMappingData.GetUiCameraDelayTime();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CameraAnimation;
		ELogAuthor author = ELogAuthor.BB;
		string message = "当打开页签界面时";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tabViewName", tabViewName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("delayTime", uiCameraDelayTime);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (uiCameraDelayTime > 0f)
		{
			this.DelayPushCameraHandleByOpenView(uiCameraDelayTime, tabViewName.Value, null);
			return;
		}
		this.ResetDelayPush();
		UiCameraAnimationManager.Instance.PushCameraHandleByOpenView(tabViewName.Value, null, true, null, null);
	}

	// Token: 0x06017952 RID: 96594 RVA: 0x005FFED4 File Offset: 0x005FE0D4
	[NullableContext(2)]
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete = true)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CameraAnimation;
		ELogAuthor author = ELogAuthor.BB;
		string message = "当隐藏界面时";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", viewName);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.ResetDelayPush();
		UiCameraAnimationManager instance2 = UiCameraAnimationManager.Instance;
		string closeViewName = viewName;
		EUiViewName? euiViewName = (stackTopInfo != null) ? new EUiViewName?(stackTopInfo.Name) : null;
		instance2.PopCameraHandleByCloseView(closeViewName, (euiViewName != null) ? euiViewName.GetValueOrDefault() : null, closeViewId, popOrDelete);
	}

	// Token: 0x06017953 RID: 96595 RVA: 0x005FFF58 File Offset: 0x005FE158
	public void EnterUiCameraMode()
	{
		UiCamera uiCamera = UiCameraAnimationManager.Instance.UiCamera;
		UiCameraStructure uiCameraStructure = (uiCamera != null) ? uiCamera.GetStructure() : null;
		if (uiCameraStructure != null)
		{
			uiCameraStructure.Activate();
		}
		UiCameraHandleData lastHandleData = UiCameraAnimationManager.Instance.GetLastHandleData();
		if (lastHandleData != null)
		{
			UiCameraAnimationManager.Instance.ActivateCameraHandle(lastHandleData, false, false);
		}
	}

	// Token: 0x06017954 RID: 96596 RVA: 0x005FFFA0 File Offset: 0x005FE1A0
	public void ExitUiCameraMode()
	{
		UiCamera uiCamera = UiCameraAnimationManager.Instance.UiCamera;
		UiCameraStructure uiCameraStructure = (uiCamera != null) ? uiCamera.GetStructure() : null;
		if (uiCameraStructure != null)
		{
			uiCameraStructure.Deactivate();
		}
		CameraController.Instance.ExitCameraMode(ECustomCameraMode.Widget, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
	}

	// Token: 0x06017955 RID: 96597 RVA: 0x005FFFEC File Offset: 0x005FE1EC
	public void DeepCopyCamera(ACameraActor cameraActor)
	{
		UiCameraAnimationHandle currentCameraHandle = UiCameraAnimationManager.Instance.GetCurrentCameraHandle();
		if (currentCameraHandle == null)
		{
			return;
		}
		currentCameraHandle.DeepCopyCameraInfo(cameraActor);
	}

	// Token: 0x06017956 RID: 96598 RVA: 0x00600010 File Offset: 0x005FE210
	private void OnViewLoadCompleted(EUiViewName viewName)
	{
		UiCameraAnimationHandle currentCameraHandle = UiCameraAnimationManager.Instance.GetCurrentCameraHandle();
		if (currentCameraHandle == null)
		{
			return;
		}
		if (currentCameraHandle.GetHandleData() == null)
		{
			return;
		}
		if (!currentCameraHandle.GetIsActivate())
		{
			return;
		}
		if (currentCameraHandle.GetViewName() != viewName)
		{
			return;
		}
		if (!currentCameraHandle.IsViewInLoading)
		{
			return;
		}
		Log.Instance.Info(ELogModule.CameraAnimation, ELogAuthor.BB, "当界面加载完成时,重新激活镜头状态", default(ReadOnlySpan<ValueTuple<string, object>>));
		UiCameraAnimationManager.Instance.ReactivateCameraHandle(false, true);
	}

	// Token: 0x06017957 RID: 96599 RVA: 0x00600084 File Offset: 0x005FE284
	private void DelayPushCameraHandleByOpenView(float delayTime, string viewName, int? viewId = null)
	{
		if (!UiCameraAnimationManager.Instance.CanPushCameraHandle(viewName))
		{
			return;
		}
		this.ResetDelayPush();
		this.DelayViewName = viewName;
		this.DelayViewId = viewId;
		this.DelayPushCameraHandleTimerId = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.OnUiCameraDelayFinished), delayTime, null, null, true, 1f);
	}

	// Token: 0x06017958 RID: 96600 RVA: 0x006000D8 File Offset: 0x005FE2D8
	private void ResetDelayPush()
	{
		if (!TimerSystem.GameplayTimeInstance.Has(this.DelayPushCameraHandleTimerId))
		{
			return;
		}
		TimerSystem.GameplayTimeInstance.Remove(this.DelayPushCameraHandleTimerId);
		this.DelayViewName = null;
		this.DelayViewId = null;
		this.DelayPushCameraHandleTimerId = null;
	}

	// Token: 0x06017959 RID: 96601 RVA: 0x00600118 File Offset: 0x005FE318
	private void OnUiCameraDelayFinished(float delta)
	{
		UiCameraAnimationManager.Instance.PushCameraHandleByOpenView(this.DelayViewName, this.DelayViewId, true, null, null);
		this.ResetDelayPush();
	}

	// Token: 0x0601795A RID: 96602 RVA: 0x0060014C File Offset: 0x005FE34C
	private void OnBeforeLoadMap()
	{
		UiCameraAnimationManager.Instance.ClearDisplay();
	}

	// Token: 0x0601795B RID: 96603 RVA: 0x00600158 File Offset: 0x005FE358
	private void OnResetCameraByResetToBattleView()
	{
		this.ResetDelayPush();
		UiCameraAnimationManager.Instance.ClearDisplay();
		CameraController.Instance.ExitCameraMode(ECustomCameraMode.Widget, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
	}

	// Token: 0x0601795C RID: 96604 RVA: 0x00600188 File Offset: 0x005FE388
	private void OnActiveBattleView()
	{
		this.ResetDelayPush();
	}

	// Token: 0x0601795D RID: 96605 RVA: 0x00600190 File Offset: 0x005FE390
	private void OnDestroyAllUiCameraAnimationHandles()
	{
		this.ResetDelayPush();
		UiCameraAnimationManager.Instance.ClearDisplay();
		CameraController.Instance.ExitCameraMode(ECustomCameraMode.Widget, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
	}

	// Token: 0x0601795E RID: 96606 RVA: 0x006001C0 File Offset: 0x005FE3C0
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null)
		{
			return;
		}
		if (handle.Id != getCurrentEntity.Id)
		{
			return;
		}
		UiCameraAnimationManager.Instance.DeactivateCurrentCameraHandle();
	}

	// Token: 0x0601795F RID: 96607 RVA: 0x006001F8 File Offset: 0x005FE3F8
	private void OnAddEntity(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null)
		{
			return;
		}
		if (handle.Id != getCurrentEntity.Id)
		{
			return;
		}
		Log.Instance.Info(ELogModule.CameraAnimation, ELogAuthor.BB, "当玩家角色添加实体时,重新激活镜头状态", default(ReadOnlySpan<ValueTuple<string, object>>));
		UiCameraAnimationManager.Instance.ReactivateCameraHandle(false, false);
	}

	// Token: 0x06017960 RID: 96608 RVA: 0x0060024C File Offset: 0x005FE44C
	private void OnRoleSystemChangeRole()
	{
		Log.Instance.Info(ELogModule.CameraAnimation, ELogAuthor.BB, "当角色系统切换角色时,尝试重新激活镜头状态", default(ReadOnlySpan<ValueTuple<string, object>>));
		UiCameraAnimationManager.Instance.ReactivateCameraHandle(false, false);
	}

	// Token: 0x06017961 RID: 96609 RVA: 0x00600284 File Offset: 0x005FE484
	private void OnRoleMorphTypeChanged()
	{
		Log.Instance.Info(ELogModule.CameraAnimation, ELogAuthor.LRC, "当角色形态改变时,尝试重新激活镜头状态", default(ReadOnlySpan<ValueTuple<string, object>>));
		UiCameraAnimationManager.Instance.ReactivateCameraHandle(false, false);
	}

	// Token: 0x06017962 RID: 96610 RVA: 0x006002BC File Offset: 0x005FE4BC
	private void OnUiSceneLoaded()
	{
		Log.Instance.Info(ELogModule.CameraAnimation, ELogAuthor.BB, "当Ui场景加载完成时,尝试重新激活镜头状态", default(ReadOnlySpan<ValueTuple<string, object>>));
		UiCameraAnimationManager.Instance.ReactivateCameraHandle(false, false);
	}

	// Token: 0x17001FC6 RID: 8134
	// (get) Token: 0x06017963 RID: 96611 RVA: 0x006002F1 File Offset: 0x005FE4F1
	public static UiCameraAnimationController Instance
	{
		get
		{
			return UiCameraAnimationController._Instance;
		}
	}

	// Token: 0x06017964 RID: 96612 RVA: 0x006002F8 File Offset: 0x005FE4F8
	public static UiCameraAnimationController GetOrCreateInstance()
	{
		if (UiCameraAnimationController._Instance == null)
		{
			UiCameraAnimationController.CreateInstance();
		}
		return UiCameraAnimationController._Instance;
	}

	// Token: 0x06017965 RID: 96613 RVA: 0x0060030C File Offset: 0x005FE50C
	public static bool CreateInstance()
	{
		if (UiCameraAnimationController._Instance != null)
		{
			return true;
		}
		UiCameraAnimationController._Instance = new UiCameraAnimationController();
		return true;
	}

	// Token: 0x06017966 RID: 96614 RVA: 0x00600322 File Offset: 0x005FE522
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017967 RID: 96615 RVA: 0x00600324 File Offset: 0x005FE524
	public static void ResetStaticDefaultValue()
	{
		UiCameraAnimationController._Instance = null;
	}

	// Token: 0x06017968 RID: 96616 RVA: 0x0060032C File Offset: 0x005FE52C
	static UiCameraAnimationController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiCameraAnimationController.CreateStaticDefaultValue), new Action(UiCameraAnimationController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AFEB RID: 45035
	[Nullable(2)]
	private string DelayViewName = "";

	// Token: 0x0400AFEC RID: 45036
	private int? DelayViewId;

	// Token: 0x0400AFED RID: 45037
	[Nullable(2)]
	private TimerHandle DelayPushCameraHandleTimerId;

	// Token: 0x0400AFEE RID: 45038
	[Nullable(2)]
	private static UiCameraAnimationController _Instance;
}
