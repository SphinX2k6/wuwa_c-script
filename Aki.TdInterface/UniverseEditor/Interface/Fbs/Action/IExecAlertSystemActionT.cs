using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D77 RID: 28023
	public class IExecAlertSystemActionT
	{
		// Token: 0x1700CD9D RID: 52637
		// (get) Token: 0x060305BD RID: 198077 RVA: 0x006923F1 File Offset: 0x006905F1
		// (set) Token: 0x060305BE RID: 198078 RVA: 0x006923F9 File Offset: 0x006905F9
		public TAlertSystemOptionUnion Option { get; set; }

		// Token: 0x060305BF RID: 198079 RVA: 0x00692402 File Offset: 0x00690602
		public IExecAlertSystemActionT()
		{
			this.Option = null;
		}
	}
}
