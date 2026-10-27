using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DDA RID: 24026
	public class IGiantStableValueTotalT
	{
		// Token: 0x1700B3DE RID: 46046
		// (get) Token: 0x06029206 RID: 168454 RVA: 0x005A4F37 File Offset: 0x005A3137
		// (set) Token: 0x06029207 RID: 168455 RVA: 0x005A4F3F File Offset: 0x005A313F
		public EGiantStableValueType Type { get; set; }

		// Token: 0x1700B3DF RID: 46047
		// (get) Token: 0x06029208 RID: 168456 RVA: 0x005A4F48 File Offset: 0x005A3148
		// (set) Token: 0x06029209 RID: 168457 RVA: 0x005A4F50 File Offset: 0x005A3150
		public IGiantStableValueRangeT Range { get; set; }

		// Token: 0x0602920A RID: 168458 RVA: 0x005A4F59 File Offset: 0x005A3159
		public IGiantStableValueTotalT()
		{
			this.Type = EGiantStableValueType.Region;
			this.Range = null;
		}
	}
}
