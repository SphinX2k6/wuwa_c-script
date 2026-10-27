using System;

// Token: 0x020027AC RID: 10156
public class ResonanceDataInfo
{
	// Token: 0x06014E30 RID: 85552 RVA: 0x0054E0F4 File Offset: 0x0054C2F4
	public ResonanceDataInfo(int resonId, bool isOpen, int increase)
	{
		this.ResonId = resonId;
		this.IsOpen = isOpen;
		this.Increase = increase;
	}

	// Token: 0x04009CF4 RID: 40180
	public readonly int ResonId;

	// Token: 0x04009CF5 RID: 40181
	public readonly bool IsOpen;

	// Token: 0x04009CF6 RID: 40182
	public readonly int Increase;
}
