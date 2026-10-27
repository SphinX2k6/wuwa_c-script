using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007398 RID: 29592
	public class ITeleportToVehicleInfoT
	{
		// Token: 0x1700E09C RID: 57500
		// (get) Token: 0x06035B5D RID: 219997 RVA: 0x0074FCF6 File Offset: 0x0074DEF6
		// (set) Token: 0x06035B5E RID: 219998 RVA: 0x0074FCFE File Offset: 0x0074DEFE
		public EVehicleType Type { get; set; }

		// Token: 0x06035B5F RID: 219999 RVA: 0x0074FD07 File Offset: 0x0074DF07
		public ITeleportToVehicleInfoT()
		{
			this.Type = EVehicleType.Gongduola;
		}
	}
}
