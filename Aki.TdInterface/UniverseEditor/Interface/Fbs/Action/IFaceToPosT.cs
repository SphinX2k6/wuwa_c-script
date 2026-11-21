using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DDA RID: 28122
	public class IFaceToPosT
	{
		// Token: 0x1700CE21 RID: 52769
		// (get) Token: 0x060308B5 RID: 198837 RVA: 0x00697A21 File Offset: 0x00695C21
		// (set) Token: 0x060308B6 RID: 198838 RVA: 0x00697A29 File Offset: 0x00695C29
		public IVectorInfoT Pos { get; set; }

		// Token: 0x060308B7 RID: 198839 RVA: 0x00697A32 File Offset: 0x00695C32
		public IFaceToPosT()
		{
			this.Pos = null;
		}
	}
}
