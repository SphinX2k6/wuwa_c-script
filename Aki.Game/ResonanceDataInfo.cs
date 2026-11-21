using System;

// Token: 0x02001D27 RID: 7463
public class ResonanceDataInfo
{
	// Token: 0x0601282F RID: 75823 RVA: 0x00578E1C File Offset: 0x0057701C
	public ResonanceDataInfo(int resonId, bool isOpen, int increase)
	{
		this.ResonId = resonId;
		this.IsOpen = isOpen;
		this.Increase = increase;
	}

	// Token: 0x0400A0D7 RID: 41175
	public readonly int ResonId;

	// Token: 0x0400A0D8 RID: 41176
	public readonly bool IsOpen;

	// Token: 0x0400A0D9 RID: 41177
	public readonly int Increase;
}
