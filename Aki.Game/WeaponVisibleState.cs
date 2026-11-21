using System;

// Token: 0x02002723 RID: 10019
public class WeaponVisibleState
{
	// Token: 0x170027E8 RID: 10216
	// (get) Token: 0x0601920F RID: 102927 RVA: 0x007A8FBA File Offset: 0x007A71BA
	// (set) Token: 0x06019210 RID: 102928 RVA: 0x007A8FC2 File Offset: 0x007A71C2
	public bool IsHidden { get; set; }

	// Token: 0x170027E9 RID: 10217
	// (get) Token: 0x06019211 RID: 102929 RVA: 0x007A8FCB File Offset: 0x007A71CB
	// (set) Token: 0x06019212 RID: 102930 RVA: 0x007A8FD3 File Offset: 0x007A71D3
	public bool Active { get; set; }

	// Token: 0x170027EA RID: 10218
	// (get) Token: 0x06019213 RID: 102931 RVA: 0x007A8FDC File Offset: 0x007A71DC
	// (set) Token: 0x06019214 RID: 102932 RVA: 0x007A8FE4 File Offset: 0x007A71E4
	public int Priority { get; set; }

	// Token: 0x06019215 RID: 102933 RVA: 0x007A8FED File Offset: 0x007A71ED
	public WeaponVisibleState(bool isHidden = false, bool active = true, int priority = 0)
	{
		this.IsHidden = isHidden;
		this.Active = active;
		this.Priority = priority;
	}
}
