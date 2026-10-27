using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E6A RID: 15978
	public class IFlipperSystemVarT
	{
		// Token: 0x17006EC5 RID: 28357
		// (get) Token: 0x060167FD RID: 92157 RVA: 0x0034093F File Offset: 0x0033EB3F
		// (set) Token: 0x060167FE RID: 92158 RVA: 0x00340947 File Offset: 0x0033EB47
		public EFlipperSystemVar VarType { get; set; }

		// Token: 0x17006EC6 RID: 28358
		// (get) Token: 0x060167FF RID: 92159 RVA: 0x00340950 File Offset: 0x0033EB50
		// (set) Token: 0x06016800 RID: 92160 RVA: 0x00340958 File Offset: 0x0033EB58
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x06016801 RID: 92161 RVA: 0x00340961 File Offset: 0x0033EB61
		public IFlipperSystemVarT()
		{
			this.VarType = EFlipperSystemVar.LifeRemain;
			this.VarRef = null;
		}
	}
}
