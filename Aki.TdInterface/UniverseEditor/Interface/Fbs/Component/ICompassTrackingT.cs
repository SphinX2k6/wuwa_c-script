using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FD7 RID: 20439
	public class ICompassTrackingT
	{
		// Token: 0x17009416 RID: 37910
		// (get) Token: 0x060208F5 RID: 133365 RVA: 0x00487380 File Offset: 0x00485580
		// (set) Token: 0x060208F6 RID: 133366 RVA: 0x00487388 File Offset: 0x00485588
		public ENearbyTrackingType Type { get; set; }

		// Token: 0x17009417 RID: 37911
		// (get) Token: 0x060208F7 RID: 133367 RVA: 0x00487391 File Offset: 0x00485591
		// (set) Token: 0x060208F8 RID: 133368 RVA: 0x00487399 File Offset: 0x00485599
		public int ShowRange { get; set; }

		// Token: 0x17009418 RID: 37912
		// (get) Token: 0x060208F9 RID: 133369 RVA: 0x004873A2 File Offset: 0x004855A2
		// (set) Token: 0x060208FA RID: 133370 RVA: 0x004873AA File Offset: 0x004855AA
		public int HideRange { get; set; }

		// Token: 0x17009419 RID: 37913
		// (get) Token: 0x060208FB RID: 133371 RVA: 0x004873B3 File Offset: 0x004855B3
		// (set) Token: 0x060208FC RID: 133372 RVA: 0x004873BB File Offset: 0x004855BB
		public IIconNearByTrackingConfigT IconTrackingConfig { get; set; }

		// Token: 0x1700941A RID: 37914
		// (get) Token: 0x060208FD RID: 133373 RVA: 0x004873C4 File Offset: 0x004855C4
		// (set) Token: 0x060208FE RID: 133374 RVA: 0x004873CC File Offset: 0x004855CC
		public List<EVehicleType> VehicleTypes { get; set; }

		// Token: 0x1700941B RID: 37915
		// (get) Token: 0x060208FF RID: 133375 RVA: 0x004873D5 File Offset: 0x004855D5
		// (set) Token: 0x06020900 RID: 133376 RVA: 0x004873DD File Offset: 0x004855DD
		public byte NullMask { get; set; }

		// Token: 0x06020901 RID: 133377 RVA: 0x004873E6 File Offset: 0x004855E6
		public ICompassTrackingT()
		{
			this.Type = ENearbyTrackingType.Icon;
			this.ShowRange = 0;
			this.HideRange = 0;
			this.IconTrackingConfig = null;
			this.VehicleTypes = null;
			this.NullMask = 0;
		}
	}
}
