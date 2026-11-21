using System;
using System.Runtime.CompilerServices;

// Token: 0x020002D3 RID: 723
[NullableContext(1)]
[Nullable(0)]
public class SDKPayRole : ISDKPayRole
{
	// Token: 0x17000659 RID: 1625
	// (get) Token: 0x06002A6F RID: 10863 RVA: 0x00101928 File Offset: 0x000FFB28
	// (set) Token: 0x06002A70 RID: 10864 RVA: 0x00101930 File Offset: 0x000FFB30
	public string serverId { get; set; }

	// Token: 0x1700065A RID: 1626
	// (get) Token: 0x06002A71 RID: 10865 RVA: 0x00101939 File Offset: 0x000FFB39
	// (set) Token: 0x06002A72 RID: 10866 RVA: 0x00101941 File Offset: 0x000FFB41
	public string serverName { get; set; }

	// Token: 0x1700065B RID: 1627
	// (get) Token: 0x06002A73 RID: 10867 RVA: 0x0010194A File Offset: 0x000FFB4A
	// (set) Token: 0x06002A74 RID: 10868 RVA: 0x00101952 File Offset: 0x000FFB52
	public string roleId { get; set; }

	// Token: 0x1700065C RID: 1628
	// (get) Token: 0x06002A75 RID: 10869 RVA: 0x0010195B File Offset: 0x000FFB5B
	// (set) Token: 0x06002A76 RID: 10870 RVA: 0x00101963 File Offset: 0x000FFB63
	public string roleName { get; set; }

	// Token: 0x1700065D RID: 1629
	// (get) Token: 0x06002A77 RID: 10871 RVA: 0x0010196C File Offset: 0x000FFB6C
	// (set) Token: 0x06002A78 RID: 10872 RVA: 0x00101974 File Offset: 0x000FFB74
	public string roleLevel { get; set; }

	// Token: 0x1700065E RID: 1630
	// (get) Token: 0x06002A79 RID: 10873 RVA: 0x0010197D File Offset: 0x000FFB7D
	// (set) Token: 0x06002A7A RID: 10874 RVA: 0x00101985 File Offset: 0x000FFB85
	public string vipLevel { get; set; }

	// Token: 0x1700065F RID: 1631
	// (get) Token: 0x06002A7B RID: 10875 RVA: 0x0010198E File Offset: 0x000FFB8E
	// (set) Token: 0x06002A7C RID: 10876 RVA: 0x00101996 File Offset: 0x000FFB96
	public int setBalanceLevelOne { get; set; }

	// Token: 0x17000660 RID: 1632
	// (get) Token: 0x06002A7D RID: 10877 RVA: 0x0010199F File Offset: 0x000FFB9F
	// (set) Token: 0x06002A7E RID: 10878 RVA: 0x001019A7 File Offset: 0x000FFBA7
	public int setBalanceLevelTwo { get; set; }

	// Token: 0x17000661 RID: 1633
	// (get) Token: 0x06002A7F RID: 10879 RVA: 0x001019B0 File Offset: 0x000FFBB0
	// (set) Token: 0x06002A80 RID: 10880 RVA: 0x001019B8 File Offset: 0x000FFBB8
	public string partyName { get; set; }
}
