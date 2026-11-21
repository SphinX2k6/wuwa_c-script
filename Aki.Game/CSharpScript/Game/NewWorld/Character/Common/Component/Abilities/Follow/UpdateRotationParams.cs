using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006373 RID: 25459
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class UpdateRotationParams : IUpdateRotationParams
	{
		// Token: 0x17007515 RID: 29973
		// (get) Token: 0x0603DADF RID: 252639 RVA: 0x011DEB9E File Offset: 0x011DCD9E
		// (set) Token: 0x0603DAE0 RID: 252640 RVA: 0x011DEBA6 File Offset: 0x011DCDA6
		public float DeltaTimeMs { get; set; }

		// Token: 0x17007516 RID: 29974
		// (get) Token: 0x0603DAE1 RID: 252641 RVA: 0x011DEBAF File Offset: 0x011DCDAF
		// (set) Token: 0x0603DAE2 RID: 252642 RVA: 0x011DEBB7 File Offset: 0x011DCDB7
		public float RotationInterpSpeed { get; set; }

		// Token: 0x17007517 RID: 29975
		// (get) Token: 0x0603DAE3 RID: 252643 RVA: 0x011DEBC0 File Offset: 0x011DCDC0
		// (set) Token: 0x0603DAE4 RID: 252644 RVA: 0x011DEBC8 File Offset: 0x011DCDC8
		[RequiredMember]
		public FRotator RotateOffset { get; set; }

		// Token: 0x17007518 RID: 29976
		// (get) Token: 0x0603DAE5 RID: 252645 RVA: 0x011DEBD1 File Offset: 0x011DCDD1
		// (set) Token: 0x0603DAE6 RID: 252646 RVA: 0x011DEBD9 File Offset: 0x011DCDD9
		[RequiredMember]
		public FollowShooterAimTarget AimTarget { get; set; }

		// Token: 0x0603DAE7 RID: 252647 RVA: 0x011DEBE2 File Offset: 0x011DCDE2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public UpdateRotationParams()
		{
		}
	}
}
