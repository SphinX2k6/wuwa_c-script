using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020019EF RID: 6639
[NullableContext(1)]
[Nullable(0)]
public class ActivityGoalData : DailyActivityDefine.IActivityGoalData
{
	// Token: 0x1700103D RID: 4157
	// (get) Token: 0x0600C24F RID: 49743 RVA: 0x002BDBA0 File Offset: 0x002BBDA0
	// (set) Token: 0x0600C250 RID: 49744 RVA: 0x002BDBA8 File Offset: 0x002BBDA8
	public int Id { get; set; }

	// Token: 0x1700103E RID: 4158
	// (get) Token: 0x0600C251 RID: 49745 RVA: 0x002BDBB1 File Offset: 0x002BBDB1
	// (set) Token: 0x0600C252 RID: 49746 RVA: 0x002BDBB9 File Offset: 0x002BBDB9
	public int Goal { get; set; }

	// Token: 0x1700103F RID: 4159
	// (get) Token: 0x0600C253 RID: 49747 RVA: 0x002BDBC2 File Offset: 0x002BBDC2
	// (set) Token: 0x0600C254 RID: 49748 RVA: 0x002BDBCA File Offset: 0x002BBDCA
	public List<TItem> Rewards { get; set; } = new List<TItem>();

	// Token: 0x17001040 RID: 4160
	// (get) Token: 0x0600C255 RID: 49749 RVA: 0x002BDBD3 File Offset: 0x002BBDD3
	// (set) Token: 0x0600C256 RID: 49750 RVA: 0x002BDBDB File Offset: 0x002BBDDB
	public bool Achieved { get; set; }

	// Token: 0x17001041 RID: 4161
	// (get) Token: 0x0600C257 RID: 49751 RVA: 0x002BDBE4 File Offset: 0x002BBDE4
	// (set) Token: 0x0600C258 RID: 49752 RVA: 0x002BDBEC File Offset: 0x002BBDEC
	public EDailyActiveState State { get; set; }
}
