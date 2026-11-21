using System;
using System.Runtime.CompilerServices;

// Token: 0x020002F7 RID: 759
[NullableContext(1)]
public interface IShareInfo
{
	// Token: 0x1700067E RID: 1662
	// (get) Token: 0x06002B6F RID: 11119
	// (set) Token: 0x06002B70 RID: 11120
	string ImageData { get; set; }

	// Token: 0x1700067F RID: 1663
	// (get) Token: 0x06002B71 RID: 11121
	// (set) Token: 0x06002B72 RID: 11122
	ShareData ShareData { get; set; }
}
