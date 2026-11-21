using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004296 RID: 17046
	public class IFlagChallengeSystemVarT
	{
		// Token: 0x17007497 RID: 29847
		// (get) Token: 0x06017DBB RID: 97723 RVA: 0x0036884B File Offset: 0x00366A4B
		// (set) Token: 0x06017DBC RID: 97724 RVA: 0x00368853 File Offset: 0x00366A53
		public EFlagChallengeSystemVarType VarType { get; set; }

		// Token: 0x17007498 RID: 29848
		// (get) Token: 0x06017DBD RID: 97725 RVA: 0x0036885C File Offset: 0x00366A5C
		// (set) Token: 0x06017DBE RID: 97726 RVA: 0x00368864 File Offset: 0x00366A64
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x06017DBF RID: 97727 RVA: 0x0036886D File Offset: 0x00366A6D
		public IFlagChallengeSystemVarT()
		{
			this.VarType = EFlagChallengeSystemVarType.IsCompleted;
			this.VarRef = null;
		}
	}
}
