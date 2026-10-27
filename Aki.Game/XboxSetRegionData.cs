using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E2A RID: 3626
[NullableContext(1)]
[Nullable(0)]
public class XboxSetRegionData
{
	// Token: 0x17000647 RID: 1607
	// (get) Token: 0x06005707 RID: 22279 RVA: 0x000FA2D7 File Offset: 0x000F84D7
	// (set) Token: 0x06005708 RID: 22280 RVA: 0x000FA2DF File Offset: 0x000F84DF
	public int LoginType { get; set; }

	// Token: 0x17000648 RID: 1608
	// (get) Token: 0x06005709 RID: 22281 RVA: 0x000FA2E8 File Offset: 0x000F84E8
	// (set) Token: 0x0600570A RID: 22282 RVA: 0x000FA2F0 File Offset: 0x000F84F0
	public string Region { get; set; } = "";

	// Token: 0x17000649 RID: 1609
	// (get) Token: 0x0600570B RID: 22283 RVA: 0x000FA2F9 File Offset: 0x000F84F9
	// (set) Token: 0x0600570C RID: 22284 RVA: 0x000FA301 File Offset: 0x000F8501
	public string UserId { get; set; } = "";

	// Token: 0x1700064A RID: 1610
	// (get) Token: 0x0600570D RID: 22285 RVA: 0x000FA30A File Offset: 0x000F850A
	// (set) Token: 0x0600570E RID: 22286 RVA: 0x000FA312 File Offset: 0x000F8512
	public string UserName { get; set; } = "";

	// Token: 0x1700064B RID: 1611
	// (get) Token: 0x0600570F RID: 22287 RVA: 0x000FA31B File Offset: 0x000F851B
	// (set) Token: 0x06005710 RID: 22288 RVA: 0x000FA323 File Offset: 0x000F8523
	public string Token { get; set; } = "";
}
