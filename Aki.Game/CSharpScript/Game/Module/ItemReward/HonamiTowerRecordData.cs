using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047B8 RID: 18360
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiTowerRecordData : IHonamiTowerRecordData
	{
		// Token: 0x17005DB8 RID: 23992
		// (get) Token: 0x0602E204 RID: 188932 RVA: 0x00CDF1D6 File Offset: 0x00CDD3D6
		// (set) Token: 0x0602E205 RID: 188933 RVA: 0x00CDF1DE File Offset: 0x00CDD3DE
		public string RecordName { get; set; }

		// Token: 0x17005DB9 RID: 23993
		// (get) Token: 0x0602E206 RID: 188934 RVA: 0x00CDF1E7 File Offset: 0x00CDD3E7
		// (set) Token: 0x0602E207 RID: 188935 RVA: 0x00CDF1EF File Offset: 0x00CDD3EF
		public string RecordValue { get; set; }
	}
}
