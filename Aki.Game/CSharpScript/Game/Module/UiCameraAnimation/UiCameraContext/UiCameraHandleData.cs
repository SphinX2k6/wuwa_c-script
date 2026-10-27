using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext
{
	// Token: 0x02004A0F RID: 18959
	[NullableContext(2)]
	[Nullable(0)]
	public class UiCameraHandleData
	{
		// Token: 0x06031330 RID: 201520 RVA: 0x00B68EDC File Offset: 0x00B670DC
		[NullableContext(1)]
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 3);
			defaultInterpolatedStringHandler.AppendLiteral("UniqueId:");
			defaultInterpolatedStringHandler.AppendFormatted<int?>(this.UniqueIdInternal);
			defaultInterpolatedStringHandler.AppendLiteral(",HandleName:");
			defaultInterpolatedStringHandler.AppendFormatted(this.HandleNameInternal);
			defaultInterpolatedStringHandler.AppendLiteral(",ViewName:");
			defaultInterpolatedStringHandler.AppendFormatted(this.ViewNameInternal);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06031331 RID: 201521 RVA: 0x00B68F48 File Offset: 0x00B67148
		[NullableContext(1)]
		public static UiCameraHandleData NewByHandleName(string handleName, FTransformDouble? externalTransformInternal = null)
		{
			int uniqueId = UiCameraAnimationManager.Instance.GenerateHandleDataUniqueId();
			UiCameraHandleData uiCameraHandleData = new UiCameraHandleData();
			uiCameraHandleData.UniqueId = uniqueId;
			uiCameraHandleData.HandleName = handleName;
			if (externalTransformInternal != null && externalTransformInternal.Value.IsValid())
			{
				uiCameraHandleData.ExternalTransformInternal = externalTransformInternal;
			}
			uiCameraHandleData.Refresh();
			return uiCameraHandleData;
		}

		// Token: 0x06031332 RID: 201522 RVA: 0x00B68F9C File Offset: 0x00B6719C
		[NullableContext(1)]
		[return: Nullable(2)]
		public static UiCameraHandleData NewByView(string viewName, int? viewId = null, FTransformDouble? externalTransformInternal = null)
		{
			UiCameraMappingData cameraMappingData = UiCameraAnimationManager.Instance.GetCameraMappingData(viewName);
			if (cameraMappingData == null)
			{
				return null;
			}
			UiCameraHandleData uiCameraHandleData = new UiCameraHandleData();
			uiCameraHandleData.UniqueId = ((viewId != null && viewId.Value != 0) ? viewId.Value : UiCameraAnimationManager.Instance.GenerateHandleDataUniqueId());
			uiCameraHandleData.HandleName = cameraMappingData.GetSourceHandleName();
			uiCameraHandleData.ViewName = viewName;
			uiCameraHandleData.UiCameraMappingConfig = cameraMappingData.GetUiCameraMappingConfig();
			uiCameraHandleData.ExternalTransformInternal = externalTransformInternal;
			uiCameraHandleData.Refresh();
			return uiCameraHandleData;
		}

		// Token: 0x06031333 RID: 201523 RVA: 0x00B69018 File Offset: 0x00B67218
		public void Reset()
		{
			this.UniqueIdInternal = null;
			this.ViewNameInternal = null;
			this.OwnerViewNameInternal = null;
			this.UiCameraMappingConfigInternal = null;
			this.HandleNameInternal = string.Empty;
			this.TrackTargetLocation = null;
			this.UiCameraAnimationSettingMap.Clear();
			this.ReplaceCameraActor = null;
			this.ReplaceCameraComponent = null;
			this.TargetActor = null;
			this.TargetActorSkeletalMesh = null;
			this.CameraActorArray.Clear();
			this.UiCameraAnimationSettingsConfig = null;
		}

		// Token: 0x06031334 RID: 201524 RVA: 0x00B69098 File Offset: 0x00B67298
		public void Refresh()
		{
			this.UiCameraAnimationSettingsConfig = UiCameraAnimationConfig.Instance.GetUiCameraAnimationConfig(this.HandleName);
			if (this.UiCameraAnimationSettingsConfig == null)
			{
				return;
			}
			TEnumAsByte<EUiCameraAnimationTargetType> targetType = this.UiCameraAnimationSettingsConfig.TargetType;
			this.IsEmptyState = this.UiCameraAnimationSettingsConfig.IsEmptyState;
			this.TargetActor = UiCameraAnimationManager.Instance.GetTargetActor(targetType, this.UiCameraAnimationSettingsConfig);
			this.TargetActorSkeletalMesh = UiCameraAnimationManager.Instance.GetTargetActorSkeletalMesh(targetType, this.UiCameraAnimationSettingsConfig);
			this.ReplaceCameraTag = this.UiCameraAnimationSettingsConfig.ReplaceCameraTag;
			this.ReplaceCameraActor = this.GetCameraActorByTag(this.ReplaceCameraTag);
			ACineCameraActor replaceCameraActor = this.ReplaceCameraActor;
			this.ReplaceCameraComponent = ((replaceCameraActor != null) ? replaceCameraActor.GetCineCameraComponent() : null);
		}

		// Token: 0x170079F2 RID: 31218
		// (get) Token: 0x06031336 RID: 201526 RVA: 0x00B69168 File Offset: 0x00B67368
		// (set) Token: 0x06031335 RID: 201525 RVA: 0x00B6915A File Offset: 0x00B6735A
		public int UniqueId
		{
			get
			{
				return this.UniqueIdInternal.GetValueOrDefault();
			}
			set
			{
				this.UniqueIdInternal = new int?(value);
			}
		}

		// Token: 0x170079F3 RID: 31219
		// (get) Token: 0x06031338 RID: 201528 RVA: 0x00B6917E File Offset: 0x00B6737E
		// (set) Token: 0x06031337 RID: 201527 RVA: 0x00B69175 File Offset: 0x00B67375
		[Nullable(1)]
		public string HandleName
		{
			[NullableContext(1)]
			get
			{
				return this.HandleNameInternal;
			}
			[NullableContext(1)]
			set
			{
				this.HandleNameInternal = value;
			}
		}

		// Token: 0x170079F4 RID: 31220
		// (get) Token: 0x0603133A RID: 201530 RVA: 0x00B6918F File Offset: 0x00B6738F
		// (set) Token: 0x06031339 RID: 201529 RVA: 0x00B69186 File Offset: 0x00B67386
		public string ViewName
		{
			get
			{
				return this.ViewNameInternal;
			}
			set
			{
				this.ViewNameInternal = value;
			}
		}

		// Token: 0x170079F5 RID: 31221
		// (get) Token: 0x0603133C RID: 201532 RVA: 0x00B691A0 File Offset: 0x00B673A0
		// (set) Token: 0x0603133B RID: 201531 RVA: 0x00B69197 File Offset: 0x00B67397
		public string OwnerViewName
		{
			get
			{
				return this.OwnerViewNameInternal ?? this.ViewNameInternal;
			}
			set
			{
				this.OwnerViewNameInternal = value;
			}
		}

		// Token: 0x170079F6 RID: 31222
		// (get) Token: 0x0603133E RID: 201534 RVA: 0x00B691BB File Offset: 0x00B673BB
		// (set) Token: 0x0603133D RID: 201533 RVA: 0x00B691B2 File Offset: 0x00B673B2
		public UiCameraAnimationDefine.IUiCameraMapping UiCameraMappingConfig
		{
			get
			{
				return this.UiCameraMappingConfigInternal;
			}
			set
			{
				this.UiCameraMappingConfigInternal = value;
			}
		}

		// Token: 0x170079F7 RID: 31223
		// (get) Token: 0x0603133F RID: 201535 RVA: 0x00B691C3 File Offset: 0x00B673C3
		// (set) Token: 0x06031340 RID: 201536 RVA: 0x00B691CC File Offset: 0x00B673CC
		public FTransformDouble? ExternalTransform
		{
			get
			{
				return this.ExternalTransformInternal;
			}
			set
			{
				this.ExternalTransformInternal = ((value != null && value.Value.IsValid()) ? value : null);
			}
		}

		// Token: 0x06031341 RID: 201537 RVA: 0x00B69205 File Offset: 0x00B67405
		[NullableContext(1)]
		public string GetHandleName()
		{
			return this.HandleNameInternal;
		}

		// Token: 0x06031342 RID: 201538 RVA: 0x00B69210 File Offset: 0x00B67410
		[NullableContext(1)]
		public bool IsEqual(UiCameraHandleData checkHandleData)
		{
			return this.HandleName == checkHandleData.HandleName && this.ReplaceCameraTag == checkHandleData.ReplaceCameraTag && this.ViewName == checkHandleData.ViewName && this.UniqueId == checkHandleData.UniqueId;
		}

		// Token: 0x06031343 RID: 201539 RVA: 0x00B69266 File Offset: 0x00B67466
		public SUiCameraAnimationSettings GetUiCameraAnimationConfig()
		{
			return this.UiCameraAnimationSettingsConfig;
		}

		// Token: 0x06031344 RID: 201540 RVA: 0x00B6926E File Offset: 0x00B6746E
		public AActor GetTargetActor()
		{
			return this.TargetActor;
		}

		// Token: 0x06031345 RID: 201541 RVA: 0x00B69276 File Offset: 0x00B67476
		public USkeletalMeshComponent GetTargetSkeletalMesh()
		{
			return this.TargetActorSkeletalMesh;
		}

		// Token: 0x06031346 RID: 201542 RVA: 0x00B69280 File Offset: 0x00B67480
		public FTransformDouble? GetTargetSkeletalMeshTransform()
		{
			USkeletalMeshComponent targetSkeletalMesh = this.GetTargetSkeletalMesh();
			if (targetSkeletalMesh == null)
			{
				return null;
			}
			FVectorDouble fvectorDouble = targetSkeletalMesh.D_K2_GetComponentLocation();
			this.TargetActorTransformCache.SetLocation(fvectorDouble);
			FQuat fquat = targetSkeletalMesh.K2_GetComponentQuaternion();
			this.TargetActorTransformCache.SetRotation(fquat);
			FVectorDouble fvectorDouble2 = targetSkeletalMesh.D_K2_GetComponentScale();
			this.TargetActorTransformCache.SetScale3D(fvectorDouble2);
			return new FTransformDouble?(this.TargetActorTransformCache);
		}

		// Token: 0x06031347 RID: 201543 RVA: 0x00B692EC File Offset: 0x00B674EC
		public FTransformDouble? GetTargetSkeletalMeshSocketTransform()
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName(this.GetUiCameraAnimationConfig().SocketName);
			USkeletalMeshComponent targetSkeletalMesh = this.GetTargetSkeletalMesh();
			if (targetSkeletalMesh == null)
			{
				return null;
			}
			return new FTransformDouble?(targetSkeletalMesh.D_GetSocketTransform(dynamicFName ?? FNameUtil.EMPTY, ERelativeTransformSpace.RTS_World));
		}

		// Token: 0x06031348 RID: 201544 RVA: 0x00B69344 File Offset: 0x00B67544
		public float GetTargetArmLength()
		{
			if (CameraModel.Instance.MainModel.GetSavedSeqCameraThings() != null)
			{
				return 0f;
			}
			ACineCameraActor replaceCameraActor = this.ReplaceCameraActor;
			if (replaceCameraActor == null || !replaceCameraActor.IsValid())
			{
				return this.GetUiCameraAnimationConfig().ArmLength;
			}
			AActor targetActor = this.GetTargetActor();
			if (targetActor != null && targetActor.IsValid() && this.UiCameraAnimationSettingsConfig.bTargetActorAsCenter)
			{
				Vector v = Vector.Create(targetActor.D_K2_GetActorLocation());
				Vector v2 = Vector.Create(this.ReplaceCameraActor.D_K2_GetActorLocation());
				return (float)Vector.Dist2D(v, v2);
			}
			return 0f;
		}

		// Token: 0x06031349 RID: 201545 RVA: 0x00B693DC File Offset: 0x00B675DC
		public FVectorDouble GetTargetArmOffsetLocation()
		{
			if (CameraModel.Instance.MainModel.GetSavedSeqCameraThings() != null)
			{
				return Vector.ZeroVectorDouble;
			}
			UCineCameraComponent replaceCameraComponent = this.ReplaceCameraComponent;
			if (replaceCameraComponent != null && replaceCameraComponent.IsValid())
			{
				return Vector.ZeroVectorDouble;
			}
			FVector armOffsetLocation = this.GetUiCameraAnimationConfig().ArmOffsetLocation;
			return new FVectorDouble(ref armOffsetLocation);
		}

		// Token: 0x0603134A RID: 201546 RVA: 0x00B69430 File Offset: 0x00B67630
		public FRotator GetTargetArmOffsetRotation()
		{
			if (CameraModel.Instance.MainModel.GetSavedSeqCameraThings() != null)
			{
				return Rotator.ZeroRotator;
			}
			if (this.ReplaceCameraActor != null && this.UiCameraAnimationSettingsConfig.bTargetActorAsCenter)
			{
				AActor targetActor = this.GetTargetActor();
				if (targetActor != null)
				{
					FVectorDouble targetCameraAnimationLocation = this.GetTargetCameraAnimationLocation(targetActor.D_K2_GetActorLocation(), this.ReplaceCameraActor.D_K2_GetActorLocation(), this.ReplaceCameraActor.K2_GetActorRotation());
					FVectorDouble fvectorDouble = this.ReplaceCameraActor.D_K2_GetActorLocation();
					return UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble, targetCameraAnimationLocation);
				}
			}
			return this.GetUiCameraAnimationConfig().ArmOffsetRotation;
		}

		// Token: 0x0603134B RID: 201547 RVA: 0x00B694B7 File Offset: 0x00B676B7
		public bool GetTargetArmCollisionTest()
		{
			if (CameraModel.Instance.MainModel.GetSavedSeqCameraThings() != null)
			{
				return false;
			}
			ACineCameraActor replaceCameraActor = this.ReplaceCameraActor;
			return (replaceCameraActor == null || !replaceCameraActor.IsValid()) && this.GetUiCameraAnimationConfig().ArmCollisionTest;
		}

		// Token: 0x0603134C RID: 201548 RVA: 0x00B694F0 File Offset: 0x00B676F0
		public float GetTargetFieldOfView()
		{
			SeqCameraThings savedSeqCameraThings = CameraModel.Instance.MainModel.GetSavedSeqCameraThings();
			if (savedSeqCameraThings != null)
			{
				return savedSeqCameraThings.FieldOfView;
			}
			UCineCameraComponent replaceCameraComponent = this.ReplaceCameraComponent;
			if (replaceCameraComponent == null || !replaceCameraComponent.IsValid())
			{
				return this.GetUiCameraAnimationConfig().CameraFieldOfView;
			}
			if (this.UiCameraAnimationSettingsConfig.IsDynamicFov)
			{
				return this.GetDynamicFieldOfView(this.ReplaceCameraComponent.FieldOfView, this.ReplaceCameraComponent.AspectRatio);
			}
			return this.ReplaceCameraComponent.FieldOfView;
		}

		// Token: 0x0603134D RID: 201549 RVA: 0x00B6956C File Offset: 0x00B6776C
		private float GetDynamicFieldOfView(float fov, float aspectRatio)
		{
			Vector2D viewportSize = UiLayer.Instance.GetViewportSize();
			float num = MathCommon.DegreeToRadian(fov);
			float num2 = (float)(viewportSize.X / viewportSize.Y);
			return MathF.Max(MathCommon.RadianToDegree(MathF.Atan(aspectRatio / num2 * MathF.Tan(num / 2f)) * 2f), fov);
		}

		// Token: 0x0603134E RID: 201550 RVA: 0x00B695C0 File Offset: 0x00B677C0
		public float GetTargetFocalDistance()
		{
			SeqCameraThings savedSeqCameraThings = CameraModel.Instance.MainModel.GetSavedSeqCameraThings();
			if (savedSeqCameraThings != null)
			{
				return savedSeqCameraThings.FocusSettings.ManualFocusDistance;
			}
			UCineCameraComponent replaceCameraComponent = this.ReplaceCameraComponent;
			if (replaceCameraComponent != null && replaceCameraComponent.IsValid())
			{
				return this.ReplaceCameraComponent.FocusSettings.ManualFocusDistance;
			}
			return this.GetUiCameraAnimationConfig().FocalDistance;
		}

		// Token: 0x0603134F RID: 201551 RVA: 0x00B6961C File Offset: 0x00B6781C
		public float GetTargetAperture()
		{
			SeqCameraThings savedSeqCameraThings = CameraModel.Instance.MainModel.GetSavedSeqCameraThings();
			if (savedSeqCameraThings != null)
			{
				return savedSeqCameraThings.CurrentAperture;
			}
			UCineCameraComponent replaceCameraComponent = this.ReplaceCameraComponent;
			if (replaceCameraComponent != null && replaceCameraComponent.IsValid())
			{
				return this.ReplaceCameraComponent.CurrentAperture;
			}
			return this.GetUiCameraAnimationConfig().Aperture;
		}

		// Token: 0x06031350 RID: 201552 RVA: 0x00B69670 File Offset: 0x00B67870
		public float GetTargetFocalRegion()
		{
			if (CameraModel.Instance.MainModel.GetSavedSeqCameraThings() != null)
			{
				return 0f;
			}
			UCineCameraComponent replaceCameraComponent = this.ReplaceCameraComponent;
			if (replaceCameraComponent != null && replaceCameraComponent.IsValid())
			{
				return this.ReplaceCameraComponent.CurrentFocalRegion;
			}
			return this.GetUiCameraAnimationConfig().FocalRegion;
		}

		// Token: 0x06031351 RID: 201553 RVA: 0x00B696C0 File Offset: 0x00B678C0
		public FVectorDouble? GetDefaultLocation()
		{
			if (this.ExternalTransform != null)
			{
				return new FVectorDouble?(this.ExternalTransform.Value.GetLocation());
			}
			SUiCameraAnimationSettings uiCameraAnimationConfig = this.GetUiCameraAnimationConfig();
			TEnumAsByte<EUiCameraAnimationTargetType> targetType = uiCameraAnimationConfig.TargetType;
			if (targetType != EUiCameraAnimationTargetType.UiSceneRole && targetType != EUiCameraAnimationTargetType.UiSceneSkeletal && targetType != EUiCameraAnimationTargetType.UiVisionHandBook)
			{
				return new FVectorDouble?(UKismetMathLibrary.Conv_VectorToVectorDouble(uiCameraAnimationConfig.Location));
			}
			if (RenderModuleController.Instance.DebugInUiSceneRendering)
			{
				return new FVectorDouble?(new FVectorDouble
				{
					X = (double)uiCameraAnimationConfig.Location.X + RenderModuleController.Instance.DebugUiSceneLoadOffset.Value.X,
					Y = (double)uiCameraAnimationConfig.Location.Y + RenderModuleController.Instance.DebugUiSceneLoadOffset.Value.Y,
					Z = (double)uiCameraAnimationConfig.Location.Z + RenderModuleController.Instance.DebugUiSceneLoadOffset.Value.Z
				});
			}
			return new FVectorDouble?(UKismetMathLibrary.Conv_VectorToVectorDouble(uiCameraAnimationConfig.Location));
		}

		// Token: 0x06031352 RID: 201554 RVA: 0x00B697E8 File Offset: 0x00B679E8
		private FVectorDouble GetTargetCameraAnimationLocation(FVectorDouble targetActorSourceLocation, FVectorDouble targetCameraLocation, FRotator targetCameraRotation)
		{
			this.TargetActorSourceLocation = targetActorSourceLocation;
			this.TargetCameraLocation = targetCameraLocation;
			float num = FVector.Dist2D(this.TargetActorSourceLocation, this.TargetCameraLocation);
			float x = MathCommon.DegreeToRadian(MathCommon.WrapAngle(targetCameraRotation.Pitch));
			float z = num * MathF.Tan(x) + this.TargetCameraLocation.Z;
			this.TargetCameraAnimationLocation.Set(this.TargetActorSourceLocation.X, this.TargetActorSourceLocation.Y, z);
			return this.TargetCameraAnimationLocation;
		}

		// Token: 0x06031353 RID: 201555 RVA: 0x00B69874 File Offset: 0x00B67A74
		public FVectorDouble? GetTargetLocation()
		{
			SeqCameraThings savedSeqCameraThings = CameraModel.Instance.MainModel.GetSavedSeqCameraThings();
			if (savedSeqCameraThings != null)
			{
				return new FVectorDouble?(savedSeqCameraThings.CameraLocation);
			}
			if (this.ExternalTransform != null)
			{
				FTransformDouble value = this.ExternalTransform.Value;
				return new FVectorDouble?(value.GetLocation());
			}
			EUiCameraAnimationLocationType euiCameraAnimationLocationType = this.UiCameraAnimationSettingsConfig.LocationType;
			SUiCameraAnimationSettings uiCameraAnimationSettingsConfig = this.UiCameraAnimationSettingsConfig;
			if (!StringUtils.IsEmpty((uiCameraAnimationSettingsConfig != null) ? uiCameraAnimationSettingsConfig.ReplaceCameraTag : null))
			{
				ACineCameraActor replaceCameraActor = this.ReplaceCameraActor;
				if (replaceCameraActor == null || !replaceCameraActor.IsValid())
				{
					return null;
				}
				AActor targetActor = this.GetTargetActor();
				if (targetActor != null && targetActor.IsValid() && this.UiCameraAnimationSettingsConfig.bTargetActorAsCenter)
				{
					return new FVectorDouble?(this.GetTargetCameraAnimationLocation(targetActor.D_K2_GetActorLocation(), this.ReplaceCameraActor.D_K2_GetActorLocation(), this.ReplaceCameraActor.K2_GetActorRotation()));
				}
				return new FVectorDouble?(this.ReplaceCameraActor.D_K2_GetActorLocation());
			}
			else
			{
				FVectorDouble? defaultLocation = this.GetDefaultLocation();
				switch (euiCameraAnimationLocationType)
				{
				case EUiCameraAnimationLocationType.WorldLocation:
					return defaultLocation;
				case EUiCameraAnimationLocationType.TargetLocation:
				{
					FTransformDouble? targetSkeletalMeshTransform = this.GetTargetSkeletalMeshTransform();
					if (targetSkeletalMeshTransform == null)
					{
						Log.Instance.Error(ELogModule.CameraAnimation, ELogAuthor.BB, "播放Ui镜头获得对应相机位置时，拿不到对应的Actor骨骼，不播放镜头动画", default(ReadOnlySpan<ValueTuple<string, object>>));
						return null;
					}
					USkeletalMeshComponent targetSkeletalMesh = this.GetTargetSkeletalMesh();
					AActor aactor = (targetSkeletalMesh != null) ? targetSkeletalMesh.GetOwner() : null;
					if (aactor == null || !aactor.IsValid())
					{
						return null;
					}
					FVectorDouble fvectorDouble = aactor.D_K2_GetActorLocation();
					FVectorDouble fvectorDouble2 = targetSkeletalMesh.D_K2_GetComponentLocation();
					if (fvectorDouble.Equals(fvectorDouble2, 1E-08))
					{
						return defaultLocation;
					}
					FTransformDouble value = targetSkeletalMeshTransform.Value;
					return new FVectorDouble?(UKismetMathLibrary.D_TransformLocation(value, defaultLocation ?? defaultLocation.Value));
				}
				case EUiCameraAnimationLocationType.SocketLocation:
				{
					FTransformDouble? targetSkeletalMeshSocketTransform = this.GetTargetSkeletalMeshSocketTransform();
					if (targetSkeletalMeshSocketTransform == null)
					{
						Log.Instance.Error(ELogModule.CameraAnimation, ELogAuthor.BB, "播放Ui镜头获得对应相机位置时，拿不到对应的Actor骨骼，不播放镜头动画", default(ReadOnlySpan<ValueTuple<string, object>>));
						return null;
					}
					FTransformDouble value = targetSkeletalMeshSocketTransform.Value;
					return new FVectorDouble?(UKismetMathLibrary.D_TransformLocation(value, defaultLocation.Value));
				}
				default:
					return null;
				}
			}
		}

		// Token: 0x06031354 RID: 201556 RVA: 0x00B69ABC File Offset: 0x00B67CBC
		public FRotator? GetDefaultRotation()
		{
			FTransformDouble? externalTransform = this.ExternalTransform;
			if (externalTransform != null)
			{
				return new FRotator?(externalTransform.Value.GetRotation().Rotator());
			}
			SUiCameraAnimationSettings uiCameraAnimationConfig = this.GetUiCameraAnimationConfig();
			ACineCameraActor replaceCameraActor = this.ReplaceCameraActor;
			if (replaceCameraActor != null && replaceCameraActor.IsValid())
			{
				return new FRotator?(this.ReplaceCameraActor.K2_GetActorRotation());
			}
			if (!uiCameraAnimationConfig.IsTrack)
			{
				return new FRotator?(uiCameraAnimationConfig.Rotation);
			}
			Vector cameraLocation = CameraController.Instance.MainModel.CameraLocation;
			FVector fvector;
			if (uiCameraAnimationConfig.IsTrackWorldLocation)
			{
				FVector trackLocation = uiCameraAnimationConfig.TrackLocation;
				fvector = cameraLocation.ToUeVectorOld();
				FRotator value = UKismetMathLibrary.FindLookAtRotation(fvector, trackLocation);
				if (uiCameraAnimationConfig.bOverrideTrackPitch)
				{
					value.Pitch = uiCameraAnimationConfig.TrackPitchOverride;
				}
				return new FRotator?(value);
			}
			AActor targetActor = this.GetTargetActor();
			if (targetActor == null)
			{
				return new FRotator?(uiCameraAnimationConfig.Rotation);
			}
			if (this.TrackTargetLocation == null)
			{
				return null;
			}
			FVector trackLocation2 = uiCameraAnimationConfig.TrackLocation;
			FVectorDouble fvectorDouble = targetActor.D_K2_GetActorLocation();
			if (this.TrackTargetLocation != null)
			{
				fvector = this.TrackTargetLocation.GetValueOrDefault();
				fvector.Set(Convert.ToSingle(fvectorDouble.X + (double)trackLocation2.X), Convert.ToSingle(fvectorDouble.Y + (double)trackLocation2.Y), Convert.ToSingle(fvectorDouble.Z + (double)trackLocation2.Z));
			}
			fvector = cameraLocation.ToUeVectorOld();
			FVector value2 = this.TrackTargetLocation.Value;
			FRotator value3 = UKismetMathLibrary.FindLookAtRotation(fvector, value2);
			if (uiCameraAnimationConfig.bOverrideTrackPitch)
			{
				value3.Pitch = uiCameraAnimationConfig.TrackPitchOverride;
			}
			return new FRotator?(value3);
		}

		// Token: 0x06031355 RID: 201557 RVA: 0x00B69C60 File Offset: 0x00B67E60
		public FRotator? GetTargetRotation()
		{
			SeqCameraThings savedSeqCameraThings = CameraModel.Instance.MainModel.GetSavedSeqCameraThings();
			if (savedSeqCameraThings != null)
			{
				return new FRotator?(savedSeqCameraThings.CameraRotation);
			}
			FTransformDouble? externalTransform = this.ExternalTransform;
			if (externalTransform != null)
			{
				return new FRotator?(externalTransform.Value.GetRotation().Rotator());
			}
			SUiCameraAnimationSettings uiCameraAnimationSettingsConfig = this.UiCameraAnimationSettingsConfig;
			if (!StringUtils.IsEmpty((uiCameraAnimationSettingsConfig != null) ? uiCameraAnimationSettingsConfig.ReplaceCameraTag : null))
			{
				ACineCameraActor replaceCameraActor = this.ReplaceCameraActor;
				if (replaceCameraActor == null || !replaceCameraActor.IsValid())
				{
					return null;
				}
				AActor targetActor = this.GetTargetActor();
				if (targetActor != null && targetActor.IsValid() && this.UiCameraAnimationSettingsConfig.bTargetActorAsCenter)
				{
					return new FRotator?(Rotator.ZeroRotator);
				}
				return new FRotator?(this.ReplaceCameraActor.K2_GetActorRotation());
			}
			else
			{
				FRotator? defaultRotation = this.GetDefaultRotation();
				switch (this.UiCameraAnimationSettingsConfig.RotationType)
				{
				case EUiCameraAnimationRotationType.WorldRotation:
					return defaultRotation;
				case EUiCameraAnimationRotationType.CurrentCameraRotation:
				{
					float yaw = CameraController.Instance.MainModel.FightCamera.GetComponent<FightCameraLogicComponent>().CameraRotationInGravity.Yaw;
					Rotator rotator = Rotator.Create(0f, yaw, 0f);
					CameraUtility.GetRotatorInNormal(rotator, rotator);
					return new FRotator?(rotator.ToUeRotator());
				}
				case EUiCameraAnimationRotationType.TargetRotation:
				{
					AActor targetActor2 = this.GetTargetActor();
					if (targetActor2 == null)
					{
						return defaultRotation;
					}
					FTransformDouble ftransformDouble = targetActor2.D_GetTransform();
					Rotator rotator2 = Rotator.Create(0f, defaultRotation.Value.Yaw, 0f);
					return new FRotator?(UKismetMathLibrary.D_TransformRotation(ftransformDouble, rotator2.ToUeRotator()));
				}
				case EUiCameraAnimationRotationType.TargetForwardRotation:
				{
					AActor targetActor3 = this.GetTargetActor();
					if (targetActor3 == null)
					{
						Log.Instance.Error(ELogModule.CameraAnimation, ELogAuthor.BB, "播放Ui镜头获得对应相机旋转时，拿不到对应的Actor，不播放镜头动画", default(ReadOnlySpan<ValueTuple<string, object>>));
						return null;
					}
					FTransformDouble ftransformDouble2 = targetActor3.D_GetTransform();
					USkeletalMeshComponent targetSkeletalMesh = this.GetTargetSkeletalMesh();
					if (targetSkeletalMesh == null)
					{
						Log.Instance.Error(ELogModule.CameraAnimation, ELogAuthor.BB, "播放Ui镜头获得对应相机旋转时，拿不到对应的Actor骨骼，不播放镜头动画", default(ReadOnlySpan<ValueTuple<string, object>>));
						return null;
					}
					FRotator relativeRotation = targetSkeletalMesh.RelativeRotation;
					Rotator rotator3 = Rotator.Create(relativeRotation.Pitch + defaultRotation.Value.Pitch, relativeRotation.Yaw + defaultRotation.Value.Yaw, relativeRotation.Roll + defaultRotation.Value.Roll);
					return new FRotator?(UKismetMathLibrary.D_TransformRotation(ftransformDouble2, rotator3.ToUeRotator()));
				}
				default:
					return null;
				}
			}
		}

		// Token: 0x06031356 RID: 201558 RVA: 0x00B69ECC File Offset: 0x00B680CC
		public float GetTargetPostProcessBlendWeight()
		{
			UCineCameraComponent replaceCameraComponent = this.ReplaceCameraComponent;
			if (replaceCameraComponent != null && replaceCameraComponent.IsValid())
			{
				return this.ReplaceCameraComponent.PostProcessBlendWeight;
			}
			return this.GetUiCameraAnimationConfig().PostProcessBlendWeight;
		}

		// Token: 0x06031357 RID: 201559 RVA: 0x00B69EFC File Offset: 0x00B680FC
		[NullableContext(1)]
		[return: Nullable(2)]
		private ACineCameraActor GetCameraActorByTag(string tag)
		{
			if (string.IsNullOrEmpty(tag))
			{
				return null;
			}
			FName? dynamicFName = FNameUtil.GetDynamicFName(this.ReplaceCameraTag);
			TArray<AActor> tarray = new TArray<AActor>();
			UGameplayStatics.GetAllActorsOfClassWithTag(GlobalData.World, ACineCameraActor.StaticClass(), dynamicFName.Value, ref tarray);
			if (tarray.Num() < 1)
			{
				return null;
			}
			return tarray.Get(0) as ACineCameraActor;
		}

		// Token: 0x06031358 RID: 201560 RVA: 0x00B69F59 File Offset: 0x00B68159
		public ACineCameraActor GetReplaceCameraActor()
		{
			return this.ReplaceCameraActor;
		}

		// Token: 0x06031359 RID: 201561 RVA: 0x00B69F64 File Offset: 0x00B68164
		public bool CanApplyAnimationHandle()
		{
			SUiCameraAnimationSettings uiCameraAnimationConfig = this.GetUiCameraAnimationConfig();
			TEnumAsByte<EUiCameraAnimationTargetType> targetType = uiCameraAnimationConfig.TargetType;
			FName? dynamicFName = FNameUtil.GetDynamicFName(uiCameraAnimationConfig.SocketName);
			bool flag = uiCameraAnimationConfig.LocationType == EUiCameraAnimationLocationType.SocketLocation;
			if (targetType == EUiCameraAnimationTargetType.Npc || targetType == EUiCameraAnimationTargetType.Player)
			{
				if (this.TargetActorSkeletalMesh == null)
				{
					return false;
				}
				if (flag)
				{
					if (FNameUtil.IsEmpty(dynamicFName))
					{
						return false;
					}
					if (!this.TargetActorSkeletalMesh.DoesSocketExist(dynamicFName.Value))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0401A4FE RID: 107774
		private int? UniqueIdInternal;

		// Token: 0x0401A4FF RID: 107775
		private string ViewNameInternal;

		// Token: 0x0401A500 RID: 107776
		private string OwnerViewNameInternal;

		// Token: 0x0401A501 RID: 107777
		private UiCameraAnimationDefine.IUiCameraMapping UiCameraMappingConfigInternal;

		// Token: 0x0401A502 RID: 107778
		private SUiCameraAnimationSettings UiCameraAnimationSettingsConfig;

		// Token: 0x0401A503 RID: 107779
		private FTransformDouble? ExternalTransformInternal;

		// Token: 0x0401A504 RID: 107780
		[Nullable(1)]
		private string HandleNameInternal = string.Empty;

		// Token: 0x0401A505 RID: 107781
		private FVector? TrackTargetLocation = new FVector?(new FVector());

		// Token: 0x0401A506 RID: 107782
		[Nullable(1)]
		private readonly Dictionary<string, SUiCameraAnimationSettings> UiCameraAnimationSettingMap = new Dictionary<string, SUiCameraAnimationSettings>();

		// Token: 0x0401A507 RID: 107783
		[Nullable(1)]
		private readonly TArray<AActor> CameraActorArray = new TArray<AActor>();

		// Token: 0x0401A508 RID: 107784
		private ACineCameraActor ReplaceCameraActor;

		// Token: 0x0401A509 RID: 107785
		private UCineCameraComponent ReplaceCameraComponent;

		// Token: 0x0401A50A RID: 107786
		private FTransformDouble TargetActorTransformCache = new FTransformDouble();

		// Token: 0x0401A50B RID: 107787
		private FVector TargetActorSourceLocation = new FVector();

		// Token: 0x0401A50C RID: 107788
		private FVector TargetCameraLocation = new FVector();

		// Token: 0x0401A50D RID: 107789
		private FVector TargetCameraAnimationLocation = new FVector();

		// Token: 0x0401A50E RID: 107790
		private AActor TargetActor;

		// Token: 0x0401A50F RID: 107791
		private USkeletalMeshComponent TargetActorSkeletalMesh;

		// Token: 0x0401A510 RID: 107792
		public bool IsEmptyState;

		// Token: 0x0401A511 RID: 107793
		[Nullable(1)]
		public string ReplaceCameraTag = string.Empty;
	}
}
