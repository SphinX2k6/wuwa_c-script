using System;
using System.Runtime.CompilerServices;

// Token: 0x0200248F RID: 9359
public class VisionAssembleSuitItemData
{
	// Token: 0x06012C8C RID: 76940 RVA: 0x004A249C File Offset: 0x004A069C
	[NullableContext(1)]
	public void Phrase(VisionFetterData data)
	{
		this.FetterGroupId = data.FetterGroupId;
		this.CurrentProgress = data.ActiveFetterGroupNum;
		this.MaxProgress = data.NeedActiveNum;
	}

	// Token: 0x04008D70 RID: 36208
	public int FetterGroupId;

	// Token: 0x04008D71 RID: 36209
	public int CurrentProgress;

	// Token: 0x04008D72 RID: 36210
	public int MaxProgress;
}
