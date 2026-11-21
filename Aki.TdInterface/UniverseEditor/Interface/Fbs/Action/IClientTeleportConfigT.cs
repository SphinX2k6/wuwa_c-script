using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A78 RID: 27256
	public class IClientTeleportConfigT
	{
		// Token: 0x1700C82F RID: 51247
		// (get) Token: 0x0602EC39 RID: 191545 RVA: 0x0065F7A6 File Offset: 0x0065D9A6
		// (set) Token: 0x0602EC3A RID: 191546 RVA: 0x0065F7AE File Offset: 0x0065D9AE
		public EClientTeleportType Type { get; set; }

		// Token: 0x0602EC3B RID: 191547 RVA: 0x0065F7B7 File Offset: 0x0065D9B7
		public IClientTeleportConfigT()
		{
			this.Type = EClientTeleportType.RelativeEntityPos;
		}
	}
}
