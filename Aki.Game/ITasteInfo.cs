using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F5E RID: 3934
[NullableContext(1)]
public interface ITasteInfo
{
	// Token: 0x170007B5 RID: 1973
	// (get) Token: 0x060064A8 RID: 25768
	// (set) Token: 0x060064A9 RID: 25769
	EDrinksFlavorType Type { get; set; }

	// Token: 0x170007B6 RID: 1974
	// (get) Token: 0x060064AA RID: 25770
	// (set) Token: 0x060064AB RID: 25771
	string Key { get; set; }

	// Token: 0x170007B7 RID: 1975
	// (get) Token: 0x060064AC RID: 25772
	// (set) Token: 0x060064AD RID: 25773
	string[] Value { get; set; }
}
