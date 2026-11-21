using System;
using System.Runtime.CompilerServices;

// Token: 0x0200184A RID: 6218
[NullableContext(1)]
[Nullable(0)]
public class PreviewPayGiftEntry : IPreviewPayGiftEntry
{
	// Token: 0x170017D4 RID: 6100
	// (get) Token: 0x0600F5BC RID: 62908 RVA: 0x0047C588 File Offset: 0x0047A788
	// (set) Token: 0x0600F5BD RID: 62909 RVA: 0x0047C590 File Offset: 0x0047A790
	public long EndStampSec { get; set; }

	// Token: 0x170017D5 RID: 6101
	// (get) Token: 0x0600F5BE RID: 62910 RVA: 0x0047C599 File Offset: 0x0047A799
	// (set) Token: 0x0600F5BF RID: 62911 RVA: 0x0047C5A1 File Offset: 0x0047A7A1
	public string Title { get; set; }

	// Token: 0x170017D6 RID: 6102
	// (get) Token: 0x0600F5C0 RID: 62912 RVA: 0x0047C5AA File Offset: 0x0047A7AA
	// (set) Token: 0x0600F5C1 RID: 62913 RVA: 0x0047C5B2 File Offset: 0x0047A7B2
	public string RewardListDesc { get; set; }
}
