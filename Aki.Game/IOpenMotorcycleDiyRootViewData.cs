using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001776 RID: 6006
[NullableContext(2)]
public interface IOpenMotorcycleDiyRootViewData
{
	// Token: 0x17001632 RID: 5682
	// (get) Token: 0x0600E8CC RID: 59596
	// (set) Token: 0x0600E8CD RID: 59597
	EUiTabViewName? OpenTabView { get; set; }

	// Token: 0x17001633 RID: 5683
	// (get) Token: 0x0600E8CE RID: 59598
	// (set) Token: 0x0600E8CF RID: 59599
	int? PartTabIndex { get; set; }

	// Token: 0x17001634 RID: 5684
	// (get) Token: 0x0600E8D0 RID: 59600
	// (set) Token: 0x0600E8D1 RID: 59601
	bool? IsNeedResetMotor { get; set; }

	// Token: 0x17001635 RID: 5685
	// (get) Token: 0x0600E8D2 RID: 59602
	// (set) Token: 0x0600E8D3 RID: 59603
	MotorcycleDiyPresetData PresetData { get; set; }

	// Token: 0x17001636 RID: 5686
	// (get) Token: 0x0600E8D4 RID: 59604
	// (set) Token: 0x0600E8D5 RID: 59605
	EMotorcycleDiyCustomMode? CustomMode { get; set; }

	// Token: 0x17001637 RID: 5687
	// (get) Token: 0x0600E8D6 RID: 59606
	// (set) Token: 0x0600E8D7 RID: 59607
	Action<int> OnNewCustomPresetCreated { get; set; }
}
