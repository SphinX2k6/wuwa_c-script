using System;

// Token: 0x02001154 RID: 4436
public class GachaViewOpenData : IGachaViewOpenData
{
	// Token: 0x1700121D RID: 4637
	// (get) Token: 0x0600B102 RID: 45314 RVA: 0x003444F5 File Offset: 0x003426F5
	// (set) Token: 0x0600B103 RID: 45315 RVA: 0x003444FD File Offset: 0x003426FD
	public bool SkipOnLoadResourceFinish { get; set; }

	// Token: 0x1700121E RID: 4638
	// (get) Token: 0x0600B104 RID: 45316 RVA: 0x00344506 File Offset: 0x00342706
	// (set) Token: 0x0600B105 RID: 45317 RVA: 0x0034450E File Offset: 0x0034270E
	public bool ResultViewHideExtraReward { get; set; }

	// Token: 0x1700121F RID: 4639
	// (get) Token: 0x0600B106 RID: 45318 RVA: 0x00344517 File Offset: 0x00342717
	// (set) Token: 0x0600B107 RID: 45319 RVA: 0x0034451F File Offset: 0x0034271F
	public bool IsOnlyShowGold { get; set; }
}
