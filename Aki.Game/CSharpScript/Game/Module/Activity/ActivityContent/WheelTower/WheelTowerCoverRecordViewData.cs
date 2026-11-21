using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F1F RID: 20255
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerCoverRecordViewData : IWheelTowerCoverRecordViewData
	{
		// Token: 0x17006320 RID: 25376
		// (get) Token: 0x06032E5C RID: 208476 RVA: 0x00E474F4 File Offset: 0x00E456F4
		// (set) Token: 0x06032E5D RID: 208477 RVA: 0x00E474FC File Offset: 0x00E456FC
		public IWheelTowerCoverRecordData BeforeData { get; set; } = new WheelTowerCoverRecordData();

		// Token: 0x17006321 RID: 25377
		// (get) Token: 0x06032E5E RID: 208478 RVA: 0x00E47505 File Offset: 0x00E45705
		// (set) Token: 0x06032E5F RID: 208479 RVA: 0x00E4750D File Offset: 0x00E4570D
		public IWheelTowerCoverRecordData AfterData { get; set; } = new WheelTowerCoverRecordData();

		// Token: 0x17006322 RID: 25378
		// (get) Token: 0x06032E60 RID: 208480 RVA: 0x00E47516 File Offset: 0x00E45716
		// (set) Token: 0x06032E61 RID: 208481 RVA: 0x00E4751E File Offset: 0x00E4571E
		public int TeamNum { get; set; }

		// Token: 0x17006323 RID: 25379
		// (get) Token: 0x06032E62 RID: 208482 RVA: 0x00E47527 File Offset: 0x00E45727
		// (set) Token: 0x06032E63 RID: 208483 RVA: 0x00E4752F File Offset: 0x00E4572F
		public bool IsEndless { get; set; }

		// Token: 0x17006324 RID: 25380
		// (get) Token: 0x06032E64 RID: 208484 RVA: 0x00E47538 File Offset: 0x00E45738
		// (set) Token: 0x06032E65 RID: 208485 RVA: 0x00E47540 File Offset: 0x00E45740
		[Nullable(2)]
		public Action OnClickConfirm { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006325 RID: 25381
		// (get) Token: 0x06032E66 RID: 208486 RVA: 0x00E47549 File Offset: 0x00E45749
		// (set) Token: 0x06032E67 RID: 208487 RVA: 0x00E47551 File Offset: 0x00E45751
		[Nullable(2)]
		public Action OnClickCancel { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
