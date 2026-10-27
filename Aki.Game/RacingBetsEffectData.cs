using System;

// Token: 0x020026F1 RID: 9969
public class RacingBetsEffectData : IRacingBetsEffectData
{
	// Token: 0x17001A94 RID: 6804
	// (get) Token: 0x060146FE RID: 83710 RVA: 0x0052B9A0 File Offset: 0x00529BA0
	// (set) Token: 0x060146FF RID: 83711 RVA: 0x0052B9A8 File Offset: 0x00529BA8
	public int Handle { get; set; }

	// Token: 0x17001A95 RID: 6805
	// (get) Token: 0x06014700 RID: 83712 RVA: 0x0052B9B1 File Offset: 0x00529BB1
	// (set) Token: 0x06014701 RID: 83713 RVA: 0x0052B9B9 File Offset: 0x00529BB9
	public ERacingBetsEffectType Type { get; set; }
}
