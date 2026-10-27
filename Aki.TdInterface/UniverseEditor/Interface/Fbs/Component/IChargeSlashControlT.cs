using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F89 RID: 20361
	public class IChargeSlashControlT
	{
		// Token: 0x17009331 RID: 37681
		// (get) Token: 0x06020561 RID: 132449 RVA: 0x0047FA81 File Offset: 0x0047DC81
		// (set) Token: 0x06020562 RID: 132450 RVA: 0x0047FA89 File Offset: 0x0047DC89
		public ECurveControlType Type { get; set; }

		// Token: 0x17009332 RID: 37682
		// (get) Token: 0x06020563 RID: 132451 RVA: 0x0047FA92 File Offset: 0x0047DC92
		// (set) Token: 0x06020564 RID: 132452 RVA: 0x0047FA9A File Offset: 0x0047DC9A
		public int UpHeight { get; set; }

		// Token: 0x17009333 RID: 37683
		// (get) Token: 0x06020565 RID: 132453 RVA: 0x0047FAA3 File Offset: 0x0047DCA3
		// (set) Token: 0x06020566 RID: 132454 RVA: 0x0047FAAB File Offset: 0x0047DCAB
		public string UpCurvePath { get; set; }

		// Token: 0x06020567 RID: 132455 RVA: 0x0047FAB4 File Offset: 0x0047DCB4
		public IChargeSlashControlT()
		{
			this.Type = ECurveControlType.ChargeSlash;
			this.UpHeight = 0;
			this.UpCurvePath = null;
		}
	}
}
