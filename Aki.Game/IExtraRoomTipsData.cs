using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D4C RID: 11596
[NullableContext(2)]
public interface IExtraRoomTipsData
{
	// Token: 0x170020D9 RID: 8409
	// (get) Token: 0x060185E0 RID: 99808
	// (set) Token: 0x060185E1 RID: 99809
	int CurScore { get; set; }

	// Token: 0x170020DA RID: 8410
	// (get) Token: 0x060185E2 RID: 99810
	// (set) Token: 0x060185E3 RID: 99811
	int MaxScore { get; set; }

	// Token: 0x170020DB RID: 8411
	// (get) Token: 0x060185E4 RID: 99812
	// (set) Token: 0x060185E5 RID: 99813
	Action CancelFunc { get; set; }

	// Token: 0x170020DC RID: 8412
	// (get) Token: 0x060185E6 RID: 99814
	// (set) Token: 0x060185E7 RID: 99815
	Action ConfirmFunc { get; set; }
}
