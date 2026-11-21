using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006359 RID: 25433
	[NullableContext(1)]
	[Nullable(0)]
	internal class DirectAttachStrategy : IFollowShooterAttachStrategy
	{
		// Token: 0x0603DA1E RID: 252446 RVA: 0x011DB040 File Offset: 0x011D9240
		public void OnAttach(USceneComponent sceneComponent, SLockOnFollowShooterAttachmentRule attachmentRule, USceneComponent targetComponent)
		{
			sceneComponent.K2_AttachToComponent(targetComponent, attachmentRule.Socket, (EAttachmentRule)attachmentRule.AttachLocationRule, (EAttachmentRule)attachmentRule.AttachRotationRule, (EAttachmentRule)attachmentRule.AttachScaleRule, false, true);
			sceneComponent.SetAbsolute(attachmentRule.AbsoluteLocation, attachmentRule.AbsoluteRotation, attachmentRule.AbsoluteScale);
		}

		// Token: 0x0603DA1F RID: 252447 RVA: 0x011DB096 File Offset: 0x011D9296
		public void OnDetach(USceneComponent sceneComponent, SLockOnFollowShooterAttachmentRule attachmentRule)
		{
			sceneComponent.K2_DetachFromComponent((EDetachmentRule)attachmentRule.DetachLocationRule, (EDetachmentRule)attachmentRule.DetachRotationRule, (EDetachmentRule)attachmentRule.DetachScaleRule, false);
		}

		// Token: 0x0603DA20 RID: 252448 RVA: 0x011DB0C0 File Offset: 0x011D92C0
		public float? UpdateTransform(USceneComponent sceneComponent, IUpdateRotationParams @params)
		{
			sceneComponent.SetAbsolute(false, true, false);
			FTransformDouble ftransformDouble = sceneComponent.D_K2_GetComponentToWorld();
			FRotator target = @params.AimTarget.ComputeTargetWorldRotator(ftransformDouble.GetLocation(), @params.RotateOffset);
			FQuat rotation = ftransformDouble.GetRotation();
			FQuat fquat = target.Quaternion();
			float value = rotation.AngularDistance(fquat) * 57.29578f;
			FRotator newRotation = UKismetMathLibrary.RInterpTo(sceneComponent.K2_GetComponentRotation(), target, @params.DeltaTimeMs / 1000f, @params.RotationInterpSpeed);
			sceneComponent.K2_SetWorldRotation(newRotation, false, ref WorldGlobal.SweepHitResult, true);
			return new float?(value);
		}
	}
}
