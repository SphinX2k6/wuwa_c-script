using System;

// Token: 0x02002078 RID: 8312
public interface IHonamiStoryLoadingData : ISpecialCustomLoadingData
{
	// Token: 0x17001430 RID: 5168
	// (get) Token: 0x060105CA RID: 67018
	// (set) Token: 0x060105CB RID: 67019
	int? LoadingId { get; set; }

	// Token: 0x17001431 RID: 5169
	// (get) Token: 0x060105CC RID: 67020
	// (set) Token: 0x060105CD RID: 67021
	int? BtId { get; set; }

	// Token: 0x17001432 RID: 5170
	// (get) Token: 0x060105CE RID: 67022
	// (set) Token: 0x060105CF RID: 67023
	int? Timing { get; set; }
}
