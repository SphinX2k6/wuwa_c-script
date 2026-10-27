using System;
using System.Runtime.CompilerServices;

// Token: 0x020027DD RID: 10205
[NullableContext(1)]
public interface IRoleDevRootTabData
{
	// Token: 0x17001B5A RID: 7002
	// (get) Token: 0x06014F50 RID: 85840
	// (set) Token: 0x06014F51 RID: 85841
	ERoleDevTabType TabIndex { get; set; }

	// Token: 0x17001B5B RID: 7003
	// (get) Token: 0x06014F52 RID: 85842
	// (set) Token: 0x06014F53 RID: 85843
	string TabName { get; set; }

	// Token: 0x17001B5C RID: 7004
	// (get) Token: 0x06014F54 RID: 85844
	// (set) Token: 0x06014F55 RID: 85845
	bool TabIsUpgrade { get; set; }

	// Token: 0x17001B5D RID: 7005
	// (get) Token: 0x06014F56 RID: 85846
	// (set) Token: 0x06014F57 RID: 85847
	bool TabIsFinish { get; set; }
}
