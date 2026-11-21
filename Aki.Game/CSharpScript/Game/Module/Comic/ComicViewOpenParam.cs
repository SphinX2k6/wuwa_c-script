using System;

namespace CSharpScript.Game.Module.Comic
{
	// Token: 0x02004B6D RID: 19309
	public class ComicViewOpenParam : IComicViewOpenParam
	{
		// Token: 0x170060AD RID: 24749
		// (get) Token: 0x06030402 RID: 197634 RVA: 0x00D71D3E File Offset: 0x00D6FF3E
		// (set) Token: 0x06030403 RID: 197635 RVA: 0x00D71D46 File Offset: 0x00D6FF46
		public int ComicId { get; set; }

		// Token: 0x170060AE RID: 24750
		// (get) Token: 0x06030404 RID: 197636 RVA: 0x00D71D4F File Offset: 0x00D6FF4F
		// (set) Token: 0x06030405 RID: 197637 RVA: 0x00D71D57 File Offset: 0x00D6FF57
		public bool? FadeBeforeHide { get; set; }
	}
}
