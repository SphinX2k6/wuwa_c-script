using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057E2 RID: 22498
	[NullableContext(1)]
	public interface IHonamiTowerSuccessData
	{
		// Token: 0x170089F0 RID: 35312
		// (get) Token: 0x060392F5 RID: 234229
		// (set) Token: 0x060392F6 RID: 234230
		IHonamiTowerRecordData[] RecordItemList { get; set; }

		// Token: 0x170089F1 RID: 35313
		// (get) Token: 0x060392F7 RID: 234231
		// (set) Token: 0x060392F8 RID: 234232
		RewardItemData[] RewardItemList { get; set; }
	}
}
