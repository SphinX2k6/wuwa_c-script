using System;

namespace CSharpScript.Game.Module.Comic
{
	// Token: 0x02005B8D RID: 23437
	public class ComicViewOpenParam : IComicViewOpenParam
	{
		// Token: 0x17008CDB RID: 36059
		// (get) Token: 0x0603B4B5 RID: 242869 RVA: 0x00E217D2 File Offset: 0x00E1F9D2
		// (set) Token: 0x0603B4B6 RID: 242870 RVA: 0x00E217DA File Offset: 0x00E1F9DA
		public int ComicId { get; set; }

		// Token: 0x17008CDC RID: 36060
		// (get) Token: 0x0603B4B7 RID: 242871 RVA: 0x00E217E3 File Offset: 0x00E1F9E3
		// (set) Token: 0x0603B4B8 RID: 242872 RVA: 0x00E217EB File Offset: 0x00E1F9EB
		public bool? FadeBeforeHide { get; set; }
	}
}
