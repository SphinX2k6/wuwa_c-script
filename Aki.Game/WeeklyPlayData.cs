using System;
using Aki.Protocol;

// Token: 0x02002288 RID: 8840
public class WeeklyPlayData
{
	// Token: 0x17002121 RID: 8481
	// (get) Token: 0x06015DA0 RID: 89504 RVA: 0x006564E2 File Offset: 0x006546E2
	// (set) Token: 0x06015DA1 RID: 89505 RVA: 0x006564EA File Offset: 0x006546EA
	public int PlayId { get; set; }

	// Token: 0x17002122 RID: 8482
	// (get) Token: 0x06015DA2 RID: 89506 RVA: 0x006564F3 File Offset: 0x006546F3
	// (set) Token: 0x06015DA3 RID: 89507 RVA: 0x006564FB File Offset: 0x006546FB
	public ActivityType Type { get; set; }

	// Token: 0x17002123 RID: 8483
	// (get) Token: 0x06015DA4 RID: 89508 RVA: 0x00656504 File Offset: 0x00654704
	// (set) Token: 0x06015DA5 RID: 89509 RVA: 0x0065650C File Offset: 0x0065470C
	public bool HasRecord { get; set; }
}
