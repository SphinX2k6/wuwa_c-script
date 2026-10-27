using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007167 RID: 29031
	public class ISolarSchoolTimeT
	{
		// Token: 0x1700D7B4 RID: 55220
		// (get) Token: 0x06033792 RID: 210834 RVA: 0x006EF37B File Offset: 0x006ED57B
		// (set) Token: 0x06033793 RID: 210835 RVA: 0x006EF383 File Offset: 0x006ED583
		public IVisualNovelDateT Date { get; set; }

		// Token: 0x1700D7B5 RID: 55221
		// (get) Token: 0x06033794 RID: 210836 RVA: 0x006EF38C File Offset: 0x006ED58C
		// (set) Token: 0x06033795 RID: 210837 RVA: 0x006EF394 File Offset: 0x006ED594
		public int PeriodId { get; set; }

		// Token: 0x06033796 RID: 210838 RVA: 0x006EF39D File Offset: 0x006ED59D
		public ISolarSchoolTimeT()
		{
			this.Date = null;
			this.PeriodId = 0;
		}
	}
}
