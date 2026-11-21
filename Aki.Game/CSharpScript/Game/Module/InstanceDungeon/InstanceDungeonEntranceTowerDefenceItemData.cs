using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004849 RID: 18505
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class InstanceDungeonEntranceTowerDefenceItemData
	{
		// Token: 0x17005E30 RID: 24112
		// (get) Token: 0x0602E8A1 RID: 190625 RVA: 0x00CFE05F File Offset: 0x00CFC25F
		// (set) Token: 0x0602E8A2 RID: 190626 RVA: 0x00CFE067 File Offset: 0x00CFC267
		[RequiredMember]
		public List<TItem> Data { get; set; }

		// Token: 0x0602E8A3 RID: 190627 RVA: 0x00CFE070 File Offset: 0x00CFC270
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public InstanceDungeonEntranceTowerDefenceItemData()
		{
		}
	}
}
