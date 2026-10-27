using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B0F RID: 23311
	public class IVehicleFeatureT
	{
		// Token: 0x1700AFF4 RID: 45044
		// (get) Token: 0x06027D44 RID: 163140 RVA: 0x0057A7D6 File Offset: 0x005789D6
		// (set) Token: 0x06027D45 RID: 163141 RVA: 0x0057A7DE File Offset: 0x005789DE
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x06027D46 RID: 163142 RVA: 0x0057A7E7 File Offset: 0x005789E7
		public IVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
		}
	}
}
