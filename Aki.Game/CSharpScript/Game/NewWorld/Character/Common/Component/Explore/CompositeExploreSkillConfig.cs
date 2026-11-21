using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x0200634E RID: 25422
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class CompositeExploreSkillConfig : ICompositeExploreSkillConfig
	{
		// Token: 0x170074F2 RID: 29938
		// (get) Token: 0x0603D9AF RID: 252335 RVA: 0x011D8280 File Offset: 0x011D6480
		// (set) Token: 0x0603D9B0 RID: 252336 RVA: 0x011D8288 File Offset: 0x011D6488
		[RequiredMember]
		public string Name { get; set; }

		// Token: 0x170074F3 RID: 29939
		// (get) Token: 0x0603D9B1 RID: 252337 RVA: 0x011D8291 File Offset: 0x011D6491
		// (set) Token: 0x0603D9B2 RID: 252338 RVA: 0x011D8299 File Offset: 0x011D6499
		[RequiredMember]
		public int EntrySkillId { get; set; }

		// Token: 0x170074F4 RID: 29940
		// (get) Token: 0x0603D9B3 RID: 252339 RVA: 0x011D82A2 File Offset: 0x011D64A2
		// (set) Token: 0x0603D9B4 RID: 252340 RVA: 0x011D82AA File Offset: 0x011D64AA
		[RequiredMember]
		public int ExitSkillId { get; set; }

		// Token: 0x0603D9B5 RID: 252341 RVA: 0x011D82B3 File Offset: 0x011D64B3
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CompositeExploreSkillConfig()
		{
		}
	}
}
