using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D29 RID: 23849
	public class IPerformanceVehicleFeatureT
	{
		// Token: 0x1700AF4F RID: 44879
		// (get) Token: 0x06027A33 RID: 162355 RVA: 0x0056C26F File Offset: 0x0056A46F
		// (set) Token: 0x06027A34 RID: 162356 RVA: 0x0056C277 File Offset: 0x0056A477
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x1700AF50 RID: 44880
		// (get) Token: 0x06027A35 RID: 162357 RVA: 0x0056C280 File Offset: 0x0056A480
		// (set) Token: 0x06027A36 RID: 162358 RVA: 0x0056C288 File Offset: 0x0056A488
		public string PerformConfig { get; set; }

		// Token: 0x06027A37 RID: 162359 RVA: 0x0056C291 File Offset: 0x0056A491
		public IPerformanceVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
			this.PerformConfig = null;
		}
	}
}
