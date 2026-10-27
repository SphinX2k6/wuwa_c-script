using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200455B RID: 17755
	public class IRollBlockGlobalConfigT
	{
		// Token: 0x17007DF5 RID: 32245
		// (get) Token: 0x0601ABB9 RID: 109497 RVA: 0x003D003A File Offset: 0x003CE23A
		// (set) Token: 0x0601ABBA RID: 109498 RVA: 0x003D0042 File Offset: 0x003CE242
		public int Id { get; set; }

		// Token: 0x17007DF6 RID: 32246
		// (get) Token: 0x0601ABBB RID: 109499 RVA: 0x003D004B File Offset: 0x003CE24B
		// (set) Token: 0x0601ABBC RID: 109500 RVA: 0x003D0053 File Offset: 0x003CE253
		public string GroupName { get; set; }

		// Token: 0x17007DF7 RID: 32247
		// (get) Token: 0x0601ABBD RID: 109501 RVA: 0x003D005C File Offset: 0x003CE25C
		// (set) Token: 0x0601ABBE RID: 109502 RVA: 0x003D0064 File Offset: 0x003CE264
		public List<IRollBlockLevelConfigT> Levels { get; set; }

		// Token: 0x0601ABBF RID: 109503 RVA: 0x003D006D File Offset: 0x003CE26D
		public IRollBlockGlobalConfigT()
		{
			this.Id = 0;
			this.GroupName = null;
			this.Levels = null;
		}
	}
}
