using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C93 RID: 31891
	public class IUiAnimConfigT
	{
		// Token: 0x1700EED0 RID: 61136
		// (get) Token: 0x0603984D RID: 235597 RVA: 0x007C380A File Offset: 0x007C1A0A
		// (set) Token: 0x0603984E RID: 235598 RVA: 0x007C3812 File Offset: 0x007C1A12
		public string UiStartAnimName { get; set; }

		// Token: 0x1700EED1 RID: 61137
		// (get) Token: 0x0603984F RID: 235599 RVA: 0x007C381B File Offset: 0x007C1A1B
		// (set) Token: 0x06039850 RID: 235600 RVA: 0x007C3823 File Offset: 0x007C1A23
		public string UiEndAnimName { get; set; }

		// Token: 0x06039851 RID: 235601 RVA: 0x007C382C File Offset: 0x007C1A2C
		public IUiAnimConfigT()
		{
			this.UiStartAnimName = null;
			this.UiEndAnimName = null;
		}
	}
}
