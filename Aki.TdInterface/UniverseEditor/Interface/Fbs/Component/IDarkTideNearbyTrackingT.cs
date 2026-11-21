using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055DB RID: 21979
	public class IDarkTideNearbyTrackingT
	{
		// Token: 0x17009D5F RID: 40287
		// (get) Token: 0x06022FAB RID: 143275 RVA: 0x004D0542 File Offset: 0x004CE742
		// (set) Token: 0x06022FAC RID: 143276 RVA: 0x004D054A File Offset: 0x004CE74A
		public ENearbyTrackingType Type { get; set; }

		// Token: 0x17009D60 RID: 40288
		// (get) Token: 0x06022FAD RID: 143277 RVA: 0x004D0553 File Offset: 0x004CE753
		// (set) Token: 0x06022FAE RID: 143278 RVA: 0x004D055B File Offset: 0x004CE75B
		public int ShowRange { get; set; }

		// Token: 0x17009D61 RID: 40289
		// (get) Token: 0x06022FAF RID: 143279 RVA: 0x004D0564 File Offset: 0x004CE764
		// (set) Token: 0x06022FB0 RID: 143280 RVA: 0x004D056C File Offset: 0x004CE76C
		public int HideRange { get; set; }

		// Token: 0x06022FB1 RID: 143281 RVA: 0x004D0575 File Offset: 0x004CE775
		public IDarkTideNearbyTrackingT()
		{
			this.Type = ENearbyTrackingType.Icon;
			this.ShowRange = 0;
			this.HideRange = 0;
		}
	}
}
