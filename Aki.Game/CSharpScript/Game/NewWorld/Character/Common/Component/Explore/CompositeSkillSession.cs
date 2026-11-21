using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02006350 RID: 25424
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class CompositeSkillSession : ICompositeSkillSession
	{
		// Token: 0x170074F8 RID: 29944
		// (get) Token: 0x0603D9BC RID: 252348 RVA: 0x011D82BB File Offset: 0x011D64BB
		// (set) Token: 0x0603D9BD RID: 252349 RVA: 0x011D82C3 File Offset: 0x011D64C3
		[RequiredMember]
		public ICompositeExploreSkillConfig Config { get; set; }

		// Token: 0x170074F9 RID: 29945
		// (get) Token: 0x0603D9BE RID: 252350 RVA: 0x011D82CC File Offset: 0x011D64CC
		// (set) Token: 0x0603D9BF RID: 252351 RVA: 0x011D82D4 File Offset: 0x011D64D4
		[RequiredMember]
		public bool EnterSent { get; set; }

		// Token: 0x170074FA RID: 29946
		// (get) Token: 0x0603D9C0 RID: 252352 RVA: 0x011D82DD File Offset: 0x011D64DD
		// (set) Token: 0x0603D9C1 RID: 252353 RVA: 0x011D82E5 File Offset: 0x011D64E5
		[RequiredMember]
		public double CreatedTime { get; set; }

		// Token: 0x0603D9C2 RID: 252354 RVA: 0x011D82EE File Offset: 0x011D64EE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CompositeSkillSession()
		{
		}
	}
}
