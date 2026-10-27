using System;

namespace CSharpScript.Game.Module.FilterSort.Sort.SortEntrance
{
	// Token: 0x02005B33 RID: 23347
	public class SortData : ISortData
	{
		// Token: 0x17008C8F RID: 35983
		// (get) Token: 0x0603B1C7 RID: 242119 RVA: 0x00E1891B File Offset: 0x00E16B1B
		// (set) Token: 0x0603B1C8 RID: 242120 RVA: 0x00E18923 File Offset: 0x00E16B23
		public int RuleId { get; set; }

		// Token: 0x17008C90 RID: 35984
		// (get) Token: 0x0603B1C9 RID: 242121 RVA: 0x00E1892C File Offset: 0x00E16B2C
		// (set) Token: 0x0603B1CA RID: 242122 RVA: 0x00E18934 File Offset: 0x00E16B34
		public ESortDataType DataType { get; set; }

		// Token: 0x17008C91 RID: 35985
		// (get) Token: 0x0603B1CB RID: 242123 RVA: 0x00E1893D File Offset: 0x00E16B3D
		// (set) Token: 0x0603B1CC RID: 242124 RVA: 0x00E18945 File Offset: 0x00E16B45
		public int SelectedRule { get; set; }
	}
}
