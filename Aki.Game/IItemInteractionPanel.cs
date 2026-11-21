using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D7F RID: 3455
[NullableContext(1)]
public interface IItemInteractionPanel
{
	// Token: 0x17000F8D RID: 3981
	// (get) Token: 0x06008DF7 RID: 36343
	// (set) Token: 0x06008DF8 RID: 36344
	List<IItemInteractionPanelItemInfo> ItemInfoList { get; set; }
}
