using System;

// Token: 0x02002049 RID: 8265
public class KingShipResultViewData : IKingShipResultViewData
{
	// Token: 0x170013DC RID: 5084
	// (get) Token: 0x060103C7 RID: 66503 RVA: 0x003F60E2 File Offset: 0x003F42E2
	// (set) Token: 0x060103C8 RID: 66504 RVA: 0x003F60EA File Offset: 0x003F42EA
	public int CardId { get; set; }

	// Token: 0x170013DD RID: 5085
	// (get) Token: 0x060103C9 RID: 66505 RVA: 0x003F60F3 File Offset: 0x003F42F3
	// (set) Token: 0x060103CA RID: 66506 RVA: 0x003F60FB File Offset: 0x003F42FB
	public int ReignsId { get; set; }

	// Token: 0x170013DE RID: 5086
	// (get) Token: 0x060103CB RID: 66507 RVA: 0x003F6104 File Offset: 0x003F4304
	// (set) Token: 0x060103CC RID: 66508 RVA: 0x003F610C File Offset: 0x003F430C
	public bool IsSuccess { get; set; }

	// Token: 0x170013DF RID: 5087
	// (get) Token: 0x060103CD RID: 66509 RVA: 0x003F6115 File Offset: 0x003F4315
	// (set) Token: 0x060103CE RID: 66510 RVA: 0x003F611D File Offset: 0x003F431D
	public int NextReignsId { get; set; }
}
