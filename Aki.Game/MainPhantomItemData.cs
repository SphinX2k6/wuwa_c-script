using System;
using System.Runtime.CompilerServices;

// Token: 0x020024B0 RID: 9392
[NullableContext(1)]
[Nullable(0)]
public class MainPhantomItemData : IMainPhantomItemData
{
	// Token: 0x170018AC RID: 6316
	// (get) Token: 0x06012DAE RID: 77230 RVA: 0x004A805D File Offset: 0x004A625D
	// (set) Token: 0x06012DAF RID: 77231 RVA: 0x004A8065 File Offset: 0x004A6265
	public MainPhantomRecommendInfo Info { get; set; }

	// Token: 0x170018AD RID: 6317
	// (get) Token: 0x06012DB0 RID: 77232 RVA: 0x004A806E File Offset: 0x004A626E
	// (set) Token: 0x06012DB1 RID: 77233 RVA: 0x004A8076 File Offset: 0x004A6276
	[Nullable(2)]
	public VisionMainSelectPhantomData CurrentSelectMainPhantom { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170018AE RID: 6318
	// (get) Token: 0x06012DB2 RID: 77234 RVA: 0x004A807F File Offset: 0x004A627F
	// (set) Token: 0x06012DB3 RID: 77235 RVA: 0x004A8087 File Offset: 0x004A6287
	public Action<IMainPhantomItemData> OnMainPhantomCallBack { get; set; }
}
