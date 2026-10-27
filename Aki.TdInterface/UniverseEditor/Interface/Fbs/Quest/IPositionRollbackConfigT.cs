using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FAE RID: 16302
	public class IPositionRollbackConfigT
	{
		// Token: 0x170071D6 RID: 29142
		// (get) Token: 0x060174DA RID: 95450 RVA: 0x0035C1BD File Offset: 0x0035A3BD
		// (set) Token: 0x060174DB RID: 95451 RVA: 0x0035C1C5 File Offset: 0x0035A3C5
		public IVectorInfoT CheckPoint { get; set; }

		// Token: 0x170071D7 RID: 29143
		// (get) Token: 0x060174DC RID: 95452 RVA: 0x0035C1CE File Offset: 0x0035A3CE
		// (set) Token: 0x060174DD RID: 95453 RVA: 0x0035C1D6 File Offset: 0x0035A3D6
		public int CheckRange { get; set; }

		// Token: 0x170071D8 RID: 29144
		// (get) Token: 0x060174DE RID: 95454 RVA: 0x0035C1DF File Offset: 0x0035A3DF
		// (set) Token: 0x060174DF RID: 95455 RVA: 0x0035C1E7 File Offset: 0x0035A3E7
		public Aki.UniverseEditor.Interface.Fbs.Action.IPosAT Position { get; set; }

		// Token: 0x060174E0 RID: 95456 RVA: 0x0035C1F0 File Offset: 0x0035A3F0
		public IPositionRollbackConfigT()
		{
			this.CheckPoint = null;
			this.CheckRange = 0;
			this.Position = null;
		}
	}
}
