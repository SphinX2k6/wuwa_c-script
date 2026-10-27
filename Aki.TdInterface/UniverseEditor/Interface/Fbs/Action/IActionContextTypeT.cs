using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006075 RID: 24693
	public class IActionContextTypeT
	{
		// Token: 0x1700B5FD RID: 46589
		// (get) Token: 0x06029D1C RID: 171292 RVA: 0x005BCC6E File Offset: 0x005BAE6E
		// (set) Token: 0x06029D1D RID: 171293 RVA: 0x005BCC76 File Offset: 0x005BAE76
		public TActionContextType Type { get; set; }

		// Token: 0x06029D1E RID: 171294 RVA: 0x005BCC7F File Offset: 0x005BAE7F
		public IActionContextTypeT()
		{
			this.Type = TActionContextType.commonBt;
		}
	}
}
