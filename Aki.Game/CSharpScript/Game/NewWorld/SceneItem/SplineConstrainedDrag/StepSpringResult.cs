using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x0200625F RID: 25183
	[RequiredMember]
	public class StepSpringResult : IStepSpringResult
	{
		// Token: 0x170072FA RID: 29434
		// (get) Token: 0x0603CC40 RID: 248896 RVA: 0x0117292A File Offset: 0x01170B2A
		// (set) Token: 0x0603CC41 RID: 248897 RVA: 0x01172932 File Offset: 0x01170B32
		[RequiredMember]
		public float NewPosition { get; set; }

		// Token: 0x170072FB RID: 29435
		// (get) Token: 0x0603CC42 RID: 248898 RVA: 0x0117293B File Offset: 0x01170B3B
		// (set) Token: 0x0603CC43 RID: 248899 RVA: 0x01172943 File Offset: 0x01170B43
		[RequiredMember]
		public float NewVelocity { get; set; }

		// Token: 0x170072FC RID: 29436
		// (get) Token: 0x0603CC44 RID: 248900 RVA: 0x0117294C File Offset: 0x01170B4C
		// (set) Token: 0x0603CC45 RID: 248901 RVA: 0x01172954 File Offset: 0x01170B54
		[RequiredMember]
		public bool Converged { get; set; }

		// Token: 0x0603CC46 RID: 248902 RVA: 0x0117295D File Offset: 0x01170B5D
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public StepSpringResult()
		{
		}
	}
}
