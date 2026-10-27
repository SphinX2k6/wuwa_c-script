using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004646 RID: 17990
	public class IExecuteActionListT
	{
		// Token: 0x17007FA4 RID: 32676
		// (get) Token: 0x0601B409 RID: 111625 RVA: 0x003E0D43 File Offset: 0x003DEF43
		// (set) Token: 0x0601B40A RID: 111626 RVA: 0x003E0D4B File Offset: 0x003DEF4B
		public EGmCommand Type { get; set; }

		// Token: 0x17007FA5 RID: 32677
		// (get) Token: 0x0601B40B RID: 111627 RVA: 0x003E0D54 File Offset: 0x003DEF54
		// (set) Token: 0x0601B40C RID: 111628 RVA: 0x003E0D5C File Offset: 0x003DEF5C
		public List<IActionInfoT> ActionList { get; set; }

		// Token: 0x0601B40D RID: 111629 RVA: 0x003E0D65 File Offset: 0x003DEF65
		public IExecuteActionListT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.ActionList = null;
		}
	}
}
