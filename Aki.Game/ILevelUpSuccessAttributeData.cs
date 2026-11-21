using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E07 RID: 7687
[NullableContext(2)]
public interface ILevelUpSuccessAttributeData
{
	// Token: 0x17001D03 RID: 7427
	// (get) Token: 0x06012FD8 RID: 77784
	// (set) Token: 0x06012FD9 RID: 77785
	string Title { get; set; }

	// Token: 0x17001D04 RID: 7428
	// (get) Token: 0x06012FDA RID: 77786
	// (set) Token: 0x06012FDB RID: 77787
	string AudioId { get; set; }

	// Token: 0x17001D05 RID: 7429
	// (get) Token: 0x06012FDC RID: 77788
	// (set) Token: 0x06012FDD RID: 77789
	ILevelInfo LevelInfo { get; set; }

	// Token: 0x17001D06 RID: 7430
	// (get) Token: 0x06012FDE RID: 77790
	// (set) Token: 0x06012FDF RID: 77791
	[Nullable(1)]
	List<IAttributeInfo> AttributeInfo { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001D07 RID: 7431
	// (get) Token: 0x06012FE0 RID: 77792
	// (set) Token: 0x06012FE1 RID: 77793
	bool? IsShowArrow { get; set; }

	// Token: 0x17001D08 RID: 7432
	// (get) Token: 0x06012FE2 RID: 77794
	// (set) Token: 0x06012FE3 RID: 77795
	string ClickText { get; set; }

	// Token: 0x17001D09 RID: 7433
	// (get) Token: 0x06012FE4 RID: 77796
	// (set) Token: 0x06012FE5 RID: 77797
	Action ClickFunction { get; set; }

	// Token: 0x17001D0A RID: 7434
	// (get) Token: 0x06012FE6 RID: 77798
	// (set) Token: 0x06012FE7 RID: 77799
	bool? WiderScrollView { get; set; }

	// Token: 0x17001D0B RID: 7435
	// (get) Token: 0x06012FE8 RID: 77800
	// (set) Token: 0x06012FE9 RID: 77801
	IStrengthUpgradeData StrengthUpgradeData { get; set; }
}
