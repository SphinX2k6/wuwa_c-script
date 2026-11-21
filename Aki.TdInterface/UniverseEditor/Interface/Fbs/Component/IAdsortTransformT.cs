using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200537A RID: 21370
	public class IAdsortTransformT
	{
		// Token: 0x170096EB RID: 38635
		// (get) Token: 0x060214AD RID: 136365 RVA: 0x00497FEA File Offset: 0x004961EA
		// (set) Token: 0x060214AE RID: 136366 RVA: 0x00497FF2 File Offset: 0x004961F2
		public IVectorInfoT Pos { get; set; }

		// Token: 0x170096EC RID: 38636
		// (get) Token: 0x060214AF RID: 136367 RVA: 0x00497FFB File Offset: 0x004961FB
		// (set) Token: 0x060214B0 RID: 136368 RVA: 0x00498003 File Offset: 0x00496203
		public IVectorInfoT Rot { get; set; }

		// Token: 0x060214B1 RID: 136369 RVA: 0x0049800C File Offset: 0x0049620C
		public IAdsortTransformT()
		{
			this.Pos = null;
			this.Rot = null;
		}
	}
}
