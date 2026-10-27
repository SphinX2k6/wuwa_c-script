using System;

// Token: 0x02000E93 RID: 3731
public class DropData : IDropData
{
	// Token: 0x170006AE RID: 1710
	// (get) Token: 0x06005B8B RID: 23435 RVA: 0x0010B797 File Offset: 0x00109997
	// (set) Token: 0x06005B8C RID: 23436 RVA: 0x0010B79F File Offset: 0x0010999F
	public int SubLevelIndex { get; set; }

	// Token: 0x170006AF RID: 1711
	// (get) Token: 0x06005B8D RID: 23437 RVA: 0x0010B7A8 File Offset: 0x001099A8
	// (set) Token: 0x06005B8E RID: 23438 RVA: 0x0010B7B0 File Offset: 0x001099B0
	public int WaveGroupIndex { get; set; }

	// Token: 0x170006B0 RID: 1712
	// (get) Token: 0x06005B8F RID: 23439 RVA: 0x0010B7B9 File Offset: 0x001099B9
	// (set) Token: 0x06005B90 RID: 23440 RVA: 0x0010B7C1 File Offset: 0x001099C1
	public int MonsterId { get; set; }

	// Token: 0x170006B1 RID: 1713
	// (get) Token: 0x06005B91 RID: 23441 RVA: 0x0010B7CA File Offset: 0x001099CA
	// (set) Token: 0x06005B92 RID: 23442 RVA: 0x0010B7D2 File Offset: 0x001099D2
	public int BuffGateId { get; set; }
}
