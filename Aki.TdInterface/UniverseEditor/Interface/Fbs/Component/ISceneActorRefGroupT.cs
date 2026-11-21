using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EAE RID: 24238
	public class ISceneActorRefGroupT
	{
		// Token: 0x1700B30D RID: 45837
		// (get) Token: 0x060289C2 RID: 166338 RVA: 0x0058D63C File Offset: 0x0058B83C
		// (set) Token: 0x060289C3 RID: 166339 RVA: 0x0058D644 File Offset: 0x0058B844
		public string EntityState { get; set; }

		// Token: 0x1700B30E RID: 45838
		// (get) Token: 0x060289C4 RID: 166340 RVA: 0x0058D64D File Offset: 0x0058B84D
		// (set) Token: 0x060289C5 RID: 166341 RVA: 0x0058D655 File Offset: 0x0058B855
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x060289C6 RID: 166342 RVA: 0x0058D65E File Offset: 0x0058B85E
		public ISceneActorRefGroupT()
		{
			this.EntityState = null;
			this.Actions = null;
		}
	}
}
