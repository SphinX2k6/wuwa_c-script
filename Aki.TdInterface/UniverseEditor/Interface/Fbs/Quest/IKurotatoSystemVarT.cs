using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004332 RID: 17202
	public class IKurotatoSystemVarT
	{
		// Token: 0x170075BB RID: 30139
		// (get) Token: 0x06018335 RID: 99125 RVA: 0x00373383 File Offset: 0x00371583
		// (set) Token: 0x06018336 RID: 99126 RVA: 0x0037338B File Offset: 0x0037158B
		public EKurotatoSystemVarType VarType { get; set; }

		// Token: 0x170075BC RID: 30140
		// (get) Token: 0x06018337 RID: 99127 RVA: 0x00373394 File Offset: 0x00371594
		// (set) Token: 0x06018338 RID: 99128 RVA: 0x0037339C File Offset: 0x0037159C
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x06018339 RID: 99129 RVA: 0x003733A5 File Offset: 0x003715A5
		public IKurotatoSystemVarT()
		{
			this.VarType = EKurotatoSystemVarType.Gold;
			this.VarRef = null;
		}
	}
}
