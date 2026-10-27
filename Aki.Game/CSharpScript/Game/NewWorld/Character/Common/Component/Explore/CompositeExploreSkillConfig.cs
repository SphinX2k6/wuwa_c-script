using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02007120 RID: 28960
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class CompositeExploreSkillConfig : ICompositeExploreSkillConfig
	{
		// Token: 0x17009D26 RID: 40230
		// (get) Token: 0x06046B64 RID: 289636 RVA: 0x011CF630 File Offset: 0x011CD830
		// (set) Token: 0x06046B65 RID: 289637 RVA: 0x011CF638 File Offset: 0x011CD838
		[RequiredMember]
		public string Name { get; set; }

		// Token: 0x17009D27 RID: 40231
		// (get) Token: 0x06046B66 RID: 289638 RVA: 0x011CF641 File Offset: 0x011CD841
		// (set) Token: 0x06046B67 RID: 289639 RVA: 0x011CF649 File Offset: 0x011CD849
		[RequiredMember]
		public int EntrySkillId { get; set; }

		// Token: 0x17009D28 RID: 40232
		// (get) Token: 0x06046B68 RID: 289640 RVA: 0x011CF652 File Offset: 0x011CD852
		// (set) Token: 0x06046B69 RID: 289641 RVA: 0x011CF65A File Offset: 0x011CD85A
		[RequiredMember]
		public int ExitSkillId { get; set; }

		// Token: 0x06046B6A RID: 289642 RVA: 0x011CF663 File Offset: 0x011CD863
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CompositeExploreSkillConfig()
		{
		}
	}
}
