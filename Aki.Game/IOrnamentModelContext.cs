using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020021C8 RID: 8648
[NullableContext(1)]
public interface IOrnamentModelContext
{
	// Token: 0x1700202E RID: 8238
	// (get) Token: 0x06015499 RID: 87193
	// (set) Token: 0x0601549A RID: 87194
	int ModelId { get; set; }

	// Token: 0x1700202F RID: 8239
	// (get) Token: 0x0601549B RID: 87195
	// (set) Token: 0x0601549C RID: 87196
	bool HideInUi { get; set; }

	// Token: 0x17002030 RID: 8240
	// (get) Token: 0x0601549D RID: 87197
	// (set) Token: 0x0601549E RID: 87198
	List<long> OrnamentUiBuff { get; set; }

	// Token: 0x17002031 RID: 8241
	// (get) Token: 0x0601549F RID: 87199
	// (set) Token: 0x060154A0 RID: 87200
	List<string> EquipTags { get; set; }
}
