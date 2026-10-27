using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200573A RID: 22330
	public class IPickInteractionT
	{
		// Token: 0x1700A679 RID: 42617
		// (get) Token: 0x06025649 RID: 153161 RVA: 0x00528E9E File Offset: 0x0052709E
		// (set) Token: 0x0602564A RID: 153162 RVA: 0x00528EA6 File Offset: 0x005270A6
		public EPickInteraction Type { get; set; }

		// Token: 0x1700A67A RID: 42618
		// (get) Token: 0x0602564B RID: 153163 RVA: 0x00528EAF File Offset: 0x005270AF
		// (set) Token: 0x0602564C RID: 153164 RVA: 0x00528EB7 File Offset: 0x005270B7
		public List<IActionInfoT> CheckedActions { get; set; }

		// Token: 0x1700A67B RID: 42619
		// (get) Token: 0x0602564D RID: 153165 RVA: 0x00528EC0 File Offset: 0x005270C0
		// (set) Token: 0x0602564E RID: 153166 RVA: 0x00528EC8 File Offset: 0x005270C8
		public List<IActionInfoT> UncheckedActions { get; set; }

		// Token: 0x1700A67C RID: 42620
		// (get) Token: 0x0602564F RID: 153167 RVA: 0x00528ED1 File Offset: 0x005270D1
		// (set) Token: 0x06025650 RID: 153168 RVA: 0x00528ED9 File Offset: 0x005270D9
		public byte NullMask { get; set; }

		// Token: 0x06025651 RID: 153169 RVA: 0x00528EE2 File Offset: 0x005270E2
		public IPickInteractionT()
		{
			this.Type = EPickInteraction.ChessmanInteract;
			this.CheckedActions = null;
			this.UncheckedActions = null;
			this.NullMask = 0;
		}
	}
}
