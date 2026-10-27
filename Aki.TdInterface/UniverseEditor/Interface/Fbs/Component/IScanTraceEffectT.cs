using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200589B RID: 22683
	public class IScanTraceEffectT
	{
		// Token: 0x1700A9C7 RID: 43463
		// (get) Token: 0x060263F6 RID: 156662 RVA: 0x005458D7 File Offset: 0x00543AD7
		// (set) Token: 0x060263F7 RID: 156663 RVA: 0x005458DF File Offset: 0x00543ADF
		public string Effect { get; set; }

		// Token: 0x1700A9C8 RID: 43464
		// (get) Token: 0x060263F8 RID: 156664 RVA: 0x005458E8 File Offset: 0x00543AE8
		// (set) Token: 0x060263F9 RID: 156665 RVA: 0x005458F0 File Offset: 0x00543AF0
		public int Target { get; set; }

		// Token: 0x060263FA RID: 156666 RVA: 0x005458F9 File Offset: 0x00543AF9
		public IScanTraceEffectT()
		{
			this.Effect = null;
			this.Target = 0;
		}
	}
}
