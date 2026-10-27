using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004092 RID: 16530
	public class IRecallEntityListT
	{
		// Token: 0x170074A8 RID: 29864
		// (get) Token: 0x060180F3 RID: 98547 RVA: 0x00378497 File Offset: 0x00376697
		// (set) Token: 0x060180F4 RID: 98548 RVA: 0x0037849F File Offset: 0x0037669F
		public int LevelId { get; set; }

		// Token: 0x170074A9 RID: 29865
		// (get) Token: 0x060180F5 RID: 98549 RVA: 0x003784A8 File Offset: 0x003766A8
		// (set) Token: 0x060180F6 RID: 98550 RVA: 0x003784B0 File Offset: 0x003766B0
		public List<int> EntityList { get; set; }

		// Token: 0x060180F7 RID: 98551 RVA: 0x003784B9 File Offset: 0x003766B9
		public IRecallEntityListT()
		{
			this.LevelId = 0;
			this.EntityList = null;
		}
	}
}
