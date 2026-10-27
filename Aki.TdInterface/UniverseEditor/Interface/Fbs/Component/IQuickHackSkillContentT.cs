using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D3 RID: 22483
	public class IQuickHackSkillContentT
	{
		// Token: 0x1700A7DA RID: 42970
		// (get) Token: 0x06025C06 RID: 154630 RVA: 0x00534C88 File Offset: 0x00532E88
		// (set) Token: 0x06025C07 RID: 154631 RVA: 0x00534C90 File Offset: 0x00532E90
		public string EntityState { get; set; }

		// Token: 0x1700A7DB RID: 42971
		// (get) Token: 0x06025C08 RID: 154632 RVA: 0x00534C99 File Offset: 0x00532E99
		// (set) Token: 0x06025C09 RID: 154633 RVA: 0x00534CA1 File Offset: 0x00532EA1
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06025C0A RID: 154634 RVA: 0x00534CAA File Offset: 0x00532EAA
		public IQuickHackSkillContentT()
		{
			this.EntityState = null;
			this.Actions = null;
		}
	}
}
