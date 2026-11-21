using System;
using System.Runtime.CompilerServices;

// Token: 0x02001773 RID: 6003
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyPresetData
{
	// Token: 0x0400849B RID: 33947
	public int OfficialId;

	// Token: 0x0400849C RID: 33948
	public int CustomId;

	// Token: 0x0400849D RID: 33949
	public string Name = "";

	// Token: 0x0400849E RID: 33950
	public int SkinId;

	// Token: 0x0400849F RID: 33951
	public int FrameId;

	// Token: 0x040084A0 RID: 33952
	public int[] StickerIds = Array.Empty<int>();

	// Token: 0x040084A1 RID: 33953
	public int[] DecorateIds = Array.Empty<int>();

	// Token: 0x040084A2 RID: 33954
	public bool IsCurEquipped;
}
