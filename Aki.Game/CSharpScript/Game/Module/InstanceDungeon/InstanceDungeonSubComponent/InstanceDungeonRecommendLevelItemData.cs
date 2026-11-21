using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TowerDefence;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x0200487E RID: 18558
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class InstanceDungeonRecommendLevelItemData
	{
		// Token: 0x17005E65 RID: 24165
		// (get) Token: 0x0602EAD8 RID: 191192 RVA: 0x00D0754B File Offset: 0x00D0574B
		// (set) Token: 0x0602EAD9 RID: 191193 RVA: 0x00D07553 File Offset: 0x00D05753
		[RequiredMember]
		public TowerDefenseRecommendLevel Level { get; set; }

		// Token: 0x0602EADA RID: 191194 RVA: 0x00D0755C File Offset: 0x00D0575C
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public InstanceDungeonRecommendLevelItemData()
		{
		}
	}
}
