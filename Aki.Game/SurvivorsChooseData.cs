using System;

// Token: 0x0200205A RID: 8282
internal class SurvivorsChooseData : ISurvivorsChooseData
{
	// Token: 0x17001EB8 RID: 7864
	// (get) Token: 0x0601479B RID: 83867 RVA: 0x005F8D94 File Offset: 0x005F6F94
	public ESurvivorsObtainMode ObtainMode { get; }

	// Token: 0x0601479C RID: 83868 RVA: 0x005F8D9C File Offset: 0x005F6F9C
	public SurvivorsChooseData(ESurvivorsObtainMode obtainMode)
	{
		this.ObtainMode = obtainMode;
	}
}
