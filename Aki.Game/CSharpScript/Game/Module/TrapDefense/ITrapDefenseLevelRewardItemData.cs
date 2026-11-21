using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A12 RID: 14866
	[NullableContext(1)]
	public interface ITrapDefenseLevelRewardItemData
	{
		// Token: 0x17004E5D RID: 20061
		// (get) Token: 0x060263E2 RID: 156642
		ETrapDefenseLevelRewardItemType ItemType { get; }

		// Token: 0x17004E5E RID: 20062
		// (get) Token: 0x060263E3 RID: 156643
		string TypeNameKey { get; }

		// Token: 0x17004E5F RID: 20063
		// (get) Token: 0x060263E4 RID: 156644
		TrapDefenseLevelData LevelData { get; }
	}
}
