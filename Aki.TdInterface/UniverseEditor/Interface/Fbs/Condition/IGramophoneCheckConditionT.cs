using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005122 RID: 20770
	public class IGramophoneCheckConditionT
	{
		// Token: 0x170094D6 RID: 38102
		// (get) Token: 0x06020A83 RID: 133763 RVA: 0x00486B1F File Offset: 0x00484D1F
		// (set) Token: 0x06020A84 RID: 133764 RVA: 0x00486B27 File Offset: 0x00484D27
		public ECommonMatchType CheckType { get; set; }

		// Token: 0x170094D7 RID: 38103
		// (get) Token: 0x06020A85 RID: 133765 RVA: 0x00486B30 File Offset: 0x00484D30
		// (set) Token: 0x06020A86 RID: 133766 RVA: 0x00486B38 File Offset: 0x00484D38
		public List<int> PlayList { get; set; }

		// Token: 0x06020A87 RID: 133767 RVA: 0x00486B41 File Offset: 0x00484D41
		public IGramophoneCheckConditionT()
		{
			this.CheckType = ECommonMatchType.MatchAll;
			this.PlayList = null;
		}
	}
}
