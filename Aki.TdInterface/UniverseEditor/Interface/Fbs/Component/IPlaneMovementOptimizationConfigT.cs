using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005746 RID: 22342
	public class IPlaneMovementOptimizationConfigT
	{
		// Token: 0x1700A6B3 RID: 42675
		// (get) Token: 0x06025703 RID: 153347 RVA: 0x0052A9FA File Offset: 0x00528BFA
		// (set) Token: 0x06025704 RID: 153348 RVA: 0x0052AA02 File Offset: 0x00528C02
		public EPerformanceOptimizationType Type { get; set; }

		// Token: 0x06025705 RID: 153349 RVA: 0x0052AA0B File Offset: 0x00528C0B
		public IPlaneMovementOptimizationConfigT()
		{
			this.Type = EPerformanceOptimizationType.PlaneMovementOptimization;
		}
	}
}
