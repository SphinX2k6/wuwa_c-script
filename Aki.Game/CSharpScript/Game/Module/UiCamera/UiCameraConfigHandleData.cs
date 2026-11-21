using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x02003995 RID: 14741
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraConfigHandleData : UiCameraHandleData
	{
		// Token: 0x06025F57 RID: 155479 RVA: 0x00AA7A88 File Offset: 0x00AA5C88
		public override bool Refresh(UiCameraModel model)
		{
			if (!base.RefreshConfigData(model))
			{
				return false;
			}
			this.RefreshCommonCameraData(base.CameraSettings);
			FVectorDouble? fvectorDouble = this.CalculateTargetLocation(base.CameraSettings);
			FRotator? frotator = this.CalculateTargetRotation(base.CameraSettings);
			if (fvectorDouble == null || frotator == null)
			{
				return false;
			}
			base.Location = fvectorDouble.Value;
			base.Rotation = frotator.Value;
			return true;
		}

		// Token: 0x06025F58 RID: 155480 RVA: 0x00AA7AF8 File Offset: 0x00AA5CF8
		protected void RefreshCommonCameraData(SUiCameraAnimationSettings settings)
		{
			base.ArmLength = settings.ArmLength;
			FVector armOffsetLocation = settings.ArmOffsetLocation;
			base.ArmOffsetLocation = new FVectorDouble(ref armOffsetLocation);
			base.ArmOffsetRotation = settings.ArmOffsetRotation;
			base.ArmCollisionTest = settings.ArmCollisionTest;
			base.FieldOfView = settings.CameraFieldOfView;
			base.FocalDistance = settings.FocalDistance;
			base.Aperture = settings.Aperture;
			base.FocalRegion = settings.FocalRegion;
			base.PostProcessBlendWeight = settings.PostProcessBlendWeight;
		}

		// Token: 0x06025F59 RID: 155481 RVA: 0x00AA7B7C File Offset: 0x00AA5D7C
		protected virtual FVectorDouble? CalculateTargetLocation(SUiCameraAnimationSettings settings)
		{
			FVectorDouble fvectorDouble = this.CalculateDefaultLocation(settings);
			switch (settings.LocationType)
			{
			case EUiCameraAnimationLocationType.WorldLocation:
				return new FVectorDouble?(fvectorDouble);
			case EUiCameraAnimationLocationType.TargetLocation:
			{
				USkeletalMeshComponent targetSkeletalMesh = base.GetTargetSkeletalMesh();
				FTransformDouble? targetSkeletalMeshTransform = this.GetTargetSkeletalMeshTransform();
				AActor aactor = (targetSkeletalMesh != null) ? targetSkeletalMesh.GetOwner() : null;
				if (targetSkeletalMesh == null || !targetSkeletalMesh.IsValid() || targetSkeletalMeshTransform == null || (aactor == null || !aactor.IsValid()))
				{
					return null;
				}
				FVectorDouble fvectorDouble2 = aactor.D_K2_GetActorLocation();
				FVectorDouble fvectorDouble3 = targetSkeletalMesh.D_K2_GetComponentLocation();
				if (fvectorDouble2.Equals(fvectorDouble3, 1E-08))
				{
					return new FVectorDouble?(fvectorDouble);
				}
				FTransformDouble value = targetSkeletalMeshTransform.Value;
				return new FVectorDouble?(UKismetMathLibrary.D_TransformLocation(value, fvectorDouble));
			}
			case EUiCameraAnimationLocationType.SocketLocation:
			{
				FTransformDouble? targetSkeletalMeshSocketTransform = this.GetTargetSkeletalMeshSocketTransform(settings.SocketName);
				if (targetSkeletalMeshSocketTransform == null)
				{
					return null;
				}
				FTransformDouble value = targetSkeletalMeshSocketTransform.Value;
				return new FVectorDouble?(UKismetMathLibrary.D_TransformLocation(value, fvectorDouble));
			}
			default:
				return null;
			}
		}

		// Token: 0x06025F5A RID: 155482 RVA: 0x00AA7C98 File Offset: 0x00AA5E98
		protected virtual FRotator? CalculateTargetRotation(SUiCameraAnimationSettings settings)
		{
			FRotator? result = this.CalculateDefaultRotation(settings);
			if (result == null)
			{
				return null;
			}
			switch (settings.RotationType)
			{
			case EUiCameraAnimationRotationType.WorldRotation:
				return result;
			case EUiCameraAnimationRotationType.CurrentCameraRotation:
			{
				FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
				FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.GetComponent<FightCameraLogicComponent>() : null;
				if (fightCameraLogicComponent == null)
				{
					return result;
				}
				Rotator rotator = Rotator.Create(0f, fightCameraLogicComponent.CameraRotationInGravity.Yaw, 0f);
				Rotator rotator2 = Rotator.Create();
				CameraUtility.GetRotatorInNormal(rotator, rotator2);
				return new FRotator?(rotator2.ToUeRotator());
			}
			case EUiCameraAnimationRotationType.TargetRotation:
			{
				AActor targetActor = base.GetTargetActor();
				if (targetActor == null || !targetActor.IsValid())
				{
					return result;
				}
				FRotator rotation = new FRotator(0f, result.Value.Yaw, 0f);
				FTransformDouble ftransformDouble = targetActor.D_GetTransform();
				return new FRotator?(UKismetMathLibrary.D_TransformRotation(ftransformDouble, rotation));
			}
			case EUiCameraAnimationRotationType.TargetForwardRotation:
			{
				AActor targetActor2 = base.GetTargetActor();
				USkeletalMeshComponent targetSkeletalMesh = base.GetTargetSkeletalMesh();
				if (targetActor2 == null || !targetActor2.IsValid() || (targetSkeletalMesh == null || !targetSkeletalMesh.IsValid()))
				{
					return null;
				}
				FRotator relativeRotation = targetSkeletalMesh.RelativeRotation;
				FRotator rotation2 = new FRotator(relativeRotation.Pitch + result.Value.Pitch, relativeRotation.Yaw + result.Value.Yaw, relativeRotation.Roll + result.Value.Roll);
				FTransformDouble ftransformDouble = targetActor2.D_GetTransform();
				return new FRotator?(UKismetMathLibrary.D_TransformRotation(ftransformDouble, rotation2));
			}
			default:
				return null;
			}
		}

		// Token: 0x06025F5B RID: 155483 RVA: 0x00AA7E40 File Offset: 0x00AA6040
		protected FVectorDouble CalculateDefaultLocation(SUiCameraAnimationSettings settings)
		{
			FVectorDouble result = UKismetMathLibrary.Conv_VectorToVectorDouble(settings.Location);
			if (base.TargetType != EUiCameraAnimationTargetType.UiSceneRole && base.TargetType != EUiCameraAnimationTargetType.UiSceneSkeletal && base.TargetType != EUiCameraAnimationTargetType.UiVisionHandBook)
			{
				return result;
			}
			FVectorDouble? debugUiSceneLoadOffset = RenderModuleController.Instance.DebugUiSceneLoadOffset;
			if (!RenderModuleController.Instance.DebugInUiSceneRendering || debugUiSceneLoadOffset == null)
			{
				return result;
			}
			result.X += debugUiSceneLoadOffset.Value.X;
			result.Y += debugUiSceneLoadOffset.Value.Y;
			result.Z += debugUiSceneLoadOffset.Value.Z;
			return result;
		}

		// Token: 0x06025F5C RID: 155484 RVA: 0x00AA7EE0 File Offset: 0x00AA60E0
		protected FRotator? CalculateDefaultRotation(SUiCameraAnimationSettings settings)
		{
			if (!settings.IsTrack)
			{
				return new FRotator?(settings.Rotation);
			}
			FVector fvector = CameraController.Instance.MainModel.CameraLocation.ToUeVectorOld();
			FVector trackLocation;
			if (settings.IsTrackWorldLocation)
			{
				trackLocation = settings.TrackLocation;
			}
			else
			{
				AActor targetActor = base.GetTargetActor();
				if (targetActor == null || !targetActor.IsValid())
				{
					return new FRotator?(settings.Rotation);
				}
				FVectorDouble fvectorDouble = targetActor.D_K2_GetActorLocation();
				trackLocation = new FVector(Convert.ToSingle(fvectorDouble.X + (double)settings.TrackLocation.X), Convert.ToSingle(fvectorDouble.Y + (double)settings.TrackLocation.Y), Convert.ToSingle(fvectorDouble.Z + (double)settings.TrackLocation.Z));
			}
			FRotator value = UKismetMathLibrary.FindLookAtRotation(fvector, trackLocation);
			if (settings.bOverrideTrackPitch)
			{
				value.Pitch = settings.TrackPitchOverride;
			}
			return new FRotator?(value);
		}

		// Token: 0x06025F5D RID: 155485 RVA: 0x00AA7FCC File Offset: 0x00AA61CC
		protected FTransformDouble? GetTargetSkeletalMeshTransform()
		{
			USkeletalMeshComponent targetSkeletalMesh = base.GetTargetSkeletalMesh();
			if (targetSkeletalMesh == null || !targetSkeletalMesh.IsValid())
			{
				return null;
			}
			FQuat fquat = targetSkeletalMesh.K2_GetComponentQuaternion();
			FVectorDouble fvectorDouble = targetSkeletalMesh.D_K2_GetComponentLocation();
			FVectorDouble fvectorDouble2 = targetSkeletalMesh.D_K2_GetComponentScale();
			FVector fvector = fvectorDouble2;
			return new FTransformDouble?(new FTransformDouble(ref fquat, ref fvectorDouble, ref fvector));
		}

		// Token: 0x06025F5E RID: 155486 RVA: 0x00AA802C File Offset: 0x00AA622C
		protected FTransformDouble? GetTargetSkeletalMeshSocketTransform(string socketName)
		{
			USkeletalMeshComponent targetSkeletalMesh = base.GetTargetSkeletalMesh();
			FName? dynamicFName = FNameUtil.GetDynamicFName(socketName);
			if (targetSkeletalMesh == null || !targetSkeletalMesh.IsValid() || FNameUtil.IsEmpty(dynamicFName) || !targetSkeletalMesh.DoesSocketExist(dynamicFName.Value))
			{
				return null;
			}
			return new FTransformDouble?(targetSkeletalMesh.D_GetSocketTransform(dynamicFName.Value, ERelativeTransformSpace.RTS_World));
		}
	}
}
