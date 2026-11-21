using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047B6 RID: 18358
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoAbyssSuccessData : IDangoAbyssSuccessData
	{
		// Token: 0x17005DB4 RID: 23988
		// (get) Token: 0x0602E1FB RID: 188923 RVA: 0x00CDF1AC File Offset: 0x00CDD3AC
		// (set) Token: 0x0602E1FC RID: 188924 RVA: 0x00CDF1B4 File Offset: 0x00CDD3B4
		public List<RewardItemData> RewardItemData { get; set; }

		// Token: 0x17005DB5 RID: 23989
		// (get) Token: 0x0602E1FD RID: 188925 RVA: 0x00CDF1BD File Offset: 0x00CDD3BD
		// (set) Token: 0x0602E1FE RID: 188926 RVA: 0x00CDF1C5 File Offset: 0x00CDD3C5
		public float Progress { get; set; }
	}
}
