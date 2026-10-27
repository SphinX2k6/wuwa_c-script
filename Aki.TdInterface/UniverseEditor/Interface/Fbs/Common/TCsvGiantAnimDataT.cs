using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E73 RID: 24179
	public class TCsvGiantAnimDataT
	{
		// Token: 0x1700B4C1 RID: 46273
		// (get) Token: 0x060296B2 RID: 169650 RVA: 0x005AD28B File Offset: 0x005AB48B
		// (set) Token: 0x060296B3 RID: 169651 RVA: 0x005AD293 File Offset: 0x005AB493
		public int Id { get; set; }

		// Token: 0x1700B4C2 RID: 46274
		// (get) Token: 0x060296B4 RID: 169652 RVA: 0x005AD29C File Offset: 0x005AB49C
		// (set) Token: 0x060296B5 RID: 169653 RVA: 0x005AD2A4 File Offset: 0x005AB4A4
		public IGiantAnimDataType_UnionUnion Data { get; set; }

		// Token: 0x060296B6 RID: 169654 RVA: 0x005AD2AD File Offset: 0x005AB4AD
		public TCsvGiantAnimDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
