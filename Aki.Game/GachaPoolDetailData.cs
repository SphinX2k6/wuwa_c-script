using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001C82 RID: 7298
[NullableContext(1)]
[Nullable(0)]
public class GachaPoolDetailData
{
	// Token: 0x0400650B RID: 25867
	public string TitleTextKey = "";

	// Token: 0x0400650C RID: 25868
	public string TitleDescKey = "";

	// Token: 0x0400650D RID: 25869
	public List<GachaPoolDrop> ItemList = new List<GachaPoolDrop>();
}
