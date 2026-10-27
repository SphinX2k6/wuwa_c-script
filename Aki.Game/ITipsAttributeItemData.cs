using System;
using System.Runtime.CompilerServices;

// Token: 0x020018D5 RID: 6357
[NullableContext(1)]
public interface ITipsAttributeItemData
{
	// Token: 0x17000F76 RID: 3958
	// (get) Token: 0x0600BA7F RID: 47743
	// (set) Token: 0x0600BA80 RID: 47744
	int Id { get; set; }

	// Token: 0x17000F77 RID: 3959
	// (get) Token: 0x0600BA81 RID: 47745
	// (set) Token: 0x0600BA82 RID: 47746
	bool IsMainAttribute { get; set; }

	// Token: 0x17000F78 RID: 3960
	// (get) Token: 0x0600BA83 RID: 47747
	// (set) Token: 0x0600BA84 RID: 47748
	string Name { get; set; }

	// Token: 0x17000F79 RID: 3961
	// (get) Token: 0x0600BA85 RID: 47749
	// (set) Token: 0x0600BA86 RID: 47750
	string IconPath { get; set; }

	// Token: 0x17000F7A RID: 3962
	// (get) Token: 0x0600BA87 RID: 47751
	// (set) Token: 0x0600BA88 RID: 47752
	double Value { get; set; }

	// Token: 0x17000F7B RID: 3963
	// (get) Token: 0x0600BA89 RID: 47753
	// (set) Token: 0x0600BA8A RID: 47754
	bool IsRatio { get; set; }
}
