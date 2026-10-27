using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020010D3 RID: 4307
[NullableContext(1)]
[Nullable(0)]
public class AdvanceNoticeNewEnemyDetailItemData
{
	// Token: 0x04003410 RID: 13328
	public string Title = "";

	// Token: 0x04003411 RID: 13329
	public object[] TitleArgs = Array.Empty<object>();

	// Token: 0x04003412 RID: 13330
	public List<PhantomFetterGroup> FetterSuitList = new List<PhantomFetterGroup>();

	// Token: 0x04003413 RID: 13331
	public string DescText = "";

	// Token: 0x04003414 RID: 13332
	public bool TitleChangeColor;
}
