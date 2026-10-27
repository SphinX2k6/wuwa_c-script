using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200607E RID: 24702
	public class IActionInfoT
	{
		// Token: 0x1700B614 RID: 46612
		// (get) Token: 0x06029D7A RID: 171386 RVA: 0x005BD7E3 File Offset: 0x005BB9E3
		// (set) Token: 0x06029D7B RID: 171387 RVA: 0x005BD7EB File Offset: 0x005BB9EB
		public EAction Name { get; set; }

		// Token: 0x1700B615 RID: 46613
		// (get) Token: 0x06029D7C RID: 171388 RVA: 0x005BD7F4 File Offset: 0x005BB9F4
		// (set) Token: 0x06029D7D RID: 171389 RVA: 0x005BD7FC File Offset: 0x005BB9FC
		public bool Async { get; set; }

		// Token: 0x1700B616 RID: 46614
		// (get) Token: 0x06029D7E RID: 171390 RVA: 0x005BD805 File Offset: 0x005BBA05
		// (set) Token: 0x06029D7F RID: 171391 RVA: 0x005BD80D File Offset: 0x005BBA0D
		public IActionParams_UnionT Params { get; set; }

		// Token: 0x1700B617 RID: 46615
		// (get) Token: 0x06029D80 RID: 171392 RVA: 0x005BD816 File Offset: 0x005BBA16
		// (set) Token: 0x06029D81 RID: 171393 RVA: 0x005BD81E File Offset: 0x005BBA1E
		public int ActionId { get; set; }

		// Token: 0x1700B618 RID: 46616
		// (get) Token: 0x06029D82 RID: 171394 RVA: 0x005BD827 File Offset: 0x005BBA27
		// (set) Token: 0x06029D83 RID: 171395 RVA: 0x005BD82F File Offset: 0x005BBA2F
		public bool Disabled { get; set; }

		// Token: 0x1700B619 RID: 46617
		// (get) Token: 0x06029D84 RID: 171396 RVA: 0x005BD838 File Offset: 0x005BBA38
		// (set) Token: 0x06029D85 RID: 171397 RVA: 0x005BD840 File Offset: 0x005BBA40
		public string ActionGuid { get; set; }

		// Token: 0x1700B61A RID: 46618
		// (get) Token: 0x06029D86 RID: 171398 RVA: 0x005BD849 File Offset: 0x005BBA49
		// (set) Token: 0x06029D87 RID: 171399 RVA: 0x005BD851 File Offset: 0x005BBA51
		public float Timeout { get; set; }

		// Token: 0x1700B61B RID: 46619
		// (get) Token: 0x06029D88 RID: 171400 RVA: 0x005BD85A File Offset: 0x005BBA5A
		// (set) Token: 0x06029D89 RID: 171401 RVA: 0x005BD862 File Offset: 0x005BBA62
		public byte NullMask { get; set; }

		// Token: 0x06029D8A RID: 171402 RVA: 0x005BD86C File Offset: 0x005BBA6C
		public IActionInfoT()
		{
			this.Name = EAction.Undefined;
			this.Async = false;
			this.Params = null;
			this.ActionId = 0;
			this.Disabled = false;
			this.ActionGuid = null;
			this.Timeout = 0f;
			this.NullMask = 0;
		}
	}
}
