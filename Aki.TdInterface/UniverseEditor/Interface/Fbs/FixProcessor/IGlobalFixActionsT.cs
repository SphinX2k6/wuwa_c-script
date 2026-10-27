using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x0200475E RID: 18270
	public class IGlobalFixActionsT
	{
		// Token: 0x17008317 RID: 33559
		// (get) Token: 0x0601C209 RID: 115209 RVA: 0x003FC305 File Offset: 0x003FA505
		// (set) Token: 0x0601C20A RID: 115210 RVA: 0x003FC30D File Offset: 0x003FA50D
		public List<IActionInfoT> ActionList { get; set; }

		// Token: 0x0601C20B RID: 115211 RVA: 0x003FC316 File Offset: 0x003FA516
		public IGlobalFixActionsT()
		{
			this.ActionList = null;
		}
	}
}
