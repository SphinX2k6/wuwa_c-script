using System;

// Token: 0x0200091F RID: 2335
public struct IRegressLevelProgressData
{
	// Token: 0x17000CFC RID: 3324
	// (get) Token: 0x0600671A RID: 26394 RVA: 0x00204468 File Offset: 0x00202668
	// (set) Token: 0x0600671B RID: 26395 RVA: 0x00204470 File Offset: 0x00202670
	public int Level { readonly get; set; }

	// Token: 0x17000CFD RID: 3325
	// (get) Token: 0x0600671C RID: 26396 RVA: 0x00204479 File Offset: 0x00202679
	// (set) Token: 0x0600671D RID: 26397 RVA: 0x00204481 File Offset: 0x00202681
	public int MaxLevel { readonly get; set; }

	// Token: 0x17000CFE RID: 3326
	// (get) Token: 0x0600671E RID: 26398 RVA: 0x0020448A File Offset: 0x0020268A
	// (set) Token: 0x0600671F RID: 26399 RVA: 0x00204492 File Offset: 0x00202692
	public int CurScore { readonly get; set; }

	// Token: 0x17000CFF RID: 3327
	// (get) Token: 0x06006720 RID: 26400 RVA: 0x0020449B File Offset: 0x0020269B
	// (set) Token: 0x06006721 RID: 26401 RVA: 0x002044A3 File Offset: 0x002026A3
	public int NeedScore { readonly get; set; }
}
