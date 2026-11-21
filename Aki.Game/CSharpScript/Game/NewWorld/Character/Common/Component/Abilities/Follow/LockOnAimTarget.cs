using System;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006358 RID: 25432
	public class LockOnAimTarget : FollowShooterAimTarget
	{
		// Token: 0x0603DA1C RID: 252444 RVA: 0x011DB022 File Offset: 0x011D9222
		public LockOnAimTarget(FVectorDouble targetLocationDouble)
		{
			this.TargetLocationDouble = targetLocationDouble;
		}

		// Token: 0x0603DA1D RID: 252445 RVA: 0x011DB031 File Offset: 0x011D9231
		protected override FRotator ComputeBaseRotator(FVectorDouble fromLocationDouble)
		{
			return UKismetMathLibrary.D_FindLookAtRotation(fromLocationDouble, this.TargetLocationDouble);
		}

		// Token: 0x04020B23 RID: 133923
		public readonly FVectorDouble TargetLocationDouble;
	}
}
