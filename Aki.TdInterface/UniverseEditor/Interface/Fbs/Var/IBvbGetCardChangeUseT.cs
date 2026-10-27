using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A5B RID: 14939
	public class IBvbGetCardChangeUseT
	{
		// Token: 0x17006669 RID: 26217
		// (get) Token: 0x060143ED RID: 82925 RVA: 0x002F5307 File Offset: 0x002F3507
		// (set) Token: 0x060143EE RID: 82926 RVA: 0x002F530F File Offset: 0x002F350F
		public ESystemVarName Type { get; set; }

		// Token: 0x1700666A RID: 26218
		// (get) Token: 0x060143EF RID: 82927 RVA: 0x002F5318 File Offset: 0x002F3518
		// (set) Token: 0x060143F0 RID: 82928 RVA: 0x002F5320 File Offset: 0x002F3520
		public TVarRefUnion Card { get; set; }

		// Token: 0x060143F1 RID: 82929 RVA: 0x002F5329 File Offset: 0x002F3529
		public IBvbGetCardChangeUseT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.Card = null;
		}
	}
}
