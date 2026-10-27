using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005719 RID: 22297
	public class IPerformanceOptimizationT
	{
		// Token: 0x1700A621 RID: 42529
		// (get) Token: 0x060254D6 RID: 152790 RVA: 0x00525BC2 File Offset: 0x00523DC2
		// (set) Token: 0x060254D7 RID: 152791 RVA: 0x00525BCA File Offset: 0x00523DCA
		public EPerformanceOptimizationType Type { get; set; }

		// Token: 0x060254D8 RID: 152792 RVA: 0x00525BD3 File Offset: 0x00523DD3
		public IPerformanceOptimizationT()
		{
			this.Type = EPerformanceOptimizationType.PlaneMovementOptimization;
		}
	}
}
