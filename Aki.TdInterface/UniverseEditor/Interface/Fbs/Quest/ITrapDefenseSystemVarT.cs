using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004698 RID: 18072
	public class ITrapDefenseSystemVarT
	{
		// Token: 0x17007E96 RID: 32406
		// (get) Token: 0x0601A8A1 RID: 108705 RVA: 0x003C6BAB File Offset: 0x003C4DAB
		// (set) Token: 0x0601A8A2 RID: 108706 RVA: 0x003C6BB3 File Offset: 0x003C4DB3
		public ETrapDefenseSystemVarType VarType { get; set; }

		// Token: 0x17007E97 RID: 32407
		// (get) Token: 0x0601A8A3 RID: 108707 RVA: 0x003C6BBC File Offset: 0x003C4DBC
		// (set) Token: 0x0601A8A4 RID: 108708 RVA: 0x003C6BC4 File Offset: 0x003C4DC4
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x0601A8A5 RID: 108709 RVA: 0x003C6BCD File Offset: 0x003C4DCD
		public ITrapDefenseSystemVarT()
		{
			this.VarType = ETrapDefenseSystemVarType.Health;
			this.VarRef = null;
		}
	}
}
