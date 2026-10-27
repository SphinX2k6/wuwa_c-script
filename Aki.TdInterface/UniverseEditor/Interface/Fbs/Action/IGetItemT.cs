using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006883 RID: 26755
	public class IGetItemT
	{
		// Token: 0x1700C6B2 RID: 50866
		// (get) Token: 0x0602EA9D RID: 191133 RVA: 0x0065CFED File Offset: 0x0065B1ED
		// (set) Token: 0x0602EA9E RID: 191134 RVA: 0x0065CFF5 File Offset: 0x0065B1F5
		public List<IItemDataT> Items { get; set; }

		// Token: 0x1700C6B3 RID: 50867
		// (get) Token: 0x0602EA9F RID: 191135 RVA: 0x0065CFFE File Offset: 0x0065B1FE
		// (set) Token: 0x0602EAA0 RID: 191136 RVA: 0x0065D006 File Offset: 0x0065B206
		public EItemGetUiType UiType { get; set; }

		// Token: 0x1700C6B4 RID: 50868
		// (get) Token: 0x0602EAA1 RID: 191137 RVA: 0x0065D00F File Offset: 0x0065B20F
		// (set) Token: 0x0602EAA2 RID: 191138 RVA: 0x0065D017 File Offset: 0x0065B217
		public IItemGetUiConfigSpecialQuestT UiConfig { get; set; }

		// Token: 0x1700C6B5 RID: 50869
		// (get) Token: 0x0602EAA3 RID: 191139 RVA: 0x0065D020 File Offset: 0x0065B220
		// (set) Token: 0x0602EAA4 RID: 191140 RVA: 0x0065D028 File Offset: 0x0065B228
		public byte NullMask { get; set; }

		// Token: 0x0602EAA5 RID: 191141 RVA: 0x0065D031 File Offset: 0x0065B231
		public IGetItemT()
		{
			this.Items = null;
			this.UiType = EItemGetUiType.None;
			this.UiConfig = null;
			this.NullMask = 0;
		}
	}
}
