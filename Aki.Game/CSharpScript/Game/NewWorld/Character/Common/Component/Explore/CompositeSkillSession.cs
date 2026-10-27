using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02007122 RID: 28962
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class CompositeSkillSession : ICompositeSkillSession
	{
		// Token: 0x17009D2C RID: 40236
		// (get) Token: 0x06046B71 RID: 289649 RVA: 0x011CF66B File Offset: 0x011CD86B
		// (set) Token: 0x06046B72 RID: 289650 RVA: 0x011CF673 File Offset: 0x011CD873
		[RequiredMember]
		public ICompositeExploreSkillConfig Config { get; set; }

		// Token: 0x17009D2D RID: 40237
		// (get) Token: 0x06046B73 RID: 289651 RVA: 0x011CF67C File Offset: 0x011CD87C
		// (set) Token: 0x06046B74 RID: 289652 RVA: 0x011CF684 File Offset: 0x011CD884
		[RequiredMember]
		public bool EnterSent { get; set; }

		// Token: 0x17009D2E RID: 40238
		// (get) Token: 0x06046B75 RID: 289653 RVA: 0x011CF68D File Offset: 0x011CD88D
		// (set) Token: 0x06046B76 RID: 289654 RVA: 0x011CF695 File Offset: 0x011CD895
		[RequiredMember]
		public double CreatedTime { get; set; }

		// Token: 0x06046B77 RID: 289655 RVA: 0x011CF69E File Offset: 0x011CD89E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CompositeSkillSession()
		{
		}
	}
}
