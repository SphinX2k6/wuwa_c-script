using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200580F RID: 22543
	public class IReboundTypeT
	{
		// Token: 0x1700A86A RID: 43114
		// (get) Token: 0x06025E73 RID: 155251 RVA: 0x0053A136 File Offset: 0x00538336
		// (set) Token: 0x06025E74 RID: 155252 RVA: 0x0053A13E File Offset: 0x0053833E
		public EReboundOptionType Type { get; set; }

		// Token: 0x06025E75 RID: 155253 RVA: 0x0053A147 File Offset: 0x00538347
		public IReboundTypeT()
		{
			this.Type = EReboundOptionType.ForwardFront;
		}
	}
}
