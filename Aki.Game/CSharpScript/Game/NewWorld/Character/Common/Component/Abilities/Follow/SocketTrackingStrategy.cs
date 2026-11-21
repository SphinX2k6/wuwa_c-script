using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200635A RID: 25434
	[NullableContext(1)]
	[Nullable(0)]
	internal class SocketTrackingStrategy : IFollowShooterAttachStrategy
	{
		// Token: 0x0603DA22 RID: 252450 RVA: 0x011DB150 File Offset: 0x011D9350
		public void OnAttach(USceneComponent sceneComponent, SLockOnFollowShooterAttachmentRule attachmentRule, USceneComponent targetComponent)
		{
			this.TrackingMap[sceneComponent] = new SocketTrackingInfo
			{
				TargetComponent = new WeakReference<USceneComponent>(targetComponent),
				SocketName = attachmentRule.Socket
			};
			FTransformDouble ftransformDouble = targetComponent.D_GetSocketTransform(attachmentRule.Socket, ERelativeTransformSpace.RTS_World);
			sceneComponent.D_K2_SetWorldTransform(ftransformDouble, false, ref WorldGlobal.SweepHitResult, true);
		}

		// Token: 0x0603DA23 RID: 252451 RVA: 0x011DB1A3 File Offset: 0x011D93A3
		public void OnDetach(USceneComponent sceneComponent, SLockOnFollowShooterAttachmentRule attachmentRule)
		{
			this.TrackingMap.Remove(sceneComponent);
		}

		// Token: 0x0603DA24 RID: 252452 RVA: 0x011DB1B2 File Offset: 0x011D93B2
		public void ClearForSceneComponent(USceneComponent sceneComponent)
		{
			this.TrackingMap.Remove(sceneComponent);
		}

		// Token: 0x0603DA25 RID: 252453 RVA: 0x011DB1C4 File Offset: 0x011D93C4
		public float? UpdateTransform(USceneComponent sceneComponent, IUpdateRotationParams @params)
		{
			ISocketTrackingInfo validTrackingInfo = this.GetValidTrackingInfo(sceneComponent);
			if (validTrackingInfo == null)
			{
				return null;
			}
			USceneComponent usceneComponent;
			validTrackingInfo.TargetComponent.TryGetTarget(out usceneComponent);
			if (usceneComponent == null || !usceneComponent.IsValid())
			{
				return null;
			}
			FVectorDouble fromLocationDouble = usceneComponent.D_K2_GetComponentLocation();
			FRotator target = @params.AimTarget.ComputeTargetWorldRotator(fromLocationDouble, @params.RotateOffset);
			FRotator fakeParentRotation = UKismetMathLibrary.RInterpTo(this.DeriveFakeParentRotation(sceneComponent, validTrackingInfo) ?? sceneComponent.K2_GetComponentRotation(), target, @params.DeltaTimeMs / 1000f, @params.RotationInterpSpeed);
			FQuat fquat = fakeParentRotation.Quaternion();
			FQuat fquat2 = target.Quaternion();
			float value = fquat.AngularDistance(fquat2) * 57.29578f;
			FTransformDouble? ftransformDouble = this.ComputeFakeSocketWorldTransform(validTrackingInfo, fakeParentRotation);
			if (ftransformDouble != null)
			{
				FTransformDouble value2 = ftransformDouble.Value;
				sceneComponent.D_K2_SetWorldTransform(value2, false, ref WorldGlobal.SweepHitResult, true);
			}
			return new float?(value);
		}

		// Token: 0x0603DA26 RID: 252454 RVA: 0x011DB2BC File Offset: 0x011D94BC
		[return: Nullable(2)]
		private ISocketTrackingInfo GetValidTrackingInfo(USceneComponent sceneComponent)
		{
			ISocketTrackingInfo socketTrackingInfo;
			if (!this.TrackingMap.TryGetValue(sceneComponent, out socketTrackingInfo))
			{
				return null;
			}
			USceneComponent usceneComponent;
			socketTrackingInfo.TargetComponent.TryGetTarget(out usceneComponent);
			if (usceneComponent == null || !usceneComponent.IsValid())
			{
				this.TrackingMap.Remove(sceneComponent);
				return null;
			}
			return socketTrackingInfo;
		}

		// Token: 0x0603DA27 RID: 252455 RVA: 0x011DB30C File Offset: 0x011D950C
		private FTransformDouble? ComputeFakeSocketWorldTransform(ISocketTrackingInfo trackingInfo, FRotator fakeParentRotation)
		{
			USceneComponent usceneComponent;
			trackingInfo.TargetComponent.TryGetTarget(out usceneComponent);
			if (usceneComponent == null || !usceneComponent.IsValid())
			{
				return null;
			}
			FTransformDouble ftransformDouble = usceneComponent.D_GetSocketTransform(trackingInfo.SocketName, ERelativeTransformSpace.RTS_Component);
			FTransformDouble ftransformDouble2 = usceneComponent.D_K2_GetComponentToWorld();
			FTransformDouble ftransformDouble3 = UKismetMathLibrary.MakeTransformDouble(ftransformDouble2.GetLocation(), fakeParentRotation, ftransformDouble2.GetScale3D());
			return new FTransformDouble?(UKismetMathLibrary.D_ComposeTransforms(ftransformDouble, ftransformDouble3));
		}

		// Token: 0x0603DA28 RID: 252456 RVA: 0x011DB37C File Offset: 0x011D957C
		private FRotator? DeriveFakeParentRotation(USceneComponent sceneComponent, ISocketTrackingInfo trackingInfo)
		{
			USceneComponent usceneComponent;
			trackingInfo.TargetComponent.TryGetTarget(out usceneComponent);
			if (usceneComponent == null || !usceneComponent.IsValid())
			{
				return null;
			}
			FTransformDouble ftransformDouble = usceneComponent.D_GetSocketTransform(trackingInfo.SocketName, ERelativeTransformSpace.RTS_Component);
			FRotator frotator = sceneComponent.K2_GetComponentRotation();
			FQuat fquat = ftransformDouble.GetRotation();
			FQuat fquat2 = fquat.Inverse();
			fquat = frotator.Quaternion();
			return new FRotator?((fquat * fquat2).Rotator());
		}

		// Token: 0x04020B24 RID: 133924
		private readonly Dictionary<USceneComponent, ISocketTrackingInfo> TrackingMap = new Dictionary<USceneComponent, ISocketTrackingInfo>();
	}
}
