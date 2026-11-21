using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F3 RID: 22003
	public class IDirectionFillT
	{
		// Token: 0x17009DB1 RID: 40369
		// (get) Token: 0x060230E7 RID: 143591 RVA: 0x004D366A File Offset: 0x004D186A
		// (set) Token: 0x060230E8 RID: 143592 RVA: 0x004D3672 File Offset: 0x004D1872
		public EFillType Type { get; set; }

		// Token: 0x17009DB2 RID: 40370
		// (get) Token: 0x060230E9 RID: 143593 RVA: 0x004D367B File Offset: 0x004D187B
		// (set) Token: 0x060230EA RID: 143594 RVA: 0x004D3683 File Offset: 0x004D1883
		public bool W { get; set; }

		// Token: 0x17009DB3 RID: 40371
		// (get) Token: 0x060230EB RID: 143595 RVA: 0x004D368C File Offset: 0x004D188C
		// (set) Token: 0x060230EC RID: 143596 RVA: 0x004D3694 File Offset: 0x004D1894
		public bool S { get; set; }

		// Token: 0x17009DB4 RID: 40372
		// (get) Token: 0x060230ED RID: 143597 RVA: 0x004D369D File Offset: 0x004D189D
		// (set) Token: 0x060230EE RID: 143598 RVA: 0x004D36A5 File Offset: 0x004D18A5
		public bool A { get; set; }

		// Token: 0x17009DB5 RID: 40373
		// (get) Token: 0x060230EF RID: 143599 RVA: 0x004D36AE File Offset: 0x004D18AE
		// (set) Token: 0x060230F0 RID: 143600 RVA: 0x004D36B6 File Offset: 0x004D18B6
		public bool D { get; set; }

		// Token: 0x060230F1 RID: 143601 RVA: 0x004D36BF File Offset: 0x004D18BF
		public IDirectionFillT()
		{
			this.Type = EFillType.Fixed;
			this.W = false;
			this.S = false;
			this.A = false;
			this.D = false;
		}
	}
}
