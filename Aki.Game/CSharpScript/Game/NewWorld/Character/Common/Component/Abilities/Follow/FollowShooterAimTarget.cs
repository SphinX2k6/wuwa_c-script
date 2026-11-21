using System;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006371 RID: 25457
	public abstract class FollowShooterAimTarget
	{
		// Token: 0x0603DAD4 RID: 252628
		protected abstract FRotator ComputeBaseRotator(FVectorDouble fromLocationDouble);

		// Token: 0x0603DAD5 RID: 252629 RVA: 0x011DEB60 File Offset: 0x011DCD60
		public FRotator ComputeTargetWorldRotator(FVectorDouble fromLocationDouble, FRotator rotateOffset)
		{
			FQuat fquat = this.ComputeBaseRotator(fromLocationDouble).Quaternion();
			FQuat fquat2 = rotateOffset.Quaternion();
			return (fquat * fquat2).Rotator();
		}
	}
}
