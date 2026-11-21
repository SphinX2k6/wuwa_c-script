using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077AD RID: 30637
	public class ISetEntityPosT
	{
		// Token: 0x1700E07E RID: 57470
		// (get) Token: 0x06035CAC RID: 220332 RVA: 0x00734DF1 File Offset: 0x00732FF1
		// (set) Token: 0x06035CAD RID: 220333 RVA: 0x00734DF9 File Offset: 0x00732FF9
		public int EntityId { get; set; }

		// Token: 0x1700E07F RID: 57471
		// (get) Token: 0x06035CAE RID: 220334 RVA: 0x00734E02 File Offset: 0x00733002
		// (set) Token: 0x06035CAF RID: 220335 RVA: 0x00734E0A File Offset: 0x0073300A
		public IPosAT Pos { get; set; }

		// Token: 0x1700E080 RID: 57472
		// (get) Token: 0x06035CB0 RID: 220336 RVA: 0x00734E13 File Offset: 0x00733013
		// (set) Token: 0x06035CB1 RID: 220337 RVA: 0x00734E1B File Offset: 0x0073301B
		public IVectorInfoT Rot { get; set; }

		// Token: 0x06035CB2 RID: 220338 RVA: 0x00734E24 File Offset: 0x00733024
		public ISetEntityPosT()
		{
			this.EntityId = 0;
			this.Pos = null;
			this.Rot = null;
		}
	}
}
