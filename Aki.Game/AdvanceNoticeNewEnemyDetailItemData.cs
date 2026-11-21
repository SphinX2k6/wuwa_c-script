using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000587 RID: 1415
[NullableContext(1)]
[Nullable(0)]
public class AdvanceNoticeNewEnemyDetailItemData
{
	// Token: 0x040034A9 RID: 13481
	public string Title = "";

	// Token: 0x040034AA RID: 13482
	public object[] TitleArgs = Array.Empty<object>();

	// Token: 0x040034AB RID: 13483
	public List<PhantomFetterGroup> FetterSuitList = new List<PhantomFetterGroup>();

	// Token: 0x040034AC RID: 13484
	public string DescText = "";

	// Token: 0x040034AD RID: 13485
	public bool TitleChangeColor;
}
