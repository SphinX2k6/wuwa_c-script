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
	// Token: 0x02005DAC RID: 23980
	public class DragActorPlayCapability : Capability
	{
		// Token: 0x0603A60A RID: 239114 RVA: 0x0107D1DC File Offset: 0x0107B3DC
		[NullableContext(2)]
		public DragActorPlayCapability(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x0603A60B RID: 239115 RVA: 0x0107D1E5 File Offset: 0x0107B3E5
		public override void Setup()
		{
		}

		// Token: 0x0603A60C RID: 239116 RVA: 0x0107D1E7 File Offset: 0x0107B3E7
		public override void PreTick(float deltaMilliseconds)
		{
		}

		// Token: 0x0603A60D RID: 239117 RVA: 0x0107D1E9 File Offset: 0x0107B3E9
		public override void TickActive(float deltaMilliseconds)
		{
		}

		// Token: 0x0603A60E RID: 239118 RVA: 0x0107D1EB File Offset: 0x0107B3EB
		public override bool ShouldActivate()
		{
			ICapabilityGameObject ownerGameObject = this.OwnerGameObject;
			DragActorPlayCameraConfigDataComponent dragActorPlayCameraConfigDataComponent = (ownerGameObject != null) ? ownerGameObject.GetCapabilityData<DragActorPlayCameraConfigDataComponent>(typeof(DragActorPlayCameraConfigDataComponent)) : null;
			return ((dragActorPlayCameraConfigDataComponent != null) ? dragActorPlayCameraConfigDataComponent.CameraConfig : null) != null;
		}

		// Token: 0x0603A60F RID: 239119 RVA: 0x0107D218 File Offset: 0x0107B418
		public override bool ShouldDeactivate()
		{
			return false;
		}

		// Token: 0x0603A610 RID: 239120 RVA: 0x0107D21C File Offset: 0x0107B41C
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

		// Token: 0x0603A611 RID: 239121 RVA: 0x0107D46C File Offset: 0x0107B66C
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

		// Token: 0x0603A612 RID: 239122 RVA: 0x0107D514 File Offset: 0x0107B714
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
