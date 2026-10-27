using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C79 RID: 7289
[NullableContext(1)]
[Nullable(0)]
public class GachaPoolData
{
	// Token: 0x170011E2 RID: 4578
	// (get) Token: 0x0600DBE2 RID: 56290 RVA: 0x00332C58 File Offset: 0x00330E58
	// (set) Token: 0x0600DBE3 RID: 56291 RVA: 0x00332C60 File Offset: 0x00330E60
	public ProtoGachaInfo GachaInfo { get; set; }

	// Token: 0x170011E3 RID: 4579
	// (get) Token: 0x0600DBE4 RID: 56292 RVA: 0x00332C69 File Offset: 0x00330E69
	// (set) Token: 0x0600DBE5 RID: 56293 RVA: 0x00332C71 File Offset: 0x00330E71
	public ProtoGachaPoolInfo PoolInfo { get; set; }

	// Token: 0x0600DBE6 RID: 56294 RVA: 0x00332C7A File Offset: 0x00330E7A
	public GachaPoolData(ProtoGachaInfo gachaInfo, ProtoGachaPoolInfo poolInfo)
	{
		this.GachaInfo = gachaInfo;
		this.PoolInfo = poolInfo;
	}
}
