using System;
using System.Runtime.CompilerServices;

// Token: 0x02002886 RID: 10374
[NullableContext(2)]
public interface IAttributeInfo
{
	// Token: 0x17001C89 RID: 7305
	// (get) Token: 0x06015593 RID: 87443
	// (set) Token: 0x06015594 RID: 87444
	string Name { get; set; }

	// Token: 0x17001C8A RID: 7306
	// (get) Token: 0x06015595 RID: 87445
	// (set) Token: 0x06015596 RID: 87446
	string IconPath { get; set; }

	// Token: 0x17001C8B RID: 7307
	// (get) Token: 0x06015597 RID: 87447
	// (set) Token: 0x06015598 RID: 87448
	bool? ShowArrow { get; set; }

	// Token: 0x17001C8C RID: 7308
	// (get) Token: 0x06015599 RID: 87449
	// (set) Token: 0x0601559A RID: 87450
	string PreText { get; set; }

	// Token: 0x17001C8D RID: 7309
	// (get) Token: 0x0601559B RID: 87451
	// (set) Token: 0x0601559C RID: 87452
	string CurText { get; set; }

	// Token: 0x17001C8E RID: 7310
	// (get) Token: 0x0601559D RID: 87453
	// (set) Token: 0x0601559E RID: 87454
	bool? IsNormalBg { get; set; }

	// Token: 0x17001C8F RID: 7311
	// (get) Token: 0x0601559F RID: 87455
	// (set) Token: 0x060155A0 RID: 87456
	bool? InnerShowBg { get; set; }

	// Token: 0x17001C90 RID: 7312
	// (get) Token: 0x060155A1 RID: 87457
	// (set) Token: 0x060155A2 RID: 87458
	bool? IsLine { get; set; }
}
