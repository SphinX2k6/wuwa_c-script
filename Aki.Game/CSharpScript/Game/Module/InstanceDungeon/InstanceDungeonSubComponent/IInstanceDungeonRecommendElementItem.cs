using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058A4 RID: 22692
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class IInstanceDungeonRecommendElementItem
	{
		// Token: 0x17008A98 RID: 35480
		// (get) Token: 0x06039BAD RID: 236461 RVA: 0x00DB8554 File Offset: 0x00DB6754
		// (set) Token: 0x06039BAE RID: 236462 RVA: 0x00DB855C File Offset: 0x00DB675C
		[RequiredMember]
		public List<int> Element { get; set; }

		// Token: 0x06039BAF RID: 236463 RVA: 0x00DB8565 File Offset: 0x00DB6765
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public IInstanceDungeonRecommendElementItem()
		{
		}
	}
}
