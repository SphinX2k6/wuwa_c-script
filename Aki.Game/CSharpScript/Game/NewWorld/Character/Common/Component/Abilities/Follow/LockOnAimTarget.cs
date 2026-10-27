using System;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200712A RID: 28970
	public class LockOnAimTarget : FollowShooterAimTarget
	{
		// Token: 0x06046BCE RID: 289742 RVA: 0x011D24C2 File Offset: 0x011D06C2
		public LockOnAimTarget(FVectorDouble targetLocationDouble)
		{
			this.TargetLocationDouble = targetLocationDouble;
		}

		// Token: 0x06046BCF RID: 289743 RVA: 0x011D24D1 File Offset: 0x011D06D1
		protected override FRotator ComputeBaseRotator(FVectorDouble fromLocationDouble)
		{
			return UKismetMathLibrary.D_FindLookAtRotation(fromLocationDouble, this.TargetLocationDouble);
		}

		// Token: 0x04025243 RID: 152131
		public readonly FVectorDouble TargetLocationDouble;
	}
}
