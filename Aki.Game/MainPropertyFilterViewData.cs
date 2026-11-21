using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D21 RID: 3361
[NullableContext(2)]
[Nullable(0)]
public class MainPropertyFilterViewData : IMainPropertyFilterViewData
{
	// Token: 0x17000F6C RID: 3948
	// (get) Token: 0x06008B34 RID: 35636 RVA: 0x002A1848 File Offset: 0x0029FA48
	// (set) Token: 0x06008B35 RID: 35637 RVA: 0x002A1850 File Offset: 0x0029FA50
	public int UniqueId { get; set; }

	// Token: 0x17000F6D RID: 3949
	// (get) Token: 0x06008B36 RID: 35638 RVA: 0x002A1859 File Offset: 0x0029FA59
	// (set) Token: 0x06008B37 RID: 35639 RVA: 0x002A1861 File Offset: 0x0029FA61
	public int DefaultSelectCostTab { get; set; }

	// Token: 0x17000F6E RID: 3950
	// (get) Token: 0x06008B38 RID: 35640 RVA: 0x002A186A File Offset: 0x0029FA6A
	// (set) Token: 0x06008B39 RID: 35641 RVA: 0x002A1872 File Offset: 0x0029FA72
	public Action ConfirmFunction { get; set; }

	// Token: 0x17000F6F RID: 3951
	// (get) Token: 0x06008B3A RID: 35642 RVA: 0x002A187B File Offset: 0x0029FA7B
	// (set) Token: 0x06008B3B RID: 35643 RVA: 0x002A1883 File Offset: 0x0029FA83
	public int? CurrentFetterId { get; set; }
}
