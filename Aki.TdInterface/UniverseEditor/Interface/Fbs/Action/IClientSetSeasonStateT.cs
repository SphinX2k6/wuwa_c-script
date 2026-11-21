using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A6F RID: 27247
	public class IClientSetSeasonStateT
	{
		// Token: 0x1700C826 RID: 51238
		// (get) Token: 0x0602EC05 RID: 191493 RVA: 0x0065F317 File Offset: 0x0065D517
		// (set) Token: 0x0602EC06 RID: 191494 RVA: 0x0065F31F File Offset: 0x0065D51F
		public int VolumeId { get; set; }

		// Token: 0x1700C827 RID: 51239
		// (get) Token: 0x0602EC07 RID: 191495 RVA: 0x0065F328 File Offset: 0x0065D528
		// (set) Token: 0x0602EC08 RID: 191496 RVA: 0x0065F330 File Offset: 0x0065D530
		public TClientSetSeasonStateUnion Config { get; set; }

		// Token: 0x0602EC09 RID: 191497 RVA: 0x0065F339 File Offset: 0x0065D539
		public IClientSetSeasonStateT()
		{
			this.VolumeId = 0;
			this.Config = null;
		}
	}
}
