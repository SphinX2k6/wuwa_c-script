using System;

// Token: 0x020024AA RID: 9386
public class MainPhantomFilterChangedInfo : IMainPhantomFilterChangedInfo
{
	// Token: 0x170018A1 RID: 6305
	// (get) Token: 0x06012D63 RID: 77155 RVA: 0x004A63E8 File Offset: 0x004A45E8
	// (set) Token: 0x06012D64 RID: 77156 RVA: 0x004A63F0 File Offset: 0x004A45F0
	public int MonsterId { get; set; }

	// Token: 0x170018A2 RID: 6306
	// (get) Token: 0x06012D65 RID: 77157 RVA: 0x004A63F9 File Offset: 0x004A45F9
	// (set) Token: 0x06012D66 RID: 77158 RVA: 0x004A6401 File Offset: 0x004A4601
	public int FetterGroupId { get; set; }

	// Token: 0x170018A3 RID: 6307
	// (get) Token: 0x06012D67 RID: 77159 RVA: 0x004A640A File Offset: 0x004A460A
	// (set) Token: 0x06012D68 RID: 77160 RVA: 0x004A6412 File Offset: 0x004A4612
	public int Cost { get; set; }

	// Token: 0x170018A4 RID: 6308
	// (get) Token: 0x06012D69 RID: 77161 RVA: 0x004A641B File Offset: 0x004A461B
	// (set) Token: 0x06012D6A RID: 77162 RVA: 0x004A6423 File Offset: 0x004A4623
	public bool IsDeselect { get; set; }
}
