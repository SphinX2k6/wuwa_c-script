using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000570 RID: 1392
[NullableContext(1)]
[Nullable(0)]
public class ActivityCategoryTabData : IActivityCategoryTabData
{
	// Token: 0x1700098D RID: 2445
	// (get) Token: 0x06004315 RID: 17173 RVA: 0x0017421A File Offset: 0x0017241A
	// (set) Token: 0x06004316 RID: 17174 RVA: 0x00174222 File Offset: 0x00172422
	public bool IsLineType { get; set; }

	// Token: 0x1700098E RID: 2446
	// (get) Token: 0x06004317 RID: 17175 RVA: 0x0017422B File Offset: 0x0017242B
	// (set) Token: 0x06004318 RID: 17176 RVA: 0x00174233 File Offset: 0x00172433
	public int? Id { get; set; }

	// Token: 0x1700098F RID: 2447
	// (get) Token: 0x06004319 RID: 17177 RVA: 0x0017423C File Offset: 0x0017243C
	// (set) Token: 0x0600431A RID: 17178 RVA: 0x00174244 File Offset: 0x00172444
	public string TextId { get; set; }

	// Token: 0x17000990 RID: 2448
	// (get) Token: 0x0600431B RID: 17179 RVA: 0x0017424D File Offset: 0x0017244D
	// (set) Token: 0x0600431C RID: 17180 RVA: 0x00174255 File Offset: 0x00172455
	public string IconPath { get; set; }

	// Token: 0x17000991 RID: 2449
	// (get) Token: 0x0600431D RID: 17181 RVA: 0x0017425E File Offset: 0x0017245E
	// (set) Token: 0x0600431E RID: 17182 RVA: 0x00174266 File Offset: 0x00172466
	public List<ActivityBaseData> Activities { get; set; }
}
