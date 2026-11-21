using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E4C RID: 24140
	public class IRenderFlagT
	{
		// Token: 0x1700B1F7 RID: 45559
		// (get) Token: 0x06028572 RID: 165234 RVA: 0x00583E64 File Offset: 0x00582064
		// (set) Token: 0x06028573 RID: 165235 RVA: 0x00583E6C File Offset: 0x0058206C
		public ERenderFlagType Type { get; set; }

		// Token: 0x1700B1F8 RID: 45560
		// (get) Token: 0x06028574 RID: 165236 RVA: 0x00583E75 File Offset: 0x00582075
		// (set) Token: 0x06028575 RID: 165237 RVA: 0x00583E7D File Offset: 0x0058207D
		public bool Enable { get; set; }

		// Token: 0x06028576 RID: 165238 RVA: 0x00583E86 File Offset: 0x00582086
		public IRenderFlagT()
		{
			this.Type = ERenderFlagType.Fog;
			this.Enable = false;
		}
	}
}
