using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A5 RID: 17061
	public class IFlipperSystemVarT
	{
		// Token: 0x170074A9 RID: 29865
		// (get) Token: 0x06017E24 RID: 97828 RVA: 0x0036946F File Offset: 0x0036766F
		// (set) Token: 0x06017E25 RID: 97829 RVA: 0x00369477 File Offset: 0x00367677
		public EFlipperSystemVar VarType { get; set; }

		// Token: 0x170074AA RID: 29866
		// (get) Token: 0x06017E26 RID: 97830 RVA: 0x00369480 File Offset: 0x00367680
		// (set) Token: 0x06017E27 RID: 97831 RVA: 0x00369488 File Offset: 0x00367688
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x06017E28 RID: 97832 RVA: 0x00369491 File Offset: 0x00367691
		public IFlipperSystemVarT()
		{
			this.VarType = EFlipperSystemVar.LifeRemain;
			this.VarRef = null;
		}
	}
}
