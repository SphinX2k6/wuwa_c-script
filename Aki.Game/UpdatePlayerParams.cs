using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002957 RID: 10583
[NullableContext(1)]
[Nullable(0)]
public class UpdatePlayerParams : IUpdatePlayerParams
{
	// Token: 0x17001D67 RID: 7527
	// (get) Token: 0x06015DDA RID: 89562 RVA: 0x00583FC2 File Offset: 0x005821C2
	// (set) Token: 0x06015DDB RID: 89563 RVA: 0x00583FCA File Offset: 0x005821CA
	public int PlayerId { get; set; }

	// Token: 0x17001D68 RID: 7528
	// (get) Token: 0x06015DDC RID: 89564 RVA: 0x00583FD3 File Offset: 0x005821D3
	// (set) Token: 0x06015DDD RID: 89565 RVA: 0x00583FDB File Offset: 0x005821DB
	public ETeamGroupType CurrentGroupType { get; set; }

	// Token: 0x17001D69 RID: 7529
	// (get) Token: 0x06015DDE RID: 89566 RVA: 0x00583FE4 File Offset: 0x005821E4
	// (set) Token: 0x06015DDF RID: 89567 RVA: 0x00583FEC File Offset: 0x005821EC
	public IList<IUpdateGroupParams> Groups { get; set; }
}
