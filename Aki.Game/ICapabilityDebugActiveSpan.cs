using System;
using System.Runtime.CompilerServices;

// Token: 0x02000238 RID: 568
[NullableContext(1)]
public interface ICapabilityDebugActiveSpan
{
	// Token: 0x17000552 RID: 1362
	// (get) Token: 0x0600238A RID: 9098
	// (set) Token: 0x0600238B RID: 9099
	string CapabilityId { get; set; }

	// Token: 0x17000553 RID: 1363
	// (get) Token: 0x0600238C RID: 9100
	// (set) Token: 0x0600238D RID: 9101
	string GameObjectId { get; set; }

	// Token: 0x17000554 RID: 1364
	// (get) Token: 0x0600238E RID: 9102
	// (set) Token: 0x0600238F RID: 9103
	string ClassName { get; set; }

	// Token: 0x17000555 RID: 1365
	// (get) Token: 0x06002390 RID: 9104
	// (set) Token: 0x06002391 RID: 9105
	double StartTime { get; set; }

	// Token: 0x17000556 RID: 1366
	// (get) Token: 0x06002392 RID: 9106
	// (set) Token: 0x06002393 RID: 9107
	double EndTime { get; set; }
}
