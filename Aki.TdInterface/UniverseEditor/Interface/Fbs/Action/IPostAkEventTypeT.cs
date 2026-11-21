using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F9 RID: 29945
	public class IPostAkEventTypeT
	{
		// Token: 0x1700DC6F RID: 56431
		// (get) Token: 0x06034840 RID: 215104 RVA: 0x00711CC2 File Offset: 0x0070FEC2
		// (set) Token: 0x06034841 RID: 215105 RVA: 0x00711CCA File Offset: 0x0070FECA
		public EPostAkEvent Type { get; set; }

		// Token: 0x06034842 RID: 215106 RVA: 0x00711CD3 File Offset: 0x0070FED3
		public IPostAkEventTypeT()
		{
			this.Type = EPostAkEvent.Global;
		}
	}
}
