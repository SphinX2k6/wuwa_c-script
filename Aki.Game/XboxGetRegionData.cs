using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E28 RID: 3624
[NullableContext(1)]
[Nullable(0)]
public class XboxGetRegionData
{
	// Token: 0x17000640 RID: 1600
	// (get) Token: 0x060056F7 RID: 22263 RVA: 0x000FA224 File Offset: 0x000F8424
	// (set) Token: 0x060056F8 RID: 22264 RVA: 0x000FA22C File Offset: 0x000F842C
	public int LoginType { get; set; }

	// Token: 0x17000641 RID: 1601
	// (get) Token: 0x060056F9 RID: 22265 RVA: 0x000FA235 File Offset: 0x000F8435
	// (set) Token: 0x060056FA RID: 22266 RVA: 0x000FA23D File Offset: 0x000F843D
	public string UserId { get; set; } = "";

	// Token: 0x17000642 RID: 1602
	// (get) Token: 0x060056FB RID: 22267 RVA: 0x000FA246 File Offset: 0x000F8446
	// (set) Token: 0x060056FC RID: 22268 RVA: 0x000FA24E File Offset: 0x000F844E
	public string UserName { get; set; } = "";

	// Token: 0x17000643 RID: 1603
	// (get) Token: 0x060056FD RID: 22269 RVA: 0x000FA257 File Offset: 0x000F8457
	// (set) Token: 0x060056FE RID: 22270 RVA: 0x000FA25F File Offset: 0x000F845F
	public string Token { get; set; } = "";
}
