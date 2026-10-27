using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A23 RID: 18979
	[NullableContext(1)]
	public interface ITrapDefenseSelectBranchData
	{
		// Token: 0x17007A29 RID: 31273
		// (get) Token: 0x06031466 RID: 201830
		// (set) Token: 0x06031467 RID: 201831
		bool IsInDungeon { get; set; }

		// Token: 0x17007A2A RID: 31274
		// (get) Token: 0x06031468 RID: 201832
		// (set) Token: 0x06031469 RID: 201833
		TrapDefenseBuildingDevelopItemData Data { get; set; }
	}
}
