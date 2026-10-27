using System;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020052F4 RID: 21236
	public class IllustratedTokenDataInfo : IIllustratedTokenDataInfo
	{
		// Token: 0x17008315 RID: 33557
		// (get) Token: 0x060365AB RID: 222635 RVA: 0x00CDC6E8 File Offset: 0x00CDA8E8
		// (set) Token: 0x060365AC RID: 222636 RVA: 0x00CDC6F0 File Offset: 0x00CDA8F0
		public int ConfigId { get; set; }

		// Token: 0x17008316 RID: 33558
		// (get) Token: 0x060365AD RID: 222637 RVA: 0x00CDC6F9 File Offset: 0x00CDA8F9
		// (set) Token: 0x060365AE RID: 222638 RVA: 0x00CDC701 File Offset: 0x00CDA901
		public int CollectionIndex { get; set; }

		// Token: 0x17008317 RID: 33559
		// (get) Token: 0x060365AF RID: 222639 RVA: 0x00CDC70A File Offset: 0x00CDA90A
		// (set) Token: 0x060365B0 RID: 222640 RVA: 0x00CDC712 File Offset: 0x00CDA912
		public bool IsLock { get; set; }

		// Token: 0x17008318 RID: 33560
		// (get) Token: 0x060365B1 RID: 222641 RVA: 0x00CDC71B File Offset: 0x00CDA91B
		// (set) Token: 0x060365B2 RID: 222642 RVA: 0x00CDC723 File Offset: 0x00CDA923
		public bool HasRedDot { get; set; }

		// Token: 0x17008319 RID: 33561
		// (get) Token: 0x060365B3 RID: 222643 RVA: 0x00CDC72C File Offset: 0x00CDA92C
		// (set) Token: 0x060365B4 RID: 222644 RVA: 0x00CDC734 File Offset: 0x00CDA934
		public bool IsSelectOn { get; set; }
	}
}
