using System;
using System.Runtime.CompilerServices;

// Token: 0x02002296 RID: 8854
[NullableContext(2)]
public interface IMotorcycleDiyTabViewRegister
{
	// Token: 0x0601145C RID: 70748
	void RefreshItemScrollView();

	// Token: 0x1700160D RID: 5645
	// (get) Token: 0x0601145D RID: 70749
	// (set) Token: 0x0601145E RID: 70750
	Action<int> OnTabCameraClick { get; set; }

	// Token: 0x1700160E RID: 5646
	// (get) Token: 0x0601145F RID: 70751
	// (set) Token: 0x06011460 RID: 70752
	Action<EOutlookType, int, int> OnSelectItemClick { get; set; }
}
