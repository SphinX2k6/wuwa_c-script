using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D6C RID: 28012
	public class IPosRotT
	{
		// Token: 0x1700D0F4 RID: 53492
		// (get) Token: 0x06031786 RID: 202630 RVA: 0x006B4FDA File Offset: 0x006B31DA
		// (set) Token: 0x06031787 RID: 202631 RVA: 0x006B4FE2 File Offset: 0x006B31E2
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700D0F5 RID: 53493
		// (get) Token: 0x06031788 RID: 202632 RVA: 0x006B4FEB File Offset: 0x006B31EB
		// (set) Token: 0x06031789 RID: 202633 RVA: 0x006B4FF3 File Offset: 0x006B31F3
		public IVectorInfoT Rot { get; set; }

		// Token: 0x0603178A RID: 202634 RVA: 0x006B4FFC File Offset: 0x006B31FC
		public IPosRotT()
		{
			this.Pos = null;
			this.Rot = null;
		}
	}
}
