using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014C2 RID: 5314
[NullableContext(1)]
[Nullable(0)]
public class CommonExchangeViewData
{
	// Token: 0x0600D4A3 RID: 54435 RVA: 0x003F350E File Offset: 0x003F170E
	public void CreateData(CommonExchangeData exchangeData, int maxEx = 0, int ownNum = 0)
	{
		this.MaxExchangeTime = maxEx;
		this.OwnSrcItemNum = ownNum;
		this.ExchangeData = exchangeData;
	}

	// Token: 0x0400777A RID: 30586
	public int MaxExchangeTime;

	// Token: 0x0400777B RID: 30587
	public int OwnSrcItemNum;

	// Token: 0x0400777C RID: 30588
	[Nullable(2)]
	public CommonExchangeData ExchangeData;

	// Token: 0x0400777D RID: 30589
	public int StartSliderValue;

	// Token: 0x0400777E RID: 30590
	public List<int> ShowCurrencyList = new List<int>();

	// Token: 0x0400777F RID: 30591
	public Func<int, int, int> GetConsumeCount = (int itemId, int exchangeCount) => 0;

	// Token: 0x04007780 RID: 30592
	public Func<int, int, int> GetConsumeTotalCount = (int consumeCount, int exchangeTime) => 0;

	// Token: 0x04007781 RID: 30593
	public Func<int, int, int> GetGainCount = (int itemId, int exchangeCount) => 0;
}
