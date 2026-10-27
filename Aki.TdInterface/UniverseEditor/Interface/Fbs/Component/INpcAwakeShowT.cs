using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005618 RID: 22040
	public class INpcAwakeShowT
	{
		// Token: 0x1700A316 RID: 41750
		// (get) Token: 0x06024945 RID: 149829 RVA: 0x0050C117 File Offset: 0x0050A317
		// (set) Token: 0x06024946 RID: 149830 RVA: 0x0050C11F File Offset: 0x0050A31F
		public IMontageIdT RegisteredMontageId { get; set; }

		// Token: 0x1700A317 RID: 41751
		// (get) Token: 0x06024947 RID: 149831 RVA: 0x0050C128 File Offset: 0x0050A328
		// (set) Token: 0x06024948 RID: 149832 RVA: 0x0050C130 File Offset: 0x0050A330
		public string MaterialDa { get; set; }

		// Token: 0x06024949 RID: 149833 RVA: 0x0050C139 File Offset: 0x0050A339
		public INpcAwakeShowT()
		{
			this.RegisteredMontageId = null;
			this.MaterialDa = null;
		}
	}
}
