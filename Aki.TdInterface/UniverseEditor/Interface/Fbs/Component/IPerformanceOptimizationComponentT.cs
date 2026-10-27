using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200571C RID: 22300
	public class IPerformanceOptimizationComponentT
	{
		// Token: 0x1700A627 RID: 42535
		// (get) Token: 0x060254FC RID: 152828 RVA: 0x005261C1 File Offset: 0x005243C1
		// (set) Token: 0x060254FD RID: 152829 RVA: 0x005261C9 File Offset: 0x005243C9
		public bool Disabled { get; set; }

		// Token: 0x1700A628 RID: 42536
		// (get) Token: 0x060254FE RID: 152830 RVA: 0x005261D2 File Offset: 0x005243D2
		// (set) Token: 0x060254FF RID: 152831 RVA: 0x005261DA File Offset: 0x005243DA
		public List<TPerformanceOptimizationTypeUnion> PerformanceOptimizationList { get; set; }

		// Token: 0x1700A629 RID: 42537
		// (get) Token: 0x06025500 RID: 152832 RVA: 0x005261E3 File Offset: 0x005243E3
		// (set) Token: 0x06025501 RID: 152833 RVA: 0x005261EB File Offset: 0x005243EB
		public byte NullMask { get; set; }

		// Token: 0x06025502 RID: 152834 RVA: 0x005261F4 File Offset: 0x005243F4
		public IPerformanceOptimizationComponentT()
		{
			this.Disabled = false;
			this.PerformanceOptimizationList = null;
			this.NullMask = 0;
		}
	}
}
