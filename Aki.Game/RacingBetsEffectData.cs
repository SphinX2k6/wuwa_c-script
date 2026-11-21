using System;

// Token: 0x02001BDC RID: 7132
public class RacingBetsEffectData : IRacingBetsEffectData
{
	// Token: 0x17001ACC RID: 6860
	// (get) Token: 0x06011BE0 RID: 72672 RVA: 0x0053A6BC File Offset: 0x005388BC
	// (set) Token: 0x06011BE1 RID: 72673 RVA: 0x0053A6C4 File Offset: 0x005388C4
	public int Handle { get; set; }

	// Token: 0x17001ACD RID: 6861
	// (get) Token: 0x06011BE2 RID: 72674 RVA: 0x0053A6CD File Offset: 0x005388CD
	// (set) Token: 0x06011BE3 RID: 72675 RVA: 0x0053A6D5 File Offset: 0x005388D5
	public ERacingBetsEffectType Type { get; set; }
}
