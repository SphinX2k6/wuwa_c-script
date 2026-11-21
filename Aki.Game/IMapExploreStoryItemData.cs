using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F67 RID: 3943
[NullableContext(2)]
public interface IMapExploreStoryItemData
{
	// Token: 0x170010CB RID: 4299
	// (get) Token: 0x06009E30 RID: 40496
	// (set) Token: 0x06009E31 RID: 40497
	bool IsOpen { get; set; }

	// Token: 0x170010CC RID: 4300
	// (get) Token: 0x06009E32 RID: 40498
	// (set) Token: 0x06009E33 RID: 40499
	string StoryContent { get; set; }

	// Token: 0x170010CD RID: 4301
	// (get) Token: 0x06009E34 RID: 40500
	// (set) Token: 0x06009E35 RID: 40501
	string StoryTitle { get; set; }

	// Token: 0x170010CE RID: 4302
	// (get) Token: 0x06009E36 RID: 40502
	// (set) Token: 0x06009E37 RID: 40503
	string LockedDesc { get; set; }

	// Token: 0x170010CF RID: 4303
	// (get) Token: 0x06009E38 RID: 40504
	// (set) Token: 0x06009E39 RID: 40505
	bool? IsNewOpen { get; set; }
}
