using System;

// Token: 0x02002700 RID: 9984
public class RacingBetsRedDotState : IRacingBetsRedDotState
{
	// Token: 0x17001ADE RID: 6878
	// (get) Token: 0x06014799 RID: 83865 RVA: 0x0052BC4D File Offset: 0x00529E4D
	// (set) Token: 0x0601479A RID: 83866 RVA: 0x0052BC55 File Offset: 0x00529E55
	public bool HasViewed { get; set; }

	// Token: 0x17001ADF RID: 6879
	// (get) Token: 0x0601479B RID: 83867 RVA: 0x0052BC5E File Offset: 0x00529E5E
	// (set) Token: 0x0601479C RID: 83868 RVA: 0x0052BC66 File Offset: 0x00529E66
	public long LastViewedData { get; set; }
}
