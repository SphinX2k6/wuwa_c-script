using System;
using System.Runtime.CompilerServices;

// Token: 0x02002742 RID: 10050
[NullableContext(1)]
public interface IRecommendQualityItemData
{
	// Token: 0x17001AFF RID: 6911
	// (get) Token: 0x060149E0 RID: 84448
	// (set) Token: 0x060149E1 RID: 84449
	EGameQualitySettingLevel Quality { get; set; }

	// Token: 0x17001B00 RID: 6912
	// (get) Token: 0x060149E2 RID: 84450
	// (set) Token: 0x060149E3 RID: 84451
	string Name { get; set; }

	// Token: 0x17001B01 RID: 6913
	// (get) Token: 0x060149E4 RID: 84452
	// (set) Token: 0x060149E5 RID: 84453
	bool IsRecommend { get; set; }

	// Token: 0x17001B02 RID: 6914
	// (get) Token: 0x060149E6 RID: 84454
	// (set) Token: 0x060149E7 RID: 84455
	string Bg { get; set; }
}
