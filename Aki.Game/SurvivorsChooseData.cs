using System;

// Token: 0x02002ADE RID: 10974
internal class SurvivorsChooseData : ISurvivorsChooseData
{
	// Token: 0x17001E60 RID: 7776
	// (get) Token: 0x06016D6A RID: 93546 RVA: 0x005CC244 File Offset: 0x005CA444
	public ESurvivorsObtainMode ObtainMode { get; }

	// Token: 0x06016D6B RID: 93547 RVA: 0x005CC24C File Offset: 0x005CA44C
	public SurvivorsChooseData(ESurvivorsObtainMode obtainMode)
	{
		this.ObtainMode = obtainMode;
	}
}
