using System;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007129 RID: 28969
	public class CameraAimTarget : FollowShooterAimTarget
	{
		// Token: 0x06046BCC RID: 289740 RVA: 0x011D243B File Offset: 0x011D063B
		public CameraAimTarget(float cameraForwardDistance, FVector upVector)
		{
			this.CameraForwardDistance = cameraForwardDistance;
			this.UpVector = upVector;
		}

		// Token: 0x06046BCD RID: 289741 RVA: 0x011D2454 File Offset: 0x011D0654
		protected override FRotator ComputeBaseRotator(FVectorDouble fromLocationDouble)
		{
			FVectorDouble fvectorDouble = Global.CharacterCameraManager.D_GetActorForwardVector();
			FVectorDouble fvectorDouble2 = Global.CharacterCameraManager.D_GetCameraLocation();
			FVectorDouble fvectorDouble3 = fvectorDouble * (double)this.CameraForwardDistance;
			FVectorDouble fvectorDouble4 = fvectorDouble2 + fvectorDouble3;
			fvectorDouble2 = fvectorDouble4 - fromLocationDouble;
			FVector fvector = fvectorDouble2.GetSafeNormal(0.0001).ToVector();
			return UKuroAnimMathLibrary.LookRotation_ForwardFirst(fvector, this.UpVector);
		}

		// Token: 0x04025241 RID: 152129
		public readonly float CameraForwardDistance;

		// Token: 0x04025242 RID: 152130
		public readonly FVector UpVector;
	}
}
