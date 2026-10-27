using System;

namespace CSharpScript.Game.Module.FilterSort.Sort.SortEntrance
{
	// Token: 0x02005B32 RID: 23346
	public interface ISortData
	{
		// Token: 0x17008C8C RID: 35980
		// (get) Token: 0x0603B1C1 RID: 242113
		// (set) Token: 0x0603B1C2 RID: 242114
		int RuleId { get; set; }

		// Token: 0x17008C8D RID: 35981
		// (get) Token: 0x0603B1C3 RID: 242115
		// (set) Token: 0x0603B1C4 RID: 242116
		ESortDataType DataType { get; set; }

		// Token: 0x17008C8E RID: 35982
		// (get) Token: 0x0603B1C5 RID: 242117
		// (set) Token: 0x0603B1C6 RID: 242118
		int SelectedRule { get; set; }
	}
}
