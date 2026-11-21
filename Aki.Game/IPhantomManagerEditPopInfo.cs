using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001902 RID: 6402
[NullableContext(1)]
public interface IPhantomManagerEditPopInfo
{
	// Token: 0x17001838 RID: 6200
	// (get) Token: 0x0600FCC9 RID: 64713
	// (set) Token: 0x0600FCCA RID: 64714
	int FetterId { get; set; }

	// Token: 0x17001839 RID: 6201
	// (get) Token: 0x0600FCCB RID: 64715
	// (set) Token: 0x0600FCCC RID: 64716
	int Count { get; set; }

	// Token: 0x1700183A RID: 6202
	// (get) Token: 0x0600FCCD RID: 64717
	// (set) Token: 0x0600FCCE RID: 64718
	List<IPhantomManagerConfigNewSettingInfo> DataList { get; set; }

	// Token: 0x1700183B RID: 6203
	// (get) Token: 0x0600FCCF RID: 64719
	// (set) Token: 0x0600FCD0 RID: 64720
	[Nullable(2)]
	Action CloseCb { [NullableContext(2)] get; [NullableContext(2)] set; }
}
