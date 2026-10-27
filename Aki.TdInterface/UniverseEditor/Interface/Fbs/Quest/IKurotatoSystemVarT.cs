using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EF4 RID: 16116
	public class IKurotatoSystemVarT
	{
		// Token: 0x17006FCC RID: 28620
		// (get) Token: 0x06016CDE RID: 93406 RVA: 0x0034A1B7 File Offset: 0x003483B7
		// (set) Token: 0x06016CDF RID: 93407 RVA: 0x0034A1BF File Offset: 0x003483BF
		public EKurotatoSystemVarType VarType { get; set; }

		// Token: 0x17006FCD RID: 28621
		// (get) Token: 0x06016CE0 RID: 93408 RVA: 0x0034A1C8 File Offset: 0x003483C8
		// (set) Token: 0x06016CE1 RID: 93409 RVA: 0x0034A1D0 File Offset: 0x003483D0
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x06016CE2 RID: 93410 RVA: 0x0034A1D9 File Offset: 0x003483D9
		public IKurotatoSystemVarT()
		{
			this.VarType = EKurotatoSystemVarType.Gold;
			this.VarRef = null;
		}
	}
}
