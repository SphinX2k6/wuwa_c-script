using System;
using System.Runtime.CompilerServices;

// Token: 0x020018EA RID: 6378
[NullableContext(1)]
[Nullable(0)]
public class ButtonInfo : IButtonInfo
{
	// Token: 0x17000F8D RID: 3981
	// (get) Token: 0x0600BADF RID: 47839 RVA: 0x002A51C7 File Offset: 0x002A33C7
	// (set) Token: 0x0600BAE0 RID: 47840 RVA: 0x002A51CF File Offset: 0x002A33CF
	public Action<int> Function { get; set; }

	// Token: 0x17000F8E RID: 3982
	// (get) Token: 0x0600BAE1 RID: 47841 RVA: 0x002A51D8 File Offset: 0x002A33D8
	// (set) Token: 0x0600BAE2 RID: 47842 RVA: 0x002A51E0 File Offset: 0x002A33E0
	public string Text { get; set; }

	// Token: 0x17000F8F RID: 3983
	// (get) Token: 0x0600BAE3 RID: 47843 RVA: 0x002A51E9 File Offset: 0x002A33E9
	// (set) Token: 0x0600BAE4 RID: 47844 RVA: 0x002A51F1 File Offset: 0x002A33F1
	public int Index { get; set; }

	// Token: 0x17000F90 RID: 3984
	// (get) Token: 0x0600BAE5 RID: 47845 RVA: 0x002A51FA File Offset: 0x002A33FA
	// (set) Token: 0x0600BAE6 RID: 47846 RVA: 0x002A5202 File Offset: 0x002A3402
	public ERedDotName? RedDotName { get; set; }

	// Token: 0x17000F91 RID: 3985
	// (get) Token: 0x0600BAE7 RID: 47847 RVA: 0x002A520B File Offset: 0x002A340B
	// (set) Token: 0x0600BAE8 RID: 47848 RVA: 0x002A5213 File Offset: 0x002A3413
	public int? RedDotId { get; set; }
}
