using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045F1 RID: 17905
	public class TCsvTrapDefenseDataT
	{
		// Token: 0x17007F4F RID: 32591
		// (get) Token: 0x0601B1F5 RID: 111093 RVA: 0x003DD83F File Offset: 0x003DBA3F
		// (set) Token: 0x0601B1F6 RID: 111094 RVA: 0x003DD847 File Offset: 0x003DBA47
		public int Id { get; set; }

		// Token: 0x17007F50 RID: 32592
		// (get) Token: 0x0601B1F7 RID: 111095 RVA: 0x003DD850 File Offset: 0x003DBA50
		// (set) Token: 0x0601B1F8 RID: 111096 RVA: 0x003DD858 File Offset: 0x003DBA58
		public List<ITrapDefenseBatchT> Batches { get; set; }

		// Token: 0x0601B1F9 RID: 111097 RVA: 0x003DD861 File Offset: 0x003DBA61
		public TCsvTrapDefenseDataT()
		{
			this.Id = 0;
			this.Batches = null;
		}
	}
}
