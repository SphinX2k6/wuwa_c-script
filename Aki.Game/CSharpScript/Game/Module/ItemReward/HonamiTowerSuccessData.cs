using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057E3 RID: 22499
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiTowerSuccessData : IHonamiTowerSuccessData
	{
		// Token: 0x170089F2 RID: 35314
		// (get) Token: 0x060392F9 RID: 234233 RVA: 0x00D903B7 File Offset: 0x00D8E5B7
		// (set) Token: 0x060392FA RID: 234234 RVA: 0x00D903BF File Offset: 0x00D8E5BF
		public IHonamiTowerRecordData[] RecordItemList { get; set; }

		// Token: 0x170089F3 RID: 35315
		// (get) Token: 0x060392FB RID: 234235 RVA: 0x00D903C8 File Offset: 0x00D8E5C8
		// (set) Token: 0x060392FC RID: 234236 RVA: 0x00D903D0 File Offset: 0x00D8E5D0
		public RewardItemData[] RewardItemList { get; set; }
	}
}
