using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E1A RID: 3610
[NullableContext(1)]
public interface IShareData
{
	// Token: 0x1700060E RID: 1550
	// (get) Token: 0x06005690 RID: 22160
	// (set) Token: 0x06005691 RID: 22161
	string platform { get; set; }

	// Token: 0x1700060F RID: 1551
	// (get) Token: 0x06005692 RID: 22162
	// (set) Token: 0x06005693 RID: 22163
	string title { get; set; }

	// Token: 0x17000610 RID: 1552
	// (get) Token: 0x06005694 RID: 22164
	// (set) Token: 0x06005695 RID: 22165
	string text { get; set; }

	// Token: 0x17000611 RID: 1553
	// (get) Token: 0x06005696 RID: 22166
	// (set) Token: 0x06005697 RID: 22167
	string topicId { get; set; }

	// Token: 0x17000612 RID: 1554
	// (get) Token: 0x06005698 RID: 22168
	// (set) Token: 0x06005699 RID: 22169
	string topicName { get; set; }
}
