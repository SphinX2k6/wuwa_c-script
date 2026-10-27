using System;
using System.Runtime.CompilerServices;

// Token: 0x02002885 RID: 10373
[NullableContext(2)]
[Nullable(0)]
public class LevelInfo : ILevelInfo
{
	// Token: 0x17001C85 RID: 7301
	// (get) Token: 0x0601558A RID: 87434 RVA: 0x005633DF File Offset: 0x005615DF
	// (set) Token: 0x0601558B RID: 87435 RVA: 0x005633E7 File Offset: 0x005615E7
	public int PreUpgradeLv { get; set; }

	// Token: 0x17001C86 RID: 7302
	// (get) Token: 0x0601558C RID: 87436 RVA: 0x005633F0 File Offset: 0x005615F0
	// (set) Token: 0x0601558D RID: 87437 RVA: 0x005633F8 File Offset: 0x005615F8
	public int UpgradeLv { get; set; }

	// Token: 0x17001C87 RID: 7303
	// (get) Token: 0x0601558E RID: 87438 RVA: 0x00563401 File Offset: 0x00561601
	// (set) Token: 0x0601558F RID: 87439 RVA: 0x00563409 File Offset: 0x00561609
	public string FormatStringId { get; set; }

	// Token: 0x17001C88 RID: 7304
	// (get) Token: 0x06015590 RID: 87440 RVA: 0x00563412 File Offset: 0x00561612
	// (set) Token: 0x06015591 RID: 87441 RVA: 0x0056341A File Offset: 0x0056161A
	public bool? IsMaxLevel { get; set; }
}
