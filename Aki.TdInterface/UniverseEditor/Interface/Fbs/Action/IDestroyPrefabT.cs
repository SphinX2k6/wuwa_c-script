using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006595 RID: 26005
	public class IDestroyPrefabT
	{
		// Token: 0x1700C120 RID: 49440
		// (get) Token: 0x0602D1C5 RID: 184773 RVA: 0x00630109 File Offset: 0x0062E309
		// (set) Token: 0x0602D1C6 RID: 184774 RVA: 0x00630111 File Offset: 0x0062E311
		public TVarRefUnion VarName { get; set; }

		// Token: 0x0602D1C7 RID: 184775 RVA: 0x0063011A File Offset: 0x0062E31A
		public IDestroyPrefabT()
		{
			this.VarName = null;
		}
	}
}
