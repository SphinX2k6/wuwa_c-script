using System;
using System.Runtime.CompilerServices;

// Token: 0x020024AF RID: 9391
[NullableContext(1)]
public interface IMainPhantomItemData
{
	// Token: 0x170018A9 RID: 6313
	// (get) Token: 0x06012DA8 RID: 77224
	// (set) Token: 0x06012DA9 RID: 77225
	MainPhantomRecommendInfo Info { get; set; }

	// Token: 0x170018AA RID: 6314
	// (get) Token: 0x06012DAA RID: 77226
	// (set) Token: 0x06012DAB RID: 77227
	[Nullable(2)]
	VisionMainSelectPhantomData CurrentSelectMainPhantom { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170018AB RID: 6315
	// (get) Token: 0x06012DAC RID: 77228
	// (set) Token: 0x06012DAD RID: 77229
	Action<IMainPhantomItemData> OnMainPhantomCallBack { get; set; }
}
