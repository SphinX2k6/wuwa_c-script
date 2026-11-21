using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047BA RID: 18362
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiTowerSuccessData : IHonamiTowerSuccessData
	{
		// Token: 0x17005DBC RID: 23996
		// (get) Token: 0x0602E20D RID: 188941 RVA: 0x00CDF200 File Offset: 0x00CDD400
		// (set) Token: 0x0602E20E RID: 188942 RVA: 0x00CDF208 File Offset: 0x00CDD408
		public IHonamiTowerRecordData[] RecordItemList { get; set; }

		// Token: 0x17005DBD RID: 23997
		// (get) Token: 0x0602E20F RID: 188943 RVA: 0x00CDF211 File Offset: 0x00CDD411
		// (set) Token: 0x0602E210 RID: 188944 RVA: 0x00CDF219 File Offset: 0x00CDD419
		public RewardItemData[] RewardItemList { get; set; }
	}
}
