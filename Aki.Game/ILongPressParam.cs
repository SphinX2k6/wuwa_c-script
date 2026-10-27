using System;

// Token: 0x02002483 RID: 9347
public interface ILongPressParam
{
	// Token: 0x17001890 RID: 6288
	// (get) Token: 0x06012C0E RID: 76814
	// (set) Token: 0x06012C0F RID: 76815
	float BeforeLongPressThreshold { get; set; }

	// Token: 0x17001891 RID: 6289
	// (get) Token: 0x06012C10 RID: 76816
	// (set) Token: 0x06012C11 RID: 76817
	float LongPressThreshold { get; set; }

	// Token: 0x17001892 RID: 6290
	// (get) Token: 0x06012C12 RID: 76818
	// (set) Token: 0x06012C13 RID: 76819
	float InvalidMoveDistance { get; set; }

	// Token: 0x17001893 RID: 6291
	// (get) Token: 0x06012C14 RID: 76820
	// (set) Token: 0x06012C15 RID: 76821
	float OffsetX { get; set; }

	// Token: 0x17001894 RID: 6292
	// (get) Token: 0x06012C16 RID: 76822
	// (set) Token: 0x06012C17 RID: 76823
	float OffsetY { get; set; }
}
