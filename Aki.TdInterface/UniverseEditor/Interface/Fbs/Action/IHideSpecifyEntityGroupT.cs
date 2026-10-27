using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006904 RID: 26884
	public class IHideSpecifyEntityGroupT
	{
		// Token: 0x1700C770 RID: 51056
		// (get) Token: 0x0602EE87 RID: 192135 RVA: 0x00665DCF File Offset: 0x00663FCF
		// (set) Token: 0x0602EE88 RID: 192136 RVA: 0x00665DD7 File Offset: 0x00663FD7
		public EHideType Type { get; set; }

		// Token: 0x1700C771 RID: 51057
		// (get) Token: 0x0602EE89 RID: 192137 RVA: 0x00665DE0 File Offset: 0x00663FE0
		// (set) Token: 0x0602EE8A RID: 192138 RVA: 0x00665DE8 File Offset: 0x00663FE8
		public List<int> EntityIds { get; set; }

		// Token: 0x1700C772 RID: 51058
		// (get) Token: 0x0602EE8B RID: 192139 RVA: 0x00665DF1 File Offset: 0x00663FF1
		// (set) Token: 0x0602EE8C RID: 192140 RVA: 0x00665DF9 File Offset: 0x00663FF9
		public bool ForceClean { get; set; }

		// Token: 0x1700C773 RID: 51059
		// (get) Token: 0x0602EE8D RID: 192141 RVA: 0x00665E02 File Offset: 0x00664002
		// (set) Token: 0x0602EE8E RID: 192142 RVA: 0x00665E0A File Offset: 0x0066400A
		public byte NullMask { get; set; }

		// Token: 0x0602EE8F RID: 192143 RVA: 0x00665E13 File Offset: 0x00664013
		public IHideSpecifyEntityGroupT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.EntityIds = null;
			this.ForceClean = false;
			this.NullMask = 0;
		}
	}
}
