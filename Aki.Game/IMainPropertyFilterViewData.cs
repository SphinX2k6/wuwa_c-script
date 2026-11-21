using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D20 RID: 3360
[NullableContext(2)]
public interface IMainPropertyFilterViewData
{
	// Token: 0x17000F68 RID: 3944
	// (get) Token: 0x06008B2C RID: 35628
	// (set) Token: 0x06008B2D RID: 35629
	int UniqueId { get; set; }

	// Token: 0x17000F69 RID: 3945
	// (get) Token: 0x06008B2E RID: 35630
	// (set) Token: 0x06008B2F RID: 35631
	int DefaultSelectCostTab { get; set; }

	// Token: 0x17000F6A RID: 3946
	// (get) Token: 0x06008B30 RID: 35632
	// (set) Token: 0x06008B31 RID: 35633
	Action ConfirmFunction { get; set; }

	// Token: 0x17000F6B RID: 3947
	// (get) Token: 0x06008B32 RID: 35634
	// (set) Token: 0x06008B33 RID: 35635
	int? CurrentFetterId { get; set; }
}
