using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001842 RID: 6210
public class PayShopViewData : UiViewData
{
	// Token: 0x040089C1 RID: 35265
	public PayShopDefine.EPayShopTabType PayShopId = PayShopDefine.EPayShopTabType.Recommend;

	// Token: 0x040089C2 RID: 35266
	public int? SwitchId;

	// Token: 0x040089C3 RID: 35267
	public int? RecommendId;

	// Token: 0x040089C4 RID: 35268
	[Nullable(1)]
	public List<int> ShowShopIdList = new List<int>();

	// Token: 0x040089C5 RID: 35269
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<PayShopJumpParam> JumpTabResolver;
}
