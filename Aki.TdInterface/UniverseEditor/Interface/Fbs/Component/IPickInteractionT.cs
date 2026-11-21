using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D41 RID: 23873
	public class IPickInteractionT
	{
		// Token: 0x1700AF9D RID: 44957
		// (get) Token: 0x06027B69 RID: 162665 RVA: 0x0056F02A File Offset: 0x0056D22A
		// (set) Token: 0x06027B6A RID: 162666 RVA: 0x0056F032 File Offset: 0x0056D232
		public EPickInteraction Type { get; set; }

		// Token: 0x1700AF9E RID: 44958
		// (get) Token: 0x06027B6B RID: 162667 RVA: 0x0056F03B File Offset: 0x0056D23B
		// (set) Token: 0x06027B6C RID: 162668 RVA: 0x0056F043 File Offset: 0x0056D243
		public List<IActionInfoT> CheckedActions { get; set; }

		// Token: 0x1700AF9F RID: 44959
		// (get) Token: 0x06027B6D RID: 162669 RVA: 0x0056F04C File Offset: 0x0056D24C
		// (set) Token: 0x06027B6E RID: 162670 RVA: 0x0056F054 File Offset: 0x0056D254
		public List<IActionInfoT> UncheckedActions { get; set; }

		// Token: 0x1700AFA0 RID: 44960
		// (get) Token: 0x06027B6F RID: 162671 RVA: 0x0056F05D File Offset: 0x0056D25D
		// (set) Token: 0x06027B70 RID: 162672 RVA: 0x0056F065 File Offset: 0x0056D265
		public byte NullMask { get; set; }

		// Token: 0x06027B71 RID: 162673 RVA: 0x0056F06E File Offset: 0x0056D26E
		public IPickInteractionT()
		{
			this.Type = EPickInteraction.ChessmanInteract;
			this.CheckedActions = null;
			this.UncheckedActions = null;
			this.NullMask = 0;
		}
	}
}
