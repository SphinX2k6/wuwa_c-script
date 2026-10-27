using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A5A RID: 19034
	public class TrapDefenseResultInfo : ITrapDefenseResultInfo
	{
		// Token: 0x17007A78 RID: 31352
		// (get) Token: 0x060315EE RID: 202222 RVA: 0x00B724BD File Offset: 0x00B706BD
		// (set) Token: 0x060315EF RID: 202223 RVA: 0x00B724C5 File Offset: 0x00B706C5
		public int Value { get; set; }

		// Token: 0x17007A79 RID: 31353
		// (get) Token: 0x060315F0 RID: 202224 RVA: 0x00B724CE File Offset: 0x00B706CE
		// (set) Token: 0x060315F1 RID: 202225 RVA: 0x00B724D6 File Offset: 0x00B706D6
		public ETrapDefenseResultType Type { get; set; }

		// Token: 0x17007A7A RID: 31354
		// (get) Token: 0x060315F2 RID: 202226 RVA: 0x00B724DF File Offset: 0x00B706DF
		// (set) Token: 0x060315F3 RID: 202227 RVA: 0x00B724E7 File Offset: 0x00B706E7
		public int? Total { get; set; }

		// Token: 0x17007A7B RID: 31355
		// (get) Token: 0x060315F4 RID: 202228 RVA: 0x00B724F0 File Offset: 0x00B706F0
		// (set) Token: 0x060315F5 RID: 202229 RVA: 0x00B724F8 File Offset: 0x00B706F8
		public int? History { get; set; }
	}
}
