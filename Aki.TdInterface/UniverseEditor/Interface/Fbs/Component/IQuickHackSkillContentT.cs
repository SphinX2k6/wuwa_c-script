using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DDA RID: 24026
	public class IQuickHackSkillContentT
	{
		// Token: 0x1700B0FE RID: 45310
		// (get) Token: 0x06028126 RID: 164134 RVA: 0x0057AE14 File Offset: 0x00579014
		// (set) Token: 0x06028127 RID: 164135 RVA: 0x0057AE1C File Offset: 0x0057901C
		public string EntityState { get; set; }

		// Token: 0x1700B0FF RID: 45311
		// (get) Token: 0x06028128 RID: 164136 RVA: 0x0057AE25 File Offset: 0x00579025
		// (set) Token: 0x06028129 RID: 164137 RVA: 0x0057AE2D File Offset: 0x0057902D
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x0602812A RID: 164138 RVA: 0x0057AE36 File Offset: 0x00579036
		public IQuickHackSkillContentT()
		{
			this.EntityState = null;
			this.Actions = null;
		}
	}
}
