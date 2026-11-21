using System;

// Token: 0x02001991 RID: 6545
public class MainPhantomFilterChangedInfo : IMainPhantomFilterChangedInfo
{
	// Token: 0x170018DB RID: 6363
	// (get) Token: 0x06010224 RID: 66084 RVA: 0x004B3EE0 File Offset: 0x004B20E0
	// (set) Token: 0x06010225 RID: 66085 RVA: 0x004B3EE8 File Offset: 0x004B20E8
	public int MonsterId { get; set; }

	// Token: 0x170018DC RID: 6364
	// (get) Token: 0x06010226 RID: 66086 RVA: 0x004B3EF1 File Offset: 0x004B20F1
	// (set) Token: 0x06010227 RID: 66087 RVA: 0x004B3EF9 File Offset: 0x004B20F9
	public int FetterGroupId { get; set; }

	// Token: 0x170018DD RID: 6365
	// (get) Token: 0x06010228 RID: 66088 RVA: 0x004B3F02 File Offset: 0x004B2102
	// (set) Token: 0x06010229 RID: 66089 RVA: 0x004B3F0A File Offset: 0x004B210A
	public int Cost { get; set; }

	// Token: 0x170018DE RID: 6366
	// (get) Token: 0x0601022A RID: 66090 RVA: 0x004B3F13 File Offset: 0x004B2113
	// (set) Token: 0x0601022B RID: 66091 RVA: 0x004B3F1B File Offset: 0x004B211B
	public bool IsDeselect { get; set; }
}
