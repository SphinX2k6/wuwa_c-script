using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001FEF RID: 8175
[NullableContext(1)]
[Nullable(0)]
public class CommonExchangeViewData
{
	// Token: 0x0601003B RID: 65595 RVA: 0x003E6F16 File Offset: 0x003E5116
	public void CreateData(CommonExchangeData exchangeData, int maxEx = 0, int ownNum = 0)
	{
		this.MaxExchangeTime = maxEx;
		this.OwnSrcItemNum = ownNum;
		this.ExchangeData = exchangeData;
	}

	// Token: 0x04007691 RID: 30353
	public int MaxExchangeTime;

	// Token: 0x04007692 RID: 30354
	public int OwnSrcItemNum;

	// Token: 0x04007693 RID: 30355
	[Nullable(2)]
	public CommonExchangeData ExchangeData;

	// Token: 0x04007694 RID: 30356
	public int StartSliderValue;

	// Token: 0x04007695 RID: 30357
	public List<int> ShowCurrencyList = new List<int>();

	// Token: 0x04007696 RID: 30358
	public Func<int, int, int> GetConsumeCount = (int itemId, int exchangeCount) => 0;

	// Token: 0x04007697 RID: 30359
	public Func<int, int, int> GetConsumeTotalCount = (int consumeCount, int exchangeTime) => 0;

	// Token: 0x04007698 RID: 30360
	public Func<int, int, int> GetGainCount = (int itemId, int exchangeCount) => 0;
}
