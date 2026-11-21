using System;
using System.Runtime.CompilerServices;

// Token: 0x02001158 RID: 4440
[NullableContext(1)]
public interface ICommonShowRoleInfo
{
	// Token: 0x17001220 RID: 4640
	// (get) Token: 0x0600B10F RID: 45327
	// (set) Token: 0x0600B110 RID: 45328
	IGachaViewOpenData ResultViewData { get; set; }

	// Token: 0x17001221 RID: 4641
	// (get) Token: 0x0600B111 RID: 45329
	// (set) Token: 0x0600B112 RID: 45330
	GachaResult[] GachaResult { get; set; }
}
