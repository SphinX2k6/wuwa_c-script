using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DD4 RID: 24020
	public class IGiantStableValueRangeT
	{
		// Token: 0x1700B3D2 RID: 46034
		// (get) Token: 0x060291D6 RID: 168406 RVA: 0x005A497A File Offset: 0x005A2B7A
		// (set) Token: 0x060291D7 RID: 168407 RVA: 0x005A4982 File Offset: 0x005A2B82
		public IGiantStableValueT MinValue { get; set; }

		// Token: 0x1700B3D3 RID: 46035
		// (get) Token: 0x060291D8 RID: 168408 RVA: 0x005A498B File Offset: 0x005A2B8B
		// (set) Token: 0x060291D9 RID: 168409 RVA: 0x005A4993 File Offset: 0x005A2B93
		public IGiantStableValueT MaxValue { get; set; }

		// Token: 0x060291DA RID: 168410 RVA: 0x005A499C File Offset: 0x005A2B9C
		public IGiantStableValueRangeT()
		{
			this.MinValue = null;
			this.MaxValue = null;
		}
	}
}
