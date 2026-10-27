using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002CDE RID: 11486
[NullableContext(1)]
[Nullable(0)]
public class MultiTemplateScrollViewRefreshContext
{
	// Token: 0x17002078 RID: 8312
	// (get) Token: 0x060181B2 RID: 98738 RVA: 0x00621901 File Offset: 0x0061FB01
	// (set) Token: 0x060181B3 RID: 98739 RVA: 0x00621909 File Offset: 0x0061FB09
	public List<IMultiTemplateGridData> DataList { get; set; }

	// Token: 0x17002079 RID: 8313
	// (get) Token: 0x060181B4 RID: 98740 RVA: 0x00621912 File Offset: 0x0061FB12
	// (set) Token: 0x060181B5 RID: 98741 RVA: 0x0062191A File Offset: 0x0061FB1A
	public bool KeepContentPosition { get; set; }

	// Token: 0x1700207A RID: 8314
	// (get) Token: 0x060181B6 RID: 98742 RVA: 0x00621923 File Offset: 0x0061FB23
	// (set) Token: 0x060181B7 RID: 98743 RVA: 0x0062192B File Offset: 0x0061FB2B
	public int ScrollToGridIndex { get; set; } = -1;

	// Token: 0x1700207B RID: 8315
	// (get) Token: 0x060181B8 RID: 98744 RVA: 0x00621934 File Offset: 0x0061FB34
	// (set) Token: 0x060181B9 RID: 98745 RVA: 0x0062193C File Offset: 0x0061FB3C
	public bool PlayGridAnim { get; set; }

	// Token: 0x1700207C RID: 8316
	// (get) Token: 0x060181BA RID: 98746 RVA: 0x00621945 File Offset: 0x0061FB45
	// (set) Token: 0x060181BB RID: 98747 RVA: 0x0062194D File Offset: 0x0061FB4D
	public string GridAnimName { get; set; } = "";

	// Token: 0x060181BC RID: 98748 RVA: 0x00621956 File Offset: 0x0061FB56
	public MultiTemplateScrollViewRefreshContext(List<IMultiTemplateGridData> dataList)
	{
		this.DataList = dataList;
	}
}
