using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020018C6 RID: 6342
[NullableContext(1)]
public interface IItemInteractionPanel
{
	// Token: 0x17000F6A RID: 3946
	// (get) Token: 0x0600BA0E RID: 47630
	// (set) Token: 0x0600BA0F RID: 47631
	List<IItemInteractionPanelItemInfo> ItemInfoList { get; set; }
}
