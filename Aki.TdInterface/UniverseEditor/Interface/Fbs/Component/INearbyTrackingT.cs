using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B8F RID: 23439
	public class INearbyTrackingT
	{
		// Token: 0x1700AB51 RID: 43857
		// (get) Token: 0x06026A0C RID: 158220 RVA: 0x00549FE2 File Offset: 0x005481E2
		// (set) Token: 0x06026A0D RID: 158221 RVA: 0x00549FEA File Offset: 0x005481EA
		public ENearbyTrackingType Type { get; set; }

		// Token: 0x06026A0E RID: 158222 RVA: 0x00549FF3 File Offset: 0x005481F3
		public INearbyTrackingT()
		{
			this.Type = ENearbyTrackingType.Icon;
		}
	}
}
