using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D17 RID: 23831
	public class IAvgInterjectionT
	{
		// Token: 0x1700B294 RID: 45716
		// (get) Token: 0x06028B6D RID: 166765 RVA: 0x0059798A File Offset: 0x00595B8A
		// (set) Token: 0x06028B6E RID: 166766 RVA: 0x00597992 File Offset: 0x00595B92
		public string Word { get; set; }

		// Token: 0x1700B295 RID: 45717
		// (get) Token: 0x06028B6F RID: 166767 RVA: 0x0059799B File Offset: 0x00595B9B
		// (set) Token: 0x06028B70 RID: 166768 RVA: 0x005979A3 File Offset: 0x00595BA3
		public string AkEvent { get; set; }

		// Token: 0x06028B71 RID: 166769 RVA: 0x005979AC File Offset: 0x00595BAC
		public IAvgInterjectionT()
		{
			this.Word = null;
			this.AkEvent = null;
		}
	}
}
