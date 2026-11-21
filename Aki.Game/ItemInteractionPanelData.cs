using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D80 RID: 3456
[NullableContext(1)]
[Nullable(0)]
public class ItemInteractionPanelData : IItemInteractionPanel
{
	// Token: 0x17000F8E RID: 3982
	// (get) Token: 0x06008DF9 RID: 36345 RVA: 0x002ACADC File Offset: 0x002AACDC
	// (set) Token: 0x06008DFA RID: 36346 RVA: 0x002ACAE4 File Offset: 0x002AACE4
	public List<IItemInteractionPanelItemInfo> ItemInfoList { get; set; } = new List<IItemInteractionPanelItemInfo>();
}
