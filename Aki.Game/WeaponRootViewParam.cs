using System;

// Token: 0x02002D13 RID: 11539
public class WeaponRootViewParam : IWeaponRootViewParam
{
	// Token: 0x170020BC RID: 8380
	// (get) Token: 0x060183FC RID: 99324 RVA: 0x0062B7D3 File Offset: 0x006299D3
	// (set) Token: 0x060183FD RID: 99325 RVA: 0x0062B7DB File Offset: 0x006299DB
	public int WeaponIncId { get; set; }

	// Token: 0x170020BD RID: 8381
	// (get) Token: 0x060183FE RID: 99326 RVA: 0x0062B7E4 File Offset: 0x006299E4
	// (set) Token: 0x060183FF RID: 99327 RVA: 0x0062B7EC File Offset: 0x006299EC
	public int WeaponSkinId { get; set; }

	// Token: 0x170020BE RID: 8382
	// (get) Token: 0x06018400 RID: 99328 RVA: 0x0062B7F5 File Offset: 0x006299F5
	// (set) Token: 0x06018401 RID: 99329 RVA: 0x0062B7FD File Offset: 0x006299FD
	public bool IsFromRoleRootView { get; set; }
}
