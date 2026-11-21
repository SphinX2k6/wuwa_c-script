using System;

namespace CSharpScript.Game.Module.FilterSort.Sort.SortEntrance
{
	// Token: 0x02004B13 RID: 19219
	public interface ISortData
	{
		// Token: 0x17006066 RID: 24678
		// (get) Token: 0x06030133 RID: 196915
		// (set) Token: 0x06030134 RID: 196916
		int RuleId { get; set; }

		// Token: 0x17006067 RID: 24679
		// (get) Token: 0x06030135 RID: 196917
		// (set) Token: 0x06030136 RID: 196918
		ESortDataType DataType { get; set; }

		// Token: 0x17006068 RID: 24680
		// (get) Token: 0x06030137 RID: 196919
		// (set) Token: 0x06030138 RID: 196920
		int SelectedRule { get; set; }
	}
}
