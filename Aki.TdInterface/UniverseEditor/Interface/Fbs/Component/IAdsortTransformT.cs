using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E69 RID: 20073
	public class IAdsortTransformT
	{
		// Token: 0x17008FB2 RID: 36786
		// (get) Token: 0x0601F862 RID: 129122 RVA: 0x00463FD2 File Offset: 0x004621D2
		// (set) Token: 0x0601F863 RID: 129123 RVA: 0x00463FDA File Offset: 0x004621DA
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17008FB3 RID: 36787
		// (get) Token: 0x0601F864 RID: 129124 RVA: 0x00463FE3 File Offset: 0x004621E3
		// (set) Token: 0x0601F865 RID: 129125 RVA: 0x00463FEB File Offset: 0x004621EB
		public IVectorInfoT Rot { get; set; }

		// Token: 0x0601F866 RID: 129126 RVA: 0x00463FF4 File Offset: 0x004621F4
		public IAdsortTransformT()
		{
			this.Pos = null;
			this.Rot = null;
		}
	}
}
