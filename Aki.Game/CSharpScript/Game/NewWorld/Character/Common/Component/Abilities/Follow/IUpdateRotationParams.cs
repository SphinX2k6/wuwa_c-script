using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006372 RID: 25458
	[NullableContext(1)]
	public interface IUpdateRotationParams
	{
		// Token: 0x17007511 RID: 29969
		// (get) Token: 0x0603DAD7 RID: 252631
		// (set) Token: 0x0603DAD8 RID: 252632
		float DeltaTimeMs { get; set; }

		// Token: 0x17007512 RID: 29970
		// (get) Token: 0x0603DAD9 RID: 252633
		// (set) Token: 0x0603DADA RID: 252634
		float RotationInterpSpeed { get; set; }

		// Token: 0x17007513 RID: 29971
		// (get) Token: 0x0603DADB RID: 252635
		// (set) Token: 0x0603DADC RID: 252636
		FRotator RotateOffset { get; set; }

		// Token: 0x17007514 RID: 29972
		// (get) Token: 0x0603DADD RID: 252637
		// (set) Token: 0x0603DADE RID: 252638
		FollowShooterAimTarget AimTarget { get; set; }
	}
}
