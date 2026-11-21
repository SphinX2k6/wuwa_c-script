using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064B6 RID: 25782
	public class TCsvGiantAnimDataT
	{
		// Token: 0x1700BE2C RID: 48684
		// (get) Token: 0x0602BD5A RID: 179546 RVA: 0x005F622F File Offset: 0x005F442F
		// (set) Token: 0x0602BD5B RID: 179547 RVA: 0x005F6237 File Offset: 0x005F4437
		public int Id { get; set; }

		// Token: 0x1700BE2D RID: 48685
		// (get) Token: 0x0602BD5C RID: 179548 RVA: 0x005F6240 File Offset: 0x005F4440
		// (set) Token: 0x0602BD5D RID: 179549 RVA: 0x005F6248 File Offset: 0x005F4448
		public IGiantAnimDataType_UnionUnion Data { get; set; }

		// Token: 0x0602BD5E RID: 179550 RVA: 0x005F6251 File Offset: 0x005F4451
		public TCsvGiantAnimDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
