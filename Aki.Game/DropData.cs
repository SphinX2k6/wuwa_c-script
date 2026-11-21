using System;

// Token: 0x02000348 RID: 840
public class DropData : IDropData
{
	// Token: 0x170006D2 RID: 1746
	// (get) Token: 0x06002F22 RID: 12066 RVA: 0x0011342F File Offset: 0x0011162F
	// (set) Token: 0x06002F23 RID: 12067 RVA: 0x00113437 File Offset: 0x00111637
	public int SubLevelIndex { get; set; }

	// Token: 0x170006D3 RID: 1747
	// (get) Token: 0x06002F24 RID: 12068 RVA: 0x00113440 File Offset: 0x00111640
	// (set) Token: 0x06002F25 RID: 12069 RVA: 0x00113448 File Offset: 0x00111648
	public int WaveGroupIndex { get; set; }

	// Token: 0x170006D4 RID: 1748
	// (get) Token: 0x06002F26 RID: 12070 RVA: 0x00113451 File Offset: 0x00111651
	// (set) Token: 0x06002F27 RID: 12071 RVA: 0x00113459 File Offset: 0x00111659
	public int MonsterId { get; set; }

	// Token: 0x170006D5 RID: 1749
	// (get) Token: 0x06002F28 RID: 12072 RVA: 0x00113462 File Offset: 0x00111662
	// (set) Token: 0x06002F29 RID: 12073 RVA: 0x0011346A File Offset: 0x0011166A
	public int BuffGateId { get; set; }
}
