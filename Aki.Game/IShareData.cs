using System;
using System.Runtime.CompilerServices;

// Token: 0x020002CE RID: 718
[NullableContext(1)]
public interface IShareData
{
	// Token: 0x17000632 RID: 1586
	// (get) Token: 0x06002A20 RID: 10784
	// (set) Token: 0x06002A21 RID: 10785
	string platform { get; set; }

	// Token: 0x17000633 RID: 1587
	// (get) Token: 0x06002A22 RID: 10786
	// (set) Token: 0x06002A23 RID: 10787
	string title { get; set; }

	// Token: 0x17000634 RID: 1588
	// (get) Token: 0x06002A24 RID: 10788
	// (set) Token: 0x06002A25 RID: 10789
	string text { get; set; }

	// Token: 0x17000635 RID: 1589
	// (get) Token: 0x06002A26 RID: 10790
	// (set) Token: 0x06002A27 RID: 10791
	string topicId { get; set; }

	// Token: 0x17000636 RID: 1590
	// (get) Token: 0x06002A28 RID: 10792
	// (set) Token: 0x06002A29 RID: 10793
	string topicName { get; set; }
}
