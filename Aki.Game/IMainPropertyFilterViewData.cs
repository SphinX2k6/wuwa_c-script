using System;
using System.Runtime.CompilerServices;

// Token: 0x02001867 RID: 6247
[NullableContext(2)]
public interface IMainPropertyFilterViewData
{
	// Token: 0x17000F45 RID: 3909
	// (get) Token: 0x0600B743 RID: 46915
	// (set) Token: 0x0600B744 RID: 46916
	int UniqueId { get; set; }

	// Token: 0x17000F46 RID: 3910
	// (get) Token: 0x0600B745 RID: 46917
	// (set) Token: 0x0600B746 RID: 46918
	int DefaultSelectCostTab { get; set; }

	// Token: 0x17000F47 RID: 3911
	// (get) Token: 0x0600B747 RID: 46919
	// (set) Token: 0x0600B748 RID: 46920
	Action ConfirmFunction { get; set; }

	// Token: 0x17000F48 RID: 3912
	// (get) Token: 0x0600B749 RID: 46921
	// (set) Token: 0x0600B74A RID: 46922
	int? CurrentFetterId { get; set; }
}
