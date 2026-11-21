using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E28 RID: 24104
	public class IRefreshContentT
	{
		// Token: 0x1700B1A8 RID: 45480
		// (get) Token: 0x0602841C RID: 164892 RVA: 0x00581262 File Offset: 0x0057F462
		// (set) Token: 0x0602841D RID: 164893 RVA: 0x0058126A File Offset: 0x0057F46A
		public ERefreshContent Type { get; set; }

		// Token: 0x0602841E RID: 164894 RVA: 0x00581273 File Offset: 0x0057F473
		public IRefreshContentT()
		{
			this.Type = ERefreshContent.All;
		}
	}
}
