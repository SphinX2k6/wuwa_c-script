using System;
using System.Runtime.CompilerServices;

// Token: 0x02001868 RID: 6248
[NullableContext(2)]
[Nullable(0)]
public class MainPropertyFilterViewData : IMainPropertyFilterViewData
{
	// Token: 0x17000F49 RID: 3913
	// (get) Token: 0x0600B74B RID: 46923 RVA: 0x00297124 File Offset: 0x00295324
	// (set) Token: 0x0600B74C RID: 46924 RVA: 0x0029712C File Offset: 0x0029532C
	public int UniqueId { get; set; }

	// Token: 0x17000F4A RID: 3914
	// (get) Token: 0x0600B74D RID: 46925 RVA: 0x00297135 File Offset: 0x00295335
	// (set) Token: 0x0600B74E RID: 46926 RVA: 0x0029713D File Offset: 0x0029533D
	public int DefaultSelectCostTab { get; set; }

	// Token: 0x17000F4B RID: 3915
	// (get) Token: 0x0600B74F RID: 46927 RVA: 0x00297146 File Offset: 0x00295346
	// (set) Token: 0x0600B750 RID: 46928 RVA: 0x0029714E File Offset: 0x0029534E
	public Action ConfirmFunction { get; set; }

	// Token: 0x17000F4C RID: 3916
	// (get) Token: 0x0600B751 RID: 46929 RVA: 0x00297157 File Offset: 0x00295357
	// (set) Token: 0x0600B752 RID: 46930 RVA: 0x0029715F File Offset: 0x0029535F
	public int? CurrentFetterId { get; set; }
}
