using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A6A RID: 19050
	[NullableContext(1)]
	public interface ITrapDefenseLevelRewardItemData
	{
		// Token: 0x17007AB0 RID: 31408
		// (get) Token: 0x06031652 RID: 202322
		ETrapDefenseLevelRewardItemType ItemType { get; }

		// Token: 0x17007AB1 RID: 31409
		// (get) Token: 0x06031653 RID: 202323
		string TypeNameKey { get; }

		// Token: 0x17007AB2 RID: 31410
		// (get) Token: 0x06031654 RID: 202324
		TrapDefenseLevelData LevelData { get; }
	}
}
