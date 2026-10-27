using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B9C RID: 23452
	public class IWuWaGoBowTrapT
	{
		// Token: 0x1700B13A RID: 45370
		// (get) Token: 0x0602826D RID: 164461 RVA: 0x005849BA File Offset: 0x00582BBA
		// (set) Token: 0x0602826E RID: 164462 RVA: 0x005849C2 File Offset: 0x00582BC2
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x0602826F RID: 164463 RVA: 0x005849CB File Offset: 0x00582BCB
		public IWuWaGoBowTrapT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
		}
	}
}
