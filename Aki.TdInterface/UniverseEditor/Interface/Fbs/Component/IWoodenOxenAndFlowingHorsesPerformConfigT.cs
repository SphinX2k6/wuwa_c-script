using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B90 RID: 23440
	public class IWoodenOxenAndFlowingHorsesPerformConfigT
	{
		// Token: 0x1700B129 RID: 45353
		// (get) Token: 0x0602821D RID: 164381 RVA: 0x0058426E File Offset: 0x0058246E
		// (set) Token: 0x0602821E RID: 164382 RVA: 0x00584276 File Offset: 0x00582476
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B12A RID: 45354
		// (get) Token: 0x0602821F RID: 164383 RVA: 0x0058427F File Offset: 0x0058247F
		// (set) Token: 0x06028220 RID: 164384 RVA: 0x00584287 File Offset: 0x00582487
		public string Montage { get; set; }

		// Token: 0x1700B12B RID: 45355
		// (get) Token: 0x06028221 RID: 164385 RVA: 0x00584290 File Offset: 0x00582490
		// (set) Token: 0x06028222 RID: 164386 RVA: 0x00584298 File Offset: 0x00582498
		public IVectorInfoT RelativeRot { get; set; }

		// Token: 0x06028223 RID: 164387 RVA: 0x005842A1 File Offset: 0x005824A1
		public IWoodenOxenAndFlowingHorsesPerformConfigT()
		{
			this.Offset = null;
			this.Montage = null;
			this.RelativeRot = null;
		}
	}
}
