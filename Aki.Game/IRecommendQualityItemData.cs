using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C2D RID: 7213
[NullableContext(1)]
public interface IRecommendQualityItemData
{
	// Token: 0x17001B37 RID: 6967
	// (get) Token: 0x06011EC2 RID: 73410
	// (set) Token: 0x06011EC3 RID: 73411
	EGameQualitySettingLevel Quality { get; set; }

	// Token: 0x17001B38 RID: 6968
	// (get) Token: 0x06011EC4 RID: 73412
	// (set) Token: 0x06011EC5 RID: 73413
	string Name { get; set; }

	// Token: 0x17001B39 RID: 6969
	// (get) Token: 0x06011EC6 RID: 73414
	// (set) Token: 0x06011EC7 RID: 73415
	bool IsRecommend { get; set; }

	// Token: 0x17001B3A RID: 6970
	// (get) Token: 0x06011EC8 RID: 73416
	// (set) Token: 0x06011EC9 RID: 73417
	string Bg { get; set; }
}
