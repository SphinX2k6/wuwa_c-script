using System;

namespace CSharpScript.Game.Module.FilterSort.Sort.SortEntrance
{
	// Token: 0x02004B14 RID: 19220
	public class SortData : ISortData
	{
		// Token: 0x17006069 RID: 24681
		// (get) Token: 0x06030139 RID: 196921 RVA: 0x00D69633 File Offset: 0x00D67833
		// (set) Token: 0x0603013A RID: 196922 RVA: 0x00D6963B File Offset: 0x00D6783B
		public int RuleId { get; set; }

		// Token: 0x1700606A RID: 24682
		// (get) Token: 0x0603013B RID: 196923 RVA: 0x00D69644 File Offset: 0x00D67844
		// (set) Token: 0x0603013C RID: 196924 RVA: 0x00D6964C File Offset: 0x00D6784C
		public ESortDataType DataType { get; set; }

		// Token: 0x1700606B RID: 24683
		// (get) Token: 0x0603013D RID: 196925 RVA: 0x00D69655 File Offset: 0x00D67855
		// (set) Token: 0x0603013E RID: 196926 RVA: 0x00D6965D File Offset: 0x00D6785D
		public int SelectedRule { get; set; }
	}
}
