using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BFD RID: 27645
	public class IDestroyPrefabT
	{
		// Token: 0x1700CAAF RID: 51887
		// (get) Token: 0x0602F949 RID: 194889 RVA: 0x0067C2CD File Offset: 0x0067A4CD
		// (set) Token: 0x0602F94A RID: 194890 RVA: 0x0067C2D5 File Offset: 0x0067A4D5
		public TVarRefUnion VarName { get; set; }

		// Token: 0x0602F94B RID: 194891 RVA: 0x0067C2DE File Offset: 0x0067A4DE
		public IDestroyPrefabT()
		{
			this.VarName = null;
		}
	}
}
