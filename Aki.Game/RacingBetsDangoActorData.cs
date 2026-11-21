using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BE3 RID: 7139
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoActorData : IRacingBetsDangoActorData
{
	// Token: 0x17001AEB RID: 6891
	// (get) Token: 0x06011C21 RID: 72737 RVA: 0x0053A7B1 File Offset: 0x005389B1
	// (set) Token: 0x06011C22 RID: 72738 RVA: 0x0053A7B9 File Offset: 0x005389B9
	public EUiModelUseWay UiModelUseWay { get; set; }

	// Token: 0x17001AEC RID: 6892
	// (get) Token: 0x06011C23 RID: 72739 RVA: 0x0053A7C2 File Offset: 0x005389C2
	// (set) Token: 0x06011C24 RID: 72740 RVA: 0x0053A7CA File Offset: 0x005389CA
	public int DangoId { get; set; }

	// Token: 0x17001AED RID: 6893
	// (get) Token: 0x06011C25 RID: 72741 RVA: 0x0053A7D3 File Offset: 0x005389D3
	// (set) Token: 0x06011C26 RID: 72742 RVA: 0x0053A7DB File Offset: 0x005389DB
	public int Odds { get; set; }

	// Token: 0x17001AEE RID: 6894
	// (get) Token: 0x06011C27 RID: 72743 RVA: 0x0053A7E4 File Offset: 0x005389E4
	// (set) Token: 0x06011C28 RID: 72744 RVA: 0x0053A7EC File Offset: 0x005389EC
	public string DangoPointCase { get; set; }

	// Token: 0x17001AEF RID: 6895
	// (get) Token: 0x06011C29 RID: 72745 RVA: 0x0053A7F5 File Offset: 0x005389F5
	// (set) Token: 0x06011C2A RID: 72746 RVA: 0x0053A7FD File Offset: 0x005389FD
	public string DangoCamera { get; set; }

	// Token: 0x17001AF0 RID: 6896
	// (get) Token: 0x06011C2B RID: 72747 RVA: 0x0053A806 File Offset: 0x00538A06
	// (set) Token: 0x06011C2C RID: 72748 RVA: 0x0053A80E File Offset: 0x00538A0E
	public float DangoOffset { get; set; }

	// Token: 0x17001AF1 RID: 6897
	// (get) Token: 0x06011C2D RID: 72749 RVA: 0x0053A817 File Offset: 0x00538A17
	// (set) Token: 0x06011C2E RID: 72750 RVA: 0x0053A81F File Offset: 0x00538A1F
	public bool IsAbuDango { get; set; }
}
