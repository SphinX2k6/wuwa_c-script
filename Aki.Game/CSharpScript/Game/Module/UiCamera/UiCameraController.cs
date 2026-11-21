using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039AC RID: 14764
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class UiCameraController : ControllerBase
	{
		// Token: 0x17004D98 RID: 19864
		// (get) Token: 0x06026063 RID: 155747 RVA: 0x00AAB7F6 File Offset: 0x00AA99F6
		private UiCameraModel Model
		{
			get
			{
				return UiCameraModel.Instance;
			}
		}

		// Token: 0x06026064 RID: 155748 RVA: 0x00AAB7FD File Offset: 0x00AA99FD
		protected override bool OnInit()
		{
			this.RegisterEvents();
			return true;
		}

		// Token: 0x06026065 RID: 155749 RVA: 0x00AAB806 File Offset: 0x00AA9A06
		protected override bool OnClear()
		{
			this.UnregisterEvents();
			this.Model.ClearDisplay();
			return true;
		}

		// Token: 0x06026066 RID: 155750 RVA: 0x00AAB81A File Offset: 0x00AA9A1A
		protected override bool OnLeaveLevel()
		{
			this.ResetDelayPush();
			this.Model.ClearDisplay();
			return true;
		}

		// Token: 0x06026067 RID: 155751 RVA: 0x00AAB830 File Offset: 0x00AA9A30
		public unsafe void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType = EUiCameraHandleOperationType.Blend)
		{
			if (operationType == EUiCameraHandleOperationType.Delete)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "PushCameraHandleByOpenView不支持Delete操作";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", viewName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewId", viewId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (viewName == UiModel.Instance.MainViewName)
			{
				if (this.Model.IsActivate())
				{
					this.Model.ClearDisplay();
				}
				return;
			}
			if (!this.Model.CanPushCameraHandle(viewName.ToString()))
			{
				return;
			}
			int uiCameraDelayTime = UiCameraConfig.Instance.GetUiCameraDelayTime(viewName.ToString());
			if (uiCameraDelayTime > 0 && operationType == EUiCameraHandleOperationType.Blend)
			{
				this.DelayPush((float)uiCameraDelayTime, viewName.ToString(), new int?(viewId), null);
				return;
			}
			this.ResetDelayPush();
			this.Model.PushCameraHandleByOpenView(viewName, viewId, operationType);
		}

		// Token: 0x06026068 RID: 155752 RVA: 0x00AAB940 File Offset: 0x00AA9B40
		public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType = EUiCameraHandleOperationType.Blend)
		{
			this.ResetDelayPush();
			UiCameraConfig instance = UiCameraConfig.Instance;
			string blendName = (instance != null) ? instance.GetBlendName(viewName.ToString(), (nextViewName != null) ? nextViewName.GetValueOrDefault().ToString() : null) : null;
			this.Model.PopCameraHandleByCloseView(closeViewId, operationType, blendName);
		}

		// Token: 0x06026069 RID: 155753 RVA: 0x00AAB9A4 File Offset: 0x00AA9BA4
		public void EnterUiCameraMode()
		{
			if (!this.Model.RestoreCameraHandle())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "恢复Ui相机模式时没有可激活的镜头状态，保持当前相机模式";
				string item = "CurrentHandleData";
				UiCameraHandleData currentHandle = this.Model.CurrentHandle;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (currentHandle != null) ? currentHandle.ToString() : null);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0602606A RID: 155754 RVA: 0x00AAB9FB File Offset: 0x00AA9BFB
		public void ExitUiCameraMode()
		{
			UiCamera camera = this.Model.Camera;
			if (camera == null)
			{
				return;
			}
			camera.Exit(0f, EViewTargetBlendFunction.VTBlend_Linear, 0f);
		}

		// Token: 0x0602606B RID: 155755 RVA: 0x00AABA1D File Offset: 0x00AA9C1D
		public void DeepCopyCamera(ACameraActor cameraActor)
		{
			UiCamera orCreateCamera = this.Model.GetOrCreateCamera();
			orCreateCamera.SetWorldLocation(cameraActor.D_K2_GetActorLocation());
			orCreateCamera.SetWorldRotation(cameraActor.K2_GetActorRotation());
		}

		// Token: 0x0602606C RID: 155756 RVA: 0x00AABA44 File Offset: 0x00AA9C44
		private void RegisterEvents()
		{
			EventSystem.Instance.Add<EUiTabViewName?, UiTabViewBase>(EEventName.OpenTabView, new Action<EUiTabViewName?, UiTabViewBase>(this.OnOpenTabView));
			EventSystem.Instance.Add<EUiViewName>(EEventName.OnViewLoadCompleted, new Action<EUiViewName>(this.OnViewLoadCompleted));
			EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
			EventSystem.Instance.Add(EEventName.ResetModuleAfterResetToBattleView, new Action(this.OnResetToBattleView));
			EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
			EventSystem.Instance.Add(EEventName.DestroyAllUiCameraAnimationHandles, new Action(this.OnDestroyAllHandles));
			EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			EventSystem.Instance.Add<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
			EventSystem.Instance.Add(EEventName.OnSelectedRoleChanged, new Action(this.OnTargetChanged));
			EventSystem.Instance.Add(EEventName.OnRoleMorphTypeChanged, new Action(this.OnTargetChanged));
			EventSystem.Instance.Add(EEventName.OnUiScenePostLoaded, new Action(this.OnTargetChanged));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x0602606D RID: 155757 RVA: 0x00AABB98 File Offset: 0x00AA9D98
		private void UnregisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.OpenTabView, new Action<EUiTabViewName?, UiTabViewBase>(this.OnOpenTabView));
			EventSystem.Instance.Remove(EEventName.OnViewLoadCompleted, new Action<EUiViewName>(this.OnViewLoadCompleted));
			EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
			EventSystem.Instance.Remove(EEventName.ResetModuleAfterResetToBattleView, new Action(this.OnResetToBattleView));
			EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
			EventSystem.Instance.Remove(EEventName.DestroyAllUiCameraAnimationHandles, new Action(this.OnDestroyAllHandles));
			EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			EventSystem.Instance.Remove(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
			EventSystem.Instance.Remove(EEventName.OnSelectedRoleChanged, new Action(this.OnTargetChanged));
			EventSystem.Instance.Remove(EEventName.OnRoleMorphTypeChanged, new Action(this.OnTargetChanged));
			EventSystem.Instance.Remove(EEventName.OnUiScenePostLoaded, new Action(this.OnTargetChanged));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			this.ResetDelayPush();
		}

		// Token: 0x0602606E RID: 155758 RVA: 0x00AABCF4 File Offset: 0x00AA9EF4
		private void OnOpenTabView(EUiTabViewName? tabViewName, UiTabViewBase view)
		{
			if (tabViewName == null)
			{
				return;
			}
			string text = tabViewName.Value.ToString();
			if (!this.Model.CanPushCameraHandle(text))
			{
				return;
			}
			int uiCameraDelayTime = UiCameraConfig.Instance.GetUiCameraDelayTime(text);
			if (uiCameraDelayTime > 0)
			{
				float delayTime = (float)uiCameraDelayTime;
				string viewName = text;
				EUiTabViewName? tabViewName2 = new EUiTabViewName?(tabViewName.Value);
				this.DelayPush(delayTime, viewName, null, tabViewName2);
				return;
			}
			this.ResetDelayPush();
			this.Model.PushCameraHandleByOpenTab(tabViewName.Value, true);
		}

		// Token: 0x0602606F RID: 155759 RVA: 0x00AABD80 File Offset: 0x00AA9F80
		private void OnViewLoadCompleted(EUiViewName viewName)
		{
			UiCameraHandleData currentHandle = this.Model.CurrentHandle;
			if (((currentHandle != null) ? currentHandle.GetViewName() : null) == viewName.ToString() && this.Model.IsLoadingCameraEffectActive())
			{
				this.Model.ReactivateCameraHandle();
			}
		}

		// Token: 0x06026070 RID: 155760 RVA: 0x00AABDD1 File Offset: 0x00AA9FD1
		private void OnBeforeLoadMap()
		{
			this.ResetDelayPush();
			this.Model.ClearDisplay();
		}

		// Token: 0x06026071 RID: 155761 RVA: 0x00AABDE4 File Offset: 0x00AA9FE4
		private void OnActiveBattleView()
		{
			this.ResetDelayPush();
		}

		// Token: 0x06026072 RID: 155762 RVA: 0x00AABDEC File Offset: 0x00AA9FEC
		private void OnResetToBattleView()
		{
			this.ResetDelayPush();
			this.Model.ClearDisplay();
			CameraController.Instance.ExitCameraMode(ECustomCameraMode.Widget, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
		}

		// Token: 0x06026073 RID: 155763 RVA: 0x00AABE1D File Offset: 0x00AAA01D
		private void OnDestroyAllHandles()
		{
			this.OnResetToBattleView();
		}

		// Token: 0x06026074 RID: 155764 RVA: 0x00AABE28 File Offset: 0x00AAA028
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			int? num = (getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null;
			int id = handle.Id;
			if (num.GetValueOrDefault() == id & num != null)
			{
				UiCamera camera = this.Model.Camera;
				UiCameraNormalMode uiCameraNormalMode = (camera != null) ? camera.GetMode<UiCameraNormalMode>() : null;
				if (uiCameraNormalMode == null)
				{
					return;
				}
				uiCameraNormalMode.SetActive(false);
			}
		}

		// Token: 0x06026075 RID: 155765 RVA: 0x00AABE98 File Offset: 0x00AAA098
		private void OnAddEntity(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			int? num = (getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null;
			int id = handle.Id;
			if (num.GetValueOrDefault() == id & num != null)
			{
				this.Model.ReactivateCameraHandle();
			}
		}

		// Token: 0x06026076 RID: 155766 RVA: 0x00AABEF0 File Offset: 0x00AAA0F0
		private void OnTargetChanged()
		{
			this.Model.ReactivateCameraHandle();
		}

		// Token: 0x06026077 RID: 155767 RVA: 0x00AABEFE File Offset: 0x00AAA0FE
		private void OnWorldDone()
		{
			this.Model.ReactivateCameraHandle();
		}

		// Token: 0x06026078 RID: 155768 RVA: 0x00AABF0C File Offset: 0x00AAA10C
		private void DelayPush(float delayTime, string viewName, int? viewId = null, EUiTabViewName? tabViewName = null)
		{
			this.ResetDelayPush();
			this.DelayViewName = viewName;
			this.DelayViewId = viewId;
			this.DelayTabViewName = tabViewName;
			this.DelayPushTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.OnDelayPushFinished), delayTime, null, null, true, 1f);
		}

		// Token: 0x06026079 RID: 155769 RVA: 0x00AABF5C File Offset: 0x00AAA15C
		private void OnDelayPushFinished(float deltaTime)
		{
			string delayViewName = this.DelayViewName;
			int? delayViewId = this.DelayViewId;
			EUiTabViewName? delayTabViewName = this.DelayTabViewName;
			this.ResetDelayPush();
			if (!string.IsNullOrEmpty(delayViewName))
			{
				if (delayTabViewName != null)
				{
					this.Model.PushCameraHandleByOpenTab(delayTabViewName.Value, true);
					return;
				}
				if (delayViewId != null)
				{
					this.Model.PushCameraHandleByOpenView(delayViewName, delayViewId.Value, EUiCameraHandleOperationType.Blend);
				}
			}
		}

		// Token: 0x0602607A RID: 155770 RVA: 0x00AABFC8 File Offset: 0x00AAA1C8
		private void ResetDelayPush()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.DelayPushTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayPushTimer);
			}
			this.DelayPushTimer = null;
			this.DelayViewName = null;
			this.DelayViewId = null;
			this.DelayTabViewName = null;
		}

		// Token: 0x17004D99 RID: 19865
		// (get) Token: 0x0602607B RID: 155771 RVA: 0x00AAC01E File Offset: 0x00AAA21E
		public static UiCameraController Instance
		{
			get
			{
				return UiCameraController._Instance;
			}
		}

		// Token: 0x0602607C RID: 155772 RVA: 0x00AAC025 File Offset: 0x00AAA225
		public static UiCameraController GetOrCreateInstance()
		{
			if (UiCameraController._Instance == null)
			{
				UiCameraController.CreateInstance();
			}
			return UiCameraController._Instance;
		}

		// Token: 0x0602607D RID: 155773 RVA: 0x00AAC039 File Offset: 0x00AAA239
		public static bool CreateInstance()
		{
			if (UiCameraController._Instance != null)
			{
				return true;
			}
			UiCameraController._Instance = new UiCameraController();
			return true;
		}

		// Token: 0x0602607E RID: 155774 RVA: 0x00AAC04F File Offset: 0x00AAA24F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602607F RID: 155775 RVA: 0x00AAC051 File Offset: 0x00AAA251
		public static void ResetStaticDefaultValue()
		{
			UiCameraController._Instance = null;
		}

		// Token: 0x06026080 RID: 155776 RVA: 0x00AAC059 File Offset: 0x00AAA259
		static UiCameraController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiCameraController.CreateStaticDefaultValue), new Action(UiCameraController.ResetStaticDefaultValue));
		}

		// Token: 0x04014E39 RID: 85561
		[Nullable(2)]
		private string DelayViewName;

		// Token: 0x04014E3A RID: 85562
		private int? DelayViewId;

		// Token: 0x04014E3B RID: 85563
		private EUiTabViewName? DelayTabViewName;

		// Token: 0x04014E3C RID: 85564
		[Nullable(2)]
		private TimerHandle DelayPushTimer;

		// Token: 0x04014E3D RID: 85565
		[Nullable(2)]
		private static UiCameraController _Instance;
	}
}
