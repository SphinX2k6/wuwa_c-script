using System;
using System.Runtime.CompilerServices;

// Token: 0x0200177A RID: 6010
[NullableContext(2)]
public interface IMotorcycleDiyTabViewRegister
{
	// Token: 0x0600E8F2 RID: 59634
	void RefreshItemScrollView();

	// Token: 0x17001644 RID: 5700
	// (get) Token: 0x0600E8F3 RID: 59635
	// (set) Token: 0x0600E8F4 RID: 59636
	Action<int> OnTabCameraClick { get; set; }

	// Token: 0x17001645 RID: 5701
	// (get) Token: 0x0600E8F5 RID: 59637
	// (set) Token: 0x0600E8F6 RID: 59638
	Action<EOutlookType, int, int> OnSelectItemClick { get; set; }
}
