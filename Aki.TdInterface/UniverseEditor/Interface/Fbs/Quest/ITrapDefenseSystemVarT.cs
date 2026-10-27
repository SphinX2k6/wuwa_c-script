using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200423C RID: 16956
	public class ITrapDefenseSystemVarT
	{
		// Token: 0x17007865 RID: 30821
		// (get) Token: 0x06019135 RID: 102709 RVA: 0x0039B4D3 File Offset: 0x003996D3
		// (set) Token: 0x06019136 RID: 102710 RVA: 0x0039B4DB File Offset: 0x003996DB
		public ETrapDefenseSystemVarType VarType { get; set; }

		// Token: 0x17007866 RID: 30822
		// (get) Token: 0x06019137 RID: 102711 RVA: 0x0039B4E4 File Offset: 0x003996E4
		// (set) Token: 0x06019138 RID: 102712 RVA: 0x0039B4EC File Offset: 0x003996EC
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x06019139 RID: 102713 RVA: 0x0039B4F5 File Offset: 0x003996F5
		public ITrapDefenseSystemVarT()
		{
			this.VarType = ETrapDefenseSystemVarType.Health;
			this.VarRef = null;
		}
	}
}
