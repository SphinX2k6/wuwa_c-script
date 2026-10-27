using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AA8 RID: 6824
[NullableContext(2)]
public interface IMapExploreStoryItemData
{
	// Token: 0x170010A6 RID: 4262
	// (get) Token: 0x0600CA1F RID: 51743
	// (set) Token: 0x0600CA20 RID: 51744
	bool IsOpen { get; set; }

	// Token: 0x170010A7 RID: 4263
	// (get) Token: 0x0600CA21 RID: 51745
	// (set) Token: 0x0600CA22 RID: 51746
	string StoryContent { get; set; }

	// Token: 0x170010A8 RID: 4264
	// (get) Token: 0x0600CA23 RID: 51747
	// (set) Token: 0x0600CA24 RID: 51748
	string StoryTitle { get; set; }

	// Token: 0x170010A9 RID: 4265
	// (get) Token: 0x0600CA25 RID: 51749
	// (set) Token: 0x0600CA26 RID: 51750
	string LockedDesc { get; set; }

	// Token: 0x170010AA RID: 4266
	// (get) Token: 0x0600CA27 RID: 51751
	// (set) Token: 0x0600CA28 RID: 51752
	bool? IsNewOpen { get; set; }
}
