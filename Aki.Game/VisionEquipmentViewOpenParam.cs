using System;

// Token: 0x020019E6 RID: 6630
public class VisionEquipmentViewOpenParam : IVisionEquipmentViewOpenParam
{
	// Token: 0x17001904 RID: 6404
	// (get) Token: 0x0601055B RID: 66907 RVA: 0x004C47B2 File Offset: 0x004C29B2
	// (set) Token: 0x0601055C RID: 66908 RVA: 0x004C47BA File Offset: 0x004C29BA
	public int RoleId { get; set; }

	// Token: 0x17001905 RID: 6405
	// (get) Token: 0x0601055D RID: 66909 RVA: 0x004C47C3 File Offset: 0x004C29C3
	// (set) Token: 0x0601055E RID: 66910 RVA: 0x004C47CB File Offset: 0x004C29CB
	public int SelectIndex { get; set; }

	// Token: 0x17001906 RID: 6406
	// (get) Token: 0x0601055F RID: 66911 RVA: 0x004C47D4 File Offset: 0x004C29D4
	// (set) Token: 0x06010560 RID: 66912 RVA: 0x004C47DC File Offset: 0x004C29DC
	public ERoleViewSource? Source { get; set; }
}
