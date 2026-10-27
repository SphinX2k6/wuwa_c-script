using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064BD RID: 25789
	public class IConditionT
	{
		// Token: 0x1700BFE7 RID: 49127
		// (get) Token: 0x0602CBA8 RID: 183208 RVA: 0x00626033 File Offset: 0x00624233
		// (set) Token: 0x0602CBA9 RID: 183209 RVA: 0x0062603B File Offset: 0x0062423B
		public TVarValueUnion Var1 { get; set; }

		// Token: 0x1700BFE8 RID: 49128
		// (get) Token: 0x0602CBAA RID: 183210 RVA: 0x00626044 File Offset: 0x00624244
		// (set) Token: 0x0602CBAB RID: 183211 RVA: 0x0062604C File Offset: 0x0062424C
		public TVarValueUnion Var2 { get; set; }

		// Token: 0x1700BFE9 RID: 49129
		// (get) Token: 0x0602CBAC RID: 183212 RVA: 0x00626055 File Offset: 0x00624255
		// (set) Token: 0x0602CBAD RID: 183213 RVA: 0x0062605D File Offset: 0x0062425D
		public string Compare { get; set; }

		// Token: 0x0602CBAE RID: 183214 RVA: 0x00626066 File Offset: 0x00624266
		public IConditionT()
		{
			this.Var1 = null;
			this.Var2 = null;
			this.Compare = null;
		}
	}
}
