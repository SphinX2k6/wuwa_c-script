using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E1F RID: 3615
[NullableContext(1)]
[Nullable(0)]
public class SDKPayRole : ISDKPayRole
{
	// Token: 0x17000635 RID: 1589
	// (get) Token: 0x060056DF RID: 22239 RVA: 0x000FA142 File Offset: 0x000F8342
	// (set) Token: 0x060056E0 RID: 22240 RVA: 0x000FA14A File Offset: 0x000F834A
	public string serverId { get; set; }

	// Token: 0x17000636 RID: 1590
	// (get) Token: 0x060056E1 RID: 22241 RVA: 0x000FA153 File Offset: 0x000F8353
	// (set) Token: 0x060056E2 RID: 22242 RVA: 0x000FA15B File Offset: 0x000F835B
	public string serverName { get; set; }

	// Token: 0x17000637 RID: 1591
	// (get) Token: 0x060056E3 RID: 22243 RVA: 0x000FA164 File Offset: 0x000F8364
	// (set) Token: 0x060056E4 RID: 22244 RVA: 0x000FA16C File Offset: 0x000F836C
	public string roleId { get; set; }

	// Token: 0x17000638 RID: 1592
	// (get) Token: 0x060056E5 RID: 22245 RVA: 0x000FA175 File Offset: 0x000F8375
	// (set) Token: 0x060056E6 RID: 22246 RVA: 0x000FA17D File Offset: 0x000F837D
	public string roleName { get; set; }

	// Token: 0x17000639 RID: 1593
	// (get) Token: 0x060056E7 RID: 22247 RVA: 0x000FA186 File Offset: 0x000F8386
	// (set) Token: 0x060056E8 RID: 22248 RVA: 0x000FA18E File Offset: 0x000F838E
	public string roleLevel { get; set; }

	// Token: 0x1700063A RID: 1594
	// (get) Token: 0x060056E9 RID: 22249 RVA: 0x000FA197 File Offset: 0x000F8397
	// (set) Token: 0x060056EA RID: 22250 RVA: 0x000FA19F File Offset: 0x000F839F
	public string vipLevel { get; set; }

	// Token: 0x1700063B RID: 1595
	// (get) Token: 0x060056EB RID: 22251 RVA: 0x000FA1A8 File Offset: 0x000F83A8
	// (set) Token: 0x060056EC RID: 22252 RVA: 0x000FA1B0 File Offset: 0x000F83B0
	public int setBalanceLevelOne { get; set; }

	// Token: 0x1700063C RID: 1596
	// (get) Token: 0x060056ED RID: 22253 RVA: 0x000FA1B9 File Offset: 0x000F83B9
	// (set) Token: 0x060056EE RID: 22254 RVA: 0x000FA1C1 File Offset: 0x000F83C1
	public int setBalanceLevelTwo { get; set; }

	// Token: 0x1700063D RID: 1597
	// (get) Token: 0x060056EF RID: 22255 RVA: 0x000FA1CA File Offset: 0x000F83CA
	// (set) Token: 0x060056F0 RID: 22256 RVA: 0x000FA1D2 File Offset: 0x000F83D2
	public string partyName { get; set; }
}
