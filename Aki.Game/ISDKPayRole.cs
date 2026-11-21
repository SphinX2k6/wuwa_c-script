using System;
using System.Runtime.CompilerServices;

// Token: 0x020002D2 RID: 722
[NullableContext(1)]
public interface ISDKPayRole
{
	// Token: 0x17000650 RID: 1616
	// (get) Token: 0x06002A5D RID: 10845
	// (set) Token: 0x06002A5E RID: 10846
	string serverId { get; set; }

	// Token: 0x17000651 RID: 1617
	// (get) Token: 0x06002A5F RID: 10847
	// (set) Token: 0x06002A60 RID: 10848
	string serverName { get; set; }

	// Token: 0x17000652 RID: 1618
	// (get) Token: 0x06002A61 RID: 10849
	// (set) Token: 0x06002A62 RID: 10850
	string roleId { get; set; }

	// Token: 0x17000653 RID: 1619
	// (get) Token: 0x06002A63 RID: 10851
	// (set) Token: 0x06002A64 RID: 10852
	string roleName { get; set; }

	// Token: 0x17000654 RID: 1620
	// (get) Token: 0x06002A65 RID: 10853
	// (set) Token: 0x06002A66 RID: 10854
	string roleLevel { get; set; }

	// Token: 0x17000655 RID: 1621
	// (get) Token: 0x06002A67 RID: 10855
	// (set) Token: 0x06002A68 RID: 10856
	string vipLevel { get; set; }

	// Token: 0x17000656 RID: 1622
	// (get) Token: 0x06002A69 RID: 10857
	// (set) Token: 0x06002A6A RID: 10858
	int setBalanceLevelOne { get; set; }

	// Token: 0x17000657 RID: 1623
	// (get) Token: 0x06002A6B RID: 10859
	// (set) Token: 0x06002A6C RID: 10860
	int setBalanceLevelTwo { get; set; }

	// Token: 0x17000658 RID: 1624
	// (get) Token: 0x06002A6D RID: 10861
	// (set) Token: 0x06002A6E RID: 10862
	string partyName { get; set; }
}
