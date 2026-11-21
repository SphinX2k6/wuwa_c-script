using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001116 RID: 4374
[NullableContext(1)]
[Nullable(0)]
public class ResonantChainOptionLimitInfo
{
	// Token: 0x0600AEEA RID: 44778 RVA: 0x00338864 File Offset: 0x00336A64
	public ResonantChainOptionLimitInfo(int limitNum, ResonantChainOptionalLimitResponse response)
	{
		this.LimitNum = limitNum;
		foreach (ResonantChainOptionalLimitInfo resonantChainOptionalLimitInfo in response.Infos)
		{
			this.ItemInfos.Add(new ResonantChainOptionLimitItemInfo(resonantChainOptionalLimitInfo.ItemId, resonantChainOptionalLimitInfo.Count));
		}
	}

	// Token: 0x040064EE RID: 25838
	public int LimitNum;

	// Token: 0x040064EF RID: 25839
	public List<ResonantChainOptionLimitItemInfo> ItemInfos = new List<ResonantChainOptionLimitItemInfo>();
}
