using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x020071AA RID: 29098
	[RequiredMember]
	public class StepSpringResult : IStepSpringResult
	{
		// Token: 0x17009DAA RID: 40362
		// (get) Token: 0x06047345 RID: 291653 RVA: 0x01218A26 File Offset: 0x01216C26
		// (set) Token: 0x06047346 RID: 291654 RVA: 0x01218A2E File Offset: 0x01216C2E
		[RequiredMember]
		public float NewPosition { get; set; }

		// Token: 0x17009DAB RID: 40363
		// (get) Token: 0x06047347 RID: 291655 RVA: 0x01218A37 File Offset: 0x01216C37
		// (set) Token: 0x06047348 RID: 291656 RVA: 0x01218A3F File Offset: 0x01216C3F
		[RequiredMember]
		public float NewVelocity { get; set; }

		// Token: 0x17009DAC RID: 40364
		// (get) Token: 0x06047349 RID: 291657 RVA: 0x01218A48 File Offset: 0x01216C48
		// (set) Token: 0x0604734A RID: 291658 RVA: 0x01218A50 File Offset: 0x01216C50
		[RequiredMember]
		public bool Converged { get; set; }

		// Token: 0x0604734B RID: 291659 RVA: 0x01218A59 File Offset: 0x01216C59
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public StepSpringResult()
		{
		}
	}
}
