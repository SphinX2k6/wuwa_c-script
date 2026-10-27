using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D0 RID: 22480
	public class IQuickHackSkillT
	{
		// Token: 0x1700A7D5 RID: 42965
		// (get) Token: 0x06025BE8 RID: 154600 RVA: 0x00534897 File Offset: 0x00532A97
		// (set) Token: 0x06025BE9 RID: 154601 RVA: 0x0053489F File Offset: 0x00532A9F
		public int Id { get; set; }

		// Token: 0x1700A7D6 RID: 42966
		// (get) Token: 0x06025BEA RID: 154602 RVA: 0x005348A8 File Offset: 0x00532AA8
		// (set) Token: 0x06025BEB RID: 154603 RVA: 0x005348B0 File Offset: 0x00532AB0
		public List<IQuickHackSkillContentT> Content { get; set; }

		// Token: 0x06025BEC RID: 154604 RVA: 0x005348B9 File Offset: 0x00532AB9
		public IQuickHackSkillT()
		{
			this.Id = 0;
			this.Content = null;
		}
	}
}
