using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005464 RID: 21604
	public class IBuffProducerComponentT
	{
		// Token: 0x170099A6 RID: 39334
		// (get) Token: 0x06021EEB RID: 138987 RVA: 0x004AD517 File Offset: 0x004AB717
		// (set) Token: 0x06021EEC RID: 138988 RVA: 0x004AD51F File Offset: 0x004AB71F
		public bool Disabled { get; set; }

		// Token: 0x170099A7 RID: 39335
		// (get) Token: 0x06021EED RID: 138989 RVA: 0x004AD528 File Offset: 0x004AB728
		// (set) Token: 0x06021EEE RID: 138990 RVA: 0x004AD530 File Offset: 0x004AB730
		public TAddBuffModeUnion AddBuffMode { get; set; }

		// Token: 0x170099A8 RID: 39336
		// (get) Token: 0x06021EEF RID: 138991 RVA: 0x004AD539 File Offset: 0x004AB739
		// (set) Token: 0x06021EF0 RID: 138992 RVA: 0x004AD541 File Offset: 0x004AB741
		public long BuffId { get; set; }

		// Token: 0x170099A9 RID: 39337
		// (get) Token: 0x06021EF1 RID: 138993 RVA: 0x004AD54A File Offset: 0x004AB74A
		// (set) Token: 0x06021EF2 RID: 138994 RVA: 0x004AD552 File Offset: 0x004AB752
		public byte NullMask { get; set; }

		// Token: 0x06021EF3 RID: 138995 RVA: 0x004AD55B File Offset: 0x004AB75B
		public IBuffProducerComponentT()
		{
			this.Disabled = false;
			this.AddBuffMode = null;
			this.BuffId = 0L;
			this.NullMask = 0;
		}
	}
}
