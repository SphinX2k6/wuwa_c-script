using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002C6F RID: 11375
[NullableContext(1)]
public interface IOrnamentModelContext
{
	// Token: 0x17001FDD RID: 8157
	// (get) Token: 0x06017C27 RID: 97319
	// (set) Token: 0x06017C28 RID: 97320
	int ModelId { get; set; }

	// Token: 0x17001FDE RID: 8158
	// (get) Token: 0x06017C29 RID: 97321
	// (set) Token: 0x06017C2A RID: 97322
	bool HideInUi { get; set; }

	// Token: 0x17001FDF RID: 8159
	// (get) Token: 0x06017C2B RID: 97323
	// (set) Token: 0x06017C2C RID: 97324
	List<long> OrnamentUiBuff { get; set; }

	// Token: 0x17001FE0 RID: 8160
	// (get) Token: 0x06017C2D RID: 97325
	// (set) Token: 0x06017C2E RID: 97326
	List<string> EquipTags { get; set; }
}
