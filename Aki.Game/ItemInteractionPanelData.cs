using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020018C7 RID: 6343
[NullableContext(1)]
[Nullable(0)]
public class ItemInteractionPanelData : IItemInteractionPanel
{
	// Token: 0x17000F6B RID: 3947
	// (get) Token: 0x0600BA10 RID: 47632 RVA: 0x002A2384 File Offset: 0x002A0584
	// (set) Token: 0x0600BA11 RID: 47633 RVA: 0x002A238C File Offset: 0x002A058C
	public List<IItemInteractionPanelItemInfo> ItemInfoList { get; set; } = new List<IItemInteractionPanelItemInfo>();
}
