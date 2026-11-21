using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001777 RID: 6007
[NullableContext(2)]
[Nullable(0)]
public class OpenMotorcycleDiyRootViewData : IOpenMotorcycleDiyRootViewData
{
	// Token: 0x17001638 RID: 5688
	// (get) Token: 0x0600E8D8 RID: 59608 RVA: 0x004439B8 File Offset: 0x00441BB8
	// (set) Token: 0x0600E8D9 RID: 59609 RVA: 0x004439C0 File Offset: 0x00441BC0
	public EUiTabViewName? OpenTabView { get; set; }

	// Token: 0x17001639 RID: 5689
	// (get) Token: 0x0600E8DA RID: 59610 RVA: 0x004439C9 File Offset: 0x00441BC9
	// (set) Token: 0x0600E8DB RID: 59611 RVA: 0x004439D1 File Offset: 0x00441BD1
	public int? PartTabIndex { get; set; }

	// Token: 0x1700163A RID: 5690
	// (get) Token: 0x0600E8DC RID: 59612 RVA: 0x004439DA File Offset: 0x00441BDA
	// (set) Token: 0x0600E8DD RID: 59613 RVA: 0x004439E2 File Offset: 0x00441BE2
	public bool? IsNeedResetMotor { get; set; }

	// Token: 0x1700163B RID: 5691
	// (get) Token: 0x0600E8DE RID: 59614 RVA: 0x004439EB File Offset: 0x00441BEB
	// (set) Token: 0x0600E8DF RID: 59615 RVA: 0x004439F3 File Offset: 0x00441BF3
	public MotorcycleDiyPresetData PresetData { get; set; }

	// Token: 0x1700163C RID: 5692
	// (get) Token: 0x0600E8E0 RID: 59616 RVA: 0x004439FC File Offset: 0x00441BFC
	// (set) Token: 0x0600E8E1 RID: 59617 RVA: 0x00443A04 File Offset: 0x00441C04
	public EMotorcycleDiyCustomMode? CustomMode { get; set; }

	// Token: 0x1700163D RID: 5693
	// (get) Token: 0x0600E8E2 RID: 59618 RVA: 0x00443A0D File Offset: 0x00441C0D
	// (set) Token: 0x0600E8E3 RID: 59619 RVA: 0x00443A15 File Offset: 0x00441C15
	public Action<int> OnNewCustomPresetCreated { get; set; }
}
