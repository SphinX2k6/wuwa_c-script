using System;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006357 RID: 25431
	public class CameraAimTarget : FollowShooterAimTarget
	{
		// Token: 0x0603DA1A RID: 252442 RVA: 0x011DAF9B File Offset: 0x011D919B
		public CameraAimTarget(float cameraForwardDistance, FVector upVector)
		{
			this.CameraForwardDistance = cameraForwardDistance;
			this.UpVector = upVector;
		}

		// Token: 0x0603DA1B RID: 252443 RVA: 0x011DAFB4 File Offset: 0x011D91B4
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

		// Token: 0x04020B21 RID: 133921
		public readonly float CameraForwardDistance;

		// Token: 0x04020B22 RID: 133922
		public readonly FVector UpVector;
	}
}
