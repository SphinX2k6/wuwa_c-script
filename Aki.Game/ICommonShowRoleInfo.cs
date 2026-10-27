using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C99 RID: 7321
[NullableContext(1)]
public interface ICommonShowRoleInfo
{
	// Token: 0x170011FA RID: 4602
	// (get) Token: 0x0600DCF9 RID: 56569
	// (set) Token: 0x0600DCFA RID: 56570
	IGachaViewOpenData ResultViewData { get; set; }

	// Token: 0x170011FB RID: 4603
	// (get) Token: 0x0600DCFB RID: 56571
	// (set) Token: 0x0600DCFC RID: 56572
	GachaResult[] GachaResult { get; set; }
}
