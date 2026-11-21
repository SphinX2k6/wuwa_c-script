using System;

// Token: 0x02000BDF RID: 3039
public class CalabashUpgradeSuccessViedData : ICalabashUpgradeSuccessViedData
{
	// Token: 0x17000E3E RID: 3646
	// (get) Token: 0x06007F23 RID: 32547 RVA: 0x0027200A File Offset: 0x0027020A
	// (set) Token: 0x06007F24 RID: 32548 RVA: 0x00272012 File Offset: 0x00270212
	public bool AddExp { get; set; }

	// Token: 0x17000E3F RID: 3647
	// (get) Token: 0x06007F25 RID: 32549 RVA: 0x0027201B File Offset: 0x0027021B
	// (set) Token: 0x06007F26 RID: 32550 RVA: 0x00272023 File Offset: 0x00270223
	public int PreLevel { get; set; }

	// Token: 0x17000E40 RID: 3648
	// (get) Token: 0x06007F27 RID: 32551 RVA: 0x0027202C File Offset: 0x0027022C
	// (set) Token: 0x06007F28 RID: 32552 RVA: 0x00272034 File Offset: 0x00270234
	public int PreExp { get; set; }

	// Token: 0x17000E41 RID: 3649
	// (get) Token: 0x06007F29 RID: 32553 RVA: 0x0027203D File Offset: 0x0027023D
	// (set) Token: 0x06007F2A RID: 32554 RVA: 0x00272045 File Offset: 0x00270245
	public int CurLevel { get; set; }

	// Token: 0x17000E42 RID: 3650
	// (get) Token: 0x06007F2B RID: 32555 RVA: 0x0027204E File Offset: 0x0027024E
	// (set) Token: 0x06007F2C RID: 32556 RVA: 0x00272056 File Offset: 0x00270256
	public int CurExp { get; set; }
}
