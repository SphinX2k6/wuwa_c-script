using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007933 RID: 31027
	public class ISolarSchoolTimeT
	{
		// Token: 0x1700E399 RID: 58265
		// (get) Token: 0x06036A3C RID: 223804 RVA: 0x0074FB87 File Offset: 0x0074DD87
		// (set) Token: 0x06036A3D RID: 223805 RVA: 0x0074FB8F File Offset: 0x0074DD8F
		public IVisualNovelDateT Date { get; set; }

		// Token: 0x1700E39A RID: 58266
		// (get) Token: 0x06036A3E RID: 223806 RVA: 0x0074FB98 File Offset: 0x0074DD98
		// (set) Token: 0x06036A3F RID: 223807 RVA: 0x0074FBA0 File Offset: 0x0074DDA0
		public int PeriodId { get; set; }

		// Token: 0x06036A40 RID: 223808 RVA: 0x0074FBA9 File Offset: 0x0074DDA9
		public ISolarSchoolTimeT()
		{
			this.Date = null;
			this.PeriodId = 0;
		}
	}
}
