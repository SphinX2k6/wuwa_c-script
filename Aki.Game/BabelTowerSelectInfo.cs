using System;

// Token: 0x0200112D RID: 4397
public class BabelTowerSelectInfo : IBabelTowerSelectInfo
{
	// Token: 0x170009C5 RID: 2501
	// (get) Token: 0x0600735B RID: 29531 RVA: 0x0017B97C File Offset: 0x00179B7C
	// (set) Token: 0x0600735C RID: 29532 RVA: 0x0017B984 File Offset: 0x00179B84
	public EBabelTowerDeTermState State { get; set; }

	// Token: 0x170009C6 RID: 2502
	// (get) Token: 0x0600735D RID: 29533 RVA: 0x0017B98D File Offset: 0x00179B8D
	// (set) Token: 0x0600735E RID: 29534 RVA: 0x0017B995 File Offset: 0x00179B95
	public int SelectIndex { get; set; }
}
