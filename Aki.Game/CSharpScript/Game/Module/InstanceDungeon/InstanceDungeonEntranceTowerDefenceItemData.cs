using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005871 RID: 22641
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class InstanceDungeonEntranceTowerDefenceItemData
	{
		// Token: 0x17008A64 RID: 35428
		// (get) Token: 0x06039980 RID: 235904 RVA: 0x00DAF193 File Offset: 0x00DAD393
		// (set) Token: 0x06039981 RID: 235905 RVA: 0x00DAF19B File Offset: 0x00DAD39B
		[RequiredMember]
		public List<TItem> Data { get; set; }

		// Token: 0x06039982 RID: 235906 RVA: 0x00DAF1A4 File Offset: 0x00DAD3A4
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public InstanceDungeonEntranceTowerDefenceItemData()
		{
		}
	}
}
