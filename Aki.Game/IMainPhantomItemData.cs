using System;
using System.Runtime.CompilerServices;

// Token: 0x02001996 RID: 6550
[NullableContext(1)]
public interface IMainPhantomItemData
{
	// Token: 0x170018E3 RID: 6371
	// (get) Token: 0x06010268 RID: 66152
	// (set) Token: 0x06010269 RID: 66153
	MainPhantomRecommendInfo Info { get; set; }

	// Token: 0x170018E4 RID: 6372
	// (get) Token: 0x0601026A RID: 66154
	// (set) Token: 0x0601026B RID: 66155
	[Nullable(2)]
	VisionMainSelectPhantomData CurrentSelectMainPhantom { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170018E5 RID: 6373
	// (get) Token: 0x0601026C RID: 66156
	// (set) Token: 0x0601026D RID: 66157
	Action<IMainPhantomItemData> OnMainPhantomCallBack { get; set; }
}
