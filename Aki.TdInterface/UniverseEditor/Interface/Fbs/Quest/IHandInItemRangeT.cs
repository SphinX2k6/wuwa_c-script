using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C9 RID: 17097
	public class IHandInItemRangeT
	{
		// Token: 0x17007507 RID: 29959
		// (get) Token: 0x06017FAB RID: 98219 RVA: 0x0036C4F7 File Offset: 0x0036A6F7
		// (set) Token: 0x06017FAC RID: 98220 RVA: 0x0036C4FF File Offset: 0x0036A6FF
		public EHandInItemType HandInType { get; set; }

		// Token: 0x17007508 RID: 29960
		// (get) Token: 0x06017FAD RID: 98221 RVA: 0x0036C508 File Offset: 0x0036A708
		// (set) Token: 0x06017FAE RID: 98222 RVA: 0x0036C510 File Offset: 0x0036A710
		public List<int> ItemIds { get; set; }

		// Token: 0x06017FAF RID: 98223 RVA: 0x0036C519 File Offset: 0x0036A719
		public IHandInItemRangeT()
		{
			this.HandInType = EHandInItemType.ItemIds;
			this.ItemIds = null;
		}
	}
}
