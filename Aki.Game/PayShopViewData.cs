using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200235D RID: 9053
public class PayShopViewData : UiViewData
{
	// Token: 0x0400887C RID: 34940
	public PayShopDefine.EPayShopTabType PayShopId = PayShopDefine.EPayShopTabType.Recommend;

	// Token: 0x0400887D RID: 34941
	public int? SwitchId;

	// Token: 0x0400887E RID: 34942
	public int? RecommendId;

	// Token: 0x0400887F RID: 34943
	[Nullable(1)]
	public List<int> ShowShopIdList = new List<int>();

	// Token: 0x04008880 RID: 34944
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<PayShopJumpParam> JumpTabResolver;
}
