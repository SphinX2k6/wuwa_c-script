using System;
using System.Runtime.CompilerServices;

// Token: 0x020022A6 RID: 8870
[NullableContext(2)]
public interface IExtraRoomTipsData
{
	// Token: 0x17002134 RID: 8500
	// (get) Token: 0x06015E82 RID: 89730
	// (set) Token: 0x06015E83 RID: 89731
	int CurScore { get; set; }

	// Token: 0x17002135 RID: 8501
	// (get) Token: 0x06015E84 RID: 89732
	// (set) Token: 0x06015E85 RID: 89733
	int MaxScore { get; set; }

	// Token: 0x17002136 RID: 8502
	// (get) Token: 0x06015E86 RID: 89734
	// (set) Token: 0x06015E87 RID: 89735
	Action CancelFunc { get; set; }

	// Token: 0x17002137 RID: 8503
	// (get) Token: 0x06015E88 RID: 89736
	// (set) Token: 0x06015E89 RID: 89737
	Action ConfirmFunc { get; set; }
}
