using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A13 RID: 14867
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelRewardItemData : ITrapDefenseLevelRewardItemData
	{
		// Token: 0x17004E60 RID: 20064
		// (get) Token: 0x060263E5 RID: 156645 RVA: 0x00AB66F9 File Offset: 0x00AB48F9
		// (set) Token: 0x060263E6 RID: 156646 RVA: 0x00AB6701 File Offset: 0x00AB4901
		public ETrapDefenseLevelRewardItemType ItemType { get; set; }

		// Token: 0x17004E61 RID: 20065
		// (get) Token: 0x060263E7 RID: 156647 RVA: 0x00AB670A File Offset: 0x00AB490A
		// (set) Token: 0x060263E8 RID: 156648 RVA: 0x00AB6712 File Offset: 0x00AB4912
		public string TypeNameKey { get; set; } = "";

		// Token: 0x17004E62 RID: 20066
		// (get) Token: 0x060263E9 RID: 156649 RVA: 0x00AB671B File Offset: 0x00AB491B
		// (set) Token: 0x060263EA RID: 156650 RVA: 0x00AB6723 File Offset: 0x00AB4923
		public TrapDefenseLevelData LevelData { get; set; }
	}
}
