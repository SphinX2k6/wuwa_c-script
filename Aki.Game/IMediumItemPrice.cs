using System;
using System.Runtime.CompilerServices;

// Token: 0x02001918 RID: 6424
[NullableContext(2)]
public interface IMediumItemPrice
{
	// Token: 0x17000FAA RID: 4010
	// (get) Token: 0x0600BC28 RID: 48168
	// (set) Token: 0x0600BC29 RID: 48169
	int CurPrice { get; set; }

	// Token: 0x17000FAB RID: 4011
	// (get) Token: 0x0600BC2A RID: 48170
	// (set) Token: 0x0600BC2B RID: 48171
	int? OriginalPrice { get; set; }

	// Token: 0x17000FAC RID: 4012
	// (get) Token: 0x0600BC2C RID: 48172
	// (set) Token: 0x0600BC2D RID: 48173
	string TexPath { get; set; }

	// Token: 0x17000FAD RID: 4013
	// (get) Token: 0x0600BC2E RID: 48174
	// (set) Token: 0x0600BC2F RID: 48175
	bool? CurrencyNotEnough { get; set; }
}
