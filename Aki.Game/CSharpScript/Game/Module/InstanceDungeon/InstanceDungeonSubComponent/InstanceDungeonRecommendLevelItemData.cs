using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TowerDefence;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058A6 RID: 22694
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class InstanceDungeonRecommendLevelItemData
	{
		// Token: 0x17008A99 RID: 35481
		// (get) Token: 0x06039BB5 RID: 236469 RVA: 0x00DB8633 File Offset: 0x00DB6833
		// (set) Token: 0x06039BB6 RID: 236470 RVA: 0x00DB863B File Offset: 0x00DB683B
		[RequiredMember]
		public TowerDefenseRecommendLevel Level { get; set; }

		// Token: 0x06039BB7 RID: 236471 RVA: 0x00DB8644 File Offset: 0x00DB6844
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public InstanceDungeonRecommendLevelItemData()
		{
		}
	}
}
