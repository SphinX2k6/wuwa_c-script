using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ED6 RID: 24278
	public class ICommonBtTreeT
	{
		// Token: 0x1700B59D RID: 46493
		// (get) Token: 0x06029B46 RID: 170822 RVA: 0x005B96A2 File Offset: 0x005B78A2
		// (set) Token: 0x06029B47 RID: 170823 RVA: 0x005B96AA File Offset: 0x005B78AA
		public ICommonBtStartT Root { get; set; }

		// Token: 0x1700B59E RID: 46494
		// (get) Token: 0x06029B48 RID: 170824 RVA: 0x005B96B3 File Offset: 0x005B78B3
		// (set) Token: 0x06029B49 RID: 170825 RVA: 0x005B96BB File Offset: 0x005B78BB
		public List<int> _SelectedNodeIds { get; set; }

		// Token: 0x1700B59F RID: 46495
		// (get) Token: 0x06029B4A RID: 170826 RVA: 0x005B96C4 File Offset: 0x005B78C4
		// (set) Token: 0x06029B4B RID: 170827 RVA: 0x005B96CC File Offset: 0x005B78CC
		public byte NullMask { get; set; }

		// Token: 0x06029B4C RID: 170828 RVA: 0x005B96D5 File Offset: 0x005B78D5
		public ICommonBtTreeT()
		{
			this.Root = null;
			this._SelectedNodeIds = null;
			this.NullMask = 0;
		}
	}
}
