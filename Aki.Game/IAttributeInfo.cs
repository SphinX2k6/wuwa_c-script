using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E01 RID: 7681
[NullableContext(2)]
public interface IAttributeInfo
{
	// Token: 0x17001CE1 RID: 7393
	// (get) Token: 0x06012F91 RID: 77713
	// (set) Token: 0x06012F92 RID: 77714
	string Name { get; set; }

	// Token: 0x17001CE2 RID: 7394
	// (get) Token: 0x06012F93 RID: 77715
	// (set) Token: 0x06012F94 RID: 77716
	string IconPath { get; set; }

	// Token: 0x17001CE3 RID: 7395
	// (get) Token: 0x06012F95 RID: 77717
	// (set) Token: 0x06012F96 RID: 77718
	bool? ShowArrow { get; set; }

	// Token: 0x17001CE4 RID: 7396
	// (get) Token: 0x06012F97 RID: 77719
	// (set) Token: 0x06012F98 RID: 77720
	string PreText { get; set; }

	// Token: 0x17001CE5 RID: 7397
	// (get) Token: 0x06012F99 RID: 77721
	// (set) Token: 0x06012F9A RID: 77722
	string CurText { get; set; }

	// Token: 0x17001CE6 RID: 7398
	// (get) Token: 0x06012F9B RID: 77723
	// (set) Token: 0x06012F9C RID: 77724
	bool? IsNormalBg { get; set; }

	// Token: 0x17001CE7 RID: 7399
	// (get) Token: 0x06012F9D RID: 77725
	// (set) Token: 0x06012F9E RID: 77726
	bool? InnerShowBg { get; set; }

	// Token: 0x17001CE8 RID: 7400
	// (get) Token: 0x06012F9F RID: 77727
	// (set) Token: 0x06012FA0 RID: 77728
	bool? IsLine { get; set; }
}
