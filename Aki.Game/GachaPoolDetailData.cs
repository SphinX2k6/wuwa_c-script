using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001141 RID: 4417
[NullableContext(1)]
[Nullable(0)]
public class GachaPoolDetailData
{
	// Token: 0x040065DD RID: 26077
	public string TitleTextKey = "";

	// Token: 0x040065DE RID: 26078
	public string TitleDescKey = "";

	// Token: 0x040065DF RID: 26079
	public List<GachaPoolDrop> ItemList = new List<GachaPoolDrop>();
}
