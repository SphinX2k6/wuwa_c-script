using System;

// Token: 0x0200226D RID: 8813
public class WeaponRootViewParam : IWeaponRootViewParam
{
	// Token: 0x17002117 RID: 8471
	// (get) Token: 0x06015C9D RID: 89245 RVA: 0x006517CB File Offset: 0x0064F9CB
	// (set) Token: 0x06015C9E RID: 89246 RVA: 0x006517D3 File Offset: 0x0064F9D3
	public int WeaponIncId { get; set; }

	// Token: 0x17002118 RID: 8472
	// (get) Token: 0x06015C9F RID: 89247 RVA: 0x006517DC File Offset: 0x0064F9DC
	// (set) Token: 0x06015CA0 RID: 89248 RVA: 0x006517E4 File Offset: 0x0064F9E4
	public int WeaponSkinId { get; set; }

	// Token: 0x17002119 RID: 8473
	// (get) Token: 0x06015CA1 RID: 89249 RVA: 0x006517ED File Offset: 0x0064F9ED
	// (set) Token: 0x06015CA2 RID: 89250 RVA: 0x006517F5 File Offset: 0x0064F9F5
	public bool IsFromRoleRootView { get; set; }
}
