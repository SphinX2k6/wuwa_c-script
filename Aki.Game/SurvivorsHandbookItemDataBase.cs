using System;

// Token: 0x02002B99 RID: 11161
public class SurvivorsHandbookItemDataBase : ISurvivorsHandbookItemDataBase
{
	// Token: 0x17001F24 RID: 7972
	// (get) Token: 0x060171FD RID: 94717 RVA: 0x005DCBAD File Offset: 0x005DADAD
	// (set) Token: 0x060171FE RID: 94718 RVA: 0x005DCBB5 File Offset: 0x005DADB5
	public int Id { get; set; }

	// Token: 0x17001F25 RID: 7973
	// (get) Token: 0x060171FF RID: 94719 RVA: 0x005DCBBE File Offset: 0x005DADBE
	// (set) Token: 0x06017200 RID: 94720 RVA: 0x005DCBC6 File Offset: 0x005DADC6
	public bool? LockState { get; set; }

	// Token: 0x17001F26 RID: 7974
	// (get) Token: 0x06017201 RID: 94721 RVA: 0x005DCBCF File Offset: 0x005DADCF
	// (set) Token: 0x06017202 RID: 94722 RVA: 0x005DCBD7 File Offset: 0x005DADD7
	public bool? IsNew { get; set; }
}
