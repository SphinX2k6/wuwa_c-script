using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x0200487C RID: 18556
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class IInstanceDungeonRecommendElementItem
	{
		// Token: 0x17005E64 RID: 24164
		// (get) Token: 0x0602EAD0 RID: 191184 RVA: 0x00D0746C File Offset: 0x00D0566C
		// (set) Token: 0x0602EAD1 RID: 191185 RVA: 0x00D07474 File Offset: 0x00D05674
		[RequiredMember]
		public List<int> Element { get; set; }

		// Token: 0x0602EAD2 RID: 191186 RVA: 0x00D0747D File Offset: 0x00D0567D
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public IInstanceDungeonRecommendElementItem()
		{
		}
	}
}
