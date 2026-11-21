using System;
using System.Runtime.CompilerServices;

// Token: 0x02001138 RID: 4408
[NullableContext(1)]
[Nullable(0)]
public class GachaPoolData
{
	// Token: 0x17001208 RID: 4616
	// (get) Token: 0x0600AFF8 RID: 45048 RVA: 0x0033E0B8 File Offset: 0x0033C2B8
	// (set) Token: 0x0600AFF9 RID: 45049 RVA: 0x0033E0C0 File Offset: 0x0033C2C0
	public ProtoGachaInfo GachaInfo { get; set; }

	// Token: 0x17001209 RID: 4617
	// (get) Token: 0x0600AFFA RID: 45050 RVA: 0x0033E0C9 File Offset: 0x0033C2C9
	// (set) Token: 0x0600AFFB RID: 45051 RVA: 0x0033E0D1 File Offset: 0x0033C2D1
	public ProtoGachaPoolInfo PoolInfo { get; set; }

	// Token: 0x0600AFFC RID: 45052 RVA: 0x0033E0DA File Offset: 0x0033C2DA
	public GachaPoolData(ProtoGachaInfo gachaInfo, ProtoGachaPoolInfo poolInfo)
	{
		this.GachaInfo = gachaInfo;
		this.PoolInfo = poolInfo;
	}
}
