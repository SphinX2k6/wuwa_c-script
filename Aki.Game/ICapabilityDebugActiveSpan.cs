using System;
using System.Runtime.CompilerServices;

// Token: 0x02000234 RID: 564
[NullableContext(1)]
public interface ICapabilityDebugActiveSpan
{
	// Token: 0x1700052B RID: 1323
	// (get) Token: 0x060022D2 RID: 8914
	// (set) Token: 0x060022D3 RID: 8915
	string CapabilityId { get; set; }

	// Token: 0x1700052C RID: 1324
	// (get) Token: 0x060022D4 RID: 8916
	// (set) Token: 0x060022D5 RID: 8917
	string GameObjectId { get; set; }

	// Token: 0x1700052D RID: 1325
	// (get) Token: 0x060022D6 RID: 8918
	// (set) Token: 0x060022D7 RID: 8919
	string ClassName { get; set; }

	// Token: 0x1700052E RID: 1326
	// (get) Token: 0x060022D8 RID: 8920
	// (set) Token: 0x060022D9 RID: 8921
	double StartTime { get; set; }

	// Token: 0x1700052F RID: 1327
	// (get) Token: 0x060022DA RID: 8922
	// (set) Token: 0x060022DB RID: 8923
	double EndTime { get; set; }
}
