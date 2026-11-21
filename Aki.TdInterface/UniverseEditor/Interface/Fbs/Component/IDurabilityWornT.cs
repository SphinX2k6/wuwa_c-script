using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005632 RID: 22066
	public class IDurabilityWornT
	{
		// Token: 0x17009E76 RID: 40566
		// (get) Token: 0x060233C3 RID: 144323 RVA: 0x004D9476 File Offset: 0x004D7676
		// (set) Token: 0x060233C4 RID: 144324 RVA: 0x004D947E File Offset: 0x004D767E
		public int SlightWear { get; set; }

		// Token: 0x17009E77 RID: 40567
		// (get) Token: 0x060233C5 RID: 144325 RVA: 0x004D9487 File Offset: 0x004D7687
		// (set) Token: 0x060233C6 RID: 144326 RVA: 0x004D948F File Offset: 0x004D768F
		public int SevereWear { get; set; }

		// Token: 0x17009E78 RID: 40568
		// (get) Token: 0x060233C7 RID: 144327 RVA: 0x004D9498 File Offset: 0x004D7698
		// (set) Token: 0x060233C8 RID: 144328 RVA: 0x004D94A0 File Offset: 0x004D76A0
		public byte NullMask { get; set; }

		// Token: 0x060233C9 RID: 144329 RVA: 0x004D94A9 File Offset: 0x004D76A9
		public IDurabilityWornT()
		{
			this.SlightWear = 0;
			this.SevereWear = 0;
			this.NullMask = 0;
		}
	}
}
