using System;
using System.Runtime.CompilerServices;

// Token: 0x020007F6 RID: 2038
[NullableContext(2)]
public interface IMemoryItemData
{
	// Token: 0x17000BC7 RID: 3015
	// (get) Token: 0x06005CC2 RID: 23746
	// (set) Token: 0x06005CC3 RID: 23747
	EMemoryContentId Type { get; set; }

	// Token: 0x17000BC8 RID: 3016
	// (get) Token: 0x06005CC4 RID: 23748
	// (set) Token: 0x06005CC5 RID: 23749
	EMemoryClassify Classify { get; set; }

	// Token: 0x17000BC9 RID: 3017
	// (get) Token: 0x06005CC6 RID: 23750
	// (set) Token: 0x06005CC7 RID: 23751
	[Nullable(1)]
	string Title { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000BCA RID: 3018
	// (get) Token: 0x06005CC8 RID: 23752
	// (set) Token: 0x06005CC9 RID: 23753
	bool HasData { get; set; }

	// Token: 0x17000BCB RID: 3019
	// (get) Token: 0x06005CCA RID: 23754
	// (set) Token: 0x06005CCB RID: 23755
	bool IsDelegate { get; set; }

	// Token: 0x17000BCC RID: 3020
	// (get) Token: 0x06005CCC RID: 23756
	// (set) Token: 0x06005CCD RID: 23757
	int Sort { get; set; }

	// Token: 0x17000BCD RID: 3021
	// (get) Token: 0x06005CCE RID: 23758
	// (set) Token: 0x06005CCF RID: 23759
	string Content { get; set; }

	// Token: 0x17000BCE RID: 3022
	// (get) Token: 0x06005CD0 RID: 23760
	// (set) Token: 0x06005CD1 RID: 23761
	string SubContent { get; set; }

	// Token: 0x17000BCF RID: 3023
	// (get) Token: 0x06005CD2 RID: 23762
	// (set) Token: 0x06005CD3 RID: 23763
	string IconPath { get; set; }
}
