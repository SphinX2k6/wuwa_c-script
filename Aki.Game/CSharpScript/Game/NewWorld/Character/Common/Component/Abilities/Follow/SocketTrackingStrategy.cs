using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200712C RID: 28972
	[NullableContext(1)]
	[Nullable(0)]
	internal class SocketTrackingStrategy : IFollowShooterAttachStrategy
	{
		// Token: 0x06046BD4 RID: 289748 RVA: 0x011D25F0 File Offset: 0x011D07F0
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

		// Token: 0x06046BD5 RID: 289749 RVA: 0x011D2643 File Offset: 0x011D0843
		public void OnDetach(USceneComponent sceneComponent, SLockOnFollowShooterAttachmentRule attachmentRule)
		{
			this.TrackingMap.Remove(sceneComponent);
		}

		// Token: 0x06046BD6 RID: 289750 RVA: 0x011D2652 File Offset: 0x011D0852
		public void ClearForSceneComponent(USceneComponent sceneComponent)
		{
			this.TrackingMap.Remove(sceneComponent);
		}

		// Token: 0x06046BD7 RID: 289751 RVA: 0x011D2664 File Offset: 0x011D0864
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

		// Token: 0x06046BD8 RID: 289752 RVA: 0x011D275C File Offset: 0x011D095C
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

		// Token: 0x06046BD9 RID: 289753 RVA: 0x011D27AC File Offset: 0x011D09AC
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

		// Token: 0x06046BDA RID: 289754 RVA: 0x011D281C File Offset: 0x011D0A1C
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

		// Token: 0x04025244 RID: 152132
		private readonly Dictionary<USceneComponent, ISocketTrackingInfo> TrackingMap = new Dictionary<USceneComponent, ISocketTrackingInfo>();
	}
}
