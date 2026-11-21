using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A6C RID: 27244
	public class IClientSetPlayerPosT
	{
		// Token: 0x1700C822 RID: 51234
		// (get) Token: 0x0602EBED RID: 191469 RVA: 0x0065EFBD File Offset: 0x0065D1BD
		// (set) Token: 0x0602EBEE RID: 191470 RVA: 0x0065EFC5 File Offset: 0x0065D1C5
		public TClientTeleportConfigUnion TelePortConfig { get; set; }

		// Token: 0x0602EBEF RID: 191471 RVA: 0x0065EFCE File Offset: 0x0065D1CE
		public IClientSetPlayerPosT()
		{
			this.TelePortConfig = null;
		}
	}
}
