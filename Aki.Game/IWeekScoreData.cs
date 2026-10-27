using System;
using System.Runtime.CompilerServices;

// Token: 0x020023A6 RID: 9126
[NullableContext(1)]
public interface IWeekScoreData
{
	// Token: 0x170017B3 RID: 6067
	// (get) Token: 0x06012401 RID: 74753
	// (set) Token: 0x06012402 RID: 74754
	string Tips { get; set; }

	// Token: 0x170017B4 RID: 6068
	// (get) Token: 0x06012403 RID: 74755
	// (set) Token: 0x06012404 RID: 74756
	string IconPath { get; set; }

	// Token: 0x170017B5 RID: 6069
	// (get) Token: 0x06012405 RID: 74757
	// (set) Token: 0x06012406 RID: 74758
	int Count { get; set; }
}
