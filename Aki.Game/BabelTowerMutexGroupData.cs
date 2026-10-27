using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001139 RID: 4409
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerMutexGroupData : IBabelTowerMutexGroupData
{
	// Token: 0x170009FE RID: 2558
	// (get) Token: 0x060073D3 RID: 29651 RVA: 0x0017BB77 File Offset: 0x00179D77
	// (set) Token: 0x060073D4 RID: 29652 RVA: 0x0017BB7F File Offset: 0x00179D7F
	public int MutexId { get; set; }

	// Token: 0x170009FF RID: 2559
	// (get) Token: 0x060073D5 RID: 29653 RVA: 0x0017BB88 File Offset: 0x00179D88
	// (set) Token: 0x060073D6 RID: 29654 RVA: 0x0017BB90 File Offset: 0x00179D90
	public int GroupId { get; set; }

	// Token: 0x17000A00 RID: 2560
	// (get) Token: 0x060073D7 RID: 29655 RVA: 0x0017BB99 File Offset: 0x00179D99
	// (set) Token: 0x060073D8 RID: 29656 RVA: 0x0017BBA1 File Offset: 0x00179DA1
	public List<int> DeTermList { get; set; }

	// Token: 0x17000A01 RID: 2561
	// (get) Token: 0x060073D9 RID: 29657 RVA: 0x0017BBAA File Offset: 0x00179DAA
	// (set) Token: 0x060073DA RID: 29658 RVA: 0x0017BBB2 File Offset: 0x00179DB2
	public bool? IsNecessary { get; set; }

	// Token: 0x17000A02 RID: 2562
	// (get) Token: 0x060073DB RID: 29659 RVA: 0x0017BBBB File Offset: 0x00179DBB
	// (set) Token: 0x060073DC RID: 29660 RVA: 0x0017BBC3 File Offset: 0x00179DC3
	public int? CurrentDeTermId { get; set; }
}
