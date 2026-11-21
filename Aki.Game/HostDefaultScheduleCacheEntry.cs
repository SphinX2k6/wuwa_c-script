using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200023E RID: 574
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class HostDefaultScheduleCacheEntry
{
	// Token: 0x17000568 RID: 1384
	// (get) Token: 0x060023B9 RID: 9145 RVA: 0x000DFABC File Offset: 0x000DDCBC
	// (set) Token: 0x060023BA RID: 9146 RVA: 0x000DFAC4 File Offset: 0x000DDCC4
	[RequiredMember]
	public int Generation { get; set; }

	// Token: 0x17000569 RID: 1385
	// (get) Token: 0x060023BB RID: 9147 RVA: 0x000DFACD File Offset: 0x000DDCCD
	// (set) Token: 0x060023BC RID: 9148 RVA: 0x000DFAD5 File Offset: 0x000DDCD5
	[RequiredMember]
	public List<IScheduledEntry> Schedule { get; set; }

	// Token: 0x060023BD RID: 9149 RVA: 0x000DFADE File Offset: 0x000DDCDE
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public HostDefaultScheduleCacheEntry()
	{
	}
}
