using System;
using System.Runtime.CompilerServices;

// Token: 0x02000413 RID: 1043
[NullableContext(1)]
public interface ITasteInfo
{
	// Token: 0x170007D7 RID: 2007
	// (get) Token: 0x06003840 RID: 14400
	// (set) Token: 0x06003841 RID: 14401
	EDrinksFlavorType Type { get; set; }

	// Token: 0x170007D8 RID: 2008
	// (get) Token: 0x06003842 RID: 14402
	// (set) Token: 0x06003843 RID: 14403
	string Key { get; set; }

	// Token: 0x170007D9 RID: 2009
	// (get) Token: 0x06003844 RID: 14404
	// (set) Token: 0x06003845 RID: 14405
	string[] Value { get; set; }
}
