using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007386 RID: 29574
	public class ITeleportToAndEnterFishingBoatT
	{
		// Token: 0x1700E08B RID: 57483
		// (get) Token: 0x06035AF7 RID: 219895 RVA: 0x0074F39A File Offset: 0x0074D59A
		// (set) Token: 0x06035AF8 RID: 219896 RVA: 0x0074F3A2 File Offset: 0x0074D5A2
		public EVehicleType Type { get; set; }

		// Token: 0x06035AF9 RID: 219897 RVA: 0x0074F3AB File Offset: 0x0074D5AB
		public ITeleportToAndEnterFishingBoatT()
		{
			this.Type = EVehicleType.Gongduola;
		}
	}
}
