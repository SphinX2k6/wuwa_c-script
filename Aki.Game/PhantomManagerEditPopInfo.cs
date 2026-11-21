using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001903 RID: 6403
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerEditPopInfo : IPhantomManagerEditPopInfo
{
	// Token: 0x1700183C RID: 6204
	// (get) Token: 0x0600FCD1 RID: 64721 RVA: 0x0049CB40 File Offset: 0x0049AD40
	// (set) Token: 0x0600FCD2 RID: 64722 RVA: 0x0049CB48 File Offset: 0x0049AD48
	public int FetterId { get; set; }

	// Token: 0x1700183D RID: 6205
	// (get) Token: 0x0600FCD3 RID: 64723 RVA: 0x0049CB51 File Offset: 0x0049AD51
	// (set) Token: 0x0600FCD4 RID: 64724 RVA: 0x0049CB59 File Offset: 0x0049AD59
	public int Count { get; set; }

	// Token: 0x1700183E RID: 6206
	// (get) Token: 0x0600FCD5 RID: 64725 RVA: 0x0049CB62 File Offset: 0x0049AD62
	// (set) Token: 0x0600FCD6 RID: 64726 RVA: 0x0049CB6A File Offset: 0x0049AD6A
	public List<IPhantomManagerConfigNewSettingInfo> DataList { get; set; } = new List<IPhantomManagerConfigNewSettingInfo>();

	// Token: 0x1700183F RID: 6207
	// (get) Token: 0x0600FCD7 RID: 64727 RVA: 0x0049CB73 File Offset: 0x0049AD73
	// (set) Token: 0x0600FCD8 RID: 64728 RVA: 0x0049CB7B File Offset: 0x0049AD7B
	[Nullable(2)]
	public Action CloseCb { [NullableContext(2)] get; [NullableContext(2)] set; }
}
