using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E9F RID: 16031
	public class IGlobalVarRefT
	{
		// Token: 0x17006C67 RID: 27751
		// (get) Token: 0x06015A86 RID: 88710 RVA: 0x0031EAD9 File Offset: 0x0031CCD9
		// (set) Token: 0x06015A87 RID: 88711 RVA: 0x0031EAE1 File Offset: 0x0031CCE1
		public EVar Type { get; set; }

		// Token: 0x17006C68 RID: 27752
		// (get) Token: 0x06015A88 RID: 88712 RVA: 0x0031EAEA File Offset: 0x0031CCEA
		// (set) Token: 0x06015A89 RID: 88713 RVA: 0x0031EAF2 File Offset: 0x0031CCF2
		public EVarRefSource Source { get; set; }

		// Token: 0x17006C69 RID: 27753
		// (get) Token: 0x06015A8A RID: 88714 RVA: 0x0031EAFB File Offset: 0x0031CCFB
		// (set) Token: 0x06015A8B RID: 88715 RVA: 0x0031EB03 File Offset: 0x0031CD03
		public string Keyword { get; set; }

		// Token: 0x06015A8C RID: 88716 RVA: 0x0031EB0C File Offset: 0x0031CD0C
		public IGlobalVarRefT()
		{
			this.Type = EVar.Boolean;
			this.Source = EVarRefSource.Constant;
			this.Keyword = null;
		}
	}
}
