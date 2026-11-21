using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007032 RID: 28722
	public class IInteractActionsT
	{
		// Token: 0x1700D250 RID: 53840
		// (get) Token: 0x06031C7E RID: 203902 RVA: 0x006BD37B File Offset: 0x006BB57B
		// (set) Token: 0x06031C7F RID: 203903 RVA: 0x006BD383 File Offset: 0x006BB583
		public EInteractOption Type { get; set; }

		// Token: 0x1700D251 RID: 53841
		// (get) Token: 0x06031C80 RID: 203904 RVA: 0x006BD38C File Offset: 0x006BB58C
		// (set) Token: 0x06031C81 RID: 203905 RVA: 0x006BD394 File Offset: 0x006BB594
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06031C82 RID: 203906 RVA: 0x006BD39D File Offset: 0x006BB59D
		public IInteractActionsT()
		{
			this.Type = EInteractOption.Flow;
			this.Actions = null;
		}
	}
}
