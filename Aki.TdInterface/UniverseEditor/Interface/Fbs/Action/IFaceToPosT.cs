using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200675A RID: 26458
	public class IFaceToPosT
	{
		// Token: 0x1700C46B RID: 50283
		// (get) Token: 0x0602E06F RID: 188527 RVA: 0x0064A2DD File Offset: 0x006484DD
		// (set) Token: 0x0602E070 RID: 188528 RVA: 0x0064A2E5 File Offset: 0x006484E5
		public IVectorInfoT Pos { get; set; }

		// Token: 0x0602E071 RID: 188529 RVA: 0x0064A2EE File Offset: 0x006484EE
		public IFaceToPosT()
		{
			this.Pos = null;
		}
	}
}
