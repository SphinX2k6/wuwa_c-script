using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FAF RID: 24495
	public class IStateChangeConfigT
	{
		// Token: 0x1700B56C RID: 46444
		// (get) Token: 0x0602935E RID: 168798 RVA: 0x005A045E File Offset: 0x0059E65E
		// (set) Token: 0x0602935F RID: 168799 RVA: 0x005A0466 File Offset: 0x0059E666
		public string RefreshState { get; set; }

		// Token: 0x1700B56D RID: 46445
		// (get) Token: 0x06029360 RID: 168800 RVA: 0x005A046F File Offset: 0x0059E66F
		// (set) Token: 0x06029361 RID: 168801 RVA: 0x005A0477 File Offset: 0x0059E677
		public string SubDestroyState { get; set; }

		// Token: 0x06029362 RID: 168802 RVA: 0x005A0480 File Offset: 0x0059E680
		public IStateChangeConfigT()
		{
			this.RefreshState = null;
			this.SubDestroyState = null;
		}
	}
}
