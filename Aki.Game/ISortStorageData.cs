using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D61 RID: 3425
[NullableContext(2)]
public interface ISortStorageData
{
	// Token: 0x17000F73 RID: 3955
	// (get) Token: 0x06008CA5 RID: 36005
	// (set) Token: 0x06008CA6 RID: 36006
	int ConfigId { get; set; }

	// Token: 0x17000F74 RID: 3956
	// (get) Token: 0x06008CA7 RID: 36007
	// (set) Token: 0x06008CA8 RID: 36008
	int? SelectBaseSort { get; set; }

	// Token: 0x17000F75 RID: 3957
	// (get) Token: 0x06008CA9 RID: 36009
	// (set) Token: 0x06008CAA RID: 36010
	List<int> SelectAttributeSort { get; set; }

	// Token: 0x17000F76 RID: 3958
	// (get) Token: 0x06008CAB RID: 36011
	// (set) Token: 0x06008CAC RID: 36012
	bool IsAscending { get; set; }
}
