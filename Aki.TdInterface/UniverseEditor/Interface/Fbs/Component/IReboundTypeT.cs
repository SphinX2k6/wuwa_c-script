using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E16 RID: 24086
	public class IReboundTypeT
	{
		// Token: 0x1700B18E RID: 45454
		// (get) Token: 0x06028393 RID: 164755 RVA: 0x005802C2 File Offset: 0x0057E4C2
		// (set) Token: 0x06028394 RID: 164756 RVA: 0x005802CA File Offset: 0x0057E4CA
		public EReboundOptionType Type { get; set; }

		// Token: 0x06028395 RID: 164757 RVA: 0x005802D3 File Offset: 0x0057E4D3
		public IReboundTypeT()
		{
			this.Type = EReboundOptionType.ForwardFront;
		}
	}
}
