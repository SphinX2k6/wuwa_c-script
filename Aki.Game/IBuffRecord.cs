using System;
using System.Runtime.CompilerServices;

// Token: 0x020032BE RID: 12990
[NullableContext(2)]
public interface IBuffRecord
{
	// Token: 0x17002716 RID: 10006
	// (get) Token: 0x0601C300 RID: 115456
	// (set) Token: 0x0601C301 RID: 115457
	long BuffId { get; set; }

	// Token: 0x17002717 RID: 10007
	// (get) Token: 0x0601C302 RID: 115458
	// (set) Token: 0x0601C303 RID: 115459
	float TimeStamp { get; set; }

	// Token: 0x17002718 RID: 10008
	// (get) Token: 0x0601C304 RID: 115460
	// (set) Token: 0x0601C305 RID: 115461
	int AreaId { get; set; }

	// Token: 0x17002719 RID: 10009
	// (get) Token: 0x0601C306 RID: 115462
	// (set) Token: 0x0601C307 RID: 115463
	Vector Location { get; set; }

	// Token: 0x1700271A RID: 10010
	// (get) Token: 0x0601C308 RID: 115464
	// (set) Token: 0x0601C309 RID: 115465
	float Damage { get; set; }
}
