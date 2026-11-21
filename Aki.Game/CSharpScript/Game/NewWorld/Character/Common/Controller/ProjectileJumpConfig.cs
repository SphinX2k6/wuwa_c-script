using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x02006315 RID: 25365
	[RequiredMember]
	public class ProjectileJumpConfig : IProjectileJumpConfig
	{
		// Token: 0x17007460 RID: 29792
		// (get) Token: 0x0603D63A RID: 251450 RVA: 0x011BF62C File Offset: 0x011BD82C
		// (set) Token: 0x0603D63B RID: 251451 RVA: 0x011BF634 File Offset: 0x011BD834
		[RequiredMember]
		public float BaseJumpHeight { get; set; }

		// Token: 0x17007461 RID: 29793
		// (get) Token: 0x0603D63C RID: 251452 RVA: 0x011BF63D File Offset: 0x011BD83D
		// (set) Token: 0x0603D63D RID: 251453 RVA: 0x011BF645 File Offset: 0x011BD845
		[RequiredMember]
		public float BaseJumpDistanceRate { get; set; }

		// Token: 0x17007462 RID: 29794
		// (get) Token: 0x0603D63E RID: 251454 RVA: 0x011BF64E File Offset: 0x011BD84E
		// (set) Token: 0x0603D63F RID: 251455 RVA: 0x011BF656 File Offset: 0x011BD856
		[RequiredMember]
		public float MaxJumpDistance { get; set; }

		// Token: 0x17007463 RID: 29795
		// (get) Token: 0x0603D640 RID: 251456 RVA: 0x011BF65F File Offset: 0x011BD85F
		// (set) Token: 0x0603D641 RID: 251457 RVA: 0x011BF667 File Offset: 0x011BD867
		[RequiredMember]
		public float MaxJumpHeight { get; set; }

		// Token: 0x17007464 RID: 29796
		// (get) Token: 0x0603D642 RID: 251458 RVA: 0x011BF670 File Offset: 0x011BD870
		// (set) Token: 0x0603D643 RID: 251459 RVA: 0x011BF678 File Offset: 0x011BD878
		[RequiredMember]
		public float JumpAcceleration { get; set; }

		// Token: 0x17007465 RID: 29797
		// (get) Token: 0x0603D644 RID: 251460 RVA: 0x011BF681 File Offset: 0x011BD881
		// (set) Token: 0x0603D645 RID: 251461 RVA: 0x011BF689 File Offset: 0x011BD889
		[RequiredMember]
		public float TargetSpeedForJump { get; set; }

		// Token: 0x17007466 RID: 29798
		// (get) Token: 0x0603D646 RID: 251462 RVA: 0x011BF692 File Offset: 0x011BD892
		// (set) Token: 0x0603D647 RID: 251463 RVA: 0x011BF69A File Offset: 0x011BD89A
		[RequiredMember]
		public float AllTimeForJump { get; set; }

		// Token: 0x17007467 RID: 29799
		// (get) Token: 0x0603D648 RID: 251464 RVA: 0x011BF6A3 File Offset: 0x011BD8A3
		// (set) Token: 0x0603D649 RID: 251465 RVA: 0x011BF6AB File Offset: 0x011BD8AB
		[RequiredMember]
		public float JumpBlendTime { get; set; }

		// Token: 0x0603D64A RID: 251466 RVA: 0x011BF6B4 File Offset: 0x011BD8B4
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ProjectileJumpConfig()
		{
		}
	}
}
