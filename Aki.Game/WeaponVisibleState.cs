using System;

// Token: 0x020031B4 RID: 12724
public class WeaponVisibleState
{
	// Token: 0x170025EB RID: 9707
	// (get) Token: 0x0601B6DC RID: 112348 RVA: 0x00780C3A File Offset: 0x0077EE3A
	// (set) Token: 0x0601B6DD RID: 112349 RVA: 0x00780C42 File Offset: 0x0077EE42
	public bool IsHidden { get; set; }

	// Token: 0x170025EC RID: 9708
	// (get) Token: 0x0601B6DE RID: 112350 RVA: 0x00780C4B File Offset: 0x0077EE4B
	// (set) Token: 0x0601B6DF RID: 112351 RVA: 0x00780C53 File Offset: 0x0077EE53
	public bool Active { get; set; }

	// Token: 0x170025ED RID: 9709
	// (get) Token: 0x0601B6E0 RID: 112352 RVA: 0x00780C5C File Offset: 0x0077EE5C
	// (set) Token: 0x0601B6E1 RID: 112353 RVA: 0x00780C64 File Offset: 0x0077EE64
	public int Priority { get; set; }

	// Token: 0x0601B6E2 RID: 112354 RVA: 0x00780C6D File Offset: 0x0077EE6D
	public WeaponVisibleState(bool isHidden = false, bool active = true, int priority = 0)
	{
		this.IsHidden = isHidden;
		this.Active = active;
		this.Priority = priority;
	}
}
