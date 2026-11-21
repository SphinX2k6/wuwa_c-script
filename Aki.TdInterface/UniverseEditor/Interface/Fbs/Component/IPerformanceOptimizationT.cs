using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D20 RID: 23840
	public class IPerformanceOptimizationT
	{
		// Token: 0x1700AF41 RID: 44865
		// (get) Token: 0x060279E5 RID: 162277 RVA: 0x0056B8CA File Offset: 0x00569ACA
		// (set) Token: 0x060279E6 RID: 162278 RVA: 0x0056B8D2 File Offset: 0x00569AD2
		public EPerformanceOptimizationType Type { get; set; }

		// Token: 0x060279E7 RID: 162279 RVA: 0x0056B8DB File Offset: 0x00569ADB
		public IPerformanceOptimizationT()
		{
			this.Type = EPerformanceOptimizationType.PlaneMovementOptimization;
		}
	}
}
