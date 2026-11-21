using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F6 RID: 29942
	public class IPostAkEventTargetedT
	{
		// Token: 0x1700DC6A RID: 56426
		// (get) Token: 0x0603482A RID: 215082 RVA: 0x00711B01 File Offset: 0x0070FD01
		// (set) Token: 0x0603482B RID: 215083 RVA: 0x00711B09 File Offset: 0x0070FD09
		public EPostAkEvent Type { get; set; }

		// Token: 0x1700DC6B RID: 56427
		// (get) Token: 0x0603482C RID: 215084 RVA: 0x00711B12 File Offset: 0x0070FD12
		// (set) Token: 0x0603482D RID: 215085 RVA: 0x00711B1A File Offset: 0x0070FD1A
		public int EntityId { get; set; }

		// Token: 0x1700DC6C RID: 56428
		// (get) Token: 0x0603482E RID: 215086 RVA: 0x00711B23 File Offset: 0x0070FD23
		// (set) Token: 0x0603482F RID: 215087 RVA: 0x00711B2B File Offset: 0x0070FD2B
		public string AkEvent { get; set; }

		// Token: 0x06034830 RID: 215088 RVA: 0x00711B34 File Offset: 0x0070FD34
		public IPostAkEventTargetedT()
		{
			this.Type = EPostAkEvent.Global;
			this.EntityId = 0;
			this.AkEvent = null;
		}
	}
}
