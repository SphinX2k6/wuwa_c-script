using System;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020052F8 RID: 21240
	public class RogueEndingItemParam : IRogueEndingItemParam
	{
		// Token: 0x1700831F RID: 33567
		// (get) Token: 0x060365C1 RID: 222657 RVA: 0x00CDC759 File Offset: 0x00CDA959
		// (set) Token: 0x060365C2 RID: 222658 RVA: 0x00CDC761 File Offset: 0x00CDA961
		public int ConfigId { get; set; }

		// Token: 0x17008320 RID: 33568
		// (get) Token: 0x060365C3 RID: 222659 RVA: 0x00CDC76A File Offset: 0x00CDA96A
		// (set) Token: 0x060365C4 RID: 222660 RVA: 0x00CDC772 File Offset: 0x00CDA972
		public int Index { get; set; }

		// Token: 0x17008321 RID: 33569
		// (get) Token: 0x060365C5 RID: 222661 RVA: 0x00CDC77B File Offset: 0x00CDA97B
		// (set) Token: 0x060365C6 RID: 222662 RVA: 0x00CDC783 File Offset: 0x00CDA983
		public float? Rotation { get; set; }

		// Token: 0x17008322 RID: 33570
		// (get) Token: 0x060365C7 RID: 222663 RVA: 0x00CDC78C File Offset: 0x00CDA98C
		// (set) Token: 0x060365C8 RID: 222664 RVA: 0x00CDC794 File Offset: 0x00CDA994
		public bool IsSubView { get; set; }

		// Token: 0x17008323 RID: 33571
		// (get) Token: 0x060365C9 RID: 222665 RVA: 0x00CDC79D File Offset: 0x00CDA99D
		// (set) Token: 0x060365CA RID: 222666 RVA: 0x00CDC7A5 File Offset: 0x00CDA9A5
		public bool IsUnlock { get; set; }
	}
}
