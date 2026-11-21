using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047B9 RID: 18361
	[NullableContext(1)]
	public interface IHonamiTowerSuccessData
	{
		// Token: 0x17005DBA RID: 23994
		// (get) Token: 0x0602E209 RID: 188937
		// (set) Token: 0x0602E20A RID: 188938
		IHonamiTowerRecordData[] RecordItemList { get; set; }

		// Token: 0x17005DBB RID: 23995
		// (get) Token: 0x0602E20B RID: 188939
		// (set) Token: 0x0602E20C RID: 188940
		RewardItemData[] RewardItemList { get; set; }
	}
}
