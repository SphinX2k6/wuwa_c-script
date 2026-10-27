using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002292 RID: 8850
[NullableContext(2)]
public interface IOpenMotorcycleDiyRootViewData
{
	// Token: 0x170015FB RID: 5627
	// (get) Token: 0x06011436 RID: 70710
	// (set) Token: 0x06011437 RID: 70711
	EUiTabViewName? OpenTabView { get; set; }

	// Token: 0x170015FC RID: 5628
	// (get) Token: 0x06011438 RID: 70712
	// (set) Token: 0x06011439 RID: 70713
	int? PartTabIndex { get; set; }

	// Token: 0x170015FD RID: 5629
	// (get) Token: 0x0601143A RID: 70714
	// (set) Token: 0x0601143B RID: 70715
	bool? IsNeedResetMotor { get; set; }

	// Token: 0x170015FE RID: 5630
	// (get) Token: 0x0601143C RID: 70716
	// (set) Token: 0x0601143D RID: 70717
	MotorcycleDiyPresetData PresetData { get; set; }

	// Token: 0x170015FF RID: 5631
	// (get) Token: 0x0601143E RID: 70718
	// (set) Token: 0x0601143F RID: 70719
	EMotorcycleDiyCustomMode? CustomMode { get; set; }

	// Token: 0x17001600 RID: 5632
	// (get) Token: 0x06011440 RID: 70720
	// (set) Token: 0x06011441 RID: 70721
	Action<int> OnNewCustomPresetCreated { get; set; }
}
