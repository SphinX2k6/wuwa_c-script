using System;
using System.Runtime.CompilerServices;

// Token: 0x0200228F RID: 8847
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyPresetData
{
	// Token: 0x0400835D RID: 33629
	public int OfficialId;

	// Token: 0x0400835E RID: 33630
	public int CustomId;

	// Token: 0x0400835F RID: 33631
	public string Name = "";

	// Token: 0x04008360 RID: 33632
	public int SkinId;

	// Token: 0x04008361 RID: 33633
	public int FrameId;

	// Token: 0x04008362 RID: 33634
	public int[] StickerIds = Array.Empty<int>();

	// Token: 0x04008363 RID: 33635
	public int[] DecorateIds = Array.Empty<int>();

	// Token: 0x04008364 RID: 33636
	public bool IsCurEquipped;
}
