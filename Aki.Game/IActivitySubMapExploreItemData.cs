using System;
using System.Runtime.CompilerServices;

// Token: 0x020012C6 RID: 4806
[NullableContext(1)]
public interface IActivitySubMapExploreItemData
{
	// Token: 0x17000B38 RID: 2872
	// (get) Token: 0x0600840E RID: 33806
	// (set) Token: 0x0600840F RID: 33807
	int TaskId { get; set; }

	// Token: 0x17000B39 RID: 2873
	// (get) Token: 0x06008410 RID: 33808
	// (set) Token: 0x06008411 RID: 33809
	string RewardDesc { get; set; }

	// Token: 0x17000B3A RID: 2874
	// (get) Token: 0x06008412 RID: 33810
	// (set) Token: 0x06008413 RID: 33811
	int RewardItemId { get; set; }

	// Token: 0x17000B3B RID: 2875
	// (get) Token: 0x06008414 RID: 33812
	// (set) Token: 0x06008415 RID: 33813
	int? RewardItemCount { get; set; }

	// Token: 0x17000B3C RID: 2876
	// (get) Token: 0x06008416 RID: 33814
	// (set) Token: 0x06008417 RID: 33815
	bool IsComplete { get; set; }

	// Token: 0x17000B3D RID: 2877
	// (get) Token: 0x06008418 RID: 33816
	// (set) Token: 0x06008419 RID: 33817
	bool IsCanGet { get; set; }

	// Token: 0x17000B3E RID: 2878
	// (get) Token: 0x0600841A RID: 33818
	// (set) Token: 0x0600841B RID: 33819
	bool IsRunning { get; set; }
}
