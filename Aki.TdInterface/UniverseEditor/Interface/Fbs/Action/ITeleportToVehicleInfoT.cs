using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B7F RID: 31615
	public class ITeleportToVehicleInfoT
	{
		// Token: 0x1700ECAC RID: 60588
		// (get) Token: 0x06038EF8 RID: 233208 RVA: 0x007B2236 File Offset: 0x007B0436
		// (set) Token: 0x06038EF9 RID: 233209 RVA: 0x007B223E File Offset: 0x007B043E
		public EVehicleType Type { get; set; }

		// Token: 0x06038EFA RID: 233210 RVA: 0x007B2247 File Offset: 0x007B0447
		public ITeleportToVehicleInfoT()
		{
			this.Type = EVehicleType.Gongduola;
		}
	}
}
