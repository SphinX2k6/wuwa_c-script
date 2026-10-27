using System;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007143 RID: 28995
	public abstract class FollowShooterAimTarget
	{
		// Token: 0x06046C83 RID: 289923
		protected abstract FRotator ComputeBaseRotator(FVectorDouble fromLocationDouble);

		// Token: 0x06046C84 RID: 289924 RVA: 0x011D614C File Offset: 0x011D434C
		public FRotator ComputeTargetWorldRotator(FVectorDouble fromLocationDouble, FRotator rotateOffset)
		{
			FQuat fquat = this.ComputeBaseRotator(fromLocationDouble).Quaternion();
			FQuat fquat2 = rotateOffset.Quaternion();
			return (fquat * fquat2).Rotator();
		}
	}
}
