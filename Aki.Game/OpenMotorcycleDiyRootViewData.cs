using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002293 RID: 8851
[NullableContext(2)]
[Nullable(0)]
public class OpenMotorcycleDiyRootViewData : IOpenMotorcycleDiyRootViewData
{
	// Token: 0x17001601 RID: 5633
	// (get) Token: 0x06011442 RID: 70722 RVA: 0x00436DAC File Offset: 0x00434FAC
	// (set) Token: 0x06011443 RID: 70723 RVA: 0x00436DB4 File Offset: 0x00434FB4
	public EUiTabViewName? OpenTabView { get; set; }

	// Token: 0x17001602 RID: 5634
	// (get) Token: 0x06011444 RID: 70724 RVA: 0x00436DBD File Offset: 0x00434FBD
	// (set) Token: 0x06011445 RID: 70725 RVA: 0x00436DC5 File Offset: 0x00434FC5
	public int? PartTabIndex { get; set; }

	// Token: 0x17001603 RID: 5635
	// (get) Token: 0x06011446 RID: 70726 RVA: 0x00436DCE File Offset: 0x00434FCE
	// (set) Token: 0x06011447 RID: 70727 RVA: 0x00436DD6 File Offset: 0x00434FD6
	public bool? IsNeedResetMotor { get; set; }

	// Token: 0x17001604 RID: 5636
	// (get) Token: 0x06011448 RID: 70728 RVA: 0x00436DDF File Offset: 0x00434FDF
	// (set) Token: 0x06011449 RID: 70729 RVA: 0x00436DE7 File Offset: 0x00434FE7
	public MotorcycleDiyPresetData PresetData { get; set; }

	// Token: 0x17001605 RID: 5637
	// (get) Token: 0x0601144A RID: 70730 RVA: 0x00436DF0 File Offset: 0x00434FF0
	// (set) Token: 0x0601144B RID: 70731 RVA: 0x00436DF8 File Offset: 0x00434FF8
	public EMotorcycleDiyCustomMode? CustomMode { get; set; }

	// Token: 0x17001606 RID: 5638
	// (get) Token: 0x0601144C RID: 70732 RVA: 0x00436E01 File Offset: 0x00435001
	// (set) Token: 0x0601144D RID: 70733 RVA: 0x00436E09 File Offset: 0x00435009
	public Action<int> OnNewCustomPresetCreated { get; set; }
}
