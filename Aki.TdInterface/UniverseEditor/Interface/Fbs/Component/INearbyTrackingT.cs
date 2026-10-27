using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F1 RID: 22001
	public class INearbyTrackingT
	{
		// Token: 0x1700A2C9 RID: 41673
		// (get) Token: 0x060247FF RID: 149503 RVA: 0x00509A6A File Offset: 0x00507C6A
		// (set) Token: 0x06024800 RID: 149504 RVA: 0x00509A72 File Offset: 0x00507C72
		public ENearbyTrackingType Type { get; set; }

		// Token: 0x06024801 RID: 149505 RVA: 0x00509A7B File Offset: 0x00507C7B
		public INearbyTrackingT()
		{
			this.Type = ENearbyTrackingType.Icon;
		}
	}
}
