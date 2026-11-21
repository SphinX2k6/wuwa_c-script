using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042BD RID: 17085
	public class IGradingSystemVarT
	{
		// Token: 0x170074E9 RID: 29929
		// (get) Token: 0x06017F27 RID: 98087 RVA: 0x0036B577 File Offset: 0x00369777
		// (set) Token: 0x06017F28 RID: 98088 RVA: 0x0036B57F File Offset: 0x0036977F
		public EGradingSystemVarType VarType { get; set; }

		// Token: 0x170074EA RID: 29930
		// (get) Token: 0x06017F29 RID: 98089 RVA: 0x0036B588 File Offset: 0x00369788
		// (set) Token: 0x06017F2A RID: 98090 RVA: 0x0036B590 File Offset: 0x00369790
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x06017F2B RID: 98091 RVA: 0x0036B599 File Offset: 0x00369799
		public IGradingSystemVarT()
		{
			this.VarType = EGradingSystemVarType.Score;
			this.VarRef = null;
		}
	}
}
