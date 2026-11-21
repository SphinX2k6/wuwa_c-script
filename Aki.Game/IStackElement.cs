using System;
using System.Runtime.CompilerServices;

// Token: 0x02002AB0 RID: 10928
[NullableContext(1)]
public interface IStackElement
{
	// Token: 0x17002D0F RID: 11535
	// (get) Token: 0x0601BC26 RID: 113702
	// (set) Token: 0x0601BC27 RID: 113703
	string Node { get; set; }

	// Token: 0x17002D10 RID: 11536
	// (get) Token: 0x0601BC28 RID: 113704
	// (set) Token: 0x0601BC29 RID: 113705
	bool Traversing { get; set; }
}
