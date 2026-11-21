using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.UI.NewModule.UiCameraAnimation;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x0200398D RID: 14733
	[NullableContext(2)]
	[Nullable(0)]
	public class UiCameraDisplayComponent : UiCameraComponent
	{
		// Token: 0x06025EB6 RID: 155318 RVA: 0x00AA575A File Offset: 0x00AA395A
		protected override void OnInitialize()
		{
			if (base.Mode is UiCameraNormalMode)
			{
				this.SpawnDisplayActor();
			}
		}

		// Token: 0x06025EB7 RID: 155319 RVA: 0x00AA576F File Offset: 0x00AA396F
		protected override void OnEnterMode()
		{
			if (base.Mode is UiCameraNormalMode)
			{
				this.SpawnDisplayActor();
				this.AttachCamera();
			}
			this.MarkDirty();
		}

		// Token: 0x06025EB8 RID: 155320 RVA: 0x00AA5790 File Offset: 0x00AA3990
		protected override void OnExitMode()
		{
			if (base.Mode is UiCameraNormalMode)
			{
				this.DetachCamera();
			}
		}

		// Token: 0x06025EB9 RID: 155321 RVA: 0x00AA57A8 File Offset: 0x00AA39A8
		[NullableContext(1)]
		public unsafe override void Apply(UiCameraHandleData data)
		{
			if (base.Mode is UiCameraNormalMode)
			{
				this.AttachCamera();
			}
			this.ClearOverrides();
			this.MarkDirty();
			this.ApplyCameraState();
			UCineCameraComponent cineCameraComponent = base.Owner.CineCameraComponent;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCamera;
			ELogAuthor author = ELogAuthor.BB;
			string message = "应用Ui相机输出参数";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleData", data.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetFieldOfView", data.GetTargetFieldOfView());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("OutputFieldOfView", (cineCameraComponent != null) ? new float?(cineCameraComponent.FieldOfView) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("OutputFocalLength", (cineCameraComponent != null) ? new float?(cineCameraComponent.CurrentFocalLength) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("TargetAperture", data.GetTargetAperture());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("OutputAperture", (cineCameraComponent != null) ? new float?(cineCameraComponent.CurrentAperture) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("CameraOutputTakenOver", this.IsCameraOutputTakenOver());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
		}

		// Token: 0x06025EBA RID: 155322 RVA: 0x00AA592C File Offset: 0x00AA3B2C
		public override void Tick(float deltaTime)
		{
			UiCameraBlendComponent uiCameraBlendComponent = base.Mode.TryGetComponent<UiCameraBlendComponent>();
			bool flag = uiCameraBlendComponent != null && this.AppliedOutputVersion != uiCameraBlendComponent.GetOutputVersion();
			if (!this.OutputDirty && !flag)
			{
				return;
			}
			this.ApplyCameraState();
		}

		// Token: 0x06025EBB RID: 155323 RVA: 0x00AA5970 File Offset: 0x00AA3B70
		public void SetWorldLocation(FVectorDouble location)
		{
			BP_UiCameraAnimation_C displayActor = this.DisplayActor;
			if (displayActor == null || !displayActor.IsValid())
			{
				return;
			}
			FHitResult fhitResult = new FHitResult();
			this.DisplayActor.D_K2_SetActorLocation(location, false, ref fhitResult, false);
		}

		// Token: 0x06025EBC RID: 155324 RVA: 0x00AA59AC File Offset: 0x00AA3BAC
		public void SetWorldRotation(FRotator rotation)
		{
			BP_UiCameraAnimation_C displayActor = this.DisplayActor;
			if (displayActor == null)
			{
				return;
			}
			displayActor.K2_SetActorRotation(rotation, false);
		}

		// Token: 0x06025EBD RID: 155325 RVA: 0x00AA59C1 File Offset: 0x00AA3BC1
		public void SetCameraFocusMethod(ECameraFocusMethod focusMethod)
		{
			if (base.Owner.CineCameraComponent != null)
			{
				base.Owner.CineCameraComponent.FocusSettings.FocusMethod = focusMethod;
			}
		}

		// Token: 0x06025EBE RID: 155326 RVA: 0x00AA59E6 File Offset: 0x00AA3BE6
		public void SetCameraFocalDistance(float distance)
		{
			this.ManualFocalDistance = new float?(distance);
			this.MarkDirty();
			this.ApplyCameraState();
		}

		// Token: 0x06025EBF RID: 155327 RVA: 0x00AA5A00 File Offset: 0x00AA3C00
		public void SetCameraFieldOfView(float fieldOfView)
		{
			this.ManualFieldOfView = new float?(fieldOfView);
			this.MarkDirty();
			this.ApplyCameraState();
		}

		// Token: 0x06025EC0 RID: 155328 RVA: 0x00AA5A1A File Offset: 0x00AA3C1A
		public void SetCameraCurrentFocalLength(float currentFocalLength)
		{
			if (base.Owner.CineCameraComponent != null)
			{
				base.Owner.CineCameraComponent.CurrentFocalLength = currentFocalLength;
			}
		}

		// Token: 0x06025EC1 RID: 155329 RVA: 0x00AA5A3A File Offset: 0x00AA3C3A
		public void SetCameraAperture(float aperture)
		{
			this.ManualAperture = new float?(aperture);
			this.MarkDirty();
			this.ApplyCameraState();
		}

		// Token: 0x06025EC2 RID: 155330 RVA: 0x00AA5A54 File Offset: 0x00AA3C54
		public void SetCameraFocalRegion(float focalRegion)
		{
			this.ManualFocalRegion = new float?(focalRegion);
			this.MarkDirty();
			this.ApplyCameraState();
		}

		// Token: 0x06025EC3 RID: 155331 RVA: 0x00AA5A6E File Offset: 0x00AA3C6E
		public void SetCameraPostProcessBlendWeight(float weight)
		{
			this.ManualPostProcessBlendWeight = new float?(weight);
			this.MarkDirty();
			this.ApplyCameraState();
		}

		// Token: 0x06025EC4 RID: 155332 RVA: 0x00AA5A88 File Offset: 0x00AA3C88
		public float GetManualFocusDistance()
		{
			UCineCameraComponent cineCameraComponent = base.Owner.CineCameraComponent;
			if (cineCameraComponent == null)
			{
				return 0f;
			}
			return cineCameraComponent.FocusSettings.ManualFocusDistance;
		}

		// Token: 0x06025EC5 RID: 155333 RVA: 0x00AA5AA9 File Offset: 0x00AA3CA9
		public float GetCurrentAperture()
		{
			UCineCameraComponent cineCameraComponent = base.Owner.CineCameraComponent;
			if (cineCameraComponent == null)
			{
				return 0f;
			}
			return cineCameraComponent.CurrentAperture;
		}

		// Token: 0x06025EC6 RID: 155334 RVA: 0x00AA5AC8 File Offset: 0x00AA3CC8
		internal bool RestoreCameraState()
		{
			UiCameraBlendComponent uiCameraBlendComponent = base.Mode.TryGetComponent<UiCameraBlendComponent>();
			BP_UiCameraAnimation_C displayActor = this.DisplayActor;
			if (displayActor != null && displayActor.IsValid())
			{
				USpringArmComponent springArm = this.SpringArm;
				if (springArm != null && springArm.IsValid())
				{
					UCameraComponent camera = this.DisplayActor.Camera;
					if (camera != null && camera.IsValid())
					{
						BP_CineCamera_C cameraActor = base.Owner.CameraActor;
						if (cameraActor != null && cameraActor.IsValid())
						{
							UCineCameraComponent cineCameraComponent = base.Owner.CineCameraComponent;
							if (cineCameraComponent != null && cineCameraComponent.IsValid() && uiCameraBlendComponent != null && uiCameraBlendComponent.GetOutputVersion() != 0)
							{
								this.MarkDirty();
								this.ApplyCameraState();
								this.AttachCamera();
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06025EC7 RID: 155335 RVA: 0x00AA5B83 File Offset: 0x00AA3D83
		public void AttachCameraAfterSequence()
		{
			this.AttachCamera();
			this.MarkDirty();
			this.ApplyCameraState();
		}

		// Token: 0x06025EC8 RID: 155336 RVA: 0x00AA5B97 File Offset: 0x00AA3D97
		public void DetachCameraForSequence()
		{
			this.DetachCamera();
			this.MarkDirty();
		}

		// Token: 0x06025EC9 RID: 155337 RVA: 0x00AA5BA5 File Offset: 0x00AA3DA5
		internal void SetLoadingEffect(float focalDistance, float aperture)
		{
			this.LoadingFocalDistance = new float?(focalDistance);
			this.LoadingAperture = new float?(aperture);
			this.MarkDirty();
			this.ApplyCameraState();
		}

		// Token: 0x06025ECA RID: 155338 RVA: 0x00AA5BCB File Offset: 0x00AA3DCB
		internal void ClearLoadingEffect()
		{
			this.LoadingFocalDistance = null;
			this.LoadingAperture = null;
			this.MarkDirty();
			this.ApplyCameraState();
		}

		// Token: 0x06025ECB RID: 155339 RVA: 0x00AA5BF4 File Offset: 0x00AA3DF4
		public override void Clear()
		{
			this.DetachCamera();
			BP_UiCameraAnimation_C displayActor = this.DisplayActor;
			if (displayActor != null && displayActor.IsValid())
			{
				ActorSystem.Instance.Put("UiCameraDisplayComponent.Clear", this.DisplayActor, null);
			}
			this.DisplayActor = null;
			this.SpringArm = null;
			this.ClearOverrides();
			this.AppliedOutputVersion = -1;
			this.OutputDirty = true;
		}

		// Token: 0x06025ECC RID: 155340 RVA: 0x00AA5C54 File Offset: 0x00AA3E54
		private void MarkDirty()
		{
			this.OutputDirty = true;
		}

		// Token: 0x06025ECD RID: 155341 RVA: 0x00AA5C60 File Offset: 0x00AA3E60
		private void ApplyCameraState()
		{
			if (this.IsCameraOutputTakenOver())
			{
				return;
			}
			UiCameraBlendComponent uiCameraBlendComponent = base.Mode.TryGetComponent<UiCameraBlendComponent>();
			if (base.Mode is UiCameraNormalMode)
			{
				BP_UiCameraAnimation_C displayActor = this.DisplayActor;
				if (displayActor != null && displayActor.IsValid())
				{
					USpringArmComponent springArm = this.SpringArm;
					if (springArm != null && springArm.IsValid() && uiCameraBlendComponent != null)
					{
						this.ApplyTransform(uiCameraBlendComponent);
						goto IL_5B;
					}
				}
				return;
			}
			IL_5B:
			this.ApplyPostEffect(uiCameraBlendComponent);
			this.AppliedOutputVersion = ((uiCameraBlendComponent != null) ? uiCameraBlendComponent.GetOutputVersion() : -1);
			this.OutputDirty = false;
		}

		// Token: 0x06025ECE RID: 155342 RVA: 0x00AA5CE8 File Offset: 0x00AA3EE8
		[NullableContext(1)]
		private void ApplyTransform(UiCameraBlendComponent blend)
		{
			this.SetWorldLocation(blend.CurrentLocation);
			this.SetWorldRotation(blend.CurrentRotation);
			this.SpringArm.TargetArmLength = blend.CurrentArmLength;
			this.SpringArm.bDoCollisionTest = blend.CurrentArmCollisionTest;
			FHitResult fhitResult = new FHitResult();
			this.SpringArm.D_K2_SetRelativeLocation(blend.CurrentArmOffsetLocation, false, ref fhitResult, false);
			this.SpringArm.K2_SetRelativeRotation(blend.CurrentArmOffsetRotation, false, ref fhitResult, false);
		}

		// Token: 0x06025ECF RID: 155343 RVA: 0x00AA5D60 File Offset: 0x00AA3F60
		private void ApplyPostEffect(UiCameraBlendComponent blend)
		{
			float? num = this.ManualFieldOfView;
			float? num2 = (num != null) ? num : ((blend != null) ? new float?(blend.CurrentFieldOfView) : null);
			num = this.LoadingFocalDistance;
			float? num4;
			if (num == null)
			{
				float? num3 = this.ManualFocalDistance;
				num4 = ((num3 != null) ? num3 : ((blend != null) ? new float?(blend.CurrentFocalDistance) : null));
			}
			else
			{
				num4 = num;
			}
			float? num5 = num4;
			num = this.LoadingAperture;
			float? num6;
			if (num == null)
			{
				float? num3 = this.ManualAperture;
				num6 = ((num3 != null) ? num3 : ((blend != null) ? new float?(blend.CurrentAperture) : null));
			}
			else
			{
				num6 = num;
			}
			float? num7 = num6;
			num = this.ManualFocalRegion;
			float? num8 = (num != null) ? num : ((blend != null) ? new float?(blend.CurrentFocalRegion) : null);
			num = this.ManualPostProcessBlendWeight;
			float? num9 = (num != null) ? num : ((blend != null) ? new float?(blend.CurrentPostProcessBlendWeight) : null);
			if (num2 != null)
			{
				UCineCameraComponent cineCameraComponent = base.Owner.CineCameraComponent;
				if (cineCameraComponent != null)
				{
					cineCameraComponent.SetFieldOfView(num2.Value);
				}
			}
			if (num5 != null && base.Owner.CineCameraComponent != null)
			{
				base.Owner.CineCameraComponent.FocusSettings.ManualFocusDistance = num5.Value;
			}
			if (num7 != null && base.Owner.CineCameraComponent != null)
			{
				base.Owner.CineCameraComponent.CurrentAperture = num7.Value;
			}
			if (num8 != null && base.Owner.CineCameraComponent != null)
			{
				base.Owner.CineCameraComponent.CurrentFocalRegion = num8.Value;
			}
			if (num9 != null)
			{
				UCineCameraComponent cineCameraComponent2 = base.Owner.CineCameraComponent;
				if (cineCameraComponent2 == null)
				{
					return;
				}
				cineCameraComponent2.SetPostProcessBlendWeight(num9.Value);
			}
		}

		// Token: 0x06025ED0 RID: 155344 RVA: 0x00AA5F5F File Offset: 0x00AA415F
		private bool IsCameraOutputTakenOver()
		{
			UiCameraNormalMode uiCameraNormalMode = base.Mode as UiCameraNormalMode;
			return uiCameraNormalMode != null && uiCameraNormalMode.IsCameraOutputTakenOverBySequence();
		}

		// Token: 0x06025ED1 RID: 155345 RVA: 0x00AA5F78 File Offset: 0x00AA4178
		private void ClearOverrides()
		{
			this.ManualFieldOfView = null;
			this.ManualFocalDistance = null;
			this.ManualAperture = null;
			this.ManualFocalRegion = null;
			this.ManualPostProcessBlendWeight = null;
			this.LoadingFocalDistance = null;
			this.LoadingAperture = null;
		}

		// Token: 0x06025ED2 RID: 155346 RVA: 0x00AA5FDC File Offset: 0x00AA41DC
		private void SpawnDisplayActor()
		{
			BP_UiCameraAnimation_C displayActor = this.DisplayActor;
			if (displayActor != null && displayActor.IsValid())
			{
				return;
			}
			FQuat fquat = new FQuat(0f, 0f, 0f, 1f);
			FVector fvector = new FVector(1f, 1f, 1f);
			FTransform ftransform = new FTransform(ref fquat, ref FVector.ZeroVector, ref fvector);
			this.DisplayActor = (UGameplayStatics.BeginDeferredActorSpawnFromClass(GlobalData.World, BP_UiCameraAnimation_C.StaticClass(), ftransform, ESpawnActorCollisionHandlingMethod.Undefined, null) as BP_UiCameraAnimation_C);
			if (this.DisplayActor == null)
			{
				return;
			}
			this.DisplayActor.SetTickableWhenPaused(true);
			UGameplayStatics.FinishSpawningActor(this.DisplayActor, ftransform);
			this.SpringArm = this.DisplayActor.SpringArm;
			USpringArmComponent springArm = this.SpringArm;
			if (springArm != null)
			{
				springArm.SetTickableWhenPaused(true);
			}
			UCameraComponent camera = this.DisplayActor.Camera;
			if (camera == null)
			{
				return;
			}
			camera.SetTickableWhenPaused(true);
		}

		// Token: 0x06025ED3 RID: 155347 RVA: 0x00AA60BC File Offset: 0x00AA42BC
		private void AttachCamera()
		{
			BP_CineCamera_C cameraActor = base.Owner.CameraActor;
			if (cameraActor != null && cameraActor.IsValid())
			{
				BP_UiCameraAnimation_C displayActor = this.DisplayActor;
				bool flag;
				if (displayActor == null)
				{
					flag = true;
				}
				else
				{
					UCameraComponent camera = displayActor.Camera;
					flag = !((camera != null) ? new bool?(camera.IsValid()) : null).GetValueOrDefault();
				}
				if (!flag)
				{
					base.Owner.CameraActor.K2_AttachToComponent(this.DisplayActor.Camera, FNameUtil.NONE, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, false, true);
					return;
				}
			}
		}

		// Token: 0x06025ED4 RID: 155348 RVA: 0x00AA6143 File Offset: 0x00AA4343
		private void DetachCamera()
		{
			BP_CineCamera_C cameraActor = base.Owner.CameraActor;
			if (cameraActor == null)
			{
				return;
			}
			cameraActor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		}

		// Token: 0x04014DAE RID: 85422
		private BP_UiCameraAnimation_C DisplayActor;

		// Token: 0x04014DAF RID: 85423
		private USpringArmComponent SpringArm;

		// Token: 0x04014DB0 RID: 85424
		private float? ManualFieldOfView;

		// Token: 0x04014DB1 RID: 85425
		private float? ManualFocalDistance;

		// Token: 0x04014DB2 RID: 85426
		private float? ManualAperture;

		// Token: 0x04014DB3 RID: 85427
		private float? ManualFocalRegion;

		// Token: 0x04014DB4 RID: 85428
		private float? ManualPostProcessBlendWeight;

		// Token: 0x04014DB5 RID: 85429
		private float? LoadingFocalDistance;

		// Token: 0x04014DB6 RID: 85430
		private float? LoadingAperture;

		// Token: 0x04014DB7 RID: 85431
		private int AppliedOutputVersion = -1;

		// Token: 0x04014DB8 RID: 85432
		private bool OutputDirty = true;
	}
}
