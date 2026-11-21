using System;

// Token: 0x02002115 RID: 8469
public class SurvivorsHandbookItemDataBase : ISurvivorsHandbookItemDataBase
{
	// Token: 0x17001F7C RID: 8060
	// (get) Token: 0x06014C2E RID: 85038 RVA: 0x0060978D File Offset: 0x0060798D
	// (set) Token: 0x06014C2F RID: 85039 RVA: 0x00609795 File Offset: 0x00607995
	public int Id { get; set; }

	// Token: 0x17001F7D RID: 8061
	// (get) Token: 0x06014C30 RID: 85040 RVA: 0x0060979E File Offset: 0x0060799E
	// (set) Token: 0x06014C31 RID: 85041 RVA: 0x006097A6 File Offset: 0x006079A6
	public bool? LockState { get; set; }

	// Token: 0x17001F7E RID: 8062
	// (get) Token: 0x06014C32 RID: 85042 RVA: 0x006097AF File Offset: 0x006079AF
	// (set) Token: 0x06014C33 RID: 85043 RVA: 0x006097B7 File Offset: 0x006079B7
	public bool? IsNew { get; set; }
}
