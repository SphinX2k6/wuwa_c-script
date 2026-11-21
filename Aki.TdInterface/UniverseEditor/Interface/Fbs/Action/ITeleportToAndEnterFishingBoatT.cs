using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B6D RID: 31597
	public class ITeleportToAndEnterFishingBoatT
	{
		// Token: 0x1700EC9B RID: 60571
		// (get) Token: 0x06038E92 RID: 233106 RVA: 0x007B18DA File Offset: 0x007AFADA
		// (set) Token: 0x06038E93 RID: 233107 RVA: 0x007B18E2 File Offset: 0x007AFAE2
		public EVehicleType Type { get; set; }

		// Token: 0x06038E94 RID: 233108 RVA: 0x007B18EB File Offset: 0x007AFAEB
		public ITeleportToAndEnterFishingBoatT()
		{
			this.Type = EVehicleType.Gongduola;
		}
	}
}
