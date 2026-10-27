using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Capability;
using CSharpScript.Game.LevelGamePlay.OperationRestrict;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.LevelplayCapability
{
	// Token: 0x02006C33 RID: 27699
	public class DragActorPlayCapability : Capability
	{
		// Token: 0x060444B2 RID: 279730 RVA: 0x010D3288 File Offset: 0x010D1488
		[NullableContext(2)]
		public DragActorPlayCapability(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x060444B3 RID: 279731 RVA: 0x010D3291 File Offset: 0x010D1491
		public override void Setup()
		{
		}

		// Token: 0x060444B4 RID: 279732 RVA: 0x010D3293 File Offset: 0x010D1493
		public override void PreTick(float deltaMilliseconds)
		{
		}

		// Token: 0x060444B5 RID: 279733 RVA: 0x010D3295 File Offset: 0x010D1495
		public override void TickActive(float deltaMilliseconds)
		{
		}

		// Token: 0x060444B6 RID: 279734 RVA: 0x010D3297 File Offset: 0x010D1497
		public override bool ShouldActivate()
		{
			ICapabilityGameObject ownerGameObject = this.OwnerGameObject;
			DragActorPlayCameraConfigDataComponent dragActorPlayCameraConfigDataComponent = (ownerGameObject != null) ? ownerGameObject.GetCapabilityData<DragActorPlayCameraConfigDataComponent>(typeof(DragActorPlayCameraConfigDataComponent)) : null;
			return ((dragActorPlayCameraConfigDataComponent != null) ? dragActorPlayCameraConfigDataComponent.CameraConfig : null) != null;
		}

		// Token: 0x060444B7 RID: 279735 RVA: 0x010D32C4 File Offset: 0x010D14C4
		public override bool ShouldDeactivate()
		{
			return false;
		}

		// Token: 0x060444B8 RID: 279736 RVA: 0x010D32C8 File Offset: 0x010D14C8
		public unsafe override void OnActivated()
		{
			ICapabilityGameObject ownerGameObject = this.OwnerGameObject;
			DragActorPlayCameraConfigDataComponent dragActorPlayCameraConfigDataComponent = (ownerGameObject != null) ? ownerGameObject.GetCapabilityData<DragActorPlayCameraConfigDataComponent>(typeof(DragActorPlayCameraConfigDataComponent)) : null;
			if (((dragActorPlayCameraConfigDataComponent != null) ? dragActorPlayCameraConfigDataComponent.CameraConfig : null) == null)
			{
				global::Log.Instance.Error(ELogModule.Capability, ELogAuthor.XDW, "[DragActorPlayCapability] OnActivated: CameraConfig 未注入，跳过", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel("MainCamera");
			SceneCameraPlayerComponent sceneCameraPlayerComponent;
			if (separateCameraModel == null)
			{
				sceneCameraPlayerComponent = null;
			}
			else
			{
				SceneCamera sceneCamera = separateCameraModel.SceneCamera;
				sceneCameraPlayerComponent = ((sceneCamera != null) ? sceneCamera.PlayerComponent : null);
			}
			SceneCameraPlayerComponent sceneCameraPlayerComponent2 = sceneCameraPlayerComponent;
			if (sceneCameraPlayerComponent2 == null)
			{
				global::Log.Instance.Error(ELogModule.Capability, ELogAuthor.XDW, "[DragActorPlayCapability] OnActivated: SceneCamera.PlayerComponent 不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Vector vector = Vector.Create();
			vector.Set((double)dragActorPlayCameraConfigDataComponent.CameraConfig.CenterPos.X.GetValueOrDefault(), (double)dragActorPlayCameraConfigDataComponent.CameraConfig.CenterPos.Y.GetValueOrDefault(), (double)dragActorPlayCameraConfigDataComponent.CameraConfig.CenterPos.Z.GetValueOrDefault());
			Rotator rotator = Rotator.Create();
			rotator.Set(dragActorPlayCameraConfigDataComponent.CameraConfig.CenterRot.Y.GetValueOrDefault(), dragActorPlayCameraConfigDataComponent.CameraConfig.CenterRot.Z.GetValueOrDefault(), dragActorPlayCameraConfigDataComponent.CameraConfig.CenterRot.X.GetValueOrDefault());
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Capability;
			ELogAuthor author = ELogAuthor.XDW;
			string message = "[DragActorPlayCapability] EnterFixSceneSubCamera";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Fov", dragActorPlayCameraConfigDataComponent.CameraConfig.Fov);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FadeIn", dragActorPlayCameraConfigDataComponent.CameraConfig.FadeInTime);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			OperationRestrictUtils.Instance.SetOperationRestrictByOption(new IDisableAllPlayerOperation
			{
				Type = EPlayerOperationType.DisableAll
			});
			sceneCameraPlayerComponent2.EnterFixSceneSubCamera(vector, rotator, dragActorPlayCameraConfigDataComponent.CameraConfig.Fov, dragActorPlayCameraConfigDataComponent.CameraConfig.FadeInTime, dragActorPlayCameraConfigDataComponent.CameraConfig.FadeOutTime, ESceneSubCameraType.Fix, delegate
			{
				OperationRestrictUtils.Instance.SetOperationRestrictByOption(new IEnableAllPlayerOperation
				{
					Type = EPlayerOperationType.EnableAll
				});
				if (base.GetState() != CapabilityCommonDefine.ECapabilityState.Active)
				{
					global::Log.Instance.Error(ELogModule.Capability, ELogAuthor.XDW, "[DragActorPlayCapability] Camera Entered, 但状态不是 Active，跳过", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				SplineConstrainedDragController.Instance.OpenSplineConstrainedDragView();
				global::Log.Instance.Info(ELogModule.Capability, ELogAuthor.XDW, "[DragActorPlayCapability] Camera Entered, OpenSplineConstrainedDragView", default(ReadOnlySpan<ValueTuple<string, object>>));
			}, new UnrealEngine.EViewTargetBlendFunction?(UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear), new float?(0f), new UnrealEngine.EViewTargetBlendFunction?(UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear), new float?(0f), new bool?(false), null, new bool?(false), null, "DragActorPlayCapability.OnActivated", null, null, null, false, true);
		}

		// Token: 0x060444B9 RID: 279737 RVA: 0x010D3518 File Offset: 0x010D1718
		public override void OnDeactivated()
		{
			SplineConstrainedDragController.Instance.CloseSplineConstrainedDragView();
			CameraController instance = CameraController.Instance;
			FightCameraLogicComponent fightCameraLogicComponent;
			if (instance == null)
			{
				fightCameraLogicComponent = null;
			}
			else
			{
				CameraModelInstance mainModel = instance.MainModel;
				if (mainModel == null)
				{
					fightCameraLogicComponent = null;
				}
				else
				{
					FightCamera fightCamera = mainModel.FightCamera;
					fightCameraLogicComponent = ((fightCamera != null) ? fightCamera.LogicComponent : null);
				}
			}
			FightCameraLogicComponent fightCameraLogicComponent2 = fightCameraLogicComponent;
			if (fightCameraLogicComponent2 != null)
			{
				ICapabilityGameObject ownerGameObject = this.OwnerGameObject;
				DragActorPlayCameraConfigDataComponent dragActorPlayCameraConfigDataComponent = (ownerGameObject != null) ? ownerGameObject.GetCapabilityData<DragActorPlayCameraConfigDataComponent>(typeof(DragActorPlayCameraConfigDataComponent)) : null;
				float? num;
				if (dragActorPlayCameraConfigDataComponent == null)
				{
					num = null;
				}
				else
				{
					IFixedCameraConfig cameraConfig = dragActorPlayCameraConfigDataComponent.CameraConfig;
					num = ((cameraConfig != null) ? new float?(cameraConfig.FadeOutTime) : null);
				}
				float? fadeInTime = num;
				fightCameraLogicComponent2.RestoreCameraFromAdjust(fadeInTime, null, true);
				return;
			}
			this.LogError("OnDeactivated", "FightCamera.LogicComponent 不存在");
		}

		// Token: 0x060444BA RID: 279738 RVA: 0x010D35C0 File Offset: 0x010D17C0
		[NullableContext(1)]
		private unsafe void LogError(string stage, object err)
		{
			Exception ex = err as Exception;
			if (ex != null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Capability;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[DragActorPlayCapability] 异常";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("stage", stage);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Capability;
			ELogAuthor author2 = ELogAuthor.XDW;
			string message2 = "[DragActorPlayCapability] 异常";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("stage", stage);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("error", err);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
	}
}
