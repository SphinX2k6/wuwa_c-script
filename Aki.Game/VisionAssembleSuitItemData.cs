using System;
using System.Runtime.CompilerServices;

// Token: 0x02001976 RID: 6518
public class VisionAssembleSuitItemData
{
	// Token: 0x0601014D RID: 65869 RVA: 0x004AFF8C File Offset: 0x004AE18C
	[NullableContext(1)]
	public void Phrase(VisionFetterData data)
	{
		this.FetterGroupId = data.FetterGroupId;
		this.CurrentProgress = data.ActiveFetterGroupNum;
		this.MaxProgress = data.NeedActiveNum;
	}

	// Token: 0x04008EB9 RID: 36537
	public int FetterGroupId;

	// Token: 0x04008EBA RID: 36538
	public int CurrentProgress;

	// Token: 0x04008EBB RID: 36539
	public int MaxProgress;
}
