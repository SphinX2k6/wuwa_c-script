using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005722 RID: 22306
	public class IPerformanceVehicleFeatureT
	{
		// Token: 0x1700A62F RID: 42543
		// (get) Token: 0x06025524 RID: 152868 RVA: 0x00526567 File Offset: 0x00524767
		// (set) Token: 0x06025525 RID: 152869 RVA: 0x0052656F File Offset: 0x0052476F
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x1700A630 RID: 42544
		// (get) Token: 0x06025526 RID: 152870 RVA: 0x00526578 File Offset: 0x00524778
		// (set) Token: 0x06025527 RID: 152871 RVA: 0x00526580 File Offset: 0x00524780
		public string PerformConfig { get; set; }

		// Token: 0x06025528 RID: 152872 RVA: 0x00526589 File Offset: 0x00524789
		public IPerformanceVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
			this.PerformConfig = null;
		}
	}
}
