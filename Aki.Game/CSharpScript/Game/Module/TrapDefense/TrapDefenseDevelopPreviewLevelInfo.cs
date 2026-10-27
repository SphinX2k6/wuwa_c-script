using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A50 RID: 19024
	public class TrapDefenseDevelopPreviewLevelInfo : ITrapDefenseDevelopPreviewLevelInfo
	{
		// Token: 0x17007A61 RID: 31329
		// (get) Token: 0x060315BC RID: 202172 RVA: 0x00B723E2 File Offset: 0x00B705E2
		// (set) Token: 0x060315BD RID: 202173 RVA: 0x00B723EA File Offset: 0x00B705EA
		public int Id { get; set; }

		// Token: 0x17007A62 RID: 31330
		// (get) Token: 0x060315BE RID: 202174 RVA: 0x00B723F3 File Offset: 0x00B705F3
		// (set) Token: 0x060315BF RID: 202175 RVA: 0x00B723FB File Offset: 0x00B705FB
		public bool IsCurLevel { get; set; }

		// Token: 0x17007A63 RID: 31331
		// (get) Token: 0x060315C0 RID: 202176 RVA: 0x00B72404 File Offset: 0x00B70604
		// (set) Token: 0x060315C1 RID: 202177 RVA: 0x00B7240C File Offset: 0x00B7060C
		public bool? NeedAlpha { get; set; }
	}
}
