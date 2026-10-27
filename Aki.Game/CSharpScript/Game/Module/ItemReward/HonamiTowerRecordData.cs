using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057E1 RID: 22497
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiTowerRecordData : IHonamiTowerRecordData
	{
		// Token: 0x170089EE RID: 35310
		// (get) Token: 0x060392F0 RID: 234224 RVA: 0x00D9038D File Offset: 0x00D8E58D
		// (set) Token: 0x060392F1 RID: 234225 RVA: 0x00D90395 File Offset: 0x00D8E595
		public string RecordName { get; set; }

		// Token: 0x170089EF RID: 35311
		// (get) Token: 0x060392F2 RID: 234226 RVA: 0x00D9039E File Offset: 0x00D8E59E
		// (set) Token: 0x060392F3 RID: 234227 RVA: 0x00D903A6 File Offset: 0x00D8E5A6
		public string RecordValue { get; set; }
	}
}
