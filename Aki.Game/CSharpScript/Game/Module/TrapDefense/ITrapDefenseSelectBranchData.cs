using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039CB RID: 14795
	[NullableContext(1)]
	public interface ITrapDefenseSelectBranchData
	{
		// Token: 0x17004DD6 RID: 19926
		// (get) Token: 0x060261F6 RID: 156150
		// (set) Token: 0x060261F7 RID: 156151
		bool IsInDungeon { get; set; }

		// Token: 0x17004DD7 RID: 19927
		// (get) Token: 0x060261F8 RID: 156152
		// (set) Token: 0x060261F9 RID: 156153
		TrapDefenseBuildingDevelopItemData Data { get; set; }
	}
}
