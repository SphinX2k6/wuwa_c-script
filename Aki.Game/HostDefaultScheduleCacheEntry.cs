using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200023A RID: 570
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class HostDefaultScheduleCacheEntry
{
	// Token: 0x17000541 RID: 1345
	// (get) Token: 0x06002301 RID: 8961 RVA: 0x000D95FC File Offset: 0x000D77FC
	// (set) Token: 0x06002302 RID: 8962 RVA: 0x000D9604 File Offset: 0x000D7804
	[RequiredMember]
	public int Generation { get; set; }

	// Token: 0x17000542 RID: 1346
	// (get) Token: 0x06002303 RID: 8963 RVA: 0x000D960D File Offset: 0x000D780D
	// (set) Token: 0x06002304 RID: 8964 RVA: 0x000D9615 File Offset: 0x000D7815
	[RequiredMember]
	public List<IScheduledEntry> Schedule { get; set; }

	// Token: 0x06002305 RID: 8965 RVA: 0x000D961E File Offset: 0x000D781E
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public HostDefaultScheduleCacheEntry()
	{
	}
}
