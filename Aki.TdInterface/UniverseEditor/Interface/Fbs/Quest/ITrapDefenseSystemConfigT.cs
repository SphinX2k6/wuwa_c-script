using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004239 RID: 16953
	public class ITrapDefenseSystemConfigT
	{
		// Token: 0x1700785F RID: 30815
		// (get) Token: 0x06019116 RID: 102678 RVA: 0x0039B02D File Offset: 0x0039922D
		// (set) Token: 0x06019117 RID: 102679 RVA: 0x0039B035 File Offset: 0x00399235
		public EEnableSystemType Type { get; set; }

		// Token: 0x17007860 RID: 30816
		// (get) Token: 0x06019118 RID: 102680 RVA: 0x0039B03E File Offset: 0x0039923E
		// (set) Token: 0x06019119 RID: 102681 RVA: 0x0039B046 File Offset: 0x00399246
		public int TrapDefenseId { get; set; }

		// Token: 0x17007861 RID: 30817
		// (get) Token: 0x0601911A RID: 102682 RVA: 0x0039B04F File Offset: 0x0039924F
		// (set) Token: 0x0601911B RID: 102683 RVA: 0x0039B057 File Offset: 0x00399257
		public List<ITrapDefenseSystemVarT> Vars { get; set; }

		// Token: 0x0601911C RID: 102684 RVA: 0x0039B060 File Offset: 0x00399260
		public ITrapDefenseSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.TrapDefenseId = 0;
			this.Vars = null;
		}
	}
}
