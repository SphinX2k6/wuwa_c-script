using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D4D RID: 23885
	public class IPlaneMovementOptimizationConfigT
	{
		// Token: 0x1700AFD7 RID: 45015
		// (get) Token: 0x06027C23 RID: 162851 RVA: 0x00570B86 File Offset: 0x0056ED86
		// (set) Token: 0x06027C24 RID: 162852 RVA: 0x00570B8E File Offset: 0x0056ED8E
		public EPerformanceOptimizationType Type { get; set; }

		// Token: 0x06027C25 RID: 162853 RVA: 0x00570B97 File Offset: 0x0056ED97
		public IPlaneMovementOptimizationConfigT()
		{
			this.Type = EPerformanceOptimizationType.PlaneMovementOptimization;
		}
	}
}
