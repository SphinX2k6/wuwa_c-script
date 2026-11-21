using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002237 RID: 8759
[NullableContext(1)]
[Nullable(0)]
public class MultiTemplateScrollViewRefreshContext
{
	// Token: 0x170020CB RID: 8395
	// (get) Token: 0x06015A31 RID: 88625 RVA: 0x00647575 File Offset: 0x00645775
	// (set) Token: 0x06015A32 RID: 88626 RVA: 0x0064757D File Offset: 0x0064577D
	public List<IMultiTemplateGridData> DataList { get; set; }

	// Token: 0x170020CC RID: 8396
	// (get) Token: 0x06015A33 RID: 88627 RVA: 0x00647586 File Offset: 0x00645786
	// (set) Token: 0x06015A34 RID: 88628 RVA: 0x0064758E File Offset: 0x0064578E
	public bool KeepContentPosition { get; set; }

	// Token: 0x170020CD RID: 8397
	// (get) Token: 0x06015A35 RID: 88629 RVA: 0x00647597 File Offset: 0x00645797
	// (set) Token: 0x06015A36 RID: 88630 RVA: 0x0064759F File Offset: 0x0064579F
	public int ScrollToGridIndex { get; set; } = -1;

	// Token: 0x170020CE RID: 8398
	// (get) Token: 0x06015A37 RID: 88631 RVA: 0x006475A8 File Offset: 0x006457A8
	// (set) Token: 0x06015A38 RID: 88632 RVA: 0x006475B0 File Offset: 0x006457B0
	public bool PlayGridAnim { get; set; }

	// Token: 0x170020CF RID: 8399
	// (get) Token: 0x06015A39 RID: 88633 RVA: 0x006475B9 File Offset: 0x006457B9
	// (set) Token: 0x06015A3A RID: 88634 RVA: 0x006475C1 File Offset: 0x006457C1
	public string GridAnimName { get; set; } = "";

	// Token: 0x06015A3B RID: 88635 RVA: 0x006475CA File Offset: 0x006457CA
	public MultiTemplateScrollViewRefreshContext(List<IMultiTemplateGridData> dataList)
	{
		this.DataList = dataList;
	}
}
