using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E5B RID: 15963
	public class IFlagChallengeSystemVarT
	{
		// Token: 0x17006EB3 RID: 28339
		// (get) Token: 0x06016794 RID: 92052 RVA: 0x0033FD1B File Offset: 0x0033DF1B
		// (set) Token: 0x06016795 RID: 92053 RVA: 0x0033FD23 File Offset: 0x0033DF23
		public EFlagChallengeSystemVarType VarType { get; set; }

		// Token: 0x17006EB4 RID: 28340
		// (get) Token: 0x06016796 RID: 92054 RVA: 0x0033FD2C File Offset: 0x0033DF2C
		// (set) Token: 0x06016797 RID: 92055 RVA: 0x0033FD34 File Offset: 0x0033DF34
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x06016798 RID: 92056 RVA: 0x0033FD3D File Offset: 0x0033DF3D
		public IFlagChallengeSystemVarT()
		{
			this.VarType = EFlagChallengeSystemVarType.IsCompleted;
			this.VarRef = null;
		}
	}
}
