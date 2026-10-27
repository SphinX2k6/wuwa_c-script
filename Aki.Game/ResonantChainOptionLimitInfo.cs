using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001C57 RID: 7255
[NullableContext(1)]
[Nullable(0)]
public class ResonantChainOptionLimitInfo
{
	// Token: 0x0600DAD4 RID: 56020 RVA: 0x0032D438 File Offset: 0x0032B638
	public ResonantChainOptionLimitInfo(int limitNum, ResonantChainOptionalLimitResponse response)
	{
		this.LimitNum = limitNum;
		foreach (ResonantChainOptionalLimitInfo resonantChainOptionalLimitInfo in response.Infos)
		{
			this.ItemInfos.Add(new ResonantChainOptionLimitItemInfo(resonantChainOptionalLimitInfo.ItemId, resonantChainOptionalLimitInfo.Count));
		}
	}

	// Token: 0x0400641C RID: 25628
	public int LimitNum;

	// Token: 0x0400641D RID: 25629
	public List<ResonantChainOptionLimitItemInfo> ItemInfos = new List<ResonantChainOptionLimitItemInfo>();
}
