using System;

// Token: 0x020020EF RID: 8431
public class SurvivorsExitViewParams : ISurvivorsExitViewParams
{
	// Token: 0x17001F15 RID: 7957
	// (get) Token: 0x06014AD1 RID: 84689 RVA: 0x006064CB File Offset: 0x006046CB
	// (set) Token: 0x06014AD2 RID: 84690 RVA: 0x006064D3 File Offset: 0x006046D3
	public bool IsExternal { get; set; }

	// Token: 0x17001F16 RID: 7958
	// (get) Token: 0x06014AD3 RID: 84691 RVA: 0x006064DC File Offset: 0x006046DC
	// (set) Token: 0x06014AD4 RID: 84692 RVA: 0x006064E4 File Offset: 0x006046E4
	public int Batch { get; set; }

	// Token: 0x17001F17 RID: 7959
	// (get) Token: 0x06014AD5 RID: 84693 RVA: 0x006064ED File Offset: 0x006046ED
	// (set) Token: 0x06014AD6 RID: 84694 RVA: 0x006064F5 File Offset: 0x006046F5
	public int MaxBatch { get; set; }
}
