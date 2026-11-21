using System;
using System.Runtime.CompilerServices;

// Token: 0x02001997 RID: 6551
[NullableContext(1)]
[Nullable(0)]
public class MainPhantomItemData : IMainPhantomItemData
{
	// Token: 0x170018E6 RID: 6374
	// (get) Token: 0x0601026E RID: 66158 RVA: 0x004B5C11 File Offset: 0x004B3E11
	// (set) Token: 0x0601026F RID: 66159 RVA: 0x004B5C19 File Offset: 0x004B3E19
	public MainPhantomRecommendInfo Info { get; set; }

	// Token: 0x170018E7 RID: 6375
	// (get) Token: 0x06010270 RID: 66160 RVA: 0x004B5C22 File Offset: 0x004B3E22
	// (set) Token: 0x06010271 RID: 66161 RVA: 0x004B5C2A File Offset: 0x004B3E2A
	[Nullable(2)]
	public VisionMainSelectPhantomData CurrentSelectMainPhantom { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170018E8 RID: 6376
	// (get) Token: 0x06010272 RID: 66162 RVA: 0x004B5C33 File Offset: 0x004B3E33
	// (set) Token: 0x06010273 RID: 66163 RVA: 0x004B5C3B File Offset: 0x004B3E3B
	public Action<IMainPhantomItemData> OnMainPhantomCallBack { get; set; }
}
